namespace WhosThatPokemon.Commands
{
    public class UpdatePokemonCommand : IRequest<ServiceResponse<GetPokemonDto>>
    {
        public UpdatePokemonDto UpdatedPokemonDto { get; }

        public UpdatePokemonCommand(UpdatePokemonDto updatedPokemonDto)
        {
            UpdatedPokemonDto = updatedPokemonDto;
        }
    }
}
