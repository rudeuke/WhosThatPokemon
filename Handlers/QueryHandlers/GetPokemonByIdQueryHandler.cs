using System.Net;
using WhosThatPokemon.Data.Repositories;
using WhosThatPokemon.Exceptions;
using WhosThatPokemon.Queries;

namespace WhosThatPokemon.Handlers.QueryHandlers
{
    public class GetPokemonByIdQueryHandler : IRequestHandler<GetPokemonByIdQuery, ServiceResponse<GetPokemonDetailsDto>>
    {
        private readonly IPokemonRepository _pokemonRepository;
        private readonly IMapper _mapper;

        public GetPokemonByIdQueryHandler(IPokemonRepository pokemonRepository, IMapper mapper)
        {
            _pokemonRepository = pokemonRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<GetPokemonDetailsDto>> Handle(GetPokemonByIdQuery request, CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<GetPokemonDetailsDto>();
            var pokemon = await _pokemonRepository.GetById(request.Id);

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
