using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpdatedPokédex.Models
{
    public class Pokémon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DexEntry { get; set; }
        public Sprites Sprites { get; set; }
        public NameUrl Species { get; set; }
    }
}
