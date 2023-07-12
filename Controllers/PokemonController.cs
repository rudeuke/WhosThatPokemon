using Microsoft.AspNetCore.Mvc;

namespace WhosThatPokemon.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : Controller
    {
        private readonly IPokemonService _pokemonService;

        public PokemonController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        [HttpGet]
        public ActionResult<Pokemon> Get()
        {
            return Ok(_pokemonService.GetAllPokemons());
        }

        [HttpGet("{id}")]
        public ActionResult<Pokemon> GetSingle(int id)
        {
            return Ok(_pokemonService.GetPokemonById(id));
        }
    }
}
