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
            _db.Pokemons.Add(pokemon);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Pokemon pokemon)
        {
            _db.Pokemons.Remove(pokemon);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Pokemon>> GetAll()
        {
            return await _db.Pokemons.ToListAsync();
        }

        public async Task<Pokemon> GetById(int id)
        {
            return await _db.Pokemons.FindAsync(id);
        }

        public async Task Update(Pokemon pokemon)
        {
            _db.Pokemons.Update(pokemon);
            await _db.SaveChangesAsync();
        }
    }
}
