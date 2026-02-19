using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texac.PreparatorySection
{
    public class MaterialOrderGridRow
    {
        // Фиксированные колонки
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
        public string UnitName { get; set; }
        public int WarehouseId { get; set; }
        public double TotalRequested { get; set; }
        public double TotalReceived { get; set; }

        // Данные по заказам (ключ — OrderId)
        public Dictionary<int, OrderMaterialInfo> Orders { get; set; }

        public MaterialOrderGridRow()
        {
            Orders = new Dictionary<int, OrderMaterialInfo>();
        }
    }

    public class OrderMaterialInfo
    {
        public int? OrderId { get; set; }
        public int OrderNumber { get; set; }

        public int RequirementId { get; set; }
        public int RequirementNumber { get; set; }
        public DateTime RequirementDate { get; set; }

        public double RequestedQuantity { get; set; }
        public double ReceivedQuantity { get; set; }
    }

}
