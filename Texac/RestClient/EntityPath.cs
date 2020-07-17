using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texac.RestClient
{
    public class EntityPath : Attribute
    {
        public EntityPath(string path)
        {
            this.path = path;
        }
        public string path { get; set; }
    }
}
