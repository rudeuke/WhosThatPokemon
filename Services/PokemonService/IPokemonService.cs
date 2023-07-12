namespace WhosThatPokemon.Services.PokemonService
{
    public interface IPokemonService
    {
        ServiceResponse<List<Pokemon>> GetAllPokemons();
        ServiceResponse<Pokemon> GetPokemonById(int id);
    }
}
