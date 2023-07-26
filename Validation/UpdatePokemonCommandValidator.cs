using FluentValidation;
using WhosThatPokemon.Commands;

namespace WhosThatPokemon.Validation
{
    public class UpdatePokemonCommandValidator : AbstractValidator<UpdatePokemonCommand>
    {
        public UpdatePokemonCommandValidator()
        {
            RuleFor(x => x.UpdatedPokemonDto.Id)
                .GreaterThan(0)
                .WithMessage("Id must be greater than 0");
            RuleFor(x => x.UpdatedPokemonDto.OriginalId)
                .InclusiveBetween(1, 1010)
                .WithMessage("OriginalId must be between 1 and 1010");
            RuleFor(x => x.UpdatedPokemonDto.Name)
                .NotEmpty()
                .WithMessage("Name is required");
            RuleFor(x => x.UpdatedPokemonDto.PokemonTypes)
                .NotEmpty()
                .WithMessage("Type is required")
                .Must(pokemonTypes => pokemonTypes.Count >= 1 && pokemonTypes.Count <= 2)
                .WithMessage("Pokemon can have 1 or 2 types")
                .Must(pokemonTypes => pokemonTypes.Count == pokemonTypes.Distinct().Count())
                .WithMessage("Pokemon can't have duplicate types");
        }
    }
}
