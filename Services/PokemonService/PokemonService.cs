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

        public ServiceResponse<List<Pokemon>> GetAllPokemons()
        {
            var serviceResponse = new ServiceResponse<List<Pokemon>>();
            serviceResponse.Data = _db.Pokemons.ToList();
            return serviceResponse;
        }

        public ServiceResponse<Pokemon> GetPokemonById(int id)
        {
            var serviceResponse = new ServiceResponse<Pokemon>();
            var pokemon = _db.Pokemons.Find(id);
            if (pokemon == null)
            {
                throw new Exception("Pokemon not found");
            }
            serviceResponse.Data = pokemon;
            return serviceResponse;
        }
    }
}
