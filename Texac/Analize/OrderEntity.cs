using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texac.Analize
{
    public class OrderEntity
    {
        public int orderId { get; set; }
        public string orderNumber { get; set; }
        public DateTime orderDate { get; set; }

        public OrderEntity(int orderId, string orderNumber, DateTime orderDate)
        {
            this.orderId = orderId;
            this.orderNumber = orderNumber;
            this.orderDate = orderDate;
        }
    }
}
