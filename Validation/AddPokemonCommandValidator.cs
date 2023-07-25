using FluentValidation;
using WhosThatPokemon.Commands;

namespace WhosThatPokemon.Validation
{
    public class AddPokemonCommandValidator : AbstractValidator<AddPokemonCommand>
    {
        public AddPokemonCommandValidator()
        {
            RuleFor(x => x.NewPokemonDto.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.NewPokemonDto.PokemonTypes).NotEmpty().WithMessage("Type is required");
        }
    }
}
