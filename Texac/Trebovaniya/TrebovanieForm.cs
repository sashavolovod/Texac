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
      //  private OleDbCommand cmd = null;


        public TrebovanieForm(Int32 id)
        {
            this.id = id;
            InitializeComponent();
            Text = "Требование " + id;

            cbCustomer.DataSource = ds.DepartmentsView;
            cbCustomer.ValueMember = "DeptId";
            cbCustomer.DisplayMember = "DeptFullName";

            dgvTrebovanieDetails.EditingControlShowing += DgvTrebovanieDetails_EditingControlShowing;
            dgvTrebovanieDetails.DataError += DgvTrebovanieDetails_DataError;
        }

        private void DgvTrebovanieDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введено некорректное значение", "Ошибка");
        }

        private void DgvTrebovanieDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dgv  = sender as DataGridView;
            if (sender!=null)
           {
                if(dgv.Columns[dgv.CurrentCell.ColumnIndex].HeaderText == "Получено" ||
                    dgv.Columns[dgv.CurrentCell.ColumnIndex].HeaderText == "Затребовано")
                e.Control.KeyPress += Control_KeyPress;
           }
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
                e.Handled = false;
            }
        }

        private void TrebovanieForm_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            taDepartmentsView.Fill(ds.DepartmentsView);

            if (id > 0)
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
                bsTrebovanie.AddNew();
                cbCustomer.SelectedIndex = -1;
                dtpDocDate.Value = DateTime.Now;

                int docNumber = Properties.Settings.Default.TrebovanieLastNumber;
                tbTrebovanieNumber.Text = (++docNumber).ToString();
            }

            
            Cursor.Current = Cursors.Default;
        }



        private void btnPrint_Click(object sender, EventArgs e)
        {
            Save();
            TrebovanieReportForm form = new TrebovanieReportForm(id);
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
            }
            else
            {
                tableAdapterManager.UpdateAll(this.ds);
            }
        }
        private void Adapter_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {
            if(e.StatementType==StatementType.Insert)
            {
                OleDbCommand cmdNewID = new OleDbCommand("SELECT @@IDENTITY", e.Command.Connection);
                e.Row["TrebovanieId"] = (int)cmdNewID.ExecuteScalar();
                e.Status = UpdateStatus.SkipCurrentRow;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
