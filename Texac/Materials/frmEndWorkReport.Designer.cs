namespace TexAC2.UI
{
    partial class frmEndWorkReport
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
            this.orders208BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new TexAC2.dataDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.orders208TableAdapter = new TexAC2.dataDataSetTableAdapters.Orders208TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.orders208BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // orders208BindingSource
            // 
            this.orders208BindingSource.DataMember = "Orders208";
            this.orders208BindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.orders208BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TexAC2.Reports.EndWorkReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(695, 447);
            this.reportViewer1.TabIndex = 0;
            // 
            // orders208TableAdapter
            // 
            this.orders208TableAdapter.ClearBeforeFill = true;
            // 
            // frmEndWorkReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 447);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmEndWorkReport";
            this.Text = "Просмотр отчета";
            this.Load += new System.EventHandler(this.frmEndWorkRepor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orders208BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.Configuration.IPersistComponentSettings)(this)).LoadComponentSettings();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource orders208BindingSource;
        private dataDataSetTableAdapters.Orders208TableAdapter orders208TableAdapter;
    }
}