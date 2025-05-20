using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texac
{
    public class DopZNEntityDetails
    {
        public int? pos { get; set; }
        public string materialOld { get; set; }
        public string materialNew { get; set; }
        public double? qtyOld { get; set; }
        public double? qtyNew { get; set; }
        public string unitNameOld { get; set; }
        public string unitNameNew { get; set; }
        public string cardNumOld { get; set; }
        public string cardNumNew { get; set; }
        public DopZNEntityDetails() { }
    };

    public class DopZNEntity
    {
        public int orderId { get; set; }
        public string orderName { get; set; }
        public string osnastka { get; set; }
        public string detal { get; set; }
        public string izdelie { get; set; }
        public string customer { get; set; }
        public string producer { get; set; }
        public int amount { get; set; }
        public string employee { get; set; }
        public string unitName { get; set; }
        public List<DopZNEntityDetails> details;

        public DopZNEntity() {
            details = new List<DopZNEntityDetails>();
        }


    };

}
