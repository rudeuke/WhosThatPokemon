namespace WhosThatPokemon.Services.PokemonService
{
    public interface IPokemonService
    {
        Task<ServiceResponse<List<GetPokemonDto>>> GetAllPokemons();
        Task<ServiceResponse<GetPokemonDetailsDto>> GetPokemonById(int id);
        Task<ServiceResponse<List<GetPokemonDto>>> AddPokemon(AddPokemonDto newPokemonDto);
    }
}
