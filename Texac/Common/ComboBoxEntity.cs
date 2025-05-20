using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texac.Common
{
    public class ComboBoxEntity : IComparable
    {
        public int id { get; set; }
        public string title { get; set; }

        public ComboBoxEntity(int id, string title)
        {
            this.id = id;
            this.title = title;
        }

        public int CompareTo(object obj)
        {
            if (obj is ComboBoxEntity)
                return title.CompareTo(((ComboBoxEntity)obj).title);
            else
                throw new ArgumentException("Некорректное значение параметра");
        }
    }
}
