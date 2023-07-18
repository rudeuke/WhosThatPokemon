namespace WhosThatPokemon.Dtos.Pokemon
{
    public class GetPokemonDetailsDto
    {
        public int Id { get; set; }
        public int? OriginalId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public string? SilhouetteUrl { get; set; }

        public virtual List<GetTypeDetailsDto> PokemonTypes { get; set; } = new();
    }
}
