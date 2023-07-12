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
        public async Task<ActionResult<ServiceResponse<List<Pokemon>>>> Get()
        {
            return Ok(await _pokemonService.GetAllPokemons());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Pokemon>>> GetSingle(int id)
        {
            return Ok(await _pokemonService.GetPokemonById(id));
        }
    }
}
