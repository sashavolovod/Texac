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
    public partial class OrderNumberForm : MyForm
    {
        
        AddTrebovaniyaForm parentForm;

        public OrderNumberForm(AddTrebovaniyaForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Int32 orderId;
            if(Int32.TryParse(tbOrderNumber.Text, out orderId))
            {
                DialogResult = DialogResult.OK;
                Properties.Settings.Default.TrebovanieLastOrderId = orderId;
                parentForm.orderId = orderId;
                Properties.Settings.Default.Save();
                Close();
            }
            else
            {
                MessageBox.Show("Некорректный номер заказа","Внимание",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void OrderNumberForm_Load(object sender, EventArgs e)
        {
            tbOrderNumber.Text = Properties.Settings.Default.TrebovanieLastOrderId.ToString();
        }
    }
}
