namespace WhosThatPokemon.Dtos.Type
{
    public class GetTypeDetailsDto
    {
        public TypeEnum PokeType { get; set; }

        public virtual List<string> ResistantTo { get; set; } = new();
        public virtual List<string> ResistedBy { get; set; } = new();

        public virtual List<string> VulnerableTo { get; set; } = new();
        public virtual List<string> EffectiveAgainst { get; set; } = new();

        public virtual List<string> UnaffectedBy { get; set; } = new();
        public virtual List<string> IneffectiveTo { get; set; } = new();

        public virtual List<string> Pokemons { get; set; } = new();
    }
}
