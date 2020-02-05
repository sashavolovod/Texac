using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texac.PlanZagruzki
{
    public class PlanZagruzkiEntity
    {
        public String oborudovanie { get; set; }
        public Double zagruzka { get; set; }

        public PlanZagruzkiEntity(String oborudovanie, Double zagruzka)
        {
            this.oborudovanie = oborudovanie;
            this.zagruzka = zagruzka;
        }
    }
}
