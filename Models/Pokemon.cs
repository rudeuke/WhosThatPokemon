using System.ComponentModel.DataAnnotations;

namespace WhosThatPokemon.Models
{
    public class Pokemon
    {
        [Key]
        public int Id { get; set; }
        public int? OriginalId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public string? SilhouetteUrl { get; set; }

        public List<Type> PokemonTypes { get; set; } = new();
    }
}
