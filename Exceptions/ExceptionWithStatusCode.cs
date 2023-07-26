using System.Net;

namespace WhosThatPokemon.Exceptions
{
    public class ExceptionWithStatusCode : Exception
    {
        public HttpStatusCode HttpStatusCode { get; set; }

        public ExceptionWithStatusCode(string message, HttpStatusCode httpStatusCode)
            : base(message)
        {
            HttpStatusCode = httpStatusCode;
        }
    }
}
