namespace WhosThatPokemon.Dtos.Pokemon
{
    public class GetPokemonBaseDto
    {
        public int Id { get; set; }
        public int? OriginalId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
