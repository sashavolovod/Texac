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
        public double amount { get; set; }
        public List<DopZNEntityDetails> details;

        public DopZNEntity() { }
    };

}
