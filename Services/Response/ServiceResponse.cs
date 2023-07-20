namespace WhosThatPokemon.Services.Response
{
    public class ServiceResponse<T> : SimpleResponse
    {
        public T? Data { get; set; }
    }
}
