using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UpdatedPokédex.ViewModels;

namespace UpdatedPokédex.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View("Index");
        }



        [Route("/")]
        [HttpPost]
        public async Task<IActionResult> Index(PokemonSearchViewModel model)
        {
            return RedirectToAction("Index", "Pokémon", new { name = model.PokemonName });
        }

    }
}