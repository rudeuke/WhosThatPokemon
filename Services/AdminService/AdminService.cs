namespace WhosThatPokemon.Services.AdminService
{
    public class AdminService : IAdminService
    {
        private readonly ApplicationDbContext _db;

        public AdminService(ApplicationDbContext db)
        {
            _db = db;
        }

        public SimpleResponse DeleteAllPokemons()
        {
            var response = new SimpleResponse
            {
                Success = DatabaseSeeder.DeleteAllPokemons(_db)
            };
            return response;
        }

        public SimpleResponse InsertPokemons()
        {
            var response = new SimpleResponse
            {
                Success = DatabaseSeeder.InsertPokemons(_db)
            };
            return response;
        }
    }
}
