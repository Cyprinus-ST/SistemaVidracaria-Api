using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class UpdatePassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6baa032b-23cb-4fc3-9418-04b08cf2067c"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("4b0a773e-1617-4da1-9387-5d1d1d363976"), null, null, null, null, new DateTime(2021, 1, 3, 13, 51, 45, 955, DateTimeKind.Local).AddTicks(8463), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, null, null, null, null, null, new DateTime(2021, 1, 3, 13, 51, 45, 956, DateTimeKind.Local).AddTicks(8557) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4b0a773e-1617-4da1-9387-5d1d1d363976"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("6baa032b-23cb-4fc3-9418-04b08cf2067c"), null, null, null, null, new DateTime(2020, 12, 29, 21, 43, 41, 859, DateTimeKind.Local).AddTicks(222), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, null, null, null, null, null, new DateTime(2020, 12, 29, 21, 43, 41, 860, DateTimeKind.Local).AddTicks(630) });
        }
    }
}
