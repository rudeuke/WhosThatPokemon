using Microsoft.EntityFrameworkCore;
using WhosThatPokemon.Data;

namespace WhosThatPokemon.Services.PokemonService
{
    public class PokemonService : IPokemonService
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public PokemonService(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<Pokemon>>> AddPokemon(Pokemon newPokemon)
        {
            var serviceResponse = new ServiceResponse<List<Pokemon>>();
            _db.Pokemons.Add(newPokemon);
            await _db.SaveChangesAsync();
            serviceResponse.Data = await _db.Pokemons.ToListAsync();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetPokemonDto>>> GetAllPokemons()
        {
            var serviceResponse = new ServiceResponse<List<GetPokemonDto>>();
            serviceResponse.Data = await _db.Pokemons.Select(p => _mapper.Map<GetPokemonDto>(p)).ToListAsync();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetPokemonDto>> GetPokemonById(int id)
        {
            var serviceResponse = new ServiceResponse<GetPokemonDto>();
            var pokemon = await _db.Pokemons.FindAsync(id);
            if (pokemon == null)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Pokemon not found.";
            }
            serviceResponse.Data = _mapper.Map<GetPokemonDto>(pokemon);
            return serviceResponse;
        }
    }
}
