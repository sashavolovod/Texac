using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Texac
{
    
    public partial class TrebovanieForm : MyForm
    {
        private Int32 id;
        private bool isNewDoc = false;
        private bool copy = false;

        public TrebovanieForm(Int32 id, bool copy)
        {
            this.id = id;
            this.copy = copy;

            InitializeComponent();

            DataGridViewColumn colOrderId = new DataGridViewTextBoxColumn();

            colOrderId.DataPropertyName = "OrderId";
            colOrderId.HeaderText = "NППЗаказа";
            colOrderId.Name = "colOrderId";

            dgvTrebovanieDetails.Columns.Add(colOrderId);

            Text = "Требование " + id;

            cbCustomer.DataSource = ds.DepartmentsView;
            cbCustomer.ValueMember = "DeptId";
            cbCustomer.DisplayMember = "DeptFullName";
            dgvTrebovanieDetails.DataError += DgvTrebovanieDetails_DataError;
        }

        private void DgvTrebovanieDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введено некорректное значение", "Ошибка");
        }


        private void dgvTrebovanieDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += Control_KeyPress;
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((dgvTrebovanieDetails.Columns[dgvTrebovanieDetails.CurrentCell.ColumnIndex].HeaderText == "Получено" ||
                   dgvTrebovanieDetails.Columns[dgvTrebovanieDetails.CurrentCell.ColumnIndex].HeaderText == "Затребовано"
                 )
                 && e.KeyChar == '.'
               )
            {
                e.KeyChar = ',';
                e.Handled = false;
            }
        }

        private void TrebovanieForm_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            taDepartmentsView.Fill(ds.DepartmentsView);

            if (id > 0 && copy==false)
            {
                taTrebovanie.FillById(ds.Trebovanie, id);
                taTrebovanieDetails.FillById(ds.TrebovanieDetails, id);
                dataDataSet.TrebovanieRow r = (dataDataSet.TrebovanieRow)ds.Trebovanie.Rows[0];
                cbCustomer.SelectedValue = r.NЦеха;
            }
            else
            {
                taTrebovanie.Adapter.RowUpdated += Adapter_RowUpdated;
                isNewDoc = true;

                if (copy == true)
                {
                    Texac.dataDataSet1 tmpDs = new dataDataSet1();
                    taTrebovanie.FillById(tmpDs.Trebovanie, id);
                    taTrebovanieDetails.FillById(tmpDs.TrebovanieDetails, id);

                    if(tmpDs.Trebovanie.Rows.Count>0)
                    {
                        dataDataSet1.TrebovanieRow r = (dataDataSet1.TrebovanieRow)tmpDs.Trebovanie.Rows[0];
                        dataDataSet1.TrebovanieRow newRow = (dataDataSet1.TrebovanieRow)ds.Trebovanie.NewRow();

                        if(r.IsScladNull())
                        {
                            newRow.SetScladNull();
                        }
                        else
                        {
                            newRow.Sclad = r.Sclad;
                        }

                        if(r.IsNЦехаNull())
                        {
                            newRow.SetNЦехаNull();
                        }
                        else
                        {
                            newRow.NЦеха = r.NЦеха;
                        }
                        
                        ds.Trebovanie.AddTrebovanieRow(newRow);

                        for (int i=0; i < tmpDs.TrebovanieDetails.Rows.Count; i++)
                        {
                            dataDataSet1.TrebovanieDetailsRow newDetRow = (dataDataSet1.TrebovanieDetailsRow)ds.TrebovanieDetails.NewRow();
                            dataDataSet1.TrebovanieDetailsRow rd = (dataDataSet1.TrebovanieDetailsRow)tmpDs.TrebovanieDetails.Rows[i];
                            newDetRow.tblTrebovanielId = newRow.TrebovanieId;
                            try
                            {
                                if(rd.IsASUPCODENull()==false)
                                    newDetRow.ASUPCODE = rd.ASUPCODE;

                                if(rd.IsEdNull()==false)
                                    newDetRow.Ed = rd.Ed;

                                if(rd.IsKol1Null()==false)
                                    newDetRow.Kol1 = rd.Kol1;

                                if(rd.IsKol2Null()==false)
                                    newDetRow.Kol2 = rd.Kol2;

                                if(rd.IsMatCartIdNull()==false)
                                    newDetRow.MatCartId = rd.MatCartId;

                                if(rd.IsMaterialNull() ==false)
                                    newDetRow.Material = rd.Material;

                                if(rd.IsMaterialCodeNull()==false)
                                    newDetRow.MaterialCode = rd.MaterialCode;

                                ds.TrebovanieDetails.AddTrebovanieDetailsRow(newDetRow);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                    
                }
                else
                {
                    bsTrebovanie.AddNew();
                    cbCustomer.SelectedIndex = -1;
                }
                
                dtpDocDate.Value = DateTime.Now;
                int docNumber = Properties.Settings.Default.TrebovanieLastNumber;
                tbTrebovanieNumber.Text = (++docNumber).ToString();
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Save();
            TrebovanieReportForm form = new TrebovanieReportForm(id, tbZatreboval.Text, tbPoluchil.Text);
            form.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void Save()
        {
            Validate();
            bsTrebovanie.EndEdit();
            bsTrebovanieDetails.EndEdit();

            if (isNewDoc)
            {
                taTrebovanie.Update(ds.Trebovanie);
                dataDataSet.TrebovanieRow r = (dataDataSet.TrebovanieRow)ds.Trebovanie.Rows[0];
                taTrebovanieDetails.Update(ds.TrebovanieDetails);
                Properties.Settings.Default.TrebovanieLastNumber = r.DocNumber;
                Properties.Settings.Default.Save();
            }
            else
            {
                tableAdapterManager.UpdateAll(this.ds);
            }
            ds.AcceptChanges();
        }
        private void Adapter_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {
            if(e.StatementType==StatementType.Insert)
            {
                OleDbCommand cmdNewID = new OleDbCommand("SELECT @@IDENTITY", e.Command.Connection);
                id = (int)cmdNewID.ExecuteScalar();
                e.Row["TrebovanieId"] = id;
                e.Status = UpdateStatus.SkipCurrentRow;

                for (int i = 0; i < ds.TrebovanieDetails.Rows.Count; i++)
                {
                    dataDataSet.TrebovanieDetailsRow r = (dataDataSet.TrebovanieDetailsRow)ds.TrebovanieDetails.Rows[i];
                    if (r.tblTrebovanieDetailId < 0)
                    {
                        r.tblTrebovanielId = id;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            for(int i=0;  i<dgvTrebovanieDetails.RowCount; i++)
            {
                double kol1 = 0.0, kol2 = 0.0;
                Double.TryParse(dgvTrebovanieDetails.Rows[i].Cells["colKol1"].Value.ToString(), out kol1);
                Double.TryParse(dgvTrebovanieDetails.Rows[i].Cells["colKol2"].Value.ToString(), out kol2);

                if (kol1>0.0 && kol2==0.0)
                    dgvTrebovanieDetails.Rows[i].Cells["colKol2"].Value = kol1;
            }
        }
    }
}
