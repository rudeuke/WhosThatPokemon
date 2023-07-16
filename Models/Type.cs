using System.ComponentModel.DataAnnotations;

namespace WhosThatPokemon.Models
{
    public class Type
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public TypeEnum PokeType { get; set; }

        public virtual List<Type> ResistantTo { get; set; } = new();
        public virtual List<Type> ResistedBy { get; set; } = new();

        public virtual List<Type> VulnerableTo { get; set; } = new();
        public virtual List<Type> EffectiveAgainst { get; set; } = new();

        public virtual List<Type> UnaffectedBy { get; set; } = new();
        public virtual List<Type> IneffectiveTo { get; set; } = new();

        public virtual List<Pokemon> Pokemons { get; set; } = new();
    }
}