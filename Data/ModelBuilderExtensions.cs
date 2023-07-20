using Microsoft.EntityFrameworkCore;

namespace WhosThatPokemon.Data
{
    public static class ModelBuilderExtensions
    {
        // Configuring methods contain example data for the database

        public static void ConfigureTypes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Type>()
                .HasData(
                    new Models.Type { PokeType = TypeEnum.Normal },
                    new Models.Type { PokeType = TypeEnum.Fighting },
                    new Models.Type { PokeType = TypeEnum.Flying },
                    new Models.Type { PokeType = TypeEnum.Poison },
                    new Models.Type { PokeType = TypeEnum.Ground },
                    new Models.Type { PokeType = TypeEnum.Rock },
                    new Models.Type { PokeType = TypeEnum.Bug },
                    new Models.Type { PokeType = TypeEnum.Ghost },
                    new Models.Type { PokeType = TypeEnum.Steel },
                    new Models.Type { PokeType = TypeEnum.Fire },
                    new Models.Type { PokeType = TypeEnum.Water },
                    new Models.Type { PokeType = TypeEnum.Grass },
                    new Models.Type { PokeType = TypeEnum.Electric },
                    new Models.Type { PokeType = TypeEnum.Psychic },
                    new Models.Type { PokeType = TypeEnum.Ice },
                    new Models.Type { PokeType = TypeEnum.Dragon },
                    new Models.Type { PokeType = TypeEnum.Dark },
                    new Models.Type { PokeType = TypeEnum.Fairy }
                );

            modelBuilder.Entity<Models.Type>()
                .HasMany(t => t.ResistantTo)
                .WithMany(t => t.ResistedBy)
                .UsingEntity(j => j.HasData(
                    new { ResistedByPokeType = TypeEnum.Fighting, ResistantToPokeType = TypeEnum.Bug }, // Fighting - Resistant to Bug
                    new { ResistedByPokeType = TypeEnum.Fighting, ResistantToPokeType = TypeEnum.Rock }, // Fighting - Resistant to Rock
                    new { ResistedByPokeType = TypeEnum.Fighting, ResistantToPokeType = TypeEnum.Dark }, // Fighting - Resistant to Dark
                    new { ResistedByPokeType = TypeEnum.Flying, ResistantToPokeType = TypeEnum.Grass }, // Flying - Resistant to Electric
                    new { ResistedByPokeType = TypeEnum.Flying, ResistantToPokeType = TypeEnum.Fighting }, // Flying - Resistant to Fighting
                    new { ResistedByPokeType = TypeEnum.Flying, ResistantToPokeType = TypeEnum.Bug }, // Flying - Resistant to Bug
                    new { ResistedByPokeType = TypeEnum.Poison, ResistantToPokeType = TypeEnum.Grass }, // Poison - Resistant to Electric
                    new { ResistedByPokeType = TypeEnum.Poison, ResistantToPokeType = TypeEnum.Poison }, // Poison - Resistant to Poison (itself)
                    new { ResistedByPokeType = TypeEnum.Poison, ResistantToPokeType = TypeEnum.Fighting }, // Poison - Resistant to Fighting
                    new { ResistedByPokeType = TypeEnum.Poison, ResistantToPokeType = TypeEnum.Bug }, // Poison - Resistant to Bug
                    new { ResistedByPokeType = TypeEnum.Poison, ResistantToPokeType = TypeEnum.Fairy }, // Poison - Resistant to Fairy
                    new { ResistedByPokeType = TypeEnum.Ground, ResistantToPokeType = TypeEnum.Poison }, // Ground - Resistant to Poison
                    new { ResistedByPokeType = TypeEnum.Ground, ResistantToPokeType = TypeEnum.Rock }, // Ground - Resistant to Rock
                    new { ResistedByPokeType = TypeEnum.Rock, ResistantToPokeType = TypeEnum.Normal }, // Rock - Resistant to Normal
                    new { ResistedByPokeType = TypeEnum.Rock, ResistantToPokeType = TypeEnum.Fire }, // Rock - Resistant to Fire
                    new { ResistedByPokeType = TypeEnum.Rock, ResistantToPokeType = TypeEnum.Poison }, // Rock - Resistant to Poison
                    new { ResistedByPokeType = TypeEnum.Rock, ResistantToPokeType = TypeEnum.Flying }, // Rock - Resistant to Flying
                    new { ResistedByPokeType = TypeEnum.Bug, ResistantToPokeType = TypeEnum.Grass }, // Bug - Resistant to Electric
                    new { ResistedByPokeType = TypeEnum.Bug, ResistantToPokeType = TypeEnum.Fighting }, // Bug - Resistant to Fighting
                    new { ResistedByPokeType = TypeEnum.Bug, ResistantToPokeType = TypeEnum.Ground }, // Bug - Resistant to Ground
                    new { ResistedByPokeType = TypeEnum.Ghost, ResistantToPokeType = TypeEnum.Poison }, // Ghost - Resistant to Poison
                    new { ResistedByPokeType = TypeEnum.Ghost, ResistantToPokeType = TypeEnum.Bug }, // Ghost - Resistant to Bug
                    new { ResistedByPokeType = TypeEnum.Steel, ResistantToPokeType = TypeEnum.Normal }, // Steel - Resistant to Normal
                    new { ResistedByPokeType = TypeEnum.Steel, ResistantToPokeType = TypeEnum.Grass }, // Steel - Resistant to Electric
                    new { ResistedByPokeType = TypeEnum.Steel, ResistantToPokeType = TypeEnum.Ice }, // Steel - Resistant to Ice
                    new { ResistedByPokeType = TypeEnum.Steel, ResistantToPokeType = TypeEnum.Fighting }, // Steel - Resistant to Fighting
                    new { ResistedByPokeType = TypeEnum.Steel, ResistantToPokeType = TypeEnum.Psychic }, // Steel - Resistant to Psychic
                    new { ResistedByPokeType = TypeEnum.Steel, ResistantToPokeType = TypeEnum.Bug }, // Steel - Resistant to Bug
                    new { ResistedByPokeType = TypeEnum.Steel, ResistantToPokeType = TypeEnum.Rock }, // Steel - Resistant to Rock
                    new { ResistedByPokeType = TypeEnum.Steel, ResistantToPokeType = TypeEnum.Dragon }, // Steel - Resistant to Dragon
                    new { ResistedByPokeType = TypeEnum.Steel, ResistantToPokeType = TypeEnum.Steel }, // Steel - Resistant to Steel (itself)
                    new { ResistedByPokeType = TypeEnum.Steel, ResistantToPokeType = TypeEnum.Fairy }, // Steel - Resistant to Fairy
                    new { ResistedByPokeType = TypeEnum.Fire, ResistantToPokeType = TypeEnum.Fire }, // Fire - Resistant to Fire (itself)
                    new { ResistedByPokeType = TypeEnum.Fire, ResistantToPokeType = TypeEnum.Grass }, // Fire - Resistant to Electric
                    new { ResistedByPokeType = TypeEnum.Fire, ResistantToPokeType = TypeEnum.Ice }, // Fire - Resistant to Ice
                    new { ResistedByPokeType = TypeEnum.Fire, ResistantToPokeType = TypeEnum.Bug }, // Fire - Resistant to Bug
                    new { ResistedByPokeType = TypeEnum.Fire, ResistantToPokeType = TypeEnum.Steel }, // Fire - Resistant to Steel
                    new { ResistedByPokeType = TypeEnum.Fire, ResistantToPokeType = TypeEnum.Fairy }, // Fire - Resistant to Fairy
                    new { ResistedByPokeType = TypeEnum.Water, ResistantToPokeType = TypeEnum.Fire }, // Water - Resistant to Fire
                    new { ResistedByPokeType = TypeEnum.Water, ResistantToPokeType = TypeEnum.Water }, // Water - Resistant to Water (itself)
                    new { ResistedByPokeType = TypeEnum.Water, ResistantToPokeType = TypeEnum.Ice }, // Water - Resistant to Ice
                    new { ResistedByPokeType = TypeEnum.Water, ResistantToPokeType = TypeEnum.Steel }, // Water - Resistant to Steel
                    new { ResistedByPokeType = TypeEnum.Grass, ResistantToPokeType = TypeEnum.Water }, // Grass - Resistant to Water
                    new { ResistedByPokeType = TypeEnum.Grass, ResistantToPokeType = TypeEnum.Grass }, // Grass - Resistant to Grass (itself)
                    new { ResistedByPokeType = TypeEnum.Grass, ResistantToPokeType = TypeEnum.Electric }, // Grass - Resistant to Electric
                    new { ResistedByPokeType = TypeEnum.Grass, ResistantToPokeType = TypeEnum.Ground }, // Grass - Resistant to Ground
                    new { ResistedByPokeType = TypeEnum.Electric, ResistantToPokeType = TypeEnum.Electric }, // Electric - Resistant to Electric (itself)
                    new { ResistedByPokeType = TypeEnum.Electric, ResistantToPokeType = TypeEnum.Flying }, // Electric - Resistant to Flying
                    new { ResistedByPokeType = TypeEnum.Electric, ResistantToPokeType = TypeEnum.Steel }, // Electric - Resistant to Steel
                    new { ResistedByPokeType = TypeEnum.Psychic, ResistantToPokeType = TypeEnum.Fighting }, // Psychic - Resistant to Fighting
                    new { ResistedByPokeType = TypeEnum.Psychic, ResistantToPokeType = TypeEnum.Psychic }, // Psychic - Resistant to Psychic (itself)
                    new { ResistedByPokeType = TypeEnum.Ice, ResistantToPokeType = TypeEnum.Ice }, // Ice - Resistant to Ice (itself)
                    new { ResistedByPokeType = TypeEnum.Dragon, ResistantToPokeType = TypeEnum.Fire }, // Dragon - Resistant to Fire
                    new { ResistedByPokeType = TypeEnum.Dragon, ResistantToPokeType = TypeEnum.Water }, // Dragon - Resistant to Water
                    new { ResistedByPokeType = TypeEnum.Dragon, ResistantToPokeType = TypeEnum.Grass }, // Dragon - Resistant to Grass
                    new { ResistedByPokeType = TypeEnum.Dragon, ResistantToPokeType = TypeEnum.Electric }, // Dragon - Resistant to Electric
                    new { ResistedByPokeType = TypeEnum.Dark, ResistantToPokeType = TypeEnum.Ghost }, // Dark - Resistant to Ghost
                    new { ResistedByPokeType = TypeEnum.Dark, ResistantToPokeType = TypeEnum.Dark }, // Dark - Resistant to Dark (itself)
                    new { ResistedByPokeType = TypeEnum.Fairy, ResistantToPokeType = TypeEnum.Fighting }, // Fairy - Resistant to Fighting
                    new { ResistedByPokeType = TypeEnum.Fairy, ResistantToPokeType = TypeEnum.Bug }, // Fairy - Resistant to Bug
                    new { ResistedByPokeType = TypeEnum.Fairy, ResistantToPokeType = TypeEnum.Dark } // Fairy - Resistant to Dark
                ));

            modelBuilder.Entity<Models.Type>()
                .HasMany(t => t.VulnerableTo)
                .WithMany(t => t.EffectiveAgainst)
                .UsingEntity(j => j.HasData(
                    new { EffectiveAgainstPokeType = TypeEnum.Normal, VulnerableToPokeType = TypeEnum.Fighting }, // Normal - Vulnerable to Fighting
                    new { EffectiveAgainstPokeType = TypeEnum.Fighting, VulnerableToPokeType = TypeEnum.Flying }, // Fighting - Vulnerable to Flying
                    new { EffectiveAgainstPokeType = TypeEnum.Fighting, VulnerableToPokeType = TypeEnum.Psychic }, // Fighting - Vulnerable to Psychic
                    new { EffectiveAgainstPokeType = TypeEnum.Fighting, VulnerableToPokeType = TypeEnum.Fairy }, // Fighting - Vulnerable to Fairy
                    new { EffectiveAgainstPokeType = TypeEnum.Flying, VulnerableToPokeType = TypeEnum.Rock }, // Flying - Vulnerable to Rock
                    new { EffectiveAgainstPokeType = TypeEnum.Flying, VulnerableToPokeType = TypeEnum.Electric }, // Flying - Vulnerable to Electric
                    new { EffectiveAgainstPokeType = TypeEnum.Flying, VulnerableToPokeType = TypeEnum.Ice }, // Flying - Vulnerable to Ice
                    new { EffectiveAgainstPokeType = TypeEnum.Poison, VulnerableToPokeType = TypeEnum.Ground }, // Poison - Vulnerable to Ground
                    new { EffectiveAgainstPokeType = TypeEnum.Poison, VulnerableToPokeType = TypeEnum.Psychic }, // Poison - Vulnerable to Psychic
                    new { EffectiveAgainstPokeType = TypeEnum.Ground, VulnerableToPokeType = TypeEnum.Water }, // Ground - Vulnerable to Water
                    new { EffectiveAgainstPokeType = TypeEnum.Ground, VulnerableToPokeType = TypeEnum.Grass }, // Ground - Vulnerable to Grass
                    new { EffectiveAgainstPokeType = TypeEnum.Ground, VulnerableToPokeType = TypeEnum.Ice }, // Ground - Vulnerable to Ice
                    new { EffectiveAgainstPokeType = TypeEnum.Rock, VulnerableToPokeType = TypeEnum.Water }, // Rock - Vulnerable to Water
                    new { EffectiveAgainstPokeType = TypeEnum.Rock, VulnerableToPokeType = TypeEnum.Grass }, // Rock - Vulnerable to Grass
                    new { EffectiveAgainstPokeType = TypeEnum.Rock, VulnerableToPokeType = TypeEnum.Fighting }, // Rock - Vulnerable to Fighting
                    new { EffectiveAgainstPokeType = TypeEnum.Rock, VulnerableToPokeType = TypeEnum.Ground }, // Rock - Vulnerable to Ground
                    new { EffectiveAgainstPokeType = TypeEnum.Rock, VulnerableToPokeType = TypeEnum.Steel }, // Rock - Vulnerable to Steel
                    new { EffectiveAgainstPokeType = TypeEnum.Bug, VulnerableToPokeType = TypeEnum.Fire }, // Bug - Vulnerable to Fire
                    new { EffectiveAgainstPokeType = TypeEnum.Bug, VulnerableToPokeType = TypeEnum.Flying }, // Bug - Vulnerable to Flying
                    new { EffectiveAgainstPokeType = TypeEnum.Bug, VulnerableToPokeType = TypeEnum.Rock }, // Bug - Vulnerable to Rock
                    new { EffectiveAgainstPokeType = TypeEnum.Ghost, VulnerableToPokeType = TypeEnum.Ghost }, // Ghost - Vulnerable to Ghost (itself)
                    new { EffectiveAgainstPokeType = TypeEnum.Ghost, VulnerableToPokeType = TypeEnum.Dark }, // Ghost - Vulnerable to Dark
                    new { EffectiveAgainstPokeType = TypeEnum.Steel, VulnerableToPokeType = TypeEnum.Fire }, // Steel - Vulnerable to Fire
                    new { EffectiveAgainstPokeType = TypeEnum.Steel, VulnerableToPokeType = TypeEnum.Fighting }, // Steel - Vulnerable to Fighting
                    new { EffectiveAgainstPokeType = TypeEnum.Steel, VulnerableToPokeType = TypeEnum.Ground }, // Steel - Vulnerable to Ground
                    new { EffectiveAgainstPokeType = TypeEnum.Fire, VulnerableToPokeType = TypeEnum.Water }, // Fire - Vulnerable to Water
                    new { EffectiveAgainstPokeType = TypeEnum.Fire, VulnerableToPokeType = TypeEnum.Ground }, // Fire - Vulnerable to Ground
                    new { EffectiveAgainstPokeType = TypeEnum.Fire, VulnerableToPokeType = TypeEnum.Rock }, // Fire - Vulnerable to Rock
                    new { EffectiveAgainstPokeType = TypeEnum.Water, VulnerableToPokeType = TypeEnum.Electric }, // Water - Vulnerable to Electric
                    new { EffectiveAgainstPokeType = TypeEnum.Water, VulnerableToPokeType = TypeEnum.Grass }, // Water - Vulnerable to Grass
                    new { EffectiveAgainstPokeType = TypeEnum.Grass, VulnerableToPokeType = TypeEnum.Fire }, // Grass - Vulnerable to Fire
                    new { EffectiveAgainstPokeType = TypeEnum.Grass, VulnerableToPokeType = TypeEnum.Ice }, // Grass - Vulnerable to Ice
                    new { EffectiveAgainstPokeType = TypeEnum.Grass, VulnerableToPokeType = TypeEnum.Poison }, // Grass - Vulnerable to Poison
                    new { EffectiveAgainstPokeType = TypeEnum.Grass, VulnerableToPokeType = TypeEnum.Flying }, // Grass - Vulnerable to Flying
                    new { EffectiveAgainstPokeType = TypeEnum.Grass, VulnerableToPokeType = TypeEnum.Bug }, // Grass - Vulnerable to Bug
                    new { EffectiveAgainstPokeType = TypeEnum.Electric, VulnerableToPokeType = TypeEnum.Ground }, // Electric - Vulnerable to Ground
                    new { EffectiveAgainstPokeType = TypeEnum.Psychic, VulnerableToPokeType = TypeEnum.Bug }, // Psychic - Vulnerable to Bug
                    new { EffectiveAgainstPokeType = TypeEnum.Psychic, VulnerableToPokeType = TypeEnum.Ghost }, // Psychic - Vulnerable to Ghost
                    new { EffectiveAgainstPokeType = TypeEnum.Psychic, VulnerableToPokeType = TypeEnum.Dark }, // Psychic - Vulnerable to Dark
                    new { EffectiveAgainstPokeType = TypeEnum.Ice, VulnerableToPokeType = TypeEnum.Fire }, // Ice - Vulnerable to Fire
                    new { EffectiveAgainstPokeType = TypeEnum.Ice, VulnerableToPokeType = TypeEnum.Fighting }, // Ice - Vulnerable to Fighting
                    new { EffectiveAgainstPokeType = TypeEnum.Ice, VulnerableToPokeType = TypeEnum.Rock }, // Ice - Vulnerable to Rock
                    new { EffectiveAgainstPokeType = TypeEnum.Ice, VulnerableToPokeType = TypeEnum.Steel }, // Ice - Vulnerable to Steel
                    new { EffectiveAgainstPokeType = TypeEnum.Dragon, VulnerableToPokeType = TypeEnum.Ice }, // Dragon - Vulnerable to Ice
                    new { EffectiveAgainstPokeType = TypeEnum.Dragon, VulnerableToPokeType = TypeEnum.Dragon }, // Dragon - Vulnerable to Dragon (itself)
                    new { EffectiveAgainstPokeType = TypeEnum.Dragon, VulnerableToPokeType = TypeEnum.Fairy }, // Dragon - Vulnerable to Fairy
                    new { EffectiveAgainstPokeType = TypeEnum.Dark, VulnerableToPokeType = TypeEnum.Fighting }, // Dark - Vulnerable to Fighting
                    new { EffectiveAgainstPokeType = TypeEnum.Dark, VulnerableToPokeType = TypeEnum.Bug }, // Dark - Vulnerable to Bug
                    new { EffectiveAgainstPokeType = TypeEnum.Dark, VulnerableToPokeType = TypeEnum.Fairy }, // Dark - Vulnerable to Fairy
                    new { EffectiveAgainstPokeType = TypeEnum.Fairy, VulnerableToPokeType = TypeEnum.Poison }, // Fairy - Vulnerable to Poison
                    new { EffectiveAgainstPokeType = TypeEnum.Fairy, VulnerableToPokeType = TypeEnum.Steel } // Fairy - Vulnerable to Steel
                ));

            modelBuilder.Entity<Models.Type>()
                .HasMany(t => t.UnaffectedBy)
                .WithMany(t => t.IneffectiveTo)
                .UsingEntity(j => j.HasData(
                    new { IneffectiveToPokeType = TypeEnum.Normal, UnaffectedByPokeType = TypeEnum.Ghost }, // Normal - Unaffected by Ghost
                    new { IneffectiveToPokeType = TypeEnum.Flying, UnaffectedByPokeType = TypeEnum.Ground }, // Flying - Unaffected by Ground
                    new { IneffectiveToPokeType = TypeEnum.Ground, UnaffectedByPokeType = TypeEnum.Electric }, // Ground - Unaffected by Electric
                    new { IneffectiveToPokeType = TypeEnum.Ghost, UnaffectedByPokeType = TypeEnum.Normal }, // Ghost - Unaffected by Normal
                    new { IneffectiveToPokeType = TypeEnum.Ghost, UnaffectedByPokeType = TypeEnum.Fighting }, // Ghost - Unaffected by Fighting
                    new { IneffectiveToPokeType = TypeEnum.Steel, UnaffectedByPokeType = TypeEnum.Poison }, // Steel - Unaffected by Poison
                    new { IneffectiveToPokeType = TypeEnum.Dark, UnaffectedByPokeType = TypeEnum.Psychic }, // Dark - Unaffected by Psychic
                    new { IneffectiveToPokeType = TypeEnum.Fairy, UnaffectedByPokeType = TypeEnum.Dragon } // Fairy - Unaffected by Dragon
                ));
        }

        public static void ConfigurePokemons(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>().HasData(
                new Pokemon { Id = 1, OriginalId = 25, Name = "Pikachu", ImageUrl = "pikachu.png" },
                new Pokemon { Id = 2, OriginalId = 1, Name = "Bulbasaur", ImageUrl = "bulbasaur.png" },
                new Pokemon { Id = 3, OriginalId = 4, Name = "Charmander", ImageUrl = "charmander.png" },
                new Pokemon { Id = 4, OriginalId = 7, Name = "Squirtle", ImageUrl = "squirtle.png" }
            );

            modelBuilder.Entity<Pokemon>()
                .HasMany(p => p.PokemonTypes)
                .WithMany(p => p.Pokemons)
                .UsingEntity(j => j.HasData(
                    new { PokemonsId = 1, PokemonTypesPokeType = TypeEnum.Electric },
                    new { PokemonsId = 2, PokemonTypesPokeType = TypeEnum.Grass },
                    new { PokemonsId = 3, PokemonTypesPokeType = TypeEnum.Fire },
                    new { PokemonsId = 4, PokemonTypesPokeType = TypeEnum.Water }
            ));
        }
    }
}
