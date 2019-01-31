using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Texac.Trebovaniya
{
    public partial class TrebovanieList : UserControl
    {
        OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.connStr);

        public TrebovanieList()
        {
            InitializeComponent();
            dgvTrebovania.AutoGenerateColumns = false;
        }

        private void TrebovanieList_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.connStr);
            conn.Open();
            taTrebovania.Connection = conn;
            taTrebovania.Fill(this.dataDataSet.TrebovaniaView);
            conn.Close();
        }

        private void TrebovanieForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((Form)sender).DialogResult == DialogResult.OK)
            {
                UpdateTable();
            }
        }

        public void UpdateTable()
        {
            taTrebovania.Fill(dataDataSet.TrebovaniaView);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTrebovaniyaForm form = new AddTrebovaniyaForm();
            form.ShowDialog();
            taTrebovania.Fill(dataDataSet.TrebovaniaView);
        }

        private void actDelTrebovanie_Click(object sender, EventArgs e)
        {
            if (bsTrebovania.Position >= 0)
            {
                dataDataSet.TrebovaniaViewRow row = (dataDataSet.TrebovaniaViewRow)((DataRowView)bsTrebovania.Current).Row;
                if (MessageBox.Show("Вы действительно хоите удалить требование " + row.DocNumber.ToString() + "?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    OleDbCommand cmd = new OleDbCommand("DELETE FROM tblTrebovanie WHERE TrebovanieId = ?", conn);
                    cmd.Parameters.AddWithValue("TrebovanieId", row.TrebovanieId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    UpdateTable();
                }
            }
        }

        private void dgvTrebovania_MouseDown(object sender, MouseEventArgs e)
        {
            var hti = dgvTrebovania.HitTest(e.X, e.Y);
            if (hti.RowIndex >= 0 && hti.ColumnIndex >= 0)
            {
                dgvTrebovania.ClearSelection();
                dgvTrebovania.CurrentCell = dgvTrebovania[hti.ColumnIndex, hti.RowIndex];
            }
        }

        private void openDocument()
        {
            if (bsTrebovania.Position >= 0)
            {
                dataDataSet.TrebovaniaViewRow row = (dataDataSet.TrebovaniaViewRow)((DataRowView)bsTrebovania.Current).Row;
                TrebovanieForm form = new TrebovanieForm(row.TrebovanieId);
                form.FormClosing += TrebovanieForm_FormClosing;
                form.Show();
            }
        }

        private void dgvTrebovania_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            openDocument();
        }

        private void miOpenTrebovanie_Click(object sender, EventArgs e)
        {
            openDocument();
        }
    }
}
