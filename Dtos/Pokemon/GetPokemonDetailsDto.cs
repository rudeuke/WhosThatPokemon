namespace WhosThatPokemon.Dtos.Pokemon
{
    public class GetPokemonDetailsDto : GetPokemonDtoBase
    {
        public string? ImageUrl { get; set; }
        public string? SilhouetteUrl { get; set; }

        public virtual List<GetTypeDetailsDto> PokemonTypes { get; set; } = new();
    }
}
