using Microsoft.EntityFrameworkCore;

namespace WhosThatPokemon.Data
{
    public static class DatabaseSeeder
    {
        public async static Task<bool> DeleteAllPokemons(ApplicationDbContext db)
        {
            try
            {
                db.Pokemons.RemoveRange(db.Pokemons);
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async static Task<bool> InsertPokemons(ApplicationDbContext db)
        {
            try 
            {
                var pokemonTypes = await db.Types.ToListAsync();

                if (pokemonTypes.Count != Enum.GetNames(typeof(TypeEnum)).Length)
                {
                    throw new Exception("Pokemon types missing");
                }

                var electricType = pokemonTypes.SingleOrDefault(t => t.PokeType == TypeEnum.Electric);
                var grassType = pokemonTypes.SingleOrDefault(t => t.PokeType == TypeEnum.Grass);
                var fireType = pokemonTypes.SingleOrDefault(t => t.PokeType == TypeEnum.Fire);
                var waterType = pokemonTypes.SingleOrDefault(t => t.PokeType == TypeEnum.Water);

                db.Pokemons.AddRange(
                    new Pokemon
                    {
                        OriginalId = 25,
                        Name = "Pikachu",
                        ImageUrl = "pikachu.png",
                        PokemonTypes = { electricType }
                    },
                    new Pokemon
                    {
                        OriginalId = 1,
                        Name = "Bulbasaur",
                        ImageUrl = "bulbasaur.png",
                        PokemonTypes = { grassType }
                    },
                    new Pokemon
                    {
                        OriginalId = 4,
                        Name = "Charmander",
                        ImageUrl = "charmander.png",
                        PokemonTypes = { fireType }
                    },
                    new Pokemon
                    {
                        OriginalId = 7,
                        Name = "Squirtle",
                        ImageUrl = "squirtle.png",
                        PokemonTypes = { waterType }
                    });

                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
