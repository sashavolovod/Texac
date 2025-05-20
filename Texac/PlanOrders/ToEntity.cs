using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texac.PlanOrders
{
    public class ToEntity
    {
        public string codeTO { get; set; }
        public int typeTO { get; set; }
        public string itemNo { get; set; }
        public string detailNo { get; set; }

        public ToEntity(string codeTO, int typeTO, string itemNo, string detailNo)
        {
            this.codeTO = codeTO;
            this.typeTO = typeTO;
            this.itemNo = itemNo;
            this.detailNo = detailNo;
        }
    }
}
