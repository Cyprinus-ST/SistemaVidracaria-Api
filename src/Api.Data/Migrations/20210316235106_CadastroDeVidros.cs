using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class CadastroDeVidros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AluminiumColor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AluminiumColor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GlassColor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlassColor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StructureColor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StructureColor", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "GlassColor",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Azul" },
                    { 28, "Pontilhado" },
                    { 29, "Refletivo Champagnhe" },
                    { 30, "Refletivo Cinza" },
                    { 31, "Refletivo Verde" },
                    { 32, "Serigrafado" },
                    { 33, "Serigrafado Extra Clear Branco" },
                    { 34, "Serigrafado Extra Clear Nevado" },
                    { 35, "Serigrafado Extra Clear Branco" },
                    { 36, "Serigrafado Fume Preto" },
                    { 27, "Mini Boreal" },
                    { 37, "Serigrafado Incolor Branco" },
                    { 39, "Serigrafado Incolor Nevado" },
                    { 40, "Temperado Laminado Bronze" },
                    { 41, "Temperado Laminado Fumê" },
                    { 42, "Temperado Laminado Incolor" },
                    { 43, "Temperado Laminado Verde" },
                    { 44, "Temperado Quadrato" },
                    { 45, "Verde" },
                    { 46, "Verde Padrão" },
                    { 47, "Não Selecionar" },
                    { 38, "Serigrafado Incolor Colorido" },
                    { 26, "Laminado Verde" },
                    { 25, "Laminado Incolor" },
                    { 24, "Laminado Fumê" },
                    { 2, "Box Incolor" },
                    { 3, "Box Antílope" },
                    { 4, "Box Bronze" },
                    { 5, "Box Fumê" },
                    { 6, "Box Verde" },
                    { 7, "Box Mini Boreal" },
                    { 9, "Box Quadrato" },
                    { 10, "Bronze" },
                    { 11, "Espelho" },
                    { 12, "Espelho Bisotê" },
                    { 13, "Espelho Bronze" },
                    { 14, "Espelho Fumê" },
                    { 15, "Fumê" },
                    { 16, "Fumê Padrão" },
                    { 17, "Incolor" },
                    { 18, "Jateado Fumê" },
                    { 19, "Jateado Incolor" }
                });

            migrationBuilder.InsertData(
                table: "GlassColor",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 20, "Jateador Verde" },
                    { 21, "Lacobel Branco" },
                    { 22, "Lacobel Preto" },
                    { 23, "Lacobel Vermelho" }
                });

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 3, 16, 20, 51, 6, 378, DateTimeKind.Local).AddTicks(2334), new DateTime(2021, 3, 16, 20, 51, 6, 378, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 3, 16, 20, 51, 6, 375, DateTimeKind.Local).AddTicks(7897), new DateTime(2021, 3, 16, 20, 51, 6, 376, DateTimeKind.Local).AddTicks(8378) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AluminiumColor");

            migrationBuilder.DropTable(
                name: "GlassColor");

            migrationBuilder.DropTable(
                name: "StructureColor");

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 3, 15, 22, 44, 16, 64, DateTimeKind.Local).AddTicks(4034), new DateTime(2021, 3, 15, 22, 44, 16, 64, DateTimeKind.Local).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 3, 15, 22, 44, 16, 61, DateTimeKind.Local).AddTicks(6745), new DateTime(2021, 3, 15, 22, 44, 16, 62, DateTimeKind.Local).AddTicks(9566) });
        }
    }
}
