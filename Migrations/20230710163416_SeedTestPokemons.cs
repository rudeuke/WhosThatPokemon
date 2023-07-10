using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhosThatPokemon.Migrations
{
    /// <inheritdoc />
    public partial class SeedTestPokemons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "ImageUrl", "Name", "SilhouetteUrl" },
                values: new object[,]
                {
                    { 1, "~/images/pokemons/pikachu.png", "Pikachu", null },
                    { 2, "~/images/pokemons/bulbasaur.png", "Bulbasaur", null },
                    { 3, "~/images/pokemons/charmander.png", "Charmander", null },
                    { 4, "~/images/pokemons/squirtle.png", "Squirtle", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
