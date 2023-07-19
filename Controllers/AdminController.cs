using Microsoft.AspNetCore.Mvc;
using WhosThatPokemon.Data;

namespace WhosThatPokemon.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet("DeletePokemons")]
        public IActionResult DeletePokemons()
        {
            var response = new SimpleResponse();
            response.Success = DatabaseSeeder.DeleteAllPokemons(_db);
            return Ok(response);
        }

        [HttpGet("SeedPokemons")]
        public IActionResult SeedPokemons()
        {
            var response = new SimpleResponse();
            response.Success = DatabaseSeeder.InsertPokemons(_db);
            return Ok(response);
        }
    }
}
