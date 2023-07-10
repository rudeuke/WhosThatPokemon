using System.ComponentModel.DataAnnotations;

namespace WhosThatPokemon.Models
{
    public class Pokemon
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public string? SilhouetteUrl { get; set; }

        public Pokemon(int id, string name, string imageUrl, string silhouetteUrl)
        {
            Id = id;
            Name = name;
            ImageUrl = imageUrl;
            SilhouetteUrl = silhouetteUrl;
        }

        public Pokemon(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
