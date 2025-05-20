using System;
using Texac.RestClient;

namespace Texac.Domain
{
    [EntityPath("order")]
    public class Order
    {
        public long orderId { get; set; }
        public string orderNumber { get; set; }
        public string orderFullNumber { get; set; }
        public long? graphId { get; set; }
        public long? graphTypeId { get; set; }
        public long? reasonOrder { get; set; }
        public DateTime? orderDate { get; set; }
        public string obozTo { get; set; }
        public long? codeTo { get; set; }
        public string itemNo { get; set; }
        public string detailNo { get; set; }
        public int? qty { get; set; }
        public int? realQty { get; set; }
        public long? customerId { get; set; }
        public DateTime? planDate { get; set; }
        public long? priorityId { get; set; }
        public DateTime? planTechDate { get; set; }
        public DateTime? techDate { get; set; }
        public DateTime? shopDate { get; set; }
        public DateTime? factReadyDate { get; set; }
        public double? planNv     { get; set; }
        public long? performerShop { get; set; }
        public bool? includeInReport { get; set; }
        public DateTime? reportDate { get; set; }
        public long? techEmpId  { get; set; }
        public long? locksmithId { get; set; }
        public string orderNote { get; set; }
        public double? factNv   { get; set; }
        public string consignmentNote { get; set; }
        public string actNumber { get; set; }
        public string destinationStore { get; set; }
        public bool? anotherTimeReady { get; set; }
        public long? designerId { get; set; }
        public long? unitTypeId { get; set; }
        public bool? stopped { get; set; }
        public long? orderCard { get; set; }
        public int? serviceLifeYear { get; set; }
        public int? serviceLifeDay { get; set; }
        public long? objectType { get; set; }
        public bool? urgent { get; set; }
        public DateTime? materialDate { get; set; }
        public bool? spare { get; set; }
        public int? resistance { get; set; }
        public bool? additionalOrder { get; set; }
        public string classifier { get; set; }
        public DateTime? priceDate { get; set; }
        public DateTime? peoDate { get; set; }
        public DateTime? otizDate { get; set; }
        public int? weight { get; set; }
    }
}
