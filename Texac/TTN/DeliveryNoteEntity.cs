using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texac.Common;

namespace Texac.TTN
{
    public class DeliveryNoteEntity
    {
        public string DocNumber { get; set; }
        public DateTime? DocDate { get; set; }
        public BindingList<DeliveryNotePositionEntity> EntityList { get; set; }
    };


    public class DeliveryNotePositionEntity
    {
        public string TtnPositionTitle { get; set; }
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public string OrderDescription { get; set; }
        public string Customer { get; set; }
        public string UnitName { get; set; }
        public string Stoikost { get; set; }
        public int Qty { get; set; }
        public int ObjectType { get; set; }
        public int Life { get; set; }
        public int Lifeday { get; set; }

        public string QtySpelled => RusNumber.RusSpelledOut(Qty, RusNumber.Gender.Masculine);

        public string Note()
        {
            if (ObjectType == 0)
                return "";

            StringBuilder sb = new StringBuilder();

            if (ObjectType == 1)
                sb.Append(" (" + "Входит в состав оборудования");
            else if (ObjectType == 2)
                sb.Append(" (" + "Обособленный объект");

            if (Life > 0 || Lifeday > 0)
                sb.Append(", срок службы ");

            if (Life > 0)
            {
                sb.Append(Life.ToString());
                if (Life == 1)
                    sb.Append(" год");
                else if (Life == 2 || Life == 3 || Life == 4)
                    sb.Append(" года");
                else
                    sb.Append(" лет");
            }

            if (Lifeday > 0)
            {
                sb.Append(Lifeday.ToString());
                if (Lifeday == 1)
                    sb.Append(" месяц");
                else if (Lifeday == 2 || Lifeday == 3 || Lifeday == 4)
                    sb.Append(" месяца");
                else
                    sb.Append(" месяцев");
            }

            sb.Append(")");

            return sb.ToString();
        }
    }
}
