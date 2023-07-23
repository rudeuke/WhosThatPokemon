using WhosThatPokemon.Commands;

namespace WhosThatPokemon.Handlers.CommandHandlers
{
    public class DeleteAllPokemonsCommandHandler : IRequestHandler<DeleteAllPokemonsCommand, SimpleResponse>
    {
        private readonly ApplicationDbContext _db;

        public DeleteAllPokemonsCommandHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<SimpleResponse> Handle(DeleteAllPokemonsCommand request, CancellationToken cancellationToken)
        {
            var response = new SimpleResponse
            {
                Success = await DatabaseSeeder.DeleteAllPokemons(_db)
            };

            if (response.Success)
            {
                response.Message = "Pokemons deleted";
            }
            else
            {
                response.Message = "Failed to delete pokemons";
            }

            return response;
        }
    }
}
