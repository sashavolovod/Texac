using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texac.PlanZagruzki
{
    public class GrafikEntity
    {
        public int grafikId { get; set; }
        public string grafikName { get; set; }
        public DateTime? grafikDate { get; set; }
        public DateTime? srok { get; set; }
        public DateTime? dataVypolneniya { get; set; }

        public GrafikEntity(int grafikId, string grafikName, DateTime? grafikDate, DateTime? srok, DateTime? dataVypolneniya)
        {
            this.grafikId = grafikId;
            this.grafikName = grafikName;
            this.grafikDate = grafikDate;
            this.srok = srok;
            this.dataVypolneniya = dataVypolneniya;
        }
    }
}
