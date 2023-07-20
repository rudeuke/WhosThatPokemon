namespace WhosThatPokemon.Dtos.Pokemon
{
    public class GetPokemonDtoBase
    {
        public int Id { get; set; }
        public int? OriginalId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
