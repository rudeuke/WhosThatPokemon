using Azure.Core;
using Microsoft.EntityFrameworkCore;
using WhosThatPokemon.Commands;

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

            try
            {
                var pokemon = await _db.Pokemons.FindAsync(request.Id);

                if (pokemon == null)
                {
                    throw new Exception("Pokemon not found.");
                }

                _db.Pokemons.Remove(pokemon);
                await _db.SaveChangesAsync();

                var pokemons = await _db.Pokemons.ToListAsync();
                serviceResponse.Data = pokemons.Select(p => _mapper.Map<GetPokemonDto>(p)).ToList();
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
