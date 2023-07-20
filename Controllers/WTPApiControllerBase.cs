using Microsoft.AspNetCore.Mvc;

namespace WhosThatPokemon.Controllers
{
    public class WTPApiControllerBase : Controller
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

        protected ActionResult<ServiceResponse<T>> ReturnOkOrNotFound<T>(ServiceResponse<T> response)
        {
            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return NotFound(response);
            }
        }
    }
}
