using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texac.Common
{
    public class OrderEntity
    {
        public long orderId { get; set; }                   // NППЗаказа
        public string orderNumber { get; set; }             // NЗаказаЗавода
        public string orderFullNumber { get; set; }         // NЗаказа
        public long graphId { get; set; }                   // ГрафикN
        public long graphTypeId { get; set; }               // ВидГрафика
        public long orderBasedId { get; set; }              // ОснованиеЗаказа
        public DateTime orderDate { get; set; }             // ДатаПолученияЗаказа
        public string obozTo { get; set; }                  // ОбозначениеТО
        public long codeTo { get; set; }                    // КодТО
        public string itemNo { get; set; }                  // NИзделия 
        public string detailNo { get; set; }                // NДетали
        public int amount { get; set; }                     // Кол_во
        public int? amountFact { get; set; }                // ФКол_во
        public long customerId { get; set; }                // Заказчик
        public DateTime? planTechDate { get; set; }         // ПланТП
        public long? techEmpId { get; set; }                // Технолог

    }
}
