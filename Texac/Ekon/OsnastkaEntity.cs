using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texac.Ekon
{
    public class OsnastkaEntity
    {
        public int id { get; set; }
        public string number { get; set; }
        public string name { get; set; }
        public string obozTO { get; set; }
        public double amount { get; set; }
        public double? normaV { get; set; }
        public double? normaT { get; set; }
        public int kodTO { get; set; }

        public OsnastkaEntity()
        {

        }
        public OsnastkaEntity(int id, string number, string name, string obozTO, double amount, double? nornaV, double? normaT, int kodTO)
        {
            this.id = id;
            this.number = number;
            this.name = name;
            this.obozTO = obozTO;
            this.amount = amount;
            this.normaV = nornaV;
            this.normaT = normaT;
            this.kodTO = kodTO;
        }
    }
}
