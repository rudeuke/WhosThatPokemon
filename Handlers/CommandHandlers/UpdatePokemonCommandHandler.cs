using System.Net;
using WhosThatPokemon.Commands;
using WhosThatPokemon.Exceptions;

namespace WhosThatPokemon.Handlers.CommandHandlers
{
    public class UpdatePokemonCommandHandler : IRequestHandler<UpdatePokemonCommand, ServiceResponse<GetPokemonDto>>
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public UpdatePokemonCommandHandler(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<GetPokemonDto>> Handle(UpdatePokemonCommand request, CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<GetPokemonDto>();

            var pokemon = await _db.Pokemons.FindAsync(request.UpdatedPokemonDto.Id);

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

            await _db.SaveChangesAsync();
            serviceResponse.Data = _mapper.Map<GetPokemonDto>(pokemon);

            return serviceResponse;
        }
    }
}
