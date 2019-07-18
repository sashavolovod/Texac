using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace TexAC2.UI
{
    public partial class frmMaterialReport : MyControls.MyForm
    {
        private DAL.MaterialReportEntity reportEntity;

        public frmMaterialReport(DAL.MaterialReportEntity re)
        {
            reportEntity =  re;
            InitializeComponent();
            dgvDetail.LoadComponentSettings();
            bsMaterial.DataSource = reportEntity;
            bsMaterialDetails.DataSource = reportEntity.DetailsList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ReportViewer reportViewer = new ReportViewer();
            //reportViewer.Text = "Материальный отчет";
            //reportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            //try
            //{
            //    reportViewer.LocalReport.ReportEmbeddedResource = "TexAC2.Reports.MaterialReport.rdlc";
            //    reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MaterialReportDataSet", bsMaterial));
            //    reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MaterialReportDetailsDataSet", bsMaterialDetails));
            //    reportViewer.LocalReport.Refresh();
            //    reportViewer.Show();
            //}
            //catch (Exception exp)
            //{
            //    MessageBox.Show(exp.Message, "Сервер отчетов");
            //}



            frmReportViewer materialReportForm = new frmReportViewer(reportEntity);

            materialReportForm.Show();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + " - начало сохренения записей");
            reportEntity.SaveEntity();
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + " - конец сохренения записей");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaterialReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (reportEntity.State == DAL.PropertyState.Modified)
                if (MessageBox.Show("Сохранить изменения", "Запись изменена", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    reportEntity.SaveEntity();
        }

        private void bsMaterialDetails_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new DAL.MaterialReportDetailsEntity(reportEntity);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvDetail_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
           
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bsMaterialDetails.Position == -1) return;
            DAL.MaterialReportDetailsEntity detail = bsMaterialDetails.Current as DAL.MaterialReportDetailsEntity;
            if (detail != null)
            {
                detail.Deleted = true;
                detail.DeleteEntity();
            }
            
            bsMaterialDetails.RemoveCurrent();
        }

    }
}
