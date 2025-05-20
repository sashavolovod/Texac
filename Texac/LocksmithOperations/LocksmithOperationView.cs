using Newtonsoft.Json;
using System;

namespace Texac.LocksmithOperations
{
    public class LocksmithOperationView
    {
        [JsonProperty("orderId")]
        public long? OrderId { get; set; }

        [JsonProperty("orderDate")]
        public DateTime? OrderDate { get; set; }

        [JsonProperty("obozTo")]
        public string ObozTo { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("locksmithName")]
        public string LocksmithName { get; set; }

        [JsonProperty("customerTitle")]
        public string CustomerTitle { get; set; }

        [JsonProperty("timeNorm")]
        public double? TimeNorm { get; set; }
    }
}
