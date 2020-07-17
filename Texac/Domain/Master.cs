using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Texac.RestClient;

namespace Texac.Domain
{
    public class Detail
    {
        public long detailId { get; set; }
        public string title { get; set; }
        public double amount { get; set; }
        public long masterId { get; set; }
    }


    [EntityPath("master")]
    public class Master
    {
        public long masterId { get; set; }

        public string caption{ get; set; }

        public List<Detail> details { get; set; }
    }


}
