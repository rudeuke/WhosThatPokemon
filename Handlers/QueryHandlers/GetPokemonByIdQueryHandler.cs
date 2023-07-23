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

            try
            {
                var pokemon = await _db.Pokemons.FindAsync(request.Id);

                if (pokemon == null)
                {
                    throw new Exception("Pokemon not found.");
                }

                serviceResponse.Data = _mapper.Map<GetPokemonDetailsDto>(pokemon);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return serviceResponse;
            }

            return serviceResponse;
        }
    }
}
