using Microsoft.EntityFrameworkCore;
using WhosThatPokemon.Models;

namespace WhosThatPokemon.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Pokemon> Pokemons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>().HasData(
                new Pokemon { Id = 1, Name = "Pikachu", ImageUrl = "~/images/pokemons/pikachu.png" },
                new Pokemon { Id = 2, Name = "Bulbasaur", ImageUrl = "~/images/pokemons/bulbasaur.png" },
                new Pokemon { Id = 3, Name = "Charmander", ImageUrl = "~/images/pokemons/charmander.png" },
                new Pokemon { Id = 4, Name = "Squirtle", ImageUrl = "~/images/pokemons/squirtle.png" }
                );
        }
    }
}
