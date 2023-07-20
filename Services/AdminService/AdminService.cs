namespace WhosThatPokemon.Services.AdminService
{
    public class AdminService : IAdminService
    {
        private readonly ApplicationDbContext _db;

        public AdminService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<SimpleResponse> DeleteAllPokemons()
        {
            var response = new SimpleResponse
            {
                Success = await DatabaseSeeder.DeleteAllPokemons(_db)
            };
            return response;
        }

        public async Task<SimpleResponse> InsertPokemons()
        {
            var response = new SimpleResponse
            {
                Success = await DatabaseSeeder.InsertPokemons(_db)
            };
            return response;
        }
    }
}
