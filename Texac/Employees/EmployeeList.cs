using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Texac.Common;

namespace Texac.Employees
{
    public partial class EmployeeList : UserControl
    {
        private DataTable dept;

        public EmployeeList()
        {
            InitializeComponent();
            Name = "Список сотрудников";
            dept = createDeptDataTable();
            cbEmployee.ComboBox.DataSource = dept;
            cbEmployee.ComboBox.ValueMember = "Code";
            cbEmployee.ComboBox.DisplayMember = "Caption";
            cbEmployee.ComboBox.SelectedIndex = 1;

            dgvEmploeyes.AutoGenerateColumns = false;
        }

        private DataTable createDeptDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Code", typeof(string));
            table.Columns.Add("Caption", typeof(string));
            table.Rows.Add("700_12 ", "Руководители");
            table.Rows.Add("700_11 ", "ИТР");
            table.Rows.Add("720А_2", "120А");
            table.Rows.Add("720Б_2", "120Б");
            table.Rows.Add("720В_2", "120В");
            table.Rows.Add("720Г_2", "120Г");
            table.Rows.Add("721_2", "121");
            table.Rows.Add("722_2", "122");
            table.Rows.Add("724_2", "124");
            
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

        private void tsbPrintTabel_Click(object sender, EventArgs e)
        {

            string selected = cbEmployee.ComboBox.SelectedValue.ToString();


            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("parReportMonth", "2");
            parameters[1] = new ReportParameter("parReportYear", "2026");
            parameters[2] = new ReportParameter("parDept", cbEmployee.ComboBox.Text);

            DataView filteredView = new DataView(dataDataSet.Tables["РаботникиView"]);
            filteredView.RowFilter = "Подразд='" + selected + "' AND Работает=true";
            ReportDataSource rds = new ReportDataSource("DataSet1", filteredView);

            ReportForm reportForm = new ReportForm("Texac.Employees.EmploeeTabelReport.rdlc", "Табель ИнЦ", parameters, rds);


            reportForm.Show();
        }
    }

}
