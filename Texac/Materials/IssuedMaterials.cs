using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Texac.Materials
{
    public partial class IssuedMaterials : UserControl
    {
        public IssuedMaterials()
        {
            InitializeComponent();
            tbOrderNumber.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string orderNumber = tbOrderNumber.Text.Trim();
            int id;
            if (orderNumber.Length == 0)
                return;

            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.connStr);
            conn.Open();
            taMaterialReportDetails.Connection = conn;

            if (orderNumber.Contains("-") || orderNumber.Contains("/"))
            {
                taMaterialReportDetails.FillByOrderNumberBooker(dataDataSet.MaterialReportDetails, orderNumber);
            }
            else
            {
                Int32.TryParse(orderNumber, out id);
                taMaterialReportDetails.FillByOrderNumber(dataDataSet.MaterialReportDetails, id);
            }
           
            conn.Close();
            dgvMaterialReportDetails.Focus();
        }

        private void tbOrderNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate_Click(this, new EventArgs());
            }
        }

        public void selectTextBox()
        {
            tbOrderNumber.Focus();
        }
    }
}
