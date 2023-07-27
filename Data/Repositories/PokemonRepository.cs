using Microsoft.EntityFrameworkCore;

namespace WhosThatPokemon.Data.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly ApplicationDbContext _db;

        public PokemonRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task Add(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Pokemon>> GetAll()
        {
            return await _db.Pokemons.ToListAsync();
        }

        public async Task<Pokemon> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Pokemon pokemon)
        {
            throw new NotImplementedException();
        }
    }
}
