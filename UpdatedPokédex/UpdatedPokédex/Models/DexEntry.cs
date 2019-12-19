using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpdatedPokédex.Models
{
    public class DexEntry
    {
        public string Flavor_text { get; set; }
        public NameUrl Language { get; set; }
        public NameUrl Version { get; set; }
    }
}
