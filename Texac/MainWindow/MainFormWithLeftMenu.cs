using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Texac.Ekon;
using Texac.Ekon.Inventory;
using Texac.Employees;
using Texac.LocksmithOperations;
using Texac.Materials;
using Texac.PlanOrders;
using Texac.PsnHistory;
using Texac.Trebovaniya;
using Texac.TTN;

namespace Texac.MainWindow
{
    public partial class MainFormWithLeftMenu : Form
    {
        private const int EM_SETCUEBANNER = 0x1501;

        private KdeNavMenu menu;
        private int _menuWidthBeforeHide = 240;
        private bool _menuHidden = false;

        private int hoverIndex = -1; // Индекс вкладки, на которой находится курсор
        private readonly Image _closeImage = Properties.Resources.Close;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);


        public MainFormWithLeftMenu()
        {
            InitializeComponent();

            mainTabControl.Padding = new Point(21, 6);
            mainTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            mainTabControl.DrawItem += MainTabControl_DrawItem;
            mainTabControl.MouseMove += MainTabControl_MouseMove;
            mainTabControl.MouseLeave += MainTabControl_MouseLeave;
            mainTabControl.MouseDown += MainTabControl_MouseDown;

            picSearch.Image = Properties.Resources.icons8_search_16;

            menu = new KdeNavMenu(flpNav);
            BuildMenu();
            menu.ItemClicked += Menu_ItemClicked;

            txtMenuSearch.TextChanged += (s, e) => menu.ApplyFilter(txtMenuSearch.Text);

            txtMenuSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape)
                {
                    txtMenuSearch.Clear();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            };

            btnToggleMenu.Click += (s, e) => ToggleMenu();
            flpNav.Resize += (s, e) => UpdateSearchWidth();

            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.Control && e.KeyCode == Keys.M)
                {
                    ToggleMenu();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            };

            this.Shown += (s, e) =>
            {
                LoadUiState();
                InitSearchBox();
                UpdateSearchWidth();
            };

            this.FormClosing += (s, e) => SaveUiState();
        }

        

        private void BuildMenu()
        {
            // Заказы
            menu.AddSection("orders", "Заказы", Properties.Resources.orders);
            menu.AddItem("orders", "orders", "Заказы");
            menu.AddItem("orders", "customers", "Заказчики");
            menu.AddItem("orders", "tool_types", "Виды оснастки");
            menu.AddItem("orders", "orders_search", "Поиск заказов");

            // Технология
            menu.AddSection("tech", "Технология", Properties.Resources.technology);
            menu.AddItem("tech", "tech_processes", "Техпроцессы");
            menu.AddItem("tech", "norms", "Нормирование");

            // Материалы
            menu.AddSection("materials", "Материалы", Properties.Resources.materials);
            menu.AddItem("materials", "stock", "Остатки");
            menu.AddItem("materials", "requirements", "Требования");

            // Производство
            menu.AddSection("production", "Производство", Properties.Resources.production);
            menu.AddItem("production", "blanking", "Заготовка");
            menu.AddItem("production", "execution", "Выполнение");
            menu.AddItem("production", "work_acceptance", "Сдача работ");

            // Персонал
            menu.AddSection("staff", "Персонал", Properties.Resources.staff);
            menu.AddItem("staff", "employees", "Сотрудники");
            menu.AddItem("staff", "timesheet", "Табель");

            // Отчёты
            menu.AddSection("reports", "Отчёты", Properties.Resources.reports);
            menu.AddItem("reports", "materials_report", "По материалам");
            menu.AddItem("reports", "works_report", "По работам");

            // Администрирование
            menu.AddSection("admin", "Администрирование", Properties.Resources.admin);
            menu.AddItem("admin", "profile", "Профиль");
            menu.AddItem("admin", "settings", "Настройки");
            menu.AddItem("admin", "users_roles", "Пользователи и роли");
        }

        private void SaveUiState()
        {
            SaveWindowState();

            // --- сохранить меню/сплиттер ---
            if (menu != null)
                Properties.Settings.Default.MenuExpandedSections = menu.GetExpandedSectionsState();

            Properties.Settings.Default.MenuHidden = _menuHidden;

            // если меню скрыто — SplitterDistance недоступен, сохраняем "до скрытия"
            Properties.Settings.Default.MenuWidth = _menuHidden ? _menuWidthBeforeHide : splitMain.SplitterDistance;

            Properties.Settings.Default.Save();
        }

        private void LoadWindowState()
        {
            int x = Properties.Settings.Default.MainWindowX;
            int y = Properties.Settings.Default.MainWindowY;
            int w = Properties.Settings.Default.MainWindowW;
            int h = Properties.Settings.Default.MainWindowH;

            if (w >= 400 && h >= 300)
            {
                var desired = new Rectangle(x, y, w, h);

                // не дать окну "улететь" за пределы экранов
                Rectangle wa = Screen.FromRectangle(desired).WorkingArea;
                if (!wa.IntersectsWith(desired))
                {
                    desired = new Rectangle(
                        wa.X + 50,
                        wa.Y + 50,
                        Math.Min(w, wa.Width),
                        Math.Min(h, wa.Height)
                    );
                }

                this.StartPosition = FormStartPosition.Manual;
                this.Bounds = desired;
            }

            string state = Properties.Settings.Default.MainWindowState;
            FormWindowState ws;
            if (!Enum.TryParse(state, out ws))
                ws = FormWindowState.Normal;

            // не стартуем свернутыми
            if (ws == FormWindowState.Minimized)
                ws = FormWindowState.Normal;

            this.WindowState = ws;
        }

        private void SaveWindowState()
        {
            Properties.Settings.Default.MainWindowState = this.WindowState.ToString();

            // Если Maximized/Minimized — сохраняем RestoreBounds (куда вернётся при Normal)
            Rectangle b = (this.WindowState == FormWindowState.Normal) ? this.Bounds : this.RestoreBounds;

            Properties.Settings.Default.MainWindowX = b.X;
            Properties.Settings.Default.MainWindowY = b.Y;
            Properties.Settings.Default.MainWindowW = b.Width;
            Properties.Settings.Default.MainWindowH = b.Height;
        }

        private void LoadUiState()
        {
            LoadWindowState();

            // --- восстановление меню/сплиттера ---
            _menuWidthBeforeHide = Properties.Settings.Default.MenuWidth > 0
                ? Properties.Settings.Default.MenuWidth
                : 240;

            // 1) восстановить раскрытые секции (после того как меню построено AddSection/AddItem)
            // если menu ещё не создан — просто пропусти (на всякий случай)
            if (menu != null)
                menu.RestoreExpandedSectionsState(Properties.Settings.Default.MenuExpandedSections);

            // 2) восстановить скрытие меню
            bool savedHidden = Properties.Settings.Default.MenuHidden;

            if (savedHidden)
            {
                HideMenu(); // использует _menuWidthBeforeHide
            }
            else
            {
                ShowMenu(); // вернёт SplitterDistance
            }
        }


        void Menu_ItemClicked(string section, string item)
        {
            openNewTab(item);

        }
        private void HideMenu()
        {
            if (_menuHidden) return;

            _menuWidthBeforeHide = splitMain.SplitterDistance;
            splitMain.Panel1Collapsed = true;
            _menuHidden = true;

            btnToggleMenu.Text = ">";
        }

        private void ShowMenu()
        {
            if (!_menuHidden) return;

            splitMain.Panel1Collapsed = false;

            // вернуть ширину (если вдруг сохранилась странная)
            splitMain.SplitterDistance = (_menuWidthBeforeHide < 120) ? 240 : _menuWidthBeforeHide;

            _menuHidden = false;
            btnToggleMenu.Text = "<";
        }

        private void ToggleMenu()
        {
            if (_menuHidden) ShowMenu();
            else HideMenu();
        }

        private void UpdateSearchWidth()
        {
            int scrollbarWidth = flpNav.VerticalScroll.Visible
                   ? SystemInformation.VerticalScrollBarWidth
                   : 0;

            pnlSearchWrap.Padding = new Padding(0, 4, scrollbarWidth, 4);
        }

        private static void SetCueBanner(TextBox textBox, string cue)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, (IntPtr)1, cue);
        }

        private void InitSearchBox()
        {
            SetCueBanner(txtMenuSearch, "Поиск по меню…");
        }


        private Boolean findOpenTab(string tabPageName)
        {
            for (int i = 0; i < mainTabControl.TabPages.Count; i++)
            {
                if (mainTabControl.TabPages[i].Text == tabPageName)
                {
                    mainTabControl.SelectedIndex = i;
                    return true;
                }
            }
            return false;
        }


        private Control createTabPageControl(string tabPageName)
        {
            switch (tabPageName)
            {
                case "employees":
                    return new EmployeeList();
                case "requirements":
                    return new TrebovanieList();
                case "Полученные материалы":
                    return new IssuedMaterials();
                case "Материалы по заказ-нарядам":
                    return new MaterialZN();
                case "О выполнении плана сдачи оснастки и инструментов":
                    return new OsnastkaUserControl();
                case "Добавление годовых заявок":
                    return new PlanOrdersControl();
                case "Накладная (сдача оснастки)":
                    return new DeliveryNoteControl();
                case "Распределение слесарных работ по типу оснастки":
                    return new LocksmithOperationControl();
                case "Выписанные накладные":
                    return new PsnListControl();
                case "Метериальный отчет по оборотной ведомости":
                    return new InventoryControl();
                default:
                    return new Control();
            };
        }


        private void openNewTab(string tabPageName)
        {
            if (findOpenTab(tabPageName) == false)
            {
                Cursor = Cursors.WaitCursor;
                SuspendLayout();
                int indexNewTab = mainTabControl.TabPages.Count;
                Control c = createTabPageControl(tabPageName);
                TabPage tab = new TabPage(c.Name);

                c.Dock = DockStyle.Fill;
                tab.Controls.Add(c);
                mainTabControl.TabPages.Add(tab);
                mainTabControl.SelectedIndex = indexNewTab;

                if (c is IssuedMaterials)
                {
                    (c as IssuedMaterials).selectTextBox();
                }
                ResumeLayout(true);
                Cursor = Cursors.Default;
            }
        }

        private Rectangle GetCloseRect(int tabIndex)
        {
            var tabRect = mainTabControl.GetTabRect(tabIndex);
            tabRect.Inflate(-2, -2);

            int w = _closeImage.Width;
            int h = _closeImage.Height;

            return new Rectangle(
                tabRect.Right - w - 2,
                tabRect.Top + (tabRect.Height - h) / 2,
                w,
                h
            );
        }

        private void MainTabControl_MouseDown(object sender, MouseEventArgs e)
        {
            // (опционально) закрытие средней кнопкой по вкладке
            if (e.Button == MouseButtons.Middle)
            {
                for (int i = 0; i < mainTabControl.TabPages.Count; i++)
                {
                    if (mainTabControl.GetTabRect(i).Contains(e.Location))
                    {
                        mainTabControl.TabPages.RemoveAt(i);
                        return;
                    }
                }
            }

            if (e.Button != MouseButtons.Left)
                return;

            for (int i = 0; i < mainTabControl.TabPages.Count; i++)
            {
                if (GetCloseRect(i).Contains(e.Location))
                {
                    mainTabControl.TabPages.RemoveAt(i);
                    hoverIndex = -1;
                    mainTabControl.Invalidate();
                    return;
                }
            }
        }

        private void MainTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tabPage = mainTabControl.TabPages[e.Index];

            var tabRect = mainTabControl.GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);

            var closeRect = GetCloseRect(e.Index);

            // Подсветка кнопки закрытия при hover
            if (e.Index == hoverIndex)
            {
                using (var brush = new SolidBrush(Color.LightGray))
                    e.Graphics.FillRectangle(brush, closeRect);

                using (var pen = new Pen(Color.Gray))
                    e.Graphics.DrawRectangle(pen, closeRect);
            }

            // Текст: ограничиваем, чтобы не залезал на крестик
            var textRect = tabRect;
            textRect.Width = Math.Max(0, closeRect.Left - tabRect.Left - 6);

            TextRenderer.DrawText(
                e.Graphics,
                tabPage.Text,
                tabPage.Font,
                textRect,
                tabPage.ForeColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis
            );

            // Иконка закрытия
            var imgX = closeRect.Left + (closeRect.Width - _closeImage.Width) / 2;
            var imgY = closeRect.Top + (closeRect.Height - _closeImage.Height) / 2;

            e.Graphics.DrawImage(_closeImage, imgX, imgY, _closeImage.Width, _closeImage.Height);
        }

        private void MainTabControl_MouseMove(object sender, MouseEventArgs e)
        {
            int newHover = -1;

            for (int i = 0; i < mainTabControl.TabPages.Count; i++)
            {
                if (GetCloseRect(i).Contains(e.Location))
                {
                    newHover = i;
                    break;
                }
            }

            if (hoverIndex != newHover)
            {
                hoverIndex = newHover;
                mainTabControl.Invalidate();
            }
        }

        private void MainTabControl_MouseLeave(object sender, EventArgs e)
        {
            if (hoverIndex != -1)
            {
                hoverIndex = -1;
                mainTabControl.Invalidate();
            }
        }
    }
}
