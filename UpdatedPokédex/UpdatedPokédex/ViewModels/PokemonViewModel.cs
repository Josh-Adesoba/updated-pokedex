using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpdatedPokédex.Models;

namespace UpdatedPokédex.ViewModels
{
    public class PokemonViewModel
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string FrontImage { get; set; }
        public string ShinyImage { get; set; }
        public List<DexEntry> DexEntry { get; set; }
    }
}
