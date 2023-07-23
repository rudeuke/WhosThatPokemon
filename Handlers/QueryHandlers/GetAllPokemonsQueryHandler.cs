using Microsoft.EntityFrameworkCore;
using WhosThatPokemon.Queries;

namespace WhosThatPokemon.Handlers.QueryHandlers
{
    public class GetAllPokemonsQueryHandler : IRequestHandler<GetAllPokemonsQuery, ServiceResponse<List<GetPokemonDto>>>
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public GetAllPokemonsQueryHandler(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetPokemonDto>>> Handle(GetAllPokemonsQuery request, CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<List<GetPokemonDto>>();
            var pokemons = await _db.Pokemons.ToListAsync();
            serviceResponse.Data = pokemons.Select(p => _mapper.Map<GetPokemonDto>(p)).ToList();
            return serviceResponse;
        }
    }
}
