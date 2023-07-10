using Microsoft.AspNetCore.Mvc;
using WhosThatPokemon.Data;
using WhosThatPokemon.Models;

namespace WhosThatPokemon.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PokemonController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<Pokemon> GetPokemonById(int id)
        {
            var pokemon = _db.Pokemons.Find(id);
            if (pokemon == null)
            {
                return NotFound();
            }
            return Ok(pokemon);
        }
    }
}
