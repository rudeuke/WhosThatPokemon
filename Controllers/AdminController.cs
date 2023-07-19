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
            DatabaseSeeder.DeleteAllPokemons(_db);
            return Ok();
        }

        [HttpGet("SeedPokemons")]
        public IActionResult SeedPokemons()
        {
            DatabaseSeeder.InsertPokemons(_db);
            return Ok();
        }
    }
}
