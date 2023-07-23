namespace WhosThatPokemon.Commands
{
    public class AddPokemonCommand : IRequest<ServiceResponse<List<GetPokemonDto>>>
    {
        public AddPokemonDto NewPokemonDto { get; }

        public AddPokemonCommand(AddPokemonDto newPokemonDto)
        {
            NewPokemonDto = newPokemonDto;
        }
    }
}
