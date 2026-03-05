using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Texac.Win
{
    public static class UiStateManager
    {
        public static void Restore(Form form)
        {
            var dict = Load();

            RestoreFormBounds(form, dict);
            RestoreSplitters(form, dict);
            RestoreGrids(form, dict);
            RestoreToolStrips(form, dict);
        }

        public static void Save(Form form)
        {
            var dict = Load();

            SaveFormBounds(form, dict);
            SaveSplitters(form, dict);
            SaveGrids(form, dict);
            SaveToolStrips(form, dict);

            Save(dict);
        }

        // ---------- FORM ----------

        static void RestoreFormBounds(Form form, Dictionary<string, string> dict)
        {
            string key = form.Name + ".bounds";

            if (!dict.ContainsKey(key))
                return;

            var p = dict[key].Split(';');

            form.StartPosition = FormStartPosition.Manual;
            form.Left = int.Parse(p[0]);
            form.Top = int.Parse(p[1]);
            form.Width = int.Parse(p[2]);
            form.Height = int.Parse(p[3]);
            form.WindowState = (FormWindowState)int.Parse(p[4]);
        }

        static void SaveFormBounds(Form form, Dictionary<string, string> dict)
        {
            var b = form.WindowState == FormWindowState.Normal
                ? form.Bounds
                : form.RestoreBounds;

            dict[form.Name + ".bounds"] =
                $"{b.Left};{b.Top};{b.Width};{b.Height};{(int)form.WindowState}";
        }

        // ---------- SPLITTER ----------

        static void SaveSplitters(Control parent, Dictionary<string, string> dict)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is SplitContainer)
                {
                    SplitContainer sp = (SplitContainer)c;
                    dict[parent.Name + "." + sp.Name] = sp.SplitterDistance.ToString();
                }

                SaveSplitters(c, dict);
            }
        }

        static void RestoreSplitters(Control parent, Dictionary<string, string> dict)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is SplitContainer)
                {
                    SplitContainer sp = (SplitContainer)c;

                    string key = parent.Name + "." + sp.Name;

                    if (dict.ContainsKey(key))
                        sp.SplitterDistance = int.Parse(dict[key]);
                }

                RestoreSplitters(c, dict);
            }
        }


        // ---------- DATAGRIDVIEW: widths + displayIndex + sort ----------

        static void SaveGrids(Control parent, Dictionary<string, string> dict)
        {
            foreach (Control c in parent.Controls)
            {
                var dgv = c as DataGridView;
                if (dgv != null)
                {
                    string prefix = parent.Name + "." + dgv.Name;

                    // widths by column name
                    dict[prefix + ".w"] = string.Join(",",
                        dgv.Columns.Cast<DataGridViewColumn>()
                           .Select(col => col.Name + ":" + col.Width));

                    // display order by column name
                    dict[prefix + ".d"] = string.Join(",",
                        dgv.Columns.Cast<DataGridViewColumn>()
                           .Select(col => col.Name + ":" + col.DisplayIndex));

                    // sort: column name + direction
                    if (dgv.SortedColumn != null)
                    {
                        dict[prefix + ".s"] =
                            dgv.SortedColumn.Name + ":" + (int)dgv.SortOrder;
                    }
                    else
                    {
                        dict.Remove(prefix + ".s");
                    }
                }

                SaveGrids(c, dict);
            }
        }

        static void RestoreGrids(Control parent, Dictionary<string, string> dict)
        {
            foreach (Control c in parent.Controls)
            {
                var dgv = c as DataGridView;
                if (dgv != null)
                {
                    string prefix = parent.Name + "." + dgv.Name;

                    // 1) widths
                    if (dict.ContainsKey(prefix + ".w"))
                    {
                        var items = dict[prefix + ".w"].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var it in items)
                        {
                            var p = it.Split(':');
                            if (p.Length != 2) continue;

                            var col = dgv.Columns[p[0]];
                            int w;
                            if (col != null && int.TryParse(p[1], out w) && w > 10)
                                col.Width = w;
                        }
                    }

                    // 2) display order (перетаскивание колонок)
                    if (dict.ContainsKey(prefix + ".d"))
                    {
                        var items = dict[prefix + ".d"].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                        // Важно: задаём DisplayIndex по возрастанию, иначе могут быть конфликты
                        var pairs = items
                            .Select(x => x.Split(':'))
                            .Where(p => p.Length == 2)
                            .Select(p =>
                            {
                                int di;
                                return new { Name = p[0], Ok = int.TryParse(p[1], out di), DisplayIndex = di };
                            })
                            .Where(x => x.Ok)
                            .OrderBy(x => x.DisplayIndex)
                            .ToList();

                        foreach (var x in pairs)
                        {
                            var col = dgv.Columns[x.Name];
                            if (col != null && x.DisplayIndex >= 0 && x.DisplayIndex < dgv.Columns.Count)
                                col.DisplayIndex = x.DisplayIndex;
                        }
                    }

                    // 3) sort
                    // Важно: сортировку лучше применять ПОСЛЕ того как DataSource назначен и колонки созданы.
                    // Поэтому для надёжности применим через BeginInvoke.
                    if (dict.ContainsKey(prefix + ".s"))
                    {
                        var s = dict[prefix + ".s"].Split(':');
                        if (s.Length == 2)
                        {
                            string colName = s[0];
                            int sortOrderInt;
                            if (int.TryParse(s[1], out sortOrderInt))
                            {
                                dgv.BeginInvoke((Action)(() =>
                                {
                                    var col = dgv.Columns[colName];
                                    if (col == null) return;

                                    // 1=None, 2=Ascending, 3=Descending (DataGridViewColumnSortMode)
                                    // SortOrder: None=0, Ascending=1, Descending=2
                                    if (sortOrderInt == (int)SortOrder.Ascending)
                                        dgv.Sort(col, System.ComponentModel.ListSortDirection.Ascending);
                                    else if (sortOrderInt == (int)SortOrder.Descending)
                                        dgv.Sort(col, System.ComponentModel.ListSortDirection.Descending);
                                }));
                            }
                        }
                    }
                }

                RestoreGrids(c, dict);
            }
        }

        // ---------- TOOLSTRIP: TextBox/ComboBox/CheckButtons ----------

        static void SaveToolStrips(Control parent, Dictionary<string, string> dict)
        {
            foreach (Control c in parent.Controls)
            {
                var ts = c as ToolStrip;
                if (ts != null)
                {
                    string prefix = parent.Name + "." + ts.Name;

                    foreach (ToolStripItem item in ts.Items)
                    {
                        if (item == null || string.IsNullOrEmpty(item.Name)) continue;

                        string key = prefix + "." + item.Name;

                        var tb = item as ToolStripTextBox;
                        if (tb != null)
                        {
                            dict[key + ".t"] = tb.Text ?? "";
                            continue;
                        }

                        var cb = item as ToolStripComboBox;
                        if (cb != null)
                        {
                            dict[key + ".t"] = cb.Text ?? "";
                            continue;
                        }

                        var btn = item as ToolStripButton;
                        if (btn != null)
                        {
                            dict[key + ".c"] = btn.Checked ? "1" : "0";
                            continue;
                        }
                    }
                }

                SaveToolStrips(c, dict);
            }
        }

        static void RestoreToolStrips(Control parent, Dictionary<string, string> dict)
        {
            foreach (Control c in parent.Controls)
            {
                var ts = c as ToolStrip;
                if (ts != null)
                {
                    string prefix = parent.Name + "." + ts.Name;

                    foreach (ToolStripItem item in ts.Items)
                    {
                        if (item == null || string.IsNullOrEmpty(item.Name)) continue;

                        string key = prefix + "." + item.Name;

                        var tb = item as ToolStripTextBox;
                        if (tb != null && dict.ContainsKey(key + ".t"))
                        {
                            tb.Text = dict[key + ".t"];
                            continue;
                        }

                        var cb = item as ToolStripComboBox;
                        if (cb != null && dict.ContainsKey(key + ".t"))
                        {
                            cb.Text = dict[key + ".t"];
                            continue;
                        }

                        var btn = item as ToolStripButton;
                        if (btn != null && dict.ContainsKey(key + ".c"))
                        {
                            btn.Checked = dict[key + ".c"] == "1";
                            continue;
                        }
                    }
                }

                RestoreToolStrips(c, dict);
            }
        }
        

        // ---------- STORAGE ----------

        static Dictionary<string, string> Load()
        {
            var d = new Dictionary<string, string>();

            string raw = Properties.Settings.Default.UiState;

            if (string.IsNullOrEmpty(raw))
                return d;

            foreach (var item in raw.Split('|'))
            {
                var p = item.Split('=');

                if (p.Length == 2)
                    d[p[0]] = p[1];
            }

            return d;
        }

        static void Save(Dictionary<string, string> dict)
        {
            Properties.Settings.Default.UiState =
                string.Join("|", dict.Select(x => $"{x.Key}={x.Value}"));

            Properties.Settings.Default.Save();
        }
    }
}