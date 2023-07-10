﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WhosThatPokemon.Data;

#nullable disable

namespace WhosThatPokemon.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WhosThatPokemon.Models.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SilhouetteUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pokemons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "~/images/pokemons/pikachu.png",
                            Name = "Pikachu"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "~/images/pokemons/bulbasaur.png",
                            Name = "Bulbasaur"
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "~/images/pokemons/charmander.png",
                            Name = "Charmander"
                        },
                        new
                        {
                            Id = 4,
                            ImageUrl = "~/images/pokemons/squirtle.png",
                            Name = "Squirtle"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
