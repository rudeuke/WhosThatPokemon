namespace WhosThatPokemon.Commands
{
    public class DeletePokemonCommand : IRequest<ServiceResponse<List<GetPokemonDto>>>
    {
        public int Id { get; }

        public DeletePokemonCommand(int id)
        {
            Id = id;
        }
    }
}
