using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Texac
{
    public partial class TrebovanieForm : MyForm
    {
        private Int32 id;
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
            taTrebovanieDetails.FillById(ds.TrebovanieDetails,id);
            taTrebovanie.FillById(ds.Trebovanie, id);
            taDepartmentsView.Fill(ds.DepartmentsView);
            dataDataSet.TrebovanieRow r = (dataDataSet.TrebovanieRow)ds.Trebovanie.Rows[0];
            cbCustomer.SelectedValue = r.NЦеха;
            Cursor.Current = Cursors.Default;
        }

        private void trebovanieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsTrebovanie.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds);

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
            tableAdapterManager.UpdateAll(this.ds);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
