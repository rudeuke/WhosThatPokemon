using Microsoft.AspNetCore.Mvc;

namespace WhosThatPokemon.Controllers
{
    public class MyControllerBase : Controller
    {
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
