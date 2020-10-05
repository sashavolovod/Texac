using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Texac.DopZN;
using Tulpep.NotificationWindow;

namespace Texac
{
    public partial class DopZnForm : Form
    {
        private DopZNEntity dopZn = new DopZNEntity();

        public DopZnForm()
        {
            InitializeComponent();
        }

        private void DopZnForm_Load(object sender, EventArgs e)
        {
            //  System.Diagnostics.Debug.Write("curren date " + dtDate.Value.ToString());
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

            bsMaterialZN.EndEdit();
            dopZn.details.Clear();

            dataDataSet1.qMaterialZNDataTable dt = (dataDataSet1.qMaterialZNDataTable)dataDataSet1.Tables["qMaterialZN"];
            int reportRowCounter = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string newMaterialName = dt.Rows[i]["Материал"].ToString();
                string oldMaterialName = "";

                string newUnitName = dt.Rows[i]["ЕдИзм"].ToString();
                string oldUnitName = "";

                double newQty = 0;
                string newQtyStr = dgvMaterialZN.Rows[i].Cells["colMassa"].Value.ToString();
                newQtyStr = newQtyStr.Replace(".", ",");
                Double.TryParse(newQtyStr, out newQty);

                double oldQty = 0;

                if (dt.Rows[i].HasVersion(DataRowVersion.Original))
                {
                    oldMaterialName = dt.Rows[i]["Материал", DataRowVersion.Original].ToString();
                    oldUnitName = dt.Rows[i]["ЕдИзм", DataRowVersion.Original].ToString();
                    Double.TryParse(dt.Rows[i]["масса", DataRowVersion.Original].ToString(), out oldQty);

                    // если изменилось название материала или единица измерения 
                    if (oldMaterialName != newMaterialName || oldUnitName != newUnitName)
                    {
                        DopZNEntityDetails d = new DopZNEntityDetails();
                        //d.pos = i + 1;
                        d.pos = reportRowCounter++;
                        d.materialOld = oldMaterialName;
                        d.qtyOld = oldQty;
                        d.unitNameOld = oldUnitName;
                        d.materialNew = oldMaterialName;
                        d.qtyNew = 0;
                        d.unitNameNew = oldUnitName;
                        dopZn.details.Add(d);

                        d = new DopZNEntityDetails();
                        //d.pos = i + 1;
                        d.pos = reportRowCounter++;
                        d.materialOld = newMaterialName;
                        d.qtyOld = 0;
                        d.unitNameOld = newUnitName;
                        d.materialNew = newMaterialName;
                        d.qtyNew = newQty;
                        d.unitNameNew = newUnitName;
                        dopZn.details.Add(d);
                    }
                    // если изменилось только количество
                    else if (newQty != oldQty)
                    {
                        DopZNEntityDetails d = new DopZNEntityDetails();
                        //d.pos = i + 1;
                        d.pos = reportRowCounter++;
                        d.materialOld = oldMaterialName;
                        d.qtyOld = oldQty;
                        d.unitNameOld = oldUnitName;
                        d.materialNew = newMaterialName;
                        d.qtyNew = newQty;
                        d.unitNameNew = newUnitName;
                        dopZn.details.Add(d);
                    }
                }
                else // если новая строка добавлена
                {
                    DopZNEntityDetails d = new DopZNEntityDetails();
                    //d.pos = i + 1;
                    d.pos = reportRowCounter++;
                    d.materialOld = newMaterialName;
                    d.qtyOld = 0;
                    d.unitNameOld = newUnitName;

                    d.materialNew = newMaterialName;
                    d.qtyNew = newQty;
                    d.unitNameNew = newUnitName;

                    dopZn.details.Add(d);
                }
            }
            if (dopZn.details.Count == 0)
            {
                MessageBox.Show("Нет изменений в заказ-наряде.","Внимание",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                new DopZnReportForm(dopZn, cbPrud.Checked).Show();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string orderNumber = tbOrderNumber.Text.Trim();
            int id;

            if (orderNumber.Length == 0)
                return;

            Int32.TryParse(orderNumber, out id);

            taMaterialZN.FillByOrderId(dataDataSet1.qMaterialZN, id);
            FillDopZNEntity(id, dopZn);

            for (int i=0;i<dgvMaterialZN.Rows.Count;i++)
            {
                dgvMaterialZN.Rows[i].Cells["colMassa"].Value = dgvMaterialZN.Rows[i].Cells["colMassaRO"].Value;
            }
        }

        private void FillDopZNEntity(int id, DopZNEntity dopZn)
        {
            string queryString = "SELECT Заказы.NППЗаказа, Заказы.NЗаказаЗавода, Заказы.Кол_во, [ОбозначениеТО] & \" \" & [НаименованиеТО] AS osnastka, [Изделия.NИзделия] & \" \" & [НаименованиеИзделия] AS izdelie, [Заказы].[NДетали] & \" \" & [НаименованиеДетали] AS detal, РаботникиЦеха.ФИО, НомераЦехов.НаименованиеЦеха AS Заказчик, НомераЦехов_1.НаименованиеЦеха AS Исполнитель, p_unit " + 
" FROM(НомераЦехов INNER JOIN(РаботникиЦеха INNER JOIN(Изделия INNER JOIN(Детали INNER JOIN(КодыНаименованийТО INNER JOIN Заказы ON КодыНаименованийТО.КодТО = Заказы.КодТО) ON Детали.NДетали = Заказы.NДетали) ON Изделия.NИзделия = Заказы.NИзделия) ON РаботникиЦеха.NТабельный = Заказы.Технолог) ON НомераЦехов.NЦеха = Заказы.Заказчик) LEFT JOIN НомераЦехов AS НомераЦехов_1 ON Заказы.ЦехИсполнитель = НомераЦехов_1.NЦеха " + 
" WHERE Заказы.NППЗаказа = ?";

            using (OleDbConnection connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.Parameters.AddWithValue("@OrderId", id);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    btnPrint.Enabled = true;
                    dopZn.orderId = id;
                    dopZn.orderName = reader.GetString(1);
                    dopZn.amount = reader.GetInt32(2);
                    dopZn.osnastka = reader.GetString(3);
                    dopZn.izdelie = reader.GetString(4);
                    dopZn.detal = reader.GetString(5); 
                    if (DBNull.Value != reader[6])
                    {
                        dopZn.employee = reader.GetString(6);
                    }
                    dopZn.customer = reader.GetString(7);
                    if (DBNull.Value != reader[8])
                    {
                        dopZn.producer = reader.GetString(8);
                    }
                    if (DBNull.Value != reader[9])
                    {
                        dopZn.unitName = reader.GetString(9);
                    }
                }
                else
                {
                    btnPrint.Enabled = false;
                }
                reader.Close();
            }
        }

        private void qMaterialZNDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.RowIndex>=0 && e.ColumnIndex>=0)
            {
                DataTable dt = dataDataSet1.Tables["qMaterialZN"];
                if (e.RowIndex < dt.Rows.Count)
                {
                    DataRow dr = dt.Rows[e.RowIndex];

                    if ((dr.RowState != DataRowState.Unchanged) ||
                        (dgvMaterialZN.Rows[e.RowIndex].Cells["colMassa"].Value.Equals(dgvMaterialZN.Rows[e.RowIndex].Cells["colMassaRO"].Value) == false)
                       )
                    {
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                        e.CellStyle.ForeColor = Color.DarkRed;
                    }
                }
            }
        }

        private void dgvMaterialZN_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvMaterialZN.InvalidateRow(e.RowIndex);
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
