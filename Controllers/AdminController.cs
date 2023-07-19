using Microsoft.AspNetCore.Mvc;
using WhosThatPokemon.Data;
using WhosThatPokemon.Services.AdminService;

namespace WhosThatPokemon.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : AdminControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet("DeletePokemons")]
        public ActionResult<SimpleResponse> DeletePokemons()
        {
            return ReturnOkOrInternalError(_adminService.DeleteAllPokemons());
        }

        [HttpGet("SeedPokemons")]
        public ActionResult<SimpleResponse> SeedPokemons()
        {
            return ReturnOkOrInternalError(_adminService.InsertPokemons());
        }
    }
}
