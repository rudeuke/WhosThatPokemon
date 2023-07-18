namespace WhosThatPokemon.Dtos.Pokemon
{
    public class GetPokemonDto
    {
        public int Id { get; set; }
        public int? OriginalId { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual List<string> PokemonTypes { get; set; } = new();
    }
}
