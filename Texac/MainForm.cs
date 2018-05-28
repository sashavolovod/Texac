using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Texac.Trebovaniya;

namespace Texac
{
    public partial class MainForm : MyForm
    {
        private DataTable dept;
        OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.connStr);

        public MainForm()
        {
            InitializeComponent();
            dept = createDeptDataTable();
            cbEmployee.ComboBox.DataSource = dept;
            cbEmployee.ComboBox.ValueMember = "Code";
            cbEmployee.ComboBox.DisplayMember = "Caption";
            cbEmployee.ComboBox.SelectedIndex = 8;

            dgvEmploeyes.AutoGenerateColumns = false;
            dgvTrebovania.AutoGenerateColumns = false;

            
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
//            long startTime = DateTime.Now.Ticks;

            Cursor.Current = Cursors.WaitCursor;
            
            conn.Open();
//            long endTime = DateTime.Now.Ticks;

            taTrebovania.Connection = conn;
            taEmployee.Connection = conn;
           
            
            taTrebovania.Fill(this.dataDataSet.TrebovaniaView);
            taEmployee.Fill(dataDataSet.РаботникиView);

            conn.Close();

            

            Cursor.Current = Cursors.Default;
            tabControl1.SelectedIndex = 2;

            //Console.WriteLine(endTime-startTime);

        }

        private  DataTable createDeptDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Code", typeof(string));
            table.Columns.Add("Caption", typeof(string));
            table.Rows.Add("720 А", "120А");
            table.Rows.Add("720 Б", "120Б");
            table.Rows.Add("720 В", "120В");
            table.Rows.Add("720 Г", "120Г");
            table.Rows.Add("721", "121");
            table.Rows.Add("722", "122");
            table.Rows.Add("723", "123");
            table.Rows.Add("724", "124");
            table.Rows.Add("700 ", "ИТР");
            table.Rows.Add("Уволен.", "Уволен.");
            return table;
        }

        private void cbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbEmployee.ComboBox.SelectedValue!= null)
            {
                string selected = cbEmployee.ComboBox.SelectedValue.ToString();
                if(selected== "Уволен.")
                    bsEmployee.Filter = "Работает=false";
                else
                    bsEmployee.Filter = "Подразд='" + selected + "' AND Работает=true";
            }
            else
                bsEmployee.Filter = null;

        }

        private void miMaterialreport_Click(object sender, EventArgs e)
        {
            new RashodParametersForm().Show();
        }

        private void dgvTrebovania_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(bsTrebovania.Position>=0)
            {
                dataDataSet.TrebovaniaViewRow row = (dataDataSet.TrebovaniaViewRow)((DataRowView)bsTrebovania.Current).Row;
                TrebovanieForm form = new TrebovanieForm(row.TrebovanieId);
                form.FormClosing += TrebovanieForm_FormClosing;
                form.Show();
            }
        }

        private void TrebovanieForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(((Form)sender).DialogResult == DialogResult.OK)
            {
                UpdateTable();
            }
        }

        public void UpdateTable()
        {
            taTrebovania.Fill(dataDataSet.TrebovaniaView);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTrebovaniyaForm form = new AddTrebovaniyaForm();
            form.ShowDialog();
            taTrebovania.Fill(dataDataSet.TrebovaniaView);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
