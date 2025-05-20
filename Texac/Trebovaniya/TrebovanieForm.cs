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
        Dictionary<int, List<OrderNumberEntity>> orderByYear;

        public TrebovanieForm(Int32 id, bool copy, Dictionary<int, List<OrderNumberEntity>> orderByYear)
        {
            this.id = id;
            this.copy = copy;
            this.orderByYear = orderByYear;

            InitializeComponent();

            LoadData();

            DataGridViewColumn colOrderId = new DataGridViewTextBoxColumn();

            colOrderId.DataPropertyName = "OrderId";
            colOrderId.HeaderText = "NППЗаказа";
            colOrderId.Name = "colOrderId";

            dgvTrebovanieDetails.Columns.Add(colOrderId);

            Text = "Требование " + id;
            cbCustomer.DataSource = ds.DepartmentsView;
            cbCustomer.ValueMember = "DeptId";
            cbCustomer.DisplayMember = "DeptFullName";

            //AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            List<String> collection = new List<String>();
            collection.Add("ТМЦ под  отчет");
            collection.Add("Автопогрузчики. Запчасти и прочие материалы");
            collection.Add("Грузовые авто. Запчасти и прочие материалы");
            collection.Add("Легковые авто. Запчасти и прочие материалы");
            collection.Add("Спецмашины. Запчасти и прочие материалы");
            collection.Add("Запчасти для гарантийного ремонта");
            collection.Add("Запчасти для замены брака");
            collection.Add("Канцелярские расходы");
            collection.Add("Моющие средства");
            collection.Add("Охрана окружающей среды");
            collection.Add("Перемещение груза внутри предприятия");
            collection.Add("Санитарно-гигиенические расходы");
            collection.Add("Содержание складов готовой продукции");
            collection.Add("Уборка территории, помещений");
            collection.Add("Упаковка продукции");
            collection.Add("Содержание зданий, сооружений");
            collection.Add("Капитальный ремонт зданий, сооружений");
            collection.Add("Текущий ремонт зданий, сооружений");
            collection.Add("Содержание оборудования");
            collection.Add("Текущий ремонт оборудования");
            collection.Add("Капитальный ремонт оборудования");
            collection.Add("Содержание инвентаря и прочие");
            collection.Add("Текущий ремонт инвентаря и прочие");
            collection.Add("Содержание вычислительной техники");
            collection.Add("Охрана труда");
            collection.Add("Материалы на испытание");
            collection.Add("Озеленение и благоустройство");
            collection.Add("Сырьё и материалы заказ №");
            collection.Add("Основные средства");
            collection.Add("Материалы, принятые в переработку");
            collection.Add("Заказ-наряд №");
            collection.Add("Грузовые авто. Запчасти и прочие материалы");

            cbOsnovanie.DataSource = collection;
            //cbOsnovanie.AutoCompleteCustomSource = collection;
            //cbOsnovanie.AutoCompleteMode = AutoCompleteMode.Append;
            //            cbOsnovanie.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbOsnovanie.DataSource = collection;


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

        private void LoadData()
        {
            Cursor.Current = Cursors.WaitCursor;
            taDepartmentsView.Fill(ds.DepartmentsView);

            if (id > 0 && copy==false)
            {
                taTrebovanie.FillById(ds.Trebovanie, id);
                taTrebovanieDetails.FillById(ds.TrebovanieDetails, id);
                dataDataSet1.TrebovanieRow r = (dataDataSet1.TrebovanieRow)ds.Trebovanie.Rows[0];
                if (r.IsNЦехаNull() == false)
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

                                if (rd.IsOrderIdNull() == false)
                                    newDetRow.OrderId = rd.OrderId;

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
                    cbCustomer.SelectedValue = 70; // ИнЦ по умолчанию для новых
                    dataDataSet1.TrebovanieRow nr = (dataDataSet1.TrebovanieRow)((DataRowView)bsTrebovanie.Current).Row;
                    nr.DocDate = DateTime.Now;


                }  //  end if (copy == true) 

                int docNumber = Properties.Settings.Default.TrebovanieLastNumber;
                dataDataSet1.TrebovanieRow addedRow = (dataDataSet1.TrebovanieRow)((DataRowView)bsTrebovanie.Current).Row;
                addedRow.DocDate = DateTime.Now; 
                addedRow.DocNumber = ++docNumber;
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                TrebovanieReportForm form = new TrebovanieReportForm(id, tbCustomer.Text, tbRecipient.Text);
                form.Show();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if(Save())
            {
                DialogResult = DialogResult.OK;
                Close();

            }
                
        }

        private bool Save()
        {
            int sclad;
            Validate();
            bsTrebovanie.EndEdit();
            bsTrebovanieDetails.EndEdit();
            Int32 docNumber;

            if (Int32.TryParse(tbTrebovanieNumber.Text, out docNumber) == false)
            {
                MessageBox.Show("Поле '№' не заполнено или содержит некоректное значение", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Int32.TryParse(scladTextBox.Text.Trim(), out sclad) == false)
            {
                MessageBox.Show("Поле 'Номер склада' обязательно для заполнения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(dtpDocDate.Value == null)
            {
                MessageBox.Show("Дата требования не заполнена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbOsnovanie.Text.Length == 0)
            {
                if (MessageBox.Show("Поле 'Основание отпуска' не заполнено. Продожить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.No)
                    return false;
            }

            dataDataSet1.TrebovanieRow r = (dataDataSet1.TrebovanieRow)((DataRowView)bsTrebovanie.Current).Row;
            int year = r.DocDate.Year;

            if (orderByYear.ContainsKey(year) == false)
                orderByYear[year] = new List<OrderNumberEntity>();


           
            // количество номеров в этом году
            List<OrderNumberEntity> list = orderByYear[year].FindAll(i => i.num == r.DocNumber);

            // если требование с таким номером уже есть
            if (list.Count > 1 || (list.Count==1 && list[0].id!=r.TrebovanieId))
            {
                if (MessageBox.Show("Требование с таким номером уже существует. Продолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return false;
            }

            if (isNewDoc)
            {
                taTrebovanie.Update(ds.Trebovanie);
                dataDataSet1.TrebovanieRow row = (dataDataSet1.TrebovanieRow)ds.Trebovanie.Rows[0];
                taTrebovanieDetails.Update(ds.TrebovanieDetails);
                Properties.Settings.Default.TrebovanieLastNumber = row.DocNumber;
                Properties.Settings.Default.Save();
                orderByYear[year].Add(new OrderNumberEntity(r.TrebovanieId, r.DocNumber));
                isNewDoc = false;
            }
            else
            {
                tableAdapterManager.UpdateAll(this.ds);
                
            }
            ds.AcceptChanges();

            return true;
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
                    object row = ds.TrebovanieDetails.Rows[i];

                    dataDataSet1.TrebovanieDetailsRow r = (dataDataSet1.TrebovanieDetailsRow) row;
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
