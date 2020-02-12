namespace Texac.DopZN
{
    partial class DopZnReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bsDopZNEntityDetails = new System.Windows.Forms.BindingSource(this.components);
            this.bsDopZNEntity = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.bsDopZNEntityDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDopZNEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsDopZNEntityDetails
            // 
            this.bsDopZNEntityDetails.DataSource = typeof(Texac.DopZNEntityDetails);
            // 
            // bsDopZNEntity
            // 
            this.bsDopZNEntity.DataSource = typeof(Texac.DopZNEntity);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DeteilDataSet";
            reportDataSource1.Value = this.bsDopZNEntityDetails;
            reportDataSource2.Name = "DopZnEntity";
            reportDataSource2.Value = this.bsDopZNEntity;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Texac.DopZN.DopZnReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(919, 565);
            this.reportViewer1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 565);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(919, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // DopZnReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 587);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "DopZnReportForm";
            this.Text = "Дополнение к заказа-наряду";
            this.Load += new System.EventHandler(this.DopZnReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsDopZNEntityDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDopZNEntity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bsDopZNEntityDetails;
        private System.Windows.Forms.BindingSource bsDopZNEntity;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}