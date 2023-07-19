namespace WhosThatPokemon.Data
{
    public static class DatabaseSeeder
    {
        public static bool DeleteAllPokemons(ApplicationDbContext db)
        {
            try
            {
                db.Pokemons.RemoveRange(db.Pokemons);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool InsertPokemons(ApplicationDbContext db)
        {
            try 
            {
                var pokemonTypes = db.Types.ToList();

                if (pokemonTypes.Count != Enum.GetNames(typeof(TypeEnum)).Length)
                {
                    throw new Exception("Pokemon types missing");
                }

                var electricType = pokemonTypes.FirstOrDefault(t => t.PokeType == TypeEnum.Electric);
                var grassType = pokemonTypes.FirstOrDefault(t => t.PokeType == TypeEnum.Grass);
                var fireType = pokemonTypes.FirstOrDefault(t => t.PokeType == TypeEnum.Fire);
                var waterType = pokemonTypes.FirstOrDefault(t => t.PokeType == TypeEnum.Water);

                db.Pokemons.AddRange(
                    new Pokemon
                    {
                        OriginalId = 25,
                        Name = "Pikachu",
                        ImageUrl = "~/images/pokemons/pikachu.png",
                        PokemonTypes = { electricType }
                    },
                    new Pokemon
                    {
                        OriginalId = 1,
                        Name = "Bulbasaur",
                        ImageUrl = "~/images/pokemons/bulbasaur.png",
                        PokemonTypes = { grassType }
                    },
                    new Pokemon
                    {
                        OriginalId = 4,
                        Name = "Charmander",
                        ImageUrl = "~/images/pokemons/charmander.png",
                        PokemonTypes = { fireType }
                    },
                    new Pokemon
                    {
                        OriginalId = 7,
                        Name = "Squirtle",
                        ImageUrl = "~/images/pokemons/squirtle.png",
                        PokemonTypes = { waterType }
                    });

                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
