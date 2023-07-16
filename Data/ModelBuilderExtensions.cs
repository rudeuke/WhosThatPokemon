using Microsoft.EntityFrameworkCore;

namespace WhosThatPokemon.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Type>()
                .HasData(
                    new Models.Type { Id = 1, PokeType = TypeEnum.Normal },
                    new Models.Type { Id = 2, PokeType = TypeEnum.Fighting },
                    new Models.Type { Id = 3, PokeType = TypeEnum.Flying },
                    new Models.Type { Id = 4, PokeType = TypeEnum.Poison },
                    new Models.Type { Id = 5, PokeType = TypeEnum.Ground },
                    new Models.Type { Id = 6, PokeType = TypeEnum.Rock },
                    new Models.Type { Id = 7, PokeType = TypeEnum.Bug },
                    new Models.Type { Id = 8, PokeType = TypeEnum.Ghost },
                    new Models.Type { Id = 9, PokeType = TypeEnum.Steel },
                    new Models.Type { Id = 10, PokeType = TypeEnum.Fire },
                    new Models.Type { Id = 11, PokeType = TypeEnum.Water },
                    new Models.Type { Id = 12, PokeType = TypeEnum.Grass },
                    new Models.Type { Id = 13, PokeType = TypeEnum.Electric },
                    new Models.Type { Id = 14, PokeType = TypeEnum.Psychic },
                    new Models.Type { Id = 15, PokeType = TypeEnum.Ice },
                    new Models.Type { Id = 16, PokeType = TypeEnum.Dragon },
                    new Models.Type { Id = 17, PokeType = TypeEnum.Dark },
                    new Models.Type { Id = 18, PokeType = TypeEnum.Fairy }
                    );

            modelBuilder.Entity<Models.Type>()
                .HasMany(t => t.ResistantTo)
                .WithMany(t => t.ResistedBy)
                .UsingEntity(j => j.HasData(
                    new { ResistedById = 2, ResistantToId = 7 }, // Fighting - Resistant to Bug
                    new { ResistedById = 2, ResistantToId = 6 }, // Fighting - Resistant to Rock
                    new { ResistedById = 2, ResistantToId = 17 }, // Fighting - Resistant to Dark
                    new { ResistedById = 3, ResistantToId = 12 }, // Flying - Resistant to Electric
                    new { ResistedById = 3, ResistantToId = 2 }, // Flying - Resistant to Fighting
                    new { ResistedById = 3, ResistantToId = 7 }, // Flying - Resistant to Bug
                    new { ResistedById = 4, ResistantToId = 12 }, // Poison - Resistant to Electric
                    new { ResistedById = 4, ResistantToId = 4 }, // Poison - Resistant to Poison (itself)
                    new { ResistedById = 4, ResistantToId = 2 }, // Poison - Resistant to Fighting
                    new { ResistedById = 4, ResistantToId = 7 }, // Poison - Resistant to Bug
                    new { ResistedById = 4, ResistantToId = 18 }, // Poison - Resistant to Fairy
                    new { ResistedById = 5, ResistantToId = 4 }, // Ground - Resistant to Poison
                    new { ResistedById = 5, ResistantToId = 6 }, // Ground - Resistant to Rock
                    new { ResistedById = 6, ResistantToId = 1 }, // Rock - Resistant to Normal
                    new { ResistedById = 6, ResistantToId = 10 }, // Rock - Resistant to Fire
                    new { ResistedById = 6, ResistantToId = 4 }, // Rock - Resistant to Poison
                    new { ResistedById = 6, ResistantToId = 3 }, // Rock - Resistant to Flying
                    new { ResistedById = 7, ResistantToId = 12 }, // Bug - Resistant to Electric
                    new { ResistedById = 7, ResistantToId = 2 }, // Bug - Resistant to Fighting
                    new { ResistedById = 7, ResistantToId = 5 }, // Bug - Resistant to Ground
                    new { ResistedById = 8, ResistantToId = 4 }, // Ghost - Resistant to Poison
                    new { ResistedById = 8, ResistantToId = 7 }, // Ghost - Resistant to Bug
                    new { ResistedById = 9, ResistantToId = 1 }, // Steel - Resistant to Normal
                    new { ResistedById = 9, ResistantToId = 12 }, // Steel - Resistant to Electric
                    new { ResistedById = 9, ResistantToId = 15 }, // Steel - Resistant to Ice
                    new { ResistedById = 9, ResistantToId = 2 }, // Steel - Resistant to Fighting
                    new { ResistedById = 9, ResistantToId = 14 }, // Steel - Resistant to Psychic
                    new { ResistedById = 9, ResistantToId = 7 }, // Steel - Resistant to Bug
                    new { ResistedById = 9, ResistantToId = 6 }, // Steel - Resistant to Rock
                    new { ResistedById = 9, ResistantToId = 16 }, // Steel - Resistant to Dragon
                    new { ResistedById = 9, ResistantToId = 9 }, // Steel - Resistant to Steel (itself)
                    new { ResistedById = 9, ResistantToId = 18 }, // Steel - Resistant to Fairy
                    new { ResistedById = 10, ResistantToId = 10 }, // Fire - Resistant to Fire (itself)
                    new { ResistedById = 10, ResistantToId = 12 }, // Fire - Resistant to Electric
                    new { ResistedById = 10, ResistantToId = 15 }, // Fire - Resistant to Ice
                    new { ResistedById = 10, ResistantToId = 7 }, // Fire - Resistant to Bug
                    new { ResistedById = 10, ResistantToId = 9 }, // Fire - Resistant to Steel
                    new { ResistedById = 10, ResistantToId = 18 }, // Fire - Resistant to Fairy
                    new { ResistedById = 11, ResistantToId = 10 }, // Water - Resistant to Fire
                    new { ResistedById = 11, ResistantToId = 11 }, // Water - Resistant to Water (itself)
                    new { ResistedById = 11, ResistantToId = 15 }, // Water - Resistant to Ice
                    new { ResistedById = 11, ResistantToId = 9 }, // Water - Resistant to Steel
                    new { ResistedById = 12, ResistantToId = 11 }, // Grass - Resistant to Water
                    new { ResistedById = 12, ResistantToId = 12 }, // Grass - Resistant to Grass (itself)
                    new { ResistedById = 12, ResistantToId = 13 }, // Grass - Resistant to Electric
                    new { ResistedById = 12, ResistantToId = 5 }, // Grass - Resistant to Ground
                    new { ResistedById = 13, ResistantToId = 13 }, // Electric - Resistant to Electric (itself)
                    new { ResistedById = 13, ResistantToId = 3 }, // Electric - Resistant to Flying
                    new { ResistedById = 13, ResistantToId = 9 }, // Electric - Resistant to Steel
                    new { ResistedById = 14, ResistantToId = 2 }, // Psychic - Resistant to Fighting
                    new { ResistedById = 14, ResistantToId = 14 }, // Psychic - Resistant to Psychic (itself)
                    new { ResistedById = 15, ResistantToId = 15 }, // Ice - Resistant to Ice (itself)
                    new { ResistedById = 16, ResistantToId = 10 }, // Dragon - Resistant to Fire
                    new { ResistedById = 16, ResistantToId = 11 }, // Dragon - Resistant to Water
                    new { ResistedById = 16, ResistantToId = 12 }, // Dragon - Resistant to Grass
                    new { ResistedById = 16, ResistantToId = 13 }, // Dragon - Resistant to Electric
                    new { ResistedById = 17, ResistantToId = 8 }, // Dark - Resistant to Ghost
                    new { ResistedById = 17, ResistantToId = 17 }, // Dark - Resistant to Dark (itself)
                    new { ResistedById = 18, ResistantToId = 2 }, // Fairy - Resistant to Fighting
                    new { ResistedById = 18, ResistantToId = 7 }, // Fairy - Resistant to Bug
                    new { ResistedById = 18, ResistantToId = 17 } // Fairy - Resistant to Dark
                    ));

            modelBuilder.Entity<Models.Type>()
                .HasMany(t => t.VulnerableTo)
                .WithMany(t => t.EffectiveAgainst)
                .UsingEntity(j => j.HasData(
                    new { EffectiveAgainstId = 1, VulnerableToId = 2 }, // Normal - Vulnerable to Fighting
                    new { EffectiveAgainstId = 2, VulnerableToId = 3 }, // Fighting - Vulnerable to Flying
                    new { EffectiveAgainstId = 2, VulnerableToId = 14 }, // Fighting - Vulnerable to Psychic
                    new { EffectiveAgainstId = 2, VulnerableToId = 18 }, // Fighting - Vulnerable to Fairy
                    new { EffectiveAgainstId = 3, VulnerableToId = 6 }, // Flying - Vulnerable to Rock
                    new { EffectiveAgainstId = 3, VulnerableToId = 13 }, // Flying - Vulnerable to Electric
                    new { EffectiveAgainstId = 3, VulnerableToId = 15 }, // Flying - Vulnerable to Ice
                    new { EffectiveAgainstId = 4, VulnerableToId = 5 }, // Poison - Vulnerable to Ground
                    new { EffectiveAgainstId = 4, VulnerableToId = 14 }, // Poison - Vulnerable to Psychic
                    new { EffectiveAgainstId = 5, VulnerableToId = 11 }, // Ground - Vulnerable to Water
                    new { EffectiveAgainstId = 5, VulnerableToId = 12 }, // Ground - Vulnerable to Grass
                    new { EffectiveAgainstId = 5, VulnerableToId = 15 }, // Ground - Vulnerable to Ice
                    new { EffectiveAgainstId = 6, VulnerableToId = 11 }, // Rock - Vulnerable to Water
                    new { EffectiveAgainstId = 6, VulnerableToId = 12 }, // Rock - Vulnerable to Grass
                    new { EffectiveAgainstId = 6, VulnerableToId = 2 }, // Rock - Vulnerable to Fighting
                    new { EffectiveAgainstId = 6, VulnerableToId = 5 }, // Rock - Vulnerable to Ground
                    new { EffectiveAgainstId = 6, VulnerableToId = 9 }, // Rock - Vulnerable to Steel
                    new { EffectiveAgainstId = 7, VulnerableToId = 10 }, // Bug - Vulnerable to Fire
                    new { EffectiveAgainstId = 7, VulnerableToId = 3 }, // Bug - Vulnerable to Flying
                    new { EffectiveAgainstId = 7, VulnerableToId = 6 }, // Bug - Vulnerable to Rock
                    new { EffectiveAgainstId = 8, VulnerableToId = 8 }, // Ghost - Vulnerable to Ghost (itself)
                    new { EffectiveAgainstId = 8, VulnerableToId = 17 }, // Ghost - Vulnerable to Dark
                    new { EffectiveAgainstId = 9, VulnerableToId = 10 }, // Steel - Vulnerable to Fire
                    new { EffectiveAgainstId = 9, VulnerableToId = 2 }, // Steel - Vulnerable to Fighting
                    new { EffectiveAgainstId = 9, VulnerableToId = 5 }, // Steel - Vulnerable to Ground
                    new { EffectiveAgainstId = 10, VulnerableToId = 11 }, // Fire - Vulnerable to Water
                    new { EffectiveAgainstId = 10, VulnerableToId = 5 }, // Fire - Vulnerable to Ground
                    new { EffectiveAgainstId = 10, VulnerableToId = 6 }, // Fire - Vulnerable to Rock
                    new { EffectiveAgainstId = 11, VulnerableToId = 13 }, // Water - Vulnerable to Electric
                    new { EffectiveAgainstId = 11, VulnerableToId = 12 }, // Water - Vulnerable to Grass
                    new { EffectiveAgainstId = 12, VulnerableToId = 10 }, // Grass - Vulnerable to Fire
                    new { EffectiveAgainstId = 12, VulnerableToId = 15 }, // Grass - Vulnerable to Ice
                    new { EffectiveAgainstId = 12, VulnerableToId = 4 }, // Grass - Vulnerable to Poison
                    new { EffectiveAgainstId = 12, VulnerableToId = 3 }, // Grass - Vulnerable to Flying
                    new { EffectiveAgainstId = 12, VulnerableToId = 7 }, // Grass - Vulnerable to Bug
                    new { EffectiveAgainstId = 13, VulnerableToId = 5 }, // Electric - Vulnerable to Ground
                    new { EffectiveAgainstId = 14, VulnerableToId = 7 }, // Psychic - Vulnerable to Bug
                    new { EffectiveAgainstId = 14, VulnerableToId = 8 }, // Psychic - Vulnerable to Ghost
                    new { EffectiveAgainstId = 14, VulnerableToId = 17 }, // Psychic - Vulnerable to Dark
                    new { EffectiveAgainstId = 15, VulnerableToId = 10 }, // Ice - Vulnerable to Fire
                    new { EffectiveAgainstId = 15, VulnerableToId = 2 }, // Ice - Vulnerable to Fighting
                    new { EffectiveAgainstId = 15, VulnerableToId = 6 }, // Ice - Vulnerable to Rock
                    new { EffectiveAgainstId = 15, VulnerableToId = 9 }, // Ice - Vulnerable to Steel
                    new { EffectiveAgainstId = 16, VulnerableToId = 15 }, // Dragon - Vulnerable to Ice
                    new { EffectiveAgainstId = 16, VulnerableToId = 16 }, // Dragon - Vulnerable to Dragon (itself)
                    new { EffectiveAgainstId = 16, VulnerableToId = 18 }, // Dragon - Vulnerable to Fairy
                    new { EffectiveAgainstId = 17, VulnerableToId = 2 }, // Dark - Vulnerable to Fighting
                    new { EffectiveAgainstId = 17, VulnerableToId = 7 }, // Dark - Vulnerable to Bug
                    new { EffectiveAgainstId = 17, VulnerableToId = 18 }, // Dark - Vulnerable to Fairy
                    new { EffectiveAgainstId = 18, VulnerableToId = 4 }, // Fairy - Vulnerable to Poison
                    new { EffectiveAgainstId = 18, VulnerableToId = 9 } // Fairy - Vulnerable to Steel
                    ));

            modelBuilder.Entity<Models.Type>()
                .HasMany(t => t.UnaffectedBy)
                .WithMany(t => t.IneffectiveTo)
                .UsingEntity(j => j.HasData(
                    new { IneffectiveToId = 1, UnaffectedById = 8 }, // Normal - Unaffected by Ghost
                    new { IneffectiveToId = 3, UnaffectedById = 5 }, // Flying - Unaffected by Ground
                    new { IneffectiveToId = 5, UnaffectedById = 13 }, // Ground - Unaffected by Electric
                    new { IneffectiveToId = 8, UnaffectedById = 1 }, // Ghost - Unaffected by Normal
                    new { IneffectiveToId = 8, UnaffectedById = 2 }, // Ghost - Unaffected by Fighting
                    new { IneffectiveToId = 9, UnaffectedById = 4 }, // Steel - Unaffected by Poison
                    new { IneffectiveToId = 17, UnaffectedById = 14 }, // Dark - Unaffected by Psychic
                    new { IneffectiveToId = 18, UnaffectedById = 16 } // Fairy - Unaffected by Dragon
                    ));

            modelBuilder.Entity<Pokemon>().HasData(
                new Pokemon { Id = 1, OriginalId = 25, Name = "Pikachu", ImageUrl = "~/images/pokemons/pikachu.png" },
                new Pokemon { Id = 2, OriginalId = 1, Name = "Bulbasaur", ImageUrl = "~/images/pokemons/bulbasaur.png" },
                new Pokemon { Id = 3, OriginalId = 4, Name = "Charmander", ImageUrl = "~/images/pokemons/charmander.png" },
                new Pokemon { Id = 4, OriginalId = 7, Name = "Squirtle", ImageUrl = "~/images/pokemons/squirtle.png" }
                );

            modelBuilder.Entity<Pokemon>()
                .HasMany(p => p.PokemonTypes)
                .WithMany(p => p.Pokemons)
                .UsingEntity(j => j.HasData(
                    new { PokemonsId = 1, PokemonTypesId = 13 },
                    new { PokemonsId = 2, PokemonTypesId = 12 },
                    new { PokemonsId = 3, PokemonTypesId = 10 },
                    new { PokemonsId = 4, PokemonTypesId = 11 }
                    ));
        }
    }
}
