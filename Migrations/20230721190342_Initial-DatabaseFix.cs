using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhosThatPokemon.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabaseFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OriginalId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SilhouetteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    PokeType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.PokeType);
                });

            migrationBuilder.CreateTable(
                name: "PokemonType",
                columns: table => new
                {
                    PokemonTypesPokeType = table.Column<int>(type: "int", nullable: false),
                    PokemonsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonType", x => new { x.PokemonTypesPokeType, x.PokemonsId });
                    table.ForeignKey(
                        name: "FK_PokemonType_Pokemons_PokemonsId",
                        column: x => x.PokemonsId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonType_Types_PokemonTypesPokeType",
                        column: x => x.PokemonTypesPokeType,
                        principalTable: "Types",
                        principalColumn: "PokeType",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TypeType",
                columns: table => new
                {
                    ResistantToPokeType = table.Column<int>(type: "int", nullable: false),
                    ResistedByPokeType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeType", x => new { x.ResistantToPokeType, x.ResistedByPokeType });
                    table.ForeignKey(
                        name: "FK_TypeType_Types_ResistantToPokeType",
                        column: x => x.ResistantToPokeType,
                        principalTable: "Types",
                        principalColumn: "PokeType",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TypeType_Types_ResistedByPokeType",
                        column: x => x.ResistedByPokeType,
                        principalTable: "Types",
                        principalColumn: "PokeType");
                });

            migrationBuilder.CreateTable(
                name: "TypeType1",
                columns: table => new
                {
                    EffectiveAgainstPokeType = table.Column<int>(type: "int", nullable: false),
                    VulnerableToPokeType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeType1", x => new { x.EffectiveAgainstPokeType, x.VulnerableToPokeType });
                    table.ForeignKey(
                        name: "FK_TypeType1_Types_EffectiveAgainstPokeType",
                        column: x => x.EffectiveAgainstPokeType,
                        principalTable: "Types",
                        principalColumn: "PokeType",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TypeType1_Types_VulnerableToPokeType",
                        column: x => x.VulnerableToPokeType,
                        principalTable: "Types",
                        principalColumn: "PokeType");
                });

            migrationBuilder.CreateTable(
                name: "TypeType2",
                columns: table => new
                {
                    IneffectiveToPokeType = table.Column<int>(type: "int", nullable: false),
                    UnaffectedByPokeType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeType2", x => new { x.IneffectiveToPokeType, x.UnaffectedByPokeType });
                    table.ForeignKey(
                        name: "FK_TypeType2_Types_IneffectiveToPokeType",
                        column: x => x.IneffectiveToPokeType,
                        principalTable: "Types",
                        principalColumn: "PokeType",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TypeType2_Types_UnaffectedByPokeType",
                        column: x => x.UnaffectedByPokeType,
                        principalTable: "Types",
                        principalColumn: "PokeType");
                });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "ImageUrl", "Name", "OriginalId", "SilhouetteUrl" },
                values: new object[,]
                {
                    { 1, "pikachu.png", "Pikachu", 25, null },
                    { 2, "bulbasaur.png", "Bulbasaur", 1, null },
                    { 3, "charmander.png", "Charmander", 4, null },
                    { 4, "squirtle.png", "Squirtle", 7, null }
                });

            migrationBuilder.InsertData(
                table: "Types",
                column: "PokeType",
                values: new object[]
                {
                    0,
                    1,
                    2,
                    3,
                    4,
                    5,
                    6,
                    7,
                    8,
                    9,
                    10,
                    11,
                    12,
                    13,
                    14,
                    15,
                    16,
                    17
                });

            migrationBuilder.InsertData(
                table: "PokemonType",
                columns: new[] { "PokemonTypesPokeType", "PokemonsId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 2, 4 },
                    { 3, 2 },
                    { 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "TypeType",
                columns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                values: new object[,]
                {
                    { 0, 12 },
                    { 0, 16 },
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 12 },
                    { 1, 15 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 15 },
                    { 3, 1 },
                    { 3, 3 },
                    { 3, 7 },
                    { 3, 9 },
                    { 3, 11 },
                    { 3, 15 },
                    { 3, 16 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 15 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 5 },
                    { 5, 16 },
                    { 6, 7 },
                    { 6, 9 },
                    { 6, 10 },
                    { 6, 11 },
                    { 6, 16 },
                    { 6, 17 },
                    { 7, 7 },
                    { 7, 8 },
                    { 7, 12 },
                    { 7, 13 },
                    { 8, 3 },
                    { 8, 11 },
                    { 9, 4 },
                    { 9, 12 },
                    { 10, 10 },
                    { 10, 16 },
                    { 11, 1 },
                    { 11, 6 },
                    { 11, 7 },
                    { 11, 9 },
                    { 11, 13 },
                    { 11, 16 },
                    { 11, 17 },
                    { 12, 6 },
                    { 12, 8 },
                    { 12, 16 },
                    { 13, 14 },
                    { 14, 6 },
                    { 14, 14 },
                    { 14, 17 },
                    { 15, 16 },
                    { 16, 1 },
                    { 16, 2 },
                    { 16, 4 },
                    { 16, 16 },
                    { 17, 1 },
                    { 17, 7 },
                    { 17, 16 }
                });

            migrationBuilder.InsertData(
                table: "TypeType1",
                columns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                values: new object[,]
                {
                    { 0, 6 },
                    { 1, 2 },
                    { 1, 8 },
                    { 1, 12 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 1 },
                    { 3, 5 },
                    { 3, 7 },
                    { 3, 9 },
                    { 3, 11 },
                    { 4, 8 },
                    { 5, 1 },
                    { 5, 6 },
                    { 5, 12 },
                    { 5, 16 },
                    { 6, 9 },
                    { 6, 10 },
                    { 6, 17 },
                    { 7, 8 },
                    { 7, 10 },
                    { 8, 2 },
                    { 8, 3 },
                    { 8, 5 },
                    { 9, 4 },
                    { 9, 5 },
                    { 9, 12 },
                    { 10, 11 },
                    { 10, 13 },
                    { 10, 14 },
                    { 11, 1 },
                    { 11, 9 },
                    { 11, 12 },
                    { 12, 2 },
                    { 12, 3 },
                    { 12, 6 },
                    { 12, 8 },
                    { 12, 16 },
                    { 13, 13 },
                    { 13, 14 },
                    { 14, 6 },
                    { 14, 11 },
                    { 14, 17 },
                    { 15, 5 },
                    { 15, 15 },
                    { 15, 17 },
                    { 16, 1 },
                    { 16, 6 },
                    { 16, 8 },
                    { 17, 7 },
                    { 17, 16 }
                });

            migrationBuilder.InsertData(
                table: "TypeType2",
                columns: new[] { "IneffectiveToPokeType", "UnaffectedByPokeType" },
                values: new object[,]
                {
                    { 0, 13 },
                    { 8, 4 },
                    { 9, 8 },
                    { 13, 0 },
                    { 13, 6 },
                    { 14, 10 },
                    { 16, 7 },
                    { 17, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonType_PokemonsId",
                table: "PokemonType",
                column: "PokemonsId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeType_ResistedByPokeType",
                table: "TypeType",
                column: "ResistedByPokeType");

            migrationBuilder.CreateIndex(
                name: "IX_TypeType1_VulnerableToPokeType",
                table: "TypeType1",
                column: "VulnerableToPokeType");

            migrationBuilder.CreateIndex(
                name: "IX_TypeType2_UnaffectedByPokeType",
                table: "TypeType2",
                column: "UnaffectedByPokeType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonType");

            migrationBuilder.DropTable(
                name: "TypeType");

            migrationBuilder.DropTable(
                name: "TypeType1");

            migrationBuilder.DropTable(
                name: "TypeType2");

            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
