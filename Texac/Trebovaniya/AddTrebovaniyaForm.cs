using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Texac.Trebovaniya
{
    public partial class AddTrebovaniyaForm : MyForm
    {
        private bool oneOrder = false;
        public Int32 orderId;
        public DateTime startDate;
        public DateTime endDate;
        public string orderType;

        public AddTrebovaniyaForm()
        {
            InitializeComponent();
            taTrebovanie.Adapter.RowUpdated += Adapter_RowUpdated;
            colMatCartId.Visible = false;
        }

      
        private void btnOneOrder_Click(object sender, EventArgs e)
        {
            oneOrder = true;
            OrderNumberForm form = new OrderNumberForm(this);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                taTrebovaniyaView.FillByOrderId(ds.AddTrebovaniyaView, orderId);
                Cursor.Current = Cursors.Default;
                dgvTrebovaniya.Focus();
            }
        }

        private void btnOrderGroup_Click(object sender, EventArgs e)
        {
            oneOrder = false;
            OrderTypeForm form = new OrderTypeForm(this);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                taTrebovaniyaView.FillByDate(ds.AddTrebovaniyaView, startDate, endDate, orderType + "%");
                Cursor.Current = Cursors.Default;
                dgvTrebovaniya.Focus();
            }

        }

        private void AddTrebovaniyaForm_Load(object sender, EventArgs e)
        {
            tbTrebovanieNumber.Text = Properties.Settings.Default.TrebovanieLastNumber.ToString();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Int32 docNumber=0;
            Int32 scladNumber;
            Int32 customerNumber;

            Int32 prevScladNumber = 0;
            Int32 prevCustomerNumber = 0;
            int linePerDoc=0;
            string prevMaterialName = "";

            List<dataDataSet.AddTrebovaniyaViewRow> rows = new List<dataDataSet.AddTrebovaniyaViewRow>();
            if (dgvTrebovaniya.Rows.Count == 0)
            {
                MessageBox.Show("Нет материалов для формирования требований", "Внимание");
                return;
            }

            Cursor = Cursors.WaitCursor;
            dataDataSet1 newds = new dataDataSet1();
            dataDataSet1.TrebovanieRow r = (dataDataSet1.TrebovanieRow)newds.Trebovanie.NewRow();
            /*
                        // если выделено больше 1 строки, печатаем выделенные
                        if (dgvTrebovaniya.SelectedRows.Count > 1)
                        {
                            for (int i = 0; i < dgvTrebovaniya.SelectedRows.Count; i++)
                            {
                                dataDataSet.AddTrebovaniyaViewRow row = (dataDataSet.AddTrebovaniyaViewRow)((DataRowView)dgvTrebovaniya.SelectedRows[i].DataBoundItem).Row;
                                rows.Add(row);
                            }
                        }
                        else // иначе все строки
                        {
                            for (int i = 0; i < dgvTrebovaniya.Rows.Count; i++)
                            {
                                dataDataSet.AddTrebovaniyaViewRow row = (dataDataSet.AddTrebovaniyaViewRow)((DataRowView)dgvTrebovaniya.Rows[i].DataBoundItem).Row;
                                rows.Add(row);
                            }
                        }

                        for (int i = 0; i < rows.Count; i++)
                        {

                            dataDataSet.AddTrebovaniyaViewRow row = rows[i];
            */
            for (int i = 0; i < dgvTrebovaniya.SelectedRows.Count; i++)
            {
                dataDataSet1.AddTrebovaniyaViewRow row = (dataDataSet1.AddTrebovaniyaViewRow)((DataRowView)dgvTrebovaniya.SelectedRows[i].DataBoundItem).Row;
                dataDataSet1.TrebovanieDetailsRow d = (dataDataSet1.TrebovanieDetailsRow)newds.TrebovanieDetails.NewRow();
                if (row.IsMaterialNameNull())
                {
                    MessageBox.Show("Не заполнено название материала", "Внимание");
                    continue;
                }

                if (Int32.TryParse(row.Sclad, out scladNumber)) { } ;
                customerNumber = row.Customer;

                if (prevCustomerNumber!=customerNumber || prevScladNumber!=scladNumber || linePerDoc>7)
                {
                    linePerDoc = 0;
                    r = (dataDataSet1.TrebovanieRow)newds.Trebovanie.NewRow();

                    if (Int32.TryParse(tbTrebovanieNumber.Text, out docNumber))
                    {
                        r.DocNumber = docNumber;
                        tbTrebovanieNumber.Text = (++docNumber).ToString();
                    }
                    r.Sclad = scladNumber;
                    r.DocDate = dtpTrebovanieDate.Value;
                    r.Status = 0;
                    r.NЦеха = row.Customer;
                    if(oneOrder==true)
                    {
                        r.OrderId = row.OrderId;
                        r.OrderNumber = row.OrderNumber;
                    }

                    newds.Trebovanie.AddTrebovanieRow(r);

                    taTrebovanie.Update(newds);
                    newds.Trebovanie.AcceptChanges();

                    prevScladNumber = scladNumber;
                    prevCustomerNumber = customerNumber;
                }

                d.SetParentRow(r);
                d.OrderId = row.OrderId;
                d.MatCartId = row.MatCartId;

                if (row.IsMaterialCodeNull() == false)
                    d.MaterialCode = row.MaterialCode;

                d.Material = row.MaterialName;

                d.Ed = row.Ed;
                d.Kol1 = row.Qty;
                d.Kol2 = 0.0;



                if(row.IsASUPCODENull()==false)
                    d.ASUPCODE = row.ASUPCODE;

                if (d.Material != prevMaterialName)
                    linePerDoc++;

                prevMaterialName = d.Material;
                newds.TrebovanieDetails.AddTrebovanieDetailsRow(d);
            }           
            tam.UpdateAll(newds);
            Cursor = Cursors.Default;
            Properties.Settings.Default.TrebovanieLastNumber = docNumber;
            Properties.Settings.Default.Save();
            Close();
        }


        private void Adapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            if (e.StatementType == StatementType.Insert)
            {
                OleDbCommand cmdNewID = new OleDbCommand("SELECT @@IDENTITY", ((OleDbDataAdapter)sender).InsertCommand.Connection);

                e.Row["TrebovanieId"] = (int)cmdNewID.ExecuteScalar();
                e.Status = UpdateStatus.SkipCurrentRow;
            }
        }
    }
}
