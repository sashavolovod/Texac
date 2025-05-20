using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using Texac.Employees;
using Texac.Materials;
using Texac.Trebovaniya;
using Texac.Properties;
using Texac.Ekon;
using Texac.PlanOrders;
using System.Net.Http;
using System.Reflection;
using System.Globalization;
using Renci.SshNet;
using System.IO;
using System.Text;
using Texac.Ollama;
using Texac.TTN;
using Texac.LocksmithOperations;
using Texac.PsnHistory;

namespace Texac
{
    public partial class MainForm : MyForm
    {
        OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.connStr);

        private int hoverIndex = -1; // Индекс вкладки, на которой находится курсор

        public MainForm()
        {
            InitializeComponent();

            this.tabControl1.Padding = new Point(12, 4);
            this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;

            this.tabControl1.DrawItem += tabControl1_DrawItem;
            this.tabControl1.MouseDown += tabControl1_MouseDown;

            miAddPlanOrders.Enabled = Environment.MachineName.Equals("WIN7X64") || Environment.MachineName.Equals("INC-TECH08");
            miAdmin.Visible = Environment.MachineName.Equals("WIN7X64");
            openNewTab("AI ассистент");
            //openNewTab("Распределение слесарных работ по типу оснастки");

        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*
            long startTime = DateTime.Now.Ticks;

            Cursor.Current = Cursors.WaitCursor;

            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.connStr);
            conn.Open();
            long endTime = DateTime.Now.Ticks;


            conn.Close();
            Cursor.Current = Cursors.Default;

            //Console.WriteLine(endTime-startTime);
            */

        }
        
        private void miMaterialreport_Click(object sender, EventArgs e)
        {
            new RashodParametersForm().Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void miTrebovaniya_Click(object sender, EventArgs e)
        {
            openNewTab("Требования"); 
        }

        private void miEployees_Click(object sender, EventArgs e)
        {
            openNewTab("Список работников цеха");
        }

        private void openNewTab(string tabPageName)
        {
            if (findOpenTab(tabPageName) == false)
            {
                int indexNewTab = tabControl1.TabPages.Count;
                TabPage tab = new TabPage(tabPageName);
                Control c = createTabPageControl(tabPageName);
                c.Dock = DockStyle.Fill;
                tab.Controls.Add(c);
                tabControl1.TabPages.Add(tab);
                tabControl1.SelectedIndex = indexNewTab;

                if(c is IssuedMaterials)
                {
                    (c as IssuedMaterials).selectTextBox();
                }
            }
        }

        private Control createTabPageControl(string tabPageName)
        {
            switch (tabPageName)
            {
                case "Список рабоников цеха":
                    return new EmployeeList();
                case "Требования":
                    return new TrebovanieList();
                case "Полученные материалы":
                    return new IssuedMaterials();
                case "Материалы по заказ-нарядам":
                    return new MaterialZN();
                case "О выполнении плана сдачи оснастки и инструментов":
                    return new OsnastkaUserControl();
                case "Добавление годовых заявок":
                    return new PlanOrdersControl();
                case "AI ассистент":
                    return new OllamaControl();
                case "Накладная (сдача оснастки)":
                    return new DeliveryNoteControl();
                case "Распределение слесарных работ по типу оснастки":
                    return new LocksmithOperationControl();
                case "Выписанные накладные":
                    return new PsnListControl();
                default:
                    return new Control();
            };
        }
            

        private Boolean findOpenTab(string tabPageName)
        {
            for(int i=0;i<tabControl1.TabPages.Count;i++)
            {
                if(tabControl1.TabPages[i].Text== tabPageName)
                {
                    tabControl1.SelectedIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < this.tabControl1.TabPages.Count; i++)
            {
                var tabRect = this.tabControl1.GetTabRect(i);
                tabRect.Inflate(-2, -2);

                var closeImage = Properties.Resources.Close;

                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                   
                if (imageRect.Contains(e.Location))
                {
                    this.tabControl1.TabPages.RemoveAt(i);
                    break;
                }
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tabPage = this.tabControl1.TabPages[e.Index];
            var tabRect = this.tabControl1.GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);
            var closeImage = Properties.Resources.Close;

            var closeButtonRect = new Rectangle(
                tabRect.Right - closeImage.Width - 1,
                tabRect.Top - 1 + (tabRect.Height - closeImage.Height) / 2 ,
                closeImage.Width-2,
                closeImage.Height-2);

            // Если курсор над кнопкой, рисуем фон
            if (e.Index == hoverIndex )
            {
                using (var brush = new SolidBrush(Color.LightGray))
                {
                    e.Graphics.FillRectangle(brush, closeButtonRect);
                }
                // Рисуем рамку вокруг кнопки
                using (var pen = new Pen(Color.Gray))
                {
                    e.Graphics.DrawRectangle(pen, closeButtonRect);
                }
            }

            e.Graphics.DrawImage(closeImage, (tabRect.Right - closeImage.Width), tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
            TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, tabRect, tabPage.ForeColor, TextFormatFlags.Left);
        }

        private void tabControl1_MouseMove(object sender, MouseEventArgs e)
        {
            // Проверяем, находится ли курсор над кнопкой закрытия
            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                var tabRect = tabControl1.GetTabRect(i);

                var closeButtonRect = new Rectangle(
                    tabRect.Right - 16 - 1,
                    tabRect.Top - 1 + (tabRect.Height - 16) / 2,
                    14,
                    14);

                if (closeButtonRect.Contains(e.Location))
                {
                    if (hoverIndex != i)
                    {
                        hoverIndex = i;
                        // Перерисовываем контрол
                        tabControl1.Invalidate();
                    }
                    return;
                }
            }

            if (hoverIndex != -1)
            {
                hoverIndex = -1;
                tabControl1.Invalidate();
            }
        }

        private void tabControl1_MouseLeave(object sender, EventArgs e)
        {
            if (hoverIndex != -1)
            {
                hoverIndex = -1;
                tabControl1.Invalidate();
            }
        }

        private void miIssuedMaterials_Click(object sender, EventArgs e)
        {
            openNewTab("Полученные материалы");
        }

        private void miReadyWork_Click(object sender, EventArgs e)
        {
            new frmEndWorkReportParametrs().Show();
        }

        private void miTtn_Click(object sender, EventArgs e)
        {

        }

        private void miDopZN_Click(object sender, EventArgs e)
        {
            new DopZnForm().Show();
        }

        private void miMatZN_Click(object sender, EventArgs e)
        {
            openNewTab("Материалы по заказ-нарядам");
        }

        private void miPlanZagruzki_Click(object sender, EventArgs e)
        {
            new PlanZagruzki.PlanZagruzkiForm().Show();
        }

        private void miOsnastka_Click(object sender, EventArgs e)
        {
            openNewTab("О выполнении плана сдачи оснастки и инструментов");
        }

        private void miEqupmentByTO_Click(object sender, EventArgs e)
        {
            new Analize.AnalizeForm().Show();
        }

        private void miAddPlanOrders_Click(object sender, EventArgs e)
        {
            openNewTab("Добавление годовых заявок");
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            // new AboutBoxForm().ShowDialog();

            var files = Admin.FileVersionChecker.GetFileVersions();
            StringBuilder sb = new StringBuilder();
            foreach (var file in files)
            {
                sb.AppendLine($"{file.FileName}: {file.FileVersion}");
            }

            MessageBox.Show(sb.ToString());

        }

        async private void miDeploy_Click(object sender, EventArgs e)
        {
            String updateServerUrl = "http://172.16.2.114:8888";
            var currentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString(2);
            var executableFileNamePath = Assembly.GetEntryAssembly().Location;
            var executableFileName = Path.GetFileName(executableFileNamePath);
            
            if (executableFileNamePath.Contains("Debug"))
            {
                MessageBox.Show("Отладочная версия файла не может быть развернута");
                return;
            }
            
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync($"{updateServerUrl}/texac/version.txt");
                    var readVersion = await response.Content.ReadAsStringAsync();
                    readVersion = readVersion.TrimEnd(Environment.NewLine.ToCharArray());
                    if (Convert.ToDouble(currentVersion, CultureInfo.InvariantCulture) == Convert.ToDouble(readVersion, CultureInfo.InvariantCulture))
                    {
                        MessageBox.Show($"На сервере уже присутсвует версия { readVersion }. Измените версию исполняемого файла и повторите развертывание приложения");
                        return;
                    }
                } catch (Exception)
                {
                    MessageBox.Show("Сервер обновлений не доступен");
                }
              
                var privateKey = new PrivateKeyFile(@"c:\Users\user\Documents\ssh\keys\udly.pem");
                
                using (SftpClient sftpClient = new SftpClient("172.16.2.114", "udly", new[] { privateKey }))
                {
                    try
                    {
                        sftpClient.Connect();
                        sftpClient.UploadFile(File.OpenRead(executableFileNamePath), $"www/texac/{executableFileName}");
                        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(currentVersion)))
                        {
                            sftpClient.UploadFile(ms, $"www/texac/version.txt");
                        }
                        
                        MessageBox.Show($"Новая версия скопирована на сервер обновления");

                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
            }

        }

        private void miDeliveryNote_Click(object sender, EventArgs e)
        {
            openNewTab("Накладная (сдача оснастки)");
        }

        private void miLocksmithOperation_Click(object sender, EventArgs e)
        {
            openNewTab("Распределение слесарных работ по типу оснастки");
        }

        private void miPsnHistory_Click(object sender, EventArgs e)
        {
            openNewTab("Выписанные накладные");
        }
    }
}
