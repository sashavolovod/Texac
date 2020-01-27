using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Texac
{
    public partial class DopZnForm : MyForm
    {
        public DopZnForm()
        {
            InitializeComponent();
        }

        private void DopZnForm_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write("curren date " + dtDate.Value.ToString());
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            /*
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Привет";
            popup.ContentText = "рпорпорпорпорпорпорпорп";

            System.Diagnostics.Debug.WriteLine(popup.AnimationDuration);
            System.Diagnostics.Debug.WriteLine(popup.AnimationInterval);
            System.Diagnostics.Debug.WriteLine(popup.Delay);

            popup.Popup();
            */

            List<DopZNEntityDetails> list = new List<DopZNEntityDetails>();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string orderNumber = tbOrderNumber.Text.Trim();
            int id;

            if (orderNumber.Length == 0)
                return;

            Int32.TryParse(orderNumber, out id);

            taMaterialZN.FillByOrderId(dataDataSet1.qMaterialZN, id);
            for(int i=0;i<dgvMaterialZN.Rows.Count;i++)
            {
                // colMassaRO
                dgvMaterialZN.Rows[i].Cells["colMassa"].Value = dgvMaterialZN.Rows[i].Cells["colMassaRO"].Value;
            }
        }

        private void qMaterialZNDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.RowIndex>=0 && e.ColumnIndex>=0)
            {
//                try
//                {
                    DataTable dt = dataDataSet1.Tables["qMaterialZN"];

                    if (e.RowIndex < dt.Rows.Count)
                    {
                        DataRow dr = dt.Rows[e.RowIndex];

                        if ( (dr.RowState != DataRowState.Unchanged) ||
                            ((e.ColumnIndex == 3) && (dgvMaterialZN.Rows[e.RowIndex].Cells["colMassa"].Value.Equals(dgvMaterialZN.Rows[e.RowIndex].Cells["colMassaRO"].Value) == false))
                           )
                        { 
                            e.CellStyle.ForeColor = Color.DarkRed;
                        }
                    }
/*                 }
                catch(Exception ex)
                {
                    MessageBox.Show("");
                }
*/
            }
        }

        private void dgvMaterialZN_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvMaterialZN.InvalidateRow(e.RowIndex);

        }
    }
}
