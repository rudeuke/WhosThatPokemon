namespace WhosThatPokemon.Services.PokemonService
{
    public interface IPokemonService
    {
        List<Pokemon> GetAllPokemons();
        Pokemon GetPokemonById(int id);
    }
}
