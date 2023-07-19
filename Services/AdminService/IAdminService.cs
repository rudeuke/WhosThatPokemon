namespace WhosThatPokemon.Services.AdminService
{
    public interface IAdminService
    {
        SimpleResponse DeleteAllPokemons();
        SimpleResponse InsertPokemons();
    }
}
