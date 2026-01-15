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

namespace Texac.Request
{
    public partial class RequestReportForm : Form
    {
        public RequestReportForm(ReportParameter[] parameters)
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void RequestReportForm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
