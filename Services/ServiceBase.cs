using System.Net;
using WhosThatPokemon.Exceptions;

namespace WhosThatPokemon.Services
{
    public abstract class ServiceBase
    {
        private readonly IMediator _mediator;

        protected ServiceBase(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected async Task<TResponse> HandleCommandOrQuery<TResponse>(IRequest<TResponse> commandOrQuery)
            where TResponse : SimpleResponse, new()
        {
            try
            {
                var result = await _mediator.Send(commandOrQuery);
                return result;
            }
            catch (ValidationExceptionWithStatusCode ex)
            {
                return new TResponse
                {
                    Success = false,
                    Message = ex.Message,
                    StatusCode = ex.HttpStatusCode
                };
            }
            catch (ExceptionWithStatusCode ex)
            {
                return new TResponse
                {
                    Success = false,
                    Message = ex.Message,
                    StatusCode = ex.HttpStatusCode
                };
            }
            catch (Exception ex) //default exception
            {
                return new TResponse
                {
                    Success = false,
                    Message = ex.Message,
                    StatusCode = HttpStatusCode.NotImplemented
                };
            }
        }
    }
}
