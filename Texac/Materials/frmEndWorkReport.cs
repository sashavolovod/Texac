using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace TexAC2.UI
{
    public partial class frmEndWorkReport : MyControls.MyForm
    {
        private String _OrderType;
        private DateTime startDate;
        private DateTime endDate;
        private Boolean _NeedDescription;

        public frmEndWorkReport()
        {
            InitializeComponent();
        }

        private void frmEndWorkRepor_Load(object sender, EventArgs e)
        {
            startDate = Convert.ToDateTime("2019-01-01");
            endDate = Convert.ToDateTime("2019-01-31 23:59:59");

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("OrderNumberType", _OrderType.ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("NeedDescription", _NeedDescription.ToString()) 
                }
            );
            this.orders208TableAdapter.Fill208(this.dataDataSet.Orders208, startDate, endDate, _OrderType.ToString()+"%");
            this.reportViewer1.RefreshReport();
        }

        public void setParametrs(String OrderType, Boolean NeedDescription)
        {
            _OrderType=OrderType;
            _NeedDescription = NeedDescription;
        }

    }
}
