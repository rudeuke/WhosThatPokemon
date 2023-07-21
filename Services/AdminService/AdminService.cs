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

        public async Task<SimpleResponse> InsertPokemons()
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
