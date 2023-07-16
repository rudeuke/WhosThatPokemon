namespace WhosThatPokemon.Services.PokemonService
{
    public interface IPokemonService
    {
        Task<ServiceResponse<List<GetPokemonDto>>> GetAllPokemons();
        Task<ServiceResponse<GetPokemonDto>> GetPokemonById(int id);
        Task<ServiceResponse<List<Pokemon>>> AddPokemon(Pokemon newPokemon);
    }
}
