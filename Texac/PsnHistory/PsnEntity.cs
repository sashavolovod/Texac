using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texac.PsnHistory
{
    public class PsnEntity
    {
        //public long psnEntityId { get; set; }
        public DateTime? docDate { get; set; }
        public string docNumber { get; set; }
        public DateTime? created { get; set; }
        public int orderId { get; set; }
        public string orderNumber { get; set; }
        public string orderDescription { get; set; }
        public string customer { get; set; }
        public int qty { get; set; }
        public string unitName { get; set; }
        public string computerName { get; set; }
        public PsnEntity() { }
    }
}
