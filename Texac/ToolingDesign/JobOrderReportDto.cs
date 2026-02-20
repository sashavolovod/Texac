using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texac.ToolingDesign
{
    public class JobOrderReportDto
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalQuantity { get; set; }
        public int MaterialId { get; set; }
        public string MaterialTitle { get; set; }
        public string Unit { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
    }

    public class JobOrderReportMaster
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalQuantity { get; set; }
        public List<JobOrderReportDetail> Materials { get; set; } = new List<JobOrderReportDetail>();
    }

    public class JobOrderReportDetail
    {
        public int OrderId { get; set; }
        public int MaterialId { get; set; }
        public string MaterialTitle { get; set; }
        public string Unit { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
    }

}
