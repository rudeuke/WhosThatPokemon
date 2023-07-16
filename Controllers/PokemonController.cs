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
        public async Task<ActionResult<ServiceResponse<List<GetPokemonDto>>>> Get()
        {
            return Ok(await _pokemonService.GetAllPokemons());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetPokemonDto>>> GetSingle(int id)
        {
            return Ok(await _pokemonService.GetPokemonById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Pokemon>>>> AddPokemon(Pokemon newPokemon)
        {
            return Ok(await _pokemonService.AddPokemon(newPokemon));
        }
    }
}
