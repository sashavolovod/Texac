using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texac.Common
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        public ReportForm(string reportPath, string title, ReportParameter[] parameters, ReportDataSource rds) 
        {
            InitializeComponent();
            Text = title;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;

            reportViewer1.LocalReport.ReportEmbeddedResource = reportPath;

            if(parameters != null)
                this.reportViewer1.LocalReport.SetParameters(parameters);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

            
        }
    }
}
