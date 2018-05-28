namespace Texac
{
    partial class RashodForm
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
            this.RashodMaterialovViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new Texac.dataDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RashodMaterialovViewTableAdapter = new Texac.dataDataSetTableAdapters.RashodMaterialovViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RashodMaterialovViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // RashodMaterialovViewBindingSource
            // 
            this.RashodMaterialovViewBindingSource.DataMember = "RashodMaterialovView";
            this.RashodMaterialovViewBindingSource.DataSource = this.dataDataSet;
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
            reportDataSource1.Value = this.RashodMaterialovViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Texac.Reports.RashodMaterialov.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1029, 519);
            this.reportViewer1.TabIndex = 0;
            // 
            // RashodMaterialovViewTableAdapter
            // 
            this.RashodMaterialovViewTableAdapter.ClearBeforeFill = true;
            // 
            // RashodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 519);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RashodForm";
            this.Text = "Расход материалов по заказам";
            this.Load += new System.EventHandler(this.RashodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RashodMaterialovViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RashodMaterialovViewBindingSource;
        private dataDataSet dataDataSet;
        private dataDataSetTableAdapters.RashodMaterialovViewTableAdapter RashodMaterialovViewTableAdapter;
    }
}