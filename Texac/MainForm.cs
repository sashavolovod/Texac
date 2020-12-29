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

namespace Texac
{
    public partial class MainForm : MyForm
    {

        OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.connStr);

        public MainForm()
        {
            InitializeComponent();

            this.tabControl1.Padding = new Point(12, 4);
            this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;

            this.tabControl1.DrawItem += tabControl1_DrawItem;
            this.tabControl1.MouseDown += tabControl1_MouseDown;
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
            openNewTab("Список рабоников цеха");
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
            if (tabPageName == "Список рабоников цеха")
                return new EmployeeList();
            else if (tabPageName == "Требования")
                return new TrebovanieList();
            else if (tabPageName == "Полученные материалы")
                return new IssuedMaterials();
            else if (tabPageName == "Материалы по заказ-нарядам")
                return new MaterialZN();
            else if (tabPageName == "О выполнении плана сдачи оснастки и инструментов")
                return new OsnastkaUserControl();

            return new Control();
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
            e.Graphics.DrawImage(closeImage, (tabRect.Right - closeImage.Width), tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
            TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, tabRect, tabPage.ForeColor, TextFormatFlags.Left);
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
    }
}
