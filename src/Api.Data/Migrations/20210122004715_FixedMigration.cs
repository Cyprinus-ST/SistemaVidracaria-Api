using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class FixedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d767ebd4-ae18-4435-8c79-55822ed7301c"));

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Plan",
                newName: "Installments");

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 1, 21, 21, 47, 14, 971, DateTimeKind.Local).AddTicks(4358), new DateTime(2021, 1, 21, 21, 47, 14, 971, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CEP", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("bd43824d-95de-4b40-be71-f634b75c47be"), null, null, null, null, null, new DateTime(2021, 1, 21, 21, 47, 14, 966, DateTimeKind.Local).AddTicks(7492), "lucas.vila@email.com", "Administrador", null, null, "123456", null, null, null, null, null, null, new DateTime(2021, 1, 21, 21, 47, 14, 969, DateTimeKind.Local).AddTicks(1654) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"));

            migrationBuilder.RenameColumn(
                name: "Installments",
                table: "Plan",
                newName: "Price");

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 1, 20, 22, 15, 54, 100, DateTimeKind.Local).AddTicks(683), new DateTime(2021, 1, 20, 22, 15, 54, 100, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CEP", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("d767ebd4-ae18-4435-8c79-55822ed7301c"), null, null, null, null, null, new DateTime(2021, 1, 20, 22, 15, 54, 97, DateTimeKind.Local).AddTicks(6138), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, null, null, null, null, null, new DateTime(2021, 1, 20, 22, 15, 54, 98, DateTimeKind.Local).AddTicks(6396) });
        }
    }
}
