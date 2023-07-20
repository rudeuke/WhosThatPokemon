using Microsoft.EntityFrameworkCore;

namespace WhosThatPokemon.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Models.Type> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureTypes();
            modelBuilder.ConfigurePokemons();
        }
    }
}
