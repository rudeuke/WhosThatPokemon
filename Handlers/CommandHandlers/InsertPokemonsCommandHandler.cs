using WhosThatPokemon.Commands;

namespace WhosThatPokemon.Handlers.CommandHandlers
{
    public class InsertPokemonsCommandHandler : IRequestHandler<InsertPokemonsCommand, SimpleResponse>
    {
        private readonly ApplicationDbContext _db;

        public InsertPokemonsCommandHandler(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<SimpleResponse> Handle(InsertPokemonsCommand request, CancellationToken cancellationToken)
        {
            var response = new SimpleResponse
            {
                Success = await DatabaseSeeder.InsertPokemons(_db)
            };

            if (response.Success)
            {
                response.Message = "Pokemons inserted";
            }
            else
            {
                response.Message = "Failed to insert pokemons";
            }

            return response;
        }
    }
}
