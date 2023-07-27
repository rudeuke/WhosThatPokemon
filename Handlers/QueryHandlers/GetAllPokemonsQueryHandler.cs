using Microsoft.EntityFrameworkCore;
using WhosThatPokemon.Data.Repositories;
using WhosThatPokemon.Queries;

namespace WhosThatPokemon.Handlers.QueryHandlers
{
    public class GetAllPokemonsQueryHandler : IRequestHandler<GetAllPokemonsQuery, ServiceResponse<List<GetPokemonDto>>>
    {
        private readonly IPokemonRepository _pokemonRepository;
        private readonly IMapper _mapper;

        public GetAllPokemonsQueryHandler(IPokemonRepository pokemonRepository, IMapper mapper)
        {
            _pokemonRepository = pokemonRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetPokemonDto>>> Handle(GetAllPokemonsQuery request, CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<List<GetPokemonDto>>();
            var pokemons = await _pokemonRepository.GetAll();
            serviceResponse.Data = pokemons.Select(p => _mapper.Map<GetPokemonDto>(p)).ToList();
            serviceResponse.Message = "All pokemons retrieved successfully.";
            return serviceResponse;
        }
    }
}
