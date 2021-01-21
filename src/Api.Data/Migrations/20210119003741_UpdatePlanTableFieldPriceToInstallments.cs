using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class UpdatePlanTableFieldPriceToInstallments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9498cb07-617d-4cc9-be07-aad3d26a9605"));

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Plan",
                newName: "Installments");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CEP", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("e4b46452-9266-4084-9b5b-99d32615de69"), null, null, null, null, null, new DateTime(2021, 1, 18, 21, 37, 41, 173, DateTimeKind.Local).AddTicks(8035), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, null, null, null, null, null, new DateTime(2021, 1, 18, 21, 37, 41, 175, DateTimeKind.Local).AddTicks(7700) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e4b46452-9266-4084-9b5b-99d32615de69"));

            migrationBuilder.RenameColumn(
                name: "Installments",
                table: "Plan",
                newName: "Price");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CEP", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("9498cb07-617d-4cc9-be07-aad3d26a9605"), null, null, null, null, null, new DateTime(2021, 1, 11, 23, 34, 12, 154, DateTimeKind.Local).AddTicks(9593), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, null, null, null, null, null, new DateTime(2021, 1, 11, 23, 34, 12, 156, DateTimeKind.Local).AddTicks(7604) });
        }
    }
}
