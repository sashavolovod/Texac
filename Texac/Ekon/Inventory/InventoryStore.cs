using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texac.Ekon.Inventory
{
    public class InventoryStore
    {
        public DateTime period { get; set; }
        public int cardNumber { get; set; }
        public int orderId { get; set; }
        public double debitQuantity { get; set; }
    }
}
