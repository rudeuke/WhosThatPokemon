using Microsoft.AspNetCore.Mvc;

namespace WhosThatPokemon.Controllers
{
    public class AdminControllerBase : Controller
    {
        protected ActionResult<SimpleResponse> ReturnOkOrInternalError(SimpleResponse response)
        {
            if (response.Success)
            {
                response.Message = "Operation successful";
                return Ok(response);
            }
            else
            {
                response.Message = "Operation failed";
                return StatusCode(500, response);
            }
        }
    }
}
