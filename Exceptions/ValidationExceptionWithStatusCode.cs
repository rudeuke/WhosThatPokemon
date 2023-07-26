using FluentValidation;
using FluentValidation.Results;
using System.Net;

namespace WhosThatPokemon.Exceptions
{
    public class ValidationExceptionWithStatusCode : ValidationException
    {
        public HttpStatusCode HttpStatusCode { get; }

        public ValidationExceptionWithStatusCode(IEnumerable<ValidationFailure> failures, HttpStatusCode httpStatusCode)
            : base(failures)
        {
            HttpStatusCode = httpStatusCode;
        }
    }
}
