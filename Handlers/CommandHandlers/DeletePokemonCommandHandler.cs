using System.Net;
using WhosThatPokemon.Commands;
using WhosThatPokemon.Data.Repositories;
using WhosThatPokemon.Exceptions;

namespace WhosThatPokemon.Handlers.CommandHandlers
{
    public class DeletePokemonCommandHandler : IRequestHandler<DeletePokemonCommand, ServiceResponse<List<GetPokemonDto>>>
    {
        private readonly IPokemonRepository _pokemonRepository;
        private readonly IMapper _mapper;

        public DeletePokemonCommandHandler(IPokemonRepository pokemonRepository, IMapper mapper)
        {
            _pokemonRepository = pokemonRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetPokemonDto>>> Handle(DeletePokemonCommand request, CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<List<GetPokemonDto>>();

            var pokemon = await _pokemonRepository.GetById(request.Id);

            if (pokemon == null)
            {
                throw new ExceptionWithStatusCode("Pokemon not found.", HttpStatusCode.NotFound);
            }

            await _pokemonRepository.Delete(pokemon);

            var pokemons = await _pokemonRepository.GetAll();
            serviceResponse.Data = pokemons.Select(p => _mapper.Map<GetPokemonDto>(p)).ToList();
            serviceResponse.Message = "Pokemon deleted";
            return serviceResponse;
        }
    }
}
