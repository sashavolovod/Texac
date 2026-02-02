using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texac.Ekon.Inventory
{
    public class InventoryEntity
    {
        public string period{ get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public List<InventoryEntry> entries;
    }
}
