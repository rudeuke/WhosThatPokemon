using WhosThatPokemon.Commands;

namespace WhosThatPokemon.Services.AdminService
{
    public class AdminService : ServiceBase, IAdminService
    {
        public AdminService(IMediator mediator) : base(mediator)
        {
        }

        public async Task<SimpleResponse> DeleteAllPokemons()
        {
            return await HandleCommandOrQuery(new DeleteAllPokemonsCommand());
        }

        public async Task<SimpleResponse> InsertPokemons()
        {
            return await HandleCommandOrQuery(new InsertPokemonsCommand());
        }
    }
}
