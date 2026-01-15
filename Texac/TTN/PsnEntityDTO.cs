using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texac.TTN
{
    public class PsnEntityDTO
    {
        public long psnEntityId;
        public string docNumber;
        public DateTime? docDate;
        public int orderId;
        public string orderNumber;
        public string orderDescription;
        public string customer;
        public int qty;
        public string unitName;
        public string computerName;
        public PsnEntityDTO() { }
    }
}
