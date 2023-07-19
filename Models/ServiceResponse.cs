namespace WhosThatPokemon.Models
{
    public class ServiceResponse<T> : SimpleResponse
    {
        public T? Data { get; set; }
    }
}
