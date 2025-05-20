using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texac.RestClient;

namespace Texac.Domain
{
    [EntityPath("to_types")]
    class ToTypes  // КодыНаименованийТО
    {
        public long codeTo { get; set; }            // КодТО
        public string titleTo { get; set; }         // НаименованиеТО
        public long codeTypeTo { get; set; }        // КодВидаТО

        [JsonIgnore]
        public string title
        {
            get { return codeTo.ToString() + ". " + titleTo; }
        }
    }
}
