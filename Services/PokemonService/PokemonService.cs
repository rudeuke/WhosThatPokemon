using WhosThatPokemon.Commands;
using WhosThatPokemon.Queries;

namespace WhosThatPokemon.Services.PokemonService
{
    public class PokemonService : IPokemonService
    {
        private readonly IMediator _mediator;

        public PokemonService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<ServiceResponse<List<GetPokemonDto>>> AddPokemon(AddPokemonDto newPokemonDto)
        {
            var command = new AddPokemonCommand(newPokemonDto);
            var result = await _mediator.Send(command);
            return result;
        }

        public async Task<ServiceResponse<List<GetPokemonDto>>> DeletePokemon(int id)
        {
            var command = new DeletePokemonCommand(id);
            var result = await _mediator.Send(command);
            return result;
        }

        public async Task<ServiceResponse<List<GetPokemonDto>>> GetAllPokemons()
        {
            var query = new GetAllPokemonsQuery();
            var result = await _mediator.Send(query);
            return result;
        }

        public async Task<ServiceResponse<GetPokemonDetailsDto>> GetPokemonById(int id)
        {
            var query = new GetPokemonByIdQuery(id);
            var result = await _mediator.Send(query);
            return result;
        }

        public async Task<ServiceResponse<GetPokemonDto>> UpdatePokemon(UpdatePokemonDto updatedPokemonDto)
        {
            var command = new UpdatePokemonCommand(updatedPokemonDto);
            var result = await _mediator.Send(command);
            return result;
        }
    }
}
