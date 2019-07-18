using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Texac.Materials
{
    public partial class frmEndWorkReportParametrs : MyForm
    {
        public frmEndWorkReportParametrs()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Cursor cursor = Cursor;
            Cursor = Cursors.WaitCursor;
            frmEndWorkReport frmReport = new frmEndWorkReport();

            if (rbOrder208.Checked == true)
            {
                frmReport.setParametrs("208", chbDescription.Checked);
            }
            else
            {
                frmReport.setParametrs("23", chbDescription.Checked);
            }
            frmReport.Show();
            Cursor = cursor;
        }
    }
}
