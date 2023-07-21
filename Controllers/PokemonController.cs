using Microsoft.AspNetCore.Mvc;

namespace WhosThatPokemon.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : WTPApiControllerBase
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
        public async Task<ActionResult<ServiceResponse<GetPokemonDetailsDto>>> GetSingle(int id)
        {
            return ReturnOkOrNotFound(await _pokemonService.GetPokemonById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetPokemonDto>>>> AddPokemon(AddPokemonDto newPokemonDto)
        {
            return ReturnOkOrInternalError(await _pokemonService.AddPokemon(newPokemonDto));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetPokemonDto>>> UpdatePokemon(UpdatePokemonDto updatedPokemonDto)
        {
            return ReturnOkOrNotFound(await _pokemonService.UpdatePokemon(updatedPokemonDto));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetPokemonDto>>>> Delete(int id)
        {
            return ReturnOkOrNotFound(await _pokemonService.DeletePokemon(id));
        }
    }
}
