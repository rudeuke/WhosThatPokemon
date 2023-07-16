using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhosThatPokemon.Migrations
{
    /// <inheritdoc />
    public partial class AddPokemonTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OriginalId",
                table: "Pokemons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokeType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonType",
                columns: table => new
                {
                    PokemonTypesId = table.Column<int>(type: "int", nullable: false),
                    PokemonsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonType", x => new { x.PokemonTypesId, x.PokemonsId });
                    table.ForeignKey(
                        name: "FK_PokemonType_Pokemons_PokemonsId",
                        column: x => x.PokemonsId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonType_Types_PokemonTypesId",
                        column: x => x.PokemonTypesId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TypeType",
                columns: table => new
                {
                    ResistantToId = table.Column<int>(type: "int", nullable: false),
                    ResistedById = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeType", x => new { x.ResistantToId, x.ResistedById });
                    table.ForeignKey(
                        name: "FK_TypeType_Types_ResistantToId",
                        column: x => x.ResistantToId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TypeType_Types_ResistedById",
                        column: x => x.ResistedById,
                        principalTable: "Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TypeType1",
                columns: table => new
                {
                    EffectiveAgainstId = table.Column<int>(type: "int", nullable: false),
                    VulnerableToId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeType1", x => new { x.EffectiveAgainstId, x.VulnerableToId });
                    table.ForeignKey(
                        name: "FK_TypeType1_Types_EffectiveAgainstId",
                        column: x => x.EffectiveAgainstId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TypeType1_Types_VulnerableToId",
                        column: x => x.VulnerableToId,
                        principalTable: "Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TypeType2",
                columns: table => new
                {
                    IneffectiveToId = table.Column<int>(type: "int", nullable: false),
                    UnaffectedById = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeType2", x => new { x.IneffectiveToId, x.UnaffectedById });
                    table.ForeignKey(
                        name: "FK_TypeType2_Types_IneffectiveToId",
                        column: x => x.IneffectiveToId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TypeType2_Types_UnaffectedById",
                        column: x => x.UnaffectedById,
                        principalTable: "Types",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "OriginalId",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 2,
                column: "OriginalId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 3,
                column: "OriginalId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 4,
                column: "OriginalId",
                value: 7);

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "PokeType" },
                values: new object[,]
                {
                    { 1, 0 },
                    { 2, 6 },
                    { 3, 9 },
                    { 4, 7 },
                    { 5, 8 },
                    { 6, 12 },
                    { 7, 11 },
                    { 8, 13 },
                    { 9, 16 },
                    { 10, 1 },
                    { 11, 2 },
                    { 12, 3 },
                    { 13, 4 },
                    { 14, 10 },
                    { 15, 5 },
                    { 16, 15 },
                    { 17, 14 },
                    { 18, 17 }
                });

            migrationBuilder.InsertData(
                table: "PokemonType",
                columns: new[] { "PokemonTypesId", "PokemonsId" },
                values: new object[,]
                {
                    { 10, 3 },
                    { 11, 4 },
                    { 12, 2 },
                    { 13, 1 }
                });

            migrationBuilder.InsertData(
                table: "TypeType",
                columns: new[] { "ResistantToId", "ResistedById" },
                values: new object[,]
                {
                    { 1, 6 },
                    { 1, 9 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 7 },
                    { 2, 9 },
                    { 2, 14 },
                    { 2, 18 },
                    { 3, 6 },
                    { 3, 13 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 8 },
                    { 5, 7 },
                    { 5, 12 },
                    { 6, 2 },
                    { 6, 5 },
                    { 6, 9 },
                    { 7, 2 },
                    { 7, 3 },
                    { 7, 4 },
                    { 7, 8 },
                    { 7, 9 },
                    { 7, 10 },
                    { 7, 18 },
                    { 8, 17 },
                    { 9, 9 },
                    { 9, 10 },
                    { 9, 11 },
                    { 9, 13 },
                    { 10, 6 },
                    { 10, 10 },
                    { 10, 11 },
                    { 10, 16 },
                    { 11, 11 },
                    { 11, 12 },
                    { 11, 16 },
                    { 12, 3 },
                    { 12, 4 },
                    { 12, 7 },
                    { 12, 9 },
                    { 12, 10 },
                    { 12, 12 },
                    { 12, 16 },
                    { 13, 12 },
                    { 13, 13 },
                    { 13, 16 },
                    { 14, 9 },
                    { 14, 14 },
                    { 15, 9 },
                    { 15, 10 },
                    { 15, 11 },
                    { 15, 15 },
                    { 16, 9 },
                    { 17, 2 },
                    { 17, 17 },
                    { 17, 18 },
                    { 18, 4 },
                    { 18, 9 },
                    { 18, 10 }
                });

            migrationBuilder.InsertData(
                table: "TypeType1",
                columns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 3 },
                    { 2, 14 },
                    { 2, 18 },
                    { 3, 6 },
                    { 3, 13 },
                    { 3, 15 },
                    { 4, 5 },
                    { 4, 14 },
                    { 5, 11 },
                    { 5, 12 },
                    { 5, 15 },
                    { 6, 2 },
                    { 6, 5 },
                    { 6, 9 },
                    { 6, 11 },
                    { 6, 12 },
                    { 7, 3 },
                    { 7, 6 },
                    { 7, 10 },
                    { 8, 8 },
                    { 8, 17 },
                    { 9, 2 },
                    { 9, 5 },
                    { 9, 10 },
                    { 10, 5 },
                    { 10, 6 },
                    { 10, 11 },
                    { 11, 12 },
                    { 11, 13 },
                    { 12, 3 },
                    { 12, 4 },
                    { 12, 7 },
                    { 12, 10 },
                    { 12, 15 },
                    { 13, 5 },
                    { 14, 7 },
                    { 14, 8 },
                    { 14, 17 },
                    { 15, 2 },
                    { 15, 6 },
                    { 15, 9 },
                    { 15, 10 },
                    { 16, 15 },
                    { 16, 16 },
                    { 16, 18 },
                    { 17, 2 },
                    { 17, 7 },
                    { 17, 18 },
                    { 18, 4 },
                    { 18, 9 }
                });

            migrationBuilder.InsertData(
                table: "TypeType2",
                columns: new[] { "IneffectiveToId", "UnaffectedById" },
                values: new object[,]
                {
                    { 1, 8 },
                    { 3, 5 },
                    { 5, 13 },
                    { 8, 1 },
                    { 8, 2 },
                    { 9, 4 },
                    { 17, 14 },
                    { 18, 16 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonType_PokemonsId",
                table: "PokemonType",
                column: "PokemonsId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeType_ResistedById",
                table: "TypeType",
                column: "ResistedById");

            migrationBuilder.CreateIndex(
                name: "IX_TypeType1_VulnerableToId",
                table: "TypeType1",
                column: "VulnerableToId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeType2_UnaffectedById",
                table: "TypeType2",
                column: "UnaffectedById");
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
                name: "Types");

            migrationBuilder.DropColumn(
                name: "OriginalId",
                table: "Pokemons");
        }
    }
}
