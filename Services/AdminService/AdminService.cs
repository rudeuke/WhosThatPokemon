using WhosThatPokemon.Commands;

namespace WhosThatPokemon.Services.AdminService
{
    public class AdminService : IAdminService
    {
        private readonly ApplicationDbContext _db;
        private readonly IMediator _mediator;

        public AdminService(ApplicationDbContext db, IMediator mediator)
        {
            _db = db;
            _mediator = mediator;
        }

        public async Task<SimpleResponse> DeleteAllPokemons()
        {
            var command = new DeleteAllPokemonsCommand();
            var result = await _mediator.Send(command);
            return result;
        }

        public async Task<SimpleResponse> InsertPokemons()
        {
            var command = new InsertPokemonsCommand();
            var result = await _mediator.Send(command);
            return result;
        }
    }
}
