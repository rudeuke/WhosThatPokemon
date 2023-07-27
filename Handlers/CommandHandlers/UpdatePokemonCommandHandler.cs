using System.Net;
using WhosThatPokemon.Commands;
using WhosThatPokemon.Data.Repositories;
using WhosThatPokemon.Exceptions;

namespace WhosThatPokemon.Handlers.CommandHandlers
{
    public class UpdatePokemonCommandHandler : IRequestHandler<UpdatePokemonCommand, ServiceResponse<GetPokemonDto>>
    {
        private readonly IPokemonRepository _pokemonRepository;
        private readonly IMapper _mapper;

        public UpdatePokemonCommandHandler(IPokemonRepository pokemonRepository, IMapper mapper)
        {
            _pokemonRepository = pokemonRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<GetPokemonDto>> Handle(UpdatePokemonCommand request, CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<GetPokemonDto>();

            var pokemon = await _pokemonRepository.GetById(request.UpdatedPokemonDto.Id);

            if (pokemon == null)
            {
                throw new ExceptionWithStatusCode("Pokemon not found.", HttpStatusCode.NotFound);
            }

            var updatedPokemon = _mapper.Map<Pokemon>(request.UpdatedPokemonDto);
            pokemon.OriginalId = updatedPokemon.OriginalId;
            pokemon.Name = updatedPokemon.Name;
            pokemon.ImageUrl = updatedPokemon.ImageUrl;
            pokemon.SilhouetteUrl = updatedPokemon.SilhouetteUrl;
            pokemon.PokemonTypes.Clear();
            pokemon.PokemonTypes.AddRange(updatedPokemon.PokemonTypes);

            await _pokemonRepository.Update(pokemon);

            serviceResponse.Data = _mapper.Map<GetPokemonDto>(pokemon);
            serviceResponse.Message = "Pokemon updated";
            return serviceResponse;
        }
    }
}
