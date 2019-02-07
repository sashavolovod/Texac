using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing;

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
            taIssuedMaterialsView.Connection = conn;

            if (orderNumber.Contains("-") || orderNumber.Contains("/"))
            {
                taIssuedMaterialsView.FillByOrderNumberBooker(dataDataSet.IssuedMaterialsView, orderNumber);
            }
            else
            {
                Int32.TryParse(orderNumber, out id);
                taIssuedMaterialsView.FillByOrderNumber(dataDataSet.IssuedMaterialsView, id);
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

        private void dgvMaterialReportDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            double v1;
            double v2;
            DataGridViewRow  row = dgvMaterialReportDetails.Rows[e.RowIndex];

            if(!double.TryParse(row.Cells[6].Value.ToString(), out v1))
                v1=0.0;

            if (!double.TryParse(row.Cells[7].Value.ToString(), out v2))
                v2 = 0.0;

            if (v1 != v2)
            {
                e.CellStyle.ForeColor = System.Drawing.Color.Maroon;
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
            }
        }
    }
}
