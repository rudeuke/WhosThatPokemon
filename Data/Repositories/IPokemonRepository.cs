namespace WhosThatPokemon.Data.Repositories
{
    public interface IPokemonRepository
    {
        Task<Pokemon> GetById(int id);
        Task<List<Pokemon>> GetAll();
        Task Add(Pokemon pokemon);
        Task Update(Pokemon pokemon);
        Task Delete(int id);
    }
}
