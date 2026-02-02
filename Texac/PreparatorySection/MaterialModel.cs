using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texac.PreparatorySection
{
    public class Supplier
    {
        public int? RequirementId { get; set; }
        public int? RequirementNumber { get; set; }
        public DateTime? RequirementDate { get; set; }

        public double RequestedQuantity { get; set; }
        public double ReceivedQuantity { get; set; }

        public int? OrderId { get; set; }

    }

    public class MaterialModel
    {
        public int Id { get; set; }
        public int MaterialRequestId { get; set; }

        public int? WarehouseId { get; set; }

        public int? MaterialId { get; set; }
        public string MaterialName { get; set; }
        public string Unit { get; set; }

    }
}
