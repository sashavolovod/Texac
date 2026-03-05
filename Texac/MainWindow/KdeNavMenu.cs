using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Texac.MainWindow
{
    public class KdeNavMenu
    {
        private readonly FlowLayoutPanel _host;
        private readonly Font _headerFont;
        private readonly Font _itemFont;

        public delegate void MenuItemClickHandler(string sectionKey, string itemKey);
        public event MenuItemClickHandler ItemClicked;


        private Dictionary<string, Panel> sectionItems = new Dictionary<string, Panel>();
        private Dictionary<string, Label> sectionArrows = new Dictionary<string, Label>();

        private const int HeaderHeight = 44;
        private const int ItemHeight = 34;

        private sealed class SectionState
        {
            public Panel SectionPanel;
            public Panel ItemsPanel;
            public Label ArrowLabel;
            public bool WasExpandedBeforeFilter;
            public bool IsExpanded;
        }

        private sealed class ItemState
        {
            public string SectionKey;
            public string Text;
            public Button Button;
            public bool IsMatch;
        }

        private readonly Dictionary<string, SectionState> _sections = new Dictionary<string, SectionState>();
        private readonly List<ItemState> _allItems = new List<ItemState>();
        private bool _isFiltering;

        public KdeNavMenu(FlowLayoutPanel hostPanel)
        {
            _host = hostPanel;

            _host.FlowDirection = FlowDirection.TopDown;
            _host.WrapContents = false;
            _host.AutoScroll = true;
            _headerFont = new Font("Segoe UI", 12f, FontStyle.Regular);
            _itemFont = new Font("Segoe UI", 11f, FontStyle.Regular);
            _host.BackColor = Color.White;
        }

        public void AddSection(string key, string text, Image icon = null)
        {
            Panel section = new Panel();
            section.Width = _host.Width - 20;
            section.Height = HeaderHeight;
            section.Margin = new Padding(0);
            section.BackColor = Color.White;

            Panel header = new Panel();
            header.Height = HeaderHeight;
            header.Dock = DockStyle.Top;
            header.Cursor = Cursors.Hand;

            PictureBox pb = new PictureBox();
            pb.Width = 28;
            pb.Dock = DockStyle.Left;
            pb.SizeMode = PictureBoxSizeMode.CenterImage;

            if (icon != null)
            {
                pb.Image = new Bitmap(icon, new Size(20, 20));
            }
            else
            {
                pb.Visible = false;
            }

            Label arrow = new Label();
            arrow.Text = ">";
            arrow.Dock = DockStyle.Right;
            arrow.Width = 20;
            arrow.TextAlign = ContentAlignment.MiddleCenter;
            arrow.Font = _headerFont;

            Label lbl = new Label();
            lbl.Text = text;
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Font = _headerFont;

            header.Controls.Add(lbl);
            header.Controls.Add(arrow);
            header.Controls.Add(pb);

            Panel items = new Panel();
            items.Dock = DockStyle.Top;
            items.Height = 0;
            items.Visible = false;

            header.Click += delegate { Toggle(key); };
            lbl.Click += delegate { Toggle(key); };
            pb.Click += delegate { Toggle(key); };
            arrow.Click += delegate { Toggle(key); };

            section.Controls.Add(items);
            section.Controls.Add(header);

            _host.Controls.Add(section);

            sectionItems[key] = items;
            sectionArrows[key] = arrow;

            _sections[key] = new SectionState
            {
                SectionPanel = section,
                ItemsPanel = items,
                ArrowLabel = arrow,
                WasExpandedBeforeFilter = false,
                IsExpanded = false
            };
        }

        public void AddItem(string sectionKey, string itemKey, string text)
        {
            Panel items;
            if (!sectionItems.TryGetValue(sectionKey, out items))
                return;

            Button btn = new Button();
            btn.Text = "   " + text;
            btn.Dock = DockStyle.Top;
            btn.Height = ItemHeight;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = _itemFont;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(25, 0, 8, 0);
            btn.FlatAppearance.BorderSize = 0;

            btn.Click += delegate
            {
                if (ItemClicked != null)
                    ItemClicked(sectionKey, itemKey);
            };

            items.Controls.Add(btn);
            items.Controls.SetChildIndex(btn, 0);

            _allItems.Add(new ItemState
            {
                SectionKey = sectionKey,
                Text = text,
                Button = btn,
                IsMatch = false
            });
        }

        private void Toggle(string key)
        {
            SectionState sec;
            if (!_sections.TryGetValue(key, out sec))
                return;

            Panel items = sec.ItemsPanel;
            Label arrow = sec.ArrowLabel;
            Panel section = sec.SectionPanel;

            if (sec.IsExpanded)
            {
                sec.IsExpanded = false;

                items.Visible = false;
                items.Height = 0;
                section.Height = HeaderHeight;
                arrow.Text = ">";
            }
            else
            {
                sec.IsExpanded = true;

                items.Visible = true;
                items.Height = GetVisibleItemsHeight(items);
                section.Height = HeaderHeight + items.Height;
                arrow.Text = "";
            }

            _host.Focus();
        }

        public void ApplyFilter(string filter)
        {
            filter = (filter ?? "").Trim();
            bool enable = filter.Length > 0;

            if (enable && !_isFiltering)
            {
                // запомнить, какие секции были раскрыты ДО фильтра
                foreach (var sec in _sections.Values)
                    sec.WasExpandedBeforeFilter = sec.ItemsPanel.Visible;
            }

            _isFiltering = enable;

            // --- СБРОС ФИЛЬТРА ---
            if (!enable)
            {
                // показать все подпункты
                for (int i = 0; i < _allItems.Count; i++)
                {
                    _allItems[i].IsMatch = true;
                    _allItems[i].Button.Visible = true;
                }

                // восстановить секции как было
                foreach (var sec in _sections.Values)
                {
                    sec.SectionPanel.Visible = true;

                    if (sec.WasExpandedBeforeFilter)
                    {
                        sec.ItemsPanel.Visible = true;
                        sec.ItemsPanel.Height = GetVisibleItemsHeight(sec.ItemsPanel);
                        sec.SectionPanel.Height = HeaderHeight + sec.ItemsPanel.Height;
                        sec.ArrowLabel.Text = ""; // как у тебя при раскрытии
                    }
                    else
                    {
                        sec.ItemsPanel.Visible = false;
                        sec.ItemsPanel.Height = 0;
                        sec.SectionPanel.Height = HeaderHeight;
                        sec.ArrowLabel.Text = ">";
                    }
                }

                _host.PerformLayout();
                _host.Invalidate();
                return;
            }

            // --- ВКЛЮЧЁН ФИЛЬТР: поиск по ВСЕМ подпунктам (даже в свернутых секциях) ---
            string f = filter.ToLowerInvariant();

            // 1) ставим IsMatch каждому пункту и прячем/показываем кнопку
            for (int i = 0; i < _allItems.Count; i++)
            {
                var it = _allItems[i];
                bool match = it.Text != null && it.Text.ToLowerInvariant().Contains(f);

                it.IsMatch = match;
                it.Button.Visible = match; // ок, даже если родитель сейчас скрыт
            }

            // 2) для каждой секции решаем, есть ли совпадения НЕ через Control.Visible,
            //    а через it.IsMatch
            foreach (var kv in _sections)
            {
                string sectionKey = kv.Key;
                var sec = kv.Value;

                bool hasMatches = false;
                for (int i = 0; i < _allItems.Count; i++)
                {
                    var it = _allItems[i];
                    if (it.SectionKey == sectionKey && it.IsMatch)
                    {
                        hasMatches = true;
                        break;
                    }
                }

                if (!hasMatches)
                {
                    sec.SectionPanel.Visible = false;
                    continue;
                }

                // есть совпадения -> показываем секцию и раскрываем
                sec.SectionPanel.Visible = true;
                sec.ItemsPanel.Visible = true;

                // высота по видимым кнопкам (теперь родитель видим, GetVisibleItemsHeight работает)
                sec.ItemsPanel.Height = GetVisibleItemsHeight(sec.ItemsPanel);
                sec.SectionPanel.Height = HeaderHeight + sec.ItemsPanel.Height;

                sec.ArrowLabel.Text = ""; // раскрыто (оставляю твой стиль)
            }

            _host.PerformLayout();
            _host.Invalidate();
        }

        private int GetVisibleItemsHeight(Panel itemsPanel)
        {
            int h = 0;
            foreach (Control c in itemsPanel.Controls)
                if (c.Visible) h += c.Height;
            return h;
        }

        public string GetExpandedSectionsState()
        {
            var keys = new List<string>();

            foreach (var kv in _sections)
            {
                if (kv.Value.IsExpanded)
                    keys.Add(kv.Key);
            }

            return string.Join(";", keys.ToArray());
        }

        public void RestoreExpandedSectionsState(string state)
        {
            var expanded = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            if (!string.IsNullOrWhiteSpace(state))
            {
                string[] parts = state.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < parts.Length; i++)
                    expanded.Add(parts[i].Trim());
            }

            _host.SuspendLayout();

            foreach (var kv in _sections)
            {
                string key = kv.Key;
                var sec = kv.Value;

                bool open = expanded.Contains(key);
                sec.IsExpanded = open;

                sec.SectionPanel.Visible = true;

                if (open)
                {
                    sec.ItemsPanel.Visible = true;

                    int visibleCount = 0;
                    foreach (Control c in sec.ItemsPanel.Controls)
                        if (c.Visible) visibleCount++;

                    sec.ItemsPanel.Height = visibleCount * ItemHeight;
                    sec.SectionPanel.Height = HeaderHeight + sec.ItemsPanel.Height;

                    sec.ArrowLabel.Text = "";
                }
                else
                {
                    sec.ItemsPanel.Visible = false;
                    sec.ItemsPanel.Height = 0;
                    sec.SectionPanel.Height = HeaderHeight;
                    sec.ArrowLabel.Text = ">";
                }
            }

            _host.ResumeLayout(true);
            _host.PerformLayout();
            _host.Invalidate();
        }
    }
}
