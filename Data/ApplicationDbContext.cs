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
    }
}
