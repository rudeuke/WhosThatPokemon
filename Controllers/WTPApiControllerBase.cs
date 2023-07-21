using Microsoft.AspNetCore.Mvc;
using WhosThatPokemon.Services.Response;

namespace WhosThatPokemon.Controllers
{
    public class WTPApiControllerBase : Controller
    {
        protected ActionResult<SimpleResponse> ReturnOkOrInternalError(SimpleResponse response)
        {
            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return StatusCode(500, response);
            }
        }

        protected ActionResult<ServiceResponse<T>> ReturnOkOrInternalError<T>(ServiceResponse<T> response)
        {
            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
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
