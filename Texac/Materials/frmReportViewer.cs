using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TexAC2
{
    public partial class frmReportViewer : MyControls.MyForm
    {
        private DAL.MaterialReportEntity reportEntity;

        public frmReportViewer(DAL.MaterialReportEntity repEntity)
        {
            reportEntity = repEntity;
            InitializeComponent();
        }

        private void ReportViewerForm_Load(object sender, EventArgs e)
        {
            bsMaterialReportEntity.DataSource = reportEntity;
            this.reportViewer1.RefreshReport();
        }
    }
}
