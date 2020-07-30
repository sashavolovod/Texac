using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texac.Domain;

namespace Texac.Orders
{
    public partial class OrderForm : Form
    {
        private Order order;

        public OrderForm(Order order)
        {
            this.order = order;
            InitializeComponent();

            OrderControl c = new OrderControl(order);
            c.Dock = DockStyle.Fill;
            Controls.Add(c);

            if (order.orderId == 0)
            {
                Text = "Новый заказ";
            }
            else
            {
                Text = "Заказ " + order.orderId;
            }

        }
    }
}
