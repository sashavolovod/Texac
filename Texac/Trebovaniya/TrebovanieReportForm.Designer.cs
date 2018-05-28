namespace Texac
{
    partial class TrebovanieReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bsTrebovanieDetails = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new Texac.dataDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.taTrebovanieDetails = new Texac.dataDataSetTableAdapters.TrebovanieDetailsTableAdapter();
            this.taTrebovanie = new Texac.dataDataSetTableAdapters.TrebovanieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrebovanieDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // bsTrebovanieDetails
            // 
            this.bsTrebovanieDetails.DataMember = "TrebovanieDetails";
            this.bsTrebovanieDetails.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "dataDataSet";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bsTrebovanieDetails;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Texac.Reports.Trebovanie.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(978, 526);
            this.reportViewer1.TabIndex = 0;
            // 
            // taTrebovanieDetails
            // 
            this.taTrebovanieDetails.ClearBeforeFill = true;
            // 
            // taTrebovanie
            // 
            this.taTrebovanie.ClearBeforeFill = true;
            // 
            // TrebovanieReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 526);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TrebovanieReportForm";
            this.Text = "Требование";
            this.Load += new System.EventHandler(this.TrebovanieReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTrebovanieDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.Configuration.IPersistComponentSettings)(this)).LoadComponentSettings();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bsTrebovanieDetails;
        private dataDataSet ds;
        private dataDataSetTableAdapters.TrebovanieDetailsTableAdapter taTrebovanieDetails;
        private dataDataSetTableAdapters.TrebovanieTableAdapter taTrebovanie;
    }
}