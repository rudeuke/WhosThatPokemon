namespace WhosThatPokemon.Dtos.Pokemon
{
    public class AddPokemonDto
    {
        public int? OriginalId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public string? SilhouetteUrl { get; set; }

        public List<string> PokemonTypes { get; set; } = new();
    }
}
