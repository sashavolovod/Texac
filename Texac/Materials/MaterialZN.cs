using System;

using System.Windows.Forms;

namespace Texac.Materials
{
    public partial class MaterialZN : UserControl
    {
        public MaterialZN()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string orderNumber = tbOrderNumber.Text.Trim();
            int id;

            if (orderNumber.Length == 0)
                return;

            Int32.TryParse(orderNumber, out id);

            taMaterialZN.FillByOrderId(dataDataSet1.qMaterialZN, id);

        }

        private void tbOrderNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate_Click(this, new EventArgs());
            }
        }
    }
}
