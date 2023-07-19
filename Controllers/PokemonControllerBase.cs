using Microsoft.AspNetCore.Mvc;

namespace WhosThatPokemon.Controllers
{
    public class PokemonControllerBase : Controller
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
