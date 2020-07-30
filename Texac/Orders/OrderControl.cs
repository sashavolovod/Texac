using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texac.Domain;

namespace Texac.Orders
{
    public partial class OrderControl : UserControl
    {
        public OrderControl(Order order)
        {
            InitializeComponent();

            bsOrder.DataSource = order;


            
            if (order.reportDate == null)
            {
                dtReportDate.Value = DateTime.MinValue;
            }
        }

    }
}
