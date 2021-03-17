using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class PopulandoBaseComCores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AluminiumColor",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Branco" },
                    { 9, "Natural" },
                    { 8, "Cromada" },
                    { 7, "Champanhe 1002" },
                    { 6, "Champanhe 1001" },
                    { 10, "Não Selecionar" },
                    { 4, "Bronze 1003" },
                    { 3, "Bronze" },
                    { 2, "Brilhante" },
                    { 5, "Champanhe" }
                });

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 3, 17, 20, 46, 14, 219, DateTimeKind.Local).AddTicks(6815), new DateTime(2021, 3, 17, 20, 46, 14, 219, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.InsertData(
                table: "StructureColor",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Branco" },
                    { 2, "Cromado" },
                    { 3, "Fosco" },
                    { 4, "Marrom" },
                    { 5, "Outras" },
                    { 6, "Preto" },
                    { 7, "Não selecionar" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 3, 17, 20, 46, 14, 217, DateTimeKind.Local).AddTicks(2119), new DateTime(2021, 3, 17, 20, 46, 14, 218, DateTimeKind.Local).AddTicks(2871) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AluminiumColor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AluminiumColor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AluminiumColor",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AluminiumColor",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AluminiumColor",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AluminiumColor",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AluminiumColor",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AluminiumColor",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AluminiumColor",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AluminiumColor",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StructureColor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StructureColor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StructureColor",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StructureColor",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StructureColor",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StructureColor",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StructureColor",
                keyColumn: "Id",
                keyValue: 7);

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
    }
}
