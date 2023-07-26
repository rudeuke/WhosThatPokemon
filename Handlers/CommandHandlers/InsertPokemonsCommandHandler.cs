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
            if (!await DatabaseSeeder.InsertPokemons(_db))
            {
                throw new Exception("Error inserting pokemons");
            }

            var response = new SimpleResponse
            {
                Message = "Pokemons inserted"
            };
            return response;
        }
    }
}
