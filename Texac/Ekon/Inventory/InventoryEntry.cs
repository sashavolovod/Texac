using System;

namespace Texac.Ekon.Inventory
{
    public class InventoryEntry
    {
        public int orderId { get; set; }
        public string orderNumber { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string unit { get; set; }
        public double startQuantity { get; set; }
        public double startCost { get; set; }
        public double debitQuantity { get; set; }
        public double debitCost { get; set; }
        public double creditQuantity { get; set; }
        public double creditCost { get; set; }
        public double endQuantity { get; set; }
        public double endCost { get; set; }
        public double normQuantity { get; set; }
        public int remainingQty { get; set; }
        public double completed { get; set; }
        public DateTime? factReadyDate { get; set; }
        public string employee { get; set; }
        public string obozTO { get; set; }
    }
}
