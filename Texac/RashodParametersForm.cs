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
    public partial class RashodParametersForm : MyForm
    {
        public RashodParametersForm()
        {
            InitializeComponent();
            DateTime now = DateTime.Today;
            now = now.AddMonths(-1);
            DateTime date = new DateTime(now.Year, now.Month, 1);
            dtpStartDate.Value = date;
            date = date.AddMonths(1);
            date = date.AddDays(-1);
            dtpEndDate.Value = date;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            RashodForm form = new RashodForm(dtpStartDate.Value, dtpEndDate.Value, tbOrderType.Text);
            form.Show();

        }
    }
}
