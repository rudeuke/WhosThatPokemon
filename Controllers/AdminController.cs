using Microsoft.AspNetCore.Mvc;

namespace WhosThatPokemon.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : WTPApiControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet("DeletePokemons")]
        public async Task<ActionResult<SimpleResponse>> DeletePokemons()
        {
            return ReturnHttpResponse(await _adminService.DeleteAllPokemons());
        }

        [HttpGet("SeedPokemons")]
        public async Task<ActionResult<SimpleResponse>> SeedPokemons()
        {
            return ReturnHttpResponse(await _adminService.InsertPokemons());
        }
    }
}
