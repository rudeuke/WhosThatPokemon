using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhosThatPokemon.Migrations
{
    /// <inheritdoc />
    public partial class DeleteTypeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokemonType_Types_PokemonTypesId",
                table: "PokemonType");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeType_Types_ResistantToId",
                table: "TypeType");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeType_Types_ResistedById",
                table: "TypeType");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeType1_Types_EffectiveAgainstId",
                table: "TypeType1");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeType1_Types_VulnerableToId",
                table: "TypeType1");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeType2_Types_IneffectiveToId",
                table: "TypeType2");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeType2_Types_UnaffectedById",
                table: "TypeType2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Types",
                table: "Types");

            migrationBuilder.DeleteData(
                table: "PokemonType",
                keyColumns: new[] { "PokemonTypesId", "PokemonsId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "PokemonType",
                keyColumns: new[] { "PokemonTypesId", "PokemonsId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "PokemonType",
                keyColumns: new[] { "PokemonTypesId", "PokemonsId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "PokemonType",
                keyColumns: new[] { "PokemonTypesId", "PokemonsId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 7, 18 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 8, 17 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 9, 11 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 9, 13 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 11, 12 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 13, 12 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 13, 13 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 13, 16 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 15, 10 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 15, 11 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 15, 15 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 16, 9 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 17, 17 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 17, 18 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 18, 9 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToId", "ResistedById" },
                keyValues: new object[] { 18, 10 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 8, 17 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 11, 13 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 12, 15 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 14, 8 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 15, 6 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 15, 10 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 16, 15 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 16, 16 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 16, 18 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 17, 18 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstId", "VulnerableToId" },
                keyValues: new object[] { 18, 9 });

            migrationBuilder.DeleteData(
                table: "TypeType2",
                keyColumns: new[] { "IneffectiveToId", "UnaffectedById" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "TypeType2",
                keyColumns: new[] { "IneffectiveToId", "UnaffectedById" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "TypeType2",
                keyColumns: new[] { "IneffectiveToId", "UnaffectedById" },
                keyValues: new object[] { 5, 13 });

            migrationBuilder.DeleteData(
                table: "TypeType2",
                keyColumns: new[] { "IneffectiveToId", "UnaffectedById" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "TypeType2",
                keyColumns: new[] { "IneffectiveToId", "UnaffectedById" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "TypeType2",
                keyColumns: new[] { "IneffectiveToId", "UnaffectedById" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "TypeType2",
                keyColumns: new[] { "IneffectiveToId", "UnaffectedById" },
                keyValues: new object[] { 17, 14 });

            migrationBuilder.DeleteData(
                table: "TypeType2",
                keyColumns: new[] { "IneffectiveToId", "UnaffectedById" },
                keyValues: new object[] { 18, 16 });

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 18);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Types");

            migrationBuilder.RenameColumn(
                name: "UnaffectedById",
                table: "TypeType2",
                newName: "UnaffectedByPokeType");

            migrationBuilder.RenameColumn(
                name: "IneffectiveToId",
                table: "TypeType2",
                newName: "IneffectiveToPokeType");

            migrationBuilder.RenameIndex(
                name: "IX_TypeType2_UnaffectedById",
                table: "TypeType2",
                newName: "IX_TypeType2_UnaffectedByPokeType");

            migrationBuilder.RenameColumn(
                name: "VulnerableToId",
                table: "TypeType1",
                newName: "VulnerableToPokeType");

            migrationBuilder.RenameColumn(
                name: "EffectiveAgainstId",
                table: "TypeType1",
                newName: "EffectiveAgainstPokeType");

            migrationBuilder.RenameIndex(
                name: "IX_TypeType1_VulnerableToId",
                table: "TypeType1",
                newName: "IX_TypeType1_VulnerableToPokeType");

            migrationBuilder.RenameColumn(
                name: "ResistedById",
                table: "TypeType",
                newName: "ResistedByPokeType");

            migrationBuilder.RenameColumn(
                name: "ResistantToId",
                table: "TypeType",
                newName: "ResistantToPokeType");

            migrationBuilder.RenameIndex(
                name: "IX_TypeType_ResistedById",
                table: "TypeType",
                newName: "IX_TypeType_ResistedByPokeType");

            migrationBuilder.RenameColumn(
                name: "PokemonTypesId",
                table: "PokemonType",
                newName: "PokemonTypesPokeType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Types",
                table: "Types",
                column: "PokeType");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "pikachu.png");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "bulbasaur.png");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "charmander.png");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "squirtle.png");

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
                    { 2, 15 },
                    { 3, 1 },
                    { 3, 3 },
                    { 3, 7 },
                    { 3, 9 },
                    { 3, 11 },
                    { 3, 15 },
                    { 3, 16 },
                    { 4, 3 },
                    { 4, 15 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 5 },
                    { 5, 16 },
                    { 6, 7 },
                    { 6, 10 },
                    { 6, 11 },
                    { 6, 16 },
                    { 6, 17 },
                    { 7, 7 },
                    { 7, 12 },
                    { 7, 13 },
                    { 8, 3 },
                    { 8, 11 },
                    { 9, 4 },
                    { 9, 12 },
                    { 11, 1 },
                    { 11, 6 },
                    { 11, 7 },
                    { 11, 9 },
                    { 11, 13 },
                    { 11, 17 },
                    { 12, 6 },
                    { 12, 8 },
                    { 13, 14 },
                    { 14, 6 },
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
                    { 1, 8 },
                    { 1, 12 },
                    { 2, 4 },
                    { 3, 1 },
                    { 3, 5 },
                    { 3, 7 },
                    { 3, 9 },
                    { 3, 11 },
                    { 4, 8 },
                    { 5, 1 },
                    { 5, 6 },
                    { 5, 16 },
                    { 6, 10 },
                    { 6, 17 },
                    { 7, 8 },
                    { 8, 2 },
                    { 8, 3 },
                    { 8, 5 },
                    { 9, 4 },
                    { 9, 12 },
                    { 10, 13 },
                    { 10, 14 },
                    { 11, 1 },
                    { 11, 9 },
                    { 12, 2 },
                    { 12, 6 },
                    { 12, 8 },
                    { 12, 16 },
                    { 13, 13 },
                    { 13, 14 },
                    { 14, 6 },
                    { 14, 11 },
                    { 15, 5 },
                    { 15, 15 },
                    { 15, 17 },
                    { 16, 1 },
                    { 16, 6 },
                    { 16, 8 },
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

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonType_Types_PokemonTypesPokeType",
                table: "PokemonType",
                column: "PokemonTypesPokeType",
                principalTable: "Types",
                principalColumn: "PokeType",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeType_Types_ResistantToPokeType",
                table: "TypeType",
                column: "ResistantToPokeType",
                principalTable: "Types",
                principalColumn: "PokeType",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeType_Types_ResistedByPokeType",
                table: "TypeType",
                column: "ResistedByPokeType",
                principalTable: "Types",
                principalColumn: "PokeType");

            migrationBuilder.AddForeignKey(
                name: "FK_TypeType1_Types_EffectiveAgainstPokeType",
                table: "TypeType1",
                column: "EffectiveAgainstPokeType",
                principalTable: "Types",
                principalColumn: "PokeType",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeType1_Types_VulnerableToPokeType",
                table: "TypeType1",
                column: "VulnerableToPokeType",
                principalTable: "Types",
                principalColumn: "PokeType");

            migrationBuilder.AddForeignKey(
                name: "FK_TypeType2_Types_IneffectiveToPokeType",
                table: "TypeType2",
                column: "IneffectiveToPokeType",
                principalTable: "Types",
                principalColumn: "PokeType",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeType2_Types_UnaffectedByPokeType",
                table: "TypeType2",
                column: "UnaffectedByPokeType",
                principalTable: "Types",
                principalColumn: "PokeType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokemonType_Types_PokemonTypesPokeType",
                table: "PokemonType");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeType_Types_ResistantToPokeType",
                table: "TypeType");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeType_Types_ResistedByPokeType",
                table: "TypeType");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeType1_Types_EffectiveAgainstPokeType",
                table: "TypeType1");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeType1_Types_VulnerableToPokeType",
                table: "TypeType1");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeType2_Types_IneffectiveToPokeType",
                table: "TypeType2");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeType2_Types_UnaffectedByPokeType",
                table: "TypeType2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Types",
                table: "Types");

            migrationBuilder.DeleteData(
                table: "PokemonType",
                keyColumns: new[] { "PokemonTypesPokeType", "PokemonsId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "PokemonType",
                keyColumns: new[] { "PokemonTypesPokeType", "PokemonsId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "PokemonType",
                keyColumns: new[] { "PokemonTypesPokeType", "PokemonsId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "PokemonType",
                keyColumns: new[] { "PokemonTypesPokeType", "PokemonsId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 0, 12 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 0, 16 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 4, 15 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 6, 16 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 6, 17 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 11, 13 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 11, 17 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 13, 14 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 14, 17 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 15, 16 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 16, 16 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 17, 7 });

            migrationBuilder.DeleteData(
                table: "TypeType",
                keyColumns: new[] { "ResistantToPokeType", "ResistedByPokeType" },
                keyValues: new object[] { 17, 16 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 0, 6 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 6, 17 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 10, 13 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 10, 14 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 12, 16 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 13, 13 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 13, 14 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 14, 11 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 15, 15 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 15, 17 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 16, 6 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.DeleteData(
                table: "TypeType1",
                keyColumns: new[] { "EffectiveAgainstPokeType", "VulnerableToPokeType" },
                keyValues: new object[] { 17, 16 });

            migrationBuilder.DeleteData(
                table: "TypeType2",
                keyColumns: new[] { "IneffectiveToPokeType", "UnaffectedByPokeType" },
                keyValues: new object[] { 0, 13 });

            migrationBuilder.DeleteData(
                table: "TypeType2",
                keyColumns: new[] { "IneffectiveToPokeType", "UnaffectedByPokeType" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "TypeType2",
                keyColumns: new[] { "IneffectiveToPokeType", "UnaffectedByPokeType" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "TypeType2",
                keyColumns: new[] { "IneffectiveToPokeType", "UnaffectedByPokeType" },
                keyValues: new object[] { 13, 0 });

            migrationBuilder.DeleteData(
                table: "TypeType2",
                keyColumns: new[] { "IneffectiveToPokeType", "UnaffectedByPokeType" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "TypeType2",
                keyColumns: new[] { "IneffectiveToPokeType", "UnaffectedByPokeType" },
                keyValues: new object[] { 14, 10 });

            migrationBuilder.DeleteData(
                table: "TypeType2",
                keyColumns: new[] { "IneffectiveToPokeType", "UnaffectedByPokeType" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "TypeType2",
                keyColumns: new[] { "IneffectiveToPokeType", "UnaffectedByPokeType" },
                keyValues: new object[] { 17, 15 });

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "PokeType",
                keyValue: 0);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "PokeType",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "PokeType",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "PokeType",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "PokeType",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "PokeType",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "PokeType",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "PokeType",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "PokeType",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "PokeType",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "PokeType",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "PokeType",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "PokeType",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "PokeType",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "PokeType",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "PokeType",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "PokeType",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "PokeType",
                keyValue: 17);

            migrationBuilder.RenameColumn(
                name: "UnaffectedByPokeType",
                table: "TypeType2",
                newName: "UnaffectedById");

            migrationBuilder.RenameColumn(
                name: "IneffectiveToPokeType",
                table: "TypeType2",
                newName: "IneffectiveToId");

            migrationBuilder.RenameIndex(
                name: "IX_TypeType2_UnaffectedByPokeType",
                table: "TypeType2",
                newName: "IX_TypeType2_UnaffectedById");

            migrationBuilder.RenameColumn(
                name: "VulnerableToPokeType",
                table: "TypeType1",
                newName: "VulnerableToId");

            migrationBuilder.RenameColumn(
                name: "EffectiveAgainstPokeType",
                table: "TypeType1",
                newName: "EffectiveAgainstId");

            migrationBuilder.RenameIndex(
                name: "IX_TypeType1_VulnerableToPokeType",
                table: "TypeType1",
                newName: "IX_TypeType1_VulnerableToId");

            migrationBuilder.RenameColumn(
                name: "ResistedByPokeType",
                table: "TypeType",
                newName: "ResistedById");

            migrationBuilder.RenameColumn(
                name: "ResistantToPokeType",
                table: "TypeType",
                newName: "ResistantToId");

            migrationBuilder.RenameIndex(
                name: "IX_TypeType_ResistedByPokeType",
                table: "TypeType",
                newName: "IX_TypeType_ResistedById");

            migrationBuilder.RenameColumn(
                name: "PokemonTypesPokeType",
                table: "PokemonType",
                newName: "PokemonTypesId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Types",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Types",
                table: "Types",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "~/images/pokemons/pikachu.png");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "~/images/pokemons/bulbasaur.png");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "~/images/pokemons/charmander.png");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "~/images/pokemons/squirtle.png");

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
                    { 2, 4 },
                    { 2, 7 },
                    { 2, 9 },
                    { 2, 14 },
                    { 2, 18 },
                    { 3, 6 },
                    { 3, 13 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 8 },
                    { 5, 7 },
                    { 5, 12 },
                    { 6, 2 },
                    { 6, 5 },
                    { 7, 2 },
                    { 7, 3 },
                    { 7, 4 },
                    { 7, 9 },
                    { 7, 10 },
                    { 7, 18 },
                    { 8, 17 },
                    { 9, 9 },
                    { 9, 10 },
                    { 9, 11 },
                    { 9, 13 },
                    { 10, 6 },
                    { 10, 11 },
                    { 11, 11 },
                    { 11, 12 },
                    { 12, 3 },
                    { 12, 4 },
                    { 12, 7 },
                    { 12, 9 },
                    { 12, 10 },
                    { 12, 12 },
                    { 13, 12 },
                    { 13, 13 },
                    { 13, 16 },
                    { 14, 9 },
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
                    { 2, 14 },
                    { 2, 18 },
                    { 3, 6 },
                    { 3, 13 },
                    { 3, 15 },
                    { 4, 5 },
                    { 4, 14 },
                    { 5, 11 },
                    { 5, 15 },
                    { 6, 2 },
                    { 6, 5 },
                    { 6, 11 },
                    { 6, 12 },
                    { 7, 3 },
                    { 7, 6 },
                    { 8, 8 },
                    { 8, 17 },
                    { 9, 2 },
                    { 9, 10 },
                    { 10, 5 },
                    { 10, 6 },
                    { 11, 13 },
                    { 12, 4 },
                    { 12, 7 },
                    { 12, 10 },
                    { 12, 15 },
                    { 13, 5 },
                    { 14, 7 },
                    { 14, 8 },
                    { 15, 2 },
                    { 15, 6 },
                    { 15, 9 },
                    { 15, 10 },
                    { 16, 15 },
                    { 16, 16 },
                    { 16, 18 },
                    { 17, 2 },
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

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonType_Types_PokemonTypesId",
                table: "PokemonType",
                column: "PokemonTypesId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeType_Types_ResistantToId",
                table: "TypeType",
                column: "ResistantToId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeType_Types_ResistedById",
                table: "TypeType",
                column: "ResistedById",
                principalTable: "Types",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TypeType1_Types_EffectiveAgainstId",
                table: "TypeType1",
                column: "EffectiveAgainstId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeType1_Types_VulnerableToId",
                table: "TypeType1",
                column: "VulnerableToId",
                principalTable: "Types",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TypeType2_Types_IneffectiveToId",
                table: "TypeType2",
                column: "IneffectiveToId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeType2_Types_UnaffectedById",
                table: "TypeType2",
                column: "UnaffectedById",
                principalTable: "Types",
                principalColumn: "Id");
        }
    }
}
