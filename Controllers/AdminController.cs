using Microsoft.AspNetCore.Mvc;
using WhosThatPokemon.Data;

namespace WhosThatPokemon.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : AdminControllerBase
    {
        private readonly ApplicationDbContext _db;

        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet("DeletePokemons")]
        public ActionResult<SimpleResponse> DeletePokemons()
        {
            var response = new SimpleResponse();
            response.Success = DatabaseSeeder.DeleteAllPokemons(_db);
            return ReturnOkOrInternalError(response);
        }

        [HttpGet("SeedPokemons")]
        public ActionResult<SimpleResponse> SeedPokemons()
        {
            var response = new SimpleResponse();
            response.Success = DatabaseSeeder.InsertPokemons(_db);
            return ReturnOkOrInternalError(response);
        }
    }
}
