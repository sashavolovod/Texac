using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Texac
{
    public partial class RashodForm : MyForm
    {
        private DateTime startDate;
        private DateTime endDate;
        private String orderType;

        public RashodForm(DateTime startDate, DateTime endDate, String orderType)
        {

            this.startDate = startDate;
            this.endDate = endDate;
            this.orderType = orderType;
            InitializeComponent();
        }

        private void RashodForm_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            this.RashodMaterialovViewTableAdapter.FillByDate(this.dataDataSet.RashodMaterialovView,
                startDate,
                endDate,
                orderType + "%"
            );

            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("parStartDate", startDate.ToShortDateString());
            parameters[1] = new ReportParameter("parEndDate", endDate.ToShortDateString());
            parameters[2] = new ReportParameter("parOrderType", orderType);
            this.reportViewer1.LocalReport.SetParameters(parameters);

            Cursor.Current = Cursors.Default;

            this.reportViewer1.RefreshReport();
        }
    }
}
