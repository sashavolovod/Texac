using System;
using System.Collections.Generic;


namespace Texac.Trebovaniya
{
    public class MaterialDTO
    {
        public int materialId { get; set; }
        public string materialTitle { get; set; }
        public double quantity { get; set; }
        public double quantityAvalible { get; set; }
        public List<OrderDTO> orders { get; set; }
    }

    public class OrderDTO
    {
        public int orderId { get; set; }
        public int docNumber { get; set; }
        public double quantity { get; set; }
    }

}