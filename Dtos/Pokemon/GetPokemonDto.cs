namespace WhosThatPokemon.Dtos.Pokemon
{
    public class GetPokemonDto : GetPokemonBaseDto
    {
        public virtual List<string> PokemonTypes { get; set; } = new();
    }
}
