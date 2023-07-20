namespace WhosThatPokemon.Dtos.Pokemon
{
    public class GetPokemonDto : GetPokemonDtoBase
    {
        public virtual List<string> PokemonTypes { get; set; } = new();
    }
}
