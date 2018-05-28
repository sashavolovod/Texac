using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Texac.Trebovaniya
{
    public partial class OrderTypeForm : MyForm
    {
        private AddTrebovaniyaForm parentForm;
        public OrderTypeForm(AddTrebovaniyaForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (tbOrderType.Text == "")
            {
                MessageBox.Show("Некорректный номер заказа", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Properties.Settings.Default.TrebovanieLastType  = tbOrderType.Text;
            Properties.Settings.Default.Save();
            parentForm.orderType = tbOrderType.Text;
            parentForm.startDate = dtpStartDate.Value;
            parentForm.endDate = dtpEndDate.Value;
            Close();
        }

        private void OrderTypeForm_Load(object sender, EventArgs e)
        {
            tbOrderType.Text = Properties.Settings.Default.TrebovanieLastType;
            dtpEndDate.Value = DateTime.Today.AddDays(-1);
            dtpStartDate.Value = DateTime.Today.AddDays(-5);
        }
    }
}
