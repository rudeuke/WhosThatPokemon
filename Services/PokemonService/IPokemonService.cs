namespace WhosThatPokemon.Services.PokemonService
{
    public interface IPokemonService
    {
        Task<ServiceResponse<List<Pokemon>>> GetAllPokemons();
        Task<ServiceResponse<Pokemon>> GetPokemonById(int id);
    }
}
