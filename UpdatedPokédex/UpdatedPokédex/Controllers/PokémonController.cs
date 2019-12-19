using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UpdatedPokédex.Models;
using UpdatedPokédex.ViewModels;
using System.Linq;

namespace UpdatedPokédex.Controllers
{
    public class PokémonController : Controller
    {
        [HttpGet]
        [Route("pokemon/{name}")]
        public async Task<IActionResult> Index(string name = "")
        {
            var pokemon = await TestMethod<Pokémon>($"https://pokeapi.co/api/v2/pokemon/{name}");
            var species = await TestMethod<Species>(pokemon.Species.Url);
            var englishEntry = species.Flavor_text_entries.Where(_ => _.Language.Name.Equals("en")).ToList();

            var viewModel = new PokemonViewModel
            {
                Number = pokemon.Id,
                Name = pokemon.Name,
                FrontImage = pokemon.Sprites.Front_Default,
                ShinyImage = pokemon.Sprites.Front_Shiny,
                DexEntry = englishEntry
            };
            return View(viewModel);
        }

        public async Task<T> TestMethod<T>(string url)
        {
            var client = new HttpClient();

            var response = await client.GetAsync(url);

            var content = await response.Content.ReadAsStringAsync();

            var pokemon = JsonConvert.DeserializeObject<T>(content);

            return pokemon;
        }
    }
}

// TODO: Get sprites
// Add sprites and pokemon info into a view model - DONE!!
// return to user and show on screen - DONE!!
// Add Dex entries for pokemon - DONE!!
// List all pokemon with name/number/picture linking to main pages. Should be the first page hit















// Read up on OOP and Generics!!!!!!!!! 
// Shore up terminology for Deserialization/Serialization
// Read up on main concepts of OOP Encapsulation, Inheritance, Abstraction, Polymorphism
//Unit Tests!!!
//msdn

