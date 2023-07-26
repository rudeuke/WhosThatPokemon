using System.Net;
using WhosThatPokemon.Commands;
using WhosThatPokemon.Exceptions;

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
            if (!await DatabaseSeeder.DeleteAllPokemons(_db))
            {
                throw new ExceptionWithStatusCode("Failed to delete pokemons", HttpStatusCode.InternalServerError);
            }

            var response = new SimpleResponse
            {
                Message = "Pokemons deleted"
            };
            return response;
        }
    }
}
