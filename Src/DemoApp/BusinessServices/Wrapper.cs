using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class Wrapper
    {

        [JsonProperty]
        public object parameters { get; set; }

        public Wrapper() { parameters = new List<object>(); }

    }
}
