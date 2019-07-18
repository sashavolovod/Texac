using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TexAC2
{
    public partial class frmMain : MyControls.MyForm 
    {
        public frmMain()
        {
            InitializeComponent();
            dgvReportList.LoadComponentSettings();
            try
            {
                bsReportList.DataSource = DAL.MaterialReportEntity.GetReportsList();

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка работы с базой данных");
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа TexAC2\nРазработчик: Воловод Александр (т. 66-16)\nTexAC2 © 2013 СП ОАО \"Брестгазоаппарт\"", "О программе");
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor cursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            if (bsReportList.Position == -1) return;
            DataRowView current = bsReportList.Current as DataRowView;
            if (current != null)
            {
                int i = (int)current[0];
                try
                {
                    DAL.MaterialReportEntity reportEntity = DAL.MaterialReportEntity.GetEntity(i);
                    UI.frmMaterialReport materialForm = new UI.frmMaterialReport(reportEntity);
                    materialForm.Show();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка работы с базой данных");
                }
            }
            this.Cursor = cursor;
        }

        private void поВыполненнымРаботамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.frmEndWorkReportParametrs form = new UI.frmEndWorkReportParametrs();
            form.Show();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor cursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            if (bsReportList.Position == -1) return;
            DataRowView current = bsReportList.Current as DataRowView;
            if (current != null)
            {
                int ReportID = (int)current[0];
                DateTime StartDate = Convert.ToDateTime(current[1]);
                DateTime EndDate = Convert.ToDateTime(current[2]);
                try
                {
                    int r = DAL.MaterialReportEntity.AddMaterials(ReportID, StartDate, EndDate);
                    if (r > 0)
                        MessageBox.Show("Добавлено " + r.ToString() + " записей");

                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка работы с базой данных");
                }
            }
            this.Cursor = cursor;
        }
    }
}
