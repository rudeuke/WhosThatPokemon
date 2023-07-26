using Microsoft.EntityFrameworkCore;
using System.Net;
using WhosThatPokemon.Commands;
using WhosThatPokemon.Exceptions;

namespace WhosThatPokemon.Handlers.CommandHandlers
{
    public class DeletePokemonCommandHandler : IRequestHandler<DeletePokemonCommand, ServiceResponse<List<GetPokemonDto>>>
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public DeletePokemonCommandHandler(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetPokemonDto>>> Handle(DeletePokemonCommand request, CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<List<GetPokemonDto>>();

            var pokemon = await _db.Pokemons.FindAsync(request.Id);

            if (pokemon == null)
            {
                throw new ExceptionWithStatusCode("Pokemon not found.", HttpStatusCode.NotFound);
            }

            _db.Pokemons.Remove(pokemon);
            await _db.SaveChangesAsync();

            var pokemons = await _db.Pokemons.ToListAsync();
            serviceResponse.Data = pokemons.Select(p => _mapper.Map<GetPokemonDto>(p)).ToList();

            return serviceResponse;
        }
    }
}
