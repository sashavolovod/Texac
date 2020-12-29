using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texac.Analize
{
    public class EqupmentByTOEntity
    {
        public string Operation { get; set; }
        public double hours { get; set; }

        public EqupmentByTOEntity(string Operation, double hours)
        {
            this.Operation = Operation;
            this.hours = hours;
        }
    }
}
