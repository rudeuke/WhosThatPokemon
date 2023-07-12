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

        public List<Pokemon> GetAllPokemons()
        {
            return _db.Pokemons.ToList();
        }

        public Pokemon GetPokemonById(int id)
        {
            var pokemon = _db.Pokemons.Find(id);
            if (pokemon == null)
            {
                throw new Exception("Pokemon not found");
            }
            return pokemon;
        }
    }
}
