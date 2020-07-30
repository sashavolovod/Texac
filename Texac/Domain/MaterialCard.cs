using System;
using Texac.RestClient;

namespace Texac.Domain
{
    [EntityPath("mat_card")]
    public class MaterialCard
    {
        public long matCardId { get; set; }
        public long orderId { get; set; }
        public int detailNumber { get; set; }
        public String detailTONumber { get; set; }
        public String detailTOTitle { get; set; }
        public String materialTitle { get; set; }// название материала
        public String blackSmithOp { get; set; } // кузнечная операция
        public String detailSize { get; set; }
        public double blankQty { get; set; }
        public double detailQty { get; set; }
        public String millingOp { get; set; }     // фрезерная обработка
        public String planerOp { get; set; }      // строгальная обработка
        public String grindingOp { get; set; }    // шлифовальная обработка
        public double? millingTime { get; set; }   // время фрезерной обработки
        public double? planerTime { get; set; }    // время строгальной обработки
        public double? grindingTime { get; set; }  // время шлифовальной обработки
        public double? weight { get; set; }         // масса одной заготовки
        public double? weightTotal { get; set; }         // общая масса
        public bool? supplementToOrder { get; set; }    // дополнение для заказ-наряда
        public DateTime? technologyEditTime { get; set; }    // дата изменения технологии
        public int? storeId { get; set; }            // склад
        public long? unitOfMeasureId { get; set; }  // код единицы измерения
        public int? materialCode { get; set; }
        public bool? annealing { get; set; }
        public String thermalOp { get; set; }
        public String planerThermalOp { get; set; }
        public double? detailWeight { get; set; }
        public bool? ordered { get; set; }
    }
}
