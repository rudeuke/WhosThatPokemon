using Microsoft.EntityFrameworkCore;
using WhosThatPokemon.Data;

namespace WhosThatPokemon.Services.PokemonService
{
    public class PokemonService : IPokemonService
    {
        private readonly ApplicationDbContext _db;

        public PokemonService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse<List<Pokemon>>> GetAllPokemons()
        {
            var serviceResponse = new ServiceResponse<List<Pokemon>>();
            serviceResponse.Data = await _db.Pokemons.ToListAsync();
            return serviceResponse;
        }

        public async Task<ServiceResponse<Pokemon>> GetPokemonById(int id)
        {
            var serviceResponse = new ServiceResponse<Pokemon>();
            var pokemon = await _db.Pokemons.FindAsync(id);
            if (pokemon == null)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Pokemon not found.";
            }
            serviceResponse.Data = pokemon;
            return serviceResponse;
        }
    }
}
