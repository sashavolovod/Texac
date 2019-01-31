using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Texac.Employees
{
    public partial class EmployeeList : UserControl
    {
        private DataTable dept;

        public EmployeeList()
        {
            InitializeComponent();

            dept = createDeptDataTable();
            cbEmployee.ComboBox.DataSource = dept;
            cbEmployee.ComboBox.ValueMember = "Code";
            cbEmployee.ComboBox.DisplayMember = "Caption";
            cbEmployee.ComboBox.SelectedIndex = 8;

            dgvEmploeyes.AutoGenerateColumns = false;
        }

        private DataTable createDeptDataTable()
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

            if (cbEmployee.ComboBox.SelectedValue != null)
            {
                string selected = cbEmployee.ComboBox.SelectedValue.ToString();
                if (selected == "Уволен.")
                    bsEmployee.Filter = "Работает=false";
                else
                    bsEmployee.Filter = "Подразд='" + selected + "' AND Работает=true";
            }
            else
                bsEmployee.Filter = null;

        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.connStr);
            conn.Open();
            taEmployee.Connection = conn;
            taEmployee.Fill(dataDataSet.РаботникиView);
            conn.Close();
        }
    }

}
