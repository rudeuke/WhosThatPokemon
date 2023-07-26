using Microsoft.AspNetCore.Mvc;
using System.Net;
using WhosThatPokemon.Services.Response;

namespace WhosThatPokemon.Controllers
{
    public class WTPApiControllerBase : Controller
    {
        protected ActionResult<TResponse> ReturnHttpResponse<TResponse>(TResponse response) 
            where TResponse : SimpleResponse
        {
            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    return Ok(response);
                //case HttpStatusCode.Created:
                //    return StatusCode((int)response.StatusCode, response);
                case HttpStatusCode.BadRequest:
                    return BadRequest(response);
                case HttpStatusCode.NotFound:
                    return NotFound(response);
                //case HttpStatusCode.InternalServerError:
                //    return StatusCode((int)response.StatusCode, response);
                //case HttpStatusCode.NotImplemented:
                //    return StatusCode((int)response.StatusCode, response);
                default:
                    return StatusCode((int)response.StatusCode, response);
            }
        }
    }
}
