using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WhosThatPokemon.Models
{
    public class Type
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public TypeEnum PokeType { get; set; }

        public List<Type> ResistantTo { get; set; } = new();
        public List<Type> ResistedBy { get; set; } = new();

        public List<Type> VulnerableTo { get; set; } = new();
        public List<Type> EffectiveAgainst { get; set; } = new();

        public List<Type> UnaffectedBy { get; set; } = new();
        public List<Type> IneffectiveTo { get; set; } = new();

        public List<Pokemon> Pokemons { get; set; } = new();
    }
}