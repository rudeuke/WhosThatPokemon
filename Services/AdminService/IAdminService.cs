namespace WhosThatPokemon.Services.AdminService
{
    public interface IAdminService
    {
        Task<SimpleResponse> DeleteAllPokemons();
        Task<SimpleResponse> InsertPokemons();
    }
}
