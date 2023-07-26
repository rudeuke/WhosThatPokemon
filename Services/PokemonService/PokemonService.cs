using WhosThatPokemon.Commands;
using WhosThatPokemon.Queries;

namespace WhosThatPokemon.Services.PokemonService
{
    public class PokemonService : ServiceBase, IPokemonService
    {
        public PokemonService(IMediator mediator) : base(mediator)
        {
        }

        public async Task<ServiceResponse<List<GetPokemonDto>>> AddPokemon(AddPokemonDto newPokemonDto)
        {
            return await HandleCommandOrQuery(new AddPokemonCommand(newPokemonDto));
        }

        public async Task<ServiceResponse<List<GetPokemonDto>>> DeletePokemon(int id)
        {
            return await HandleCommandOrQuery(new DeletePokemonCommand(id));
        }

        public async Task<ServiceResponse<List<GetPokemonDto>>> GetAllPokemons()
        {
            return await HandleCommandOrQuery(new GetAllPokemonsQuery());;
        }

        public async Task<ServiceResponse<GetPokemonDetailsDto>> GetPokemonById(int id)
        {
            return await HandleCommandOrQuery(new GetPokemonByIdQuery(id));
        }

        public async Task<ServiceResponse<GetPokemonDto>> UpdatePokemon(UpdatePokemonDto updatedPokemonDto)
        {
            return await HandleCommandOrQuery(new UpdatePokemonCommand(updatedPokemonDto));
        }
    }
}
