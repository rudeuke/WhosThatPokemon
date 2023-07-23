namespace WhosThatPokemon.Queries
{
    public class GetPokemonByIdQuery : IRequest<ServiceResponse<GetPokemonDetailsDto>>
    {
        public int Id { get; }

        public GetPokemonByIdQuery(int id)
        {
            Id = id;
        }
    }
}
