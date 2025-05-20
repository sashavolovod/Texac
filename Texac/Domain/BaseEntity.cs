using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texac.Domain
{
    public class BaseEntity
    {
        public DateTime? created { get; set; }
        public DateTime? modified { get; set; }
        public long ownerId { get; set; }

    }
}
