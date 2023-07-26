using System.Net;
using WhosThatPokemon.Exceptions;
using WhosThatPokemon.Queries;

namespace WhosThatPokemon.Handlers.QueryHandlers
{
    public class GetPokemonByIdQueryHandler : IRequestHandler<GetPokemonByIdQuery, ServiceResponse<GetPokemonDetailsDto>>
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public GetPokemonByIdQueryHandler(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<GetPokemonDetailsDto>> Handle(GetPokemonByIdQuery request, CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<GetPokemonDetailsDto>();
            var pokemon = await _db.Pokemons.FindAsync(request.Id);

            if (pokemon == null)
            {
                throw new ExceptionWithStatusCode("Pokemon not found.", HttpStatusCode.NotFound);
            }

            serviceResponse.Data = _mapper.Map<GetPokemonDetailsDto>(pokemon);
            serviceResponse.Message = "Pokemon retrieved successfully.";
            return serviceResponse;
        }
    }
}
