using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Texac.DopZN
{
    public partial class DopZnReportForm : Form
    {
        private DopZNEntity entity;
        private bool trud;
        public DopZnReportForm(DopZNEntity entity, bool trud)
        {
            this.entity = entity;
            this.trud = trud;
            InitializeComponent();
        }

        private void DopZnReportForm_Load(object sender, EventArgs e)
        {
            bsDopZNEntity.DataSource = entity;
            bsDopZNEntityDetails.DataSource = entity.details;

            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("Trud", trud.ToString());
            reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.RefreshReport();
        }
    }
}
