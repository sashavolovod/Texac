using System;

namespace Texac.Request
{
    public class RequestEntity
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public string Customer { get; set; }
        public int EmployeeId { get; set; }
        public int MasterId { get; set; }
        public int Qty { get; set; }
        public DateTime RequestDate { get; set; }
        public string ScopeOfWork { get; set; }
    }
}
