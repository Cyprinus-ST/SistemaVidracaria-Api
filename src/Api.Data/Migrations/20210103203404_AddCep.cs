using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class AddCep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b29951ea-fcdf-44a3-af18-e105940a100d"));

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "User",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CEP", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("1822cf23-1075-4e4c-bc7c-2b0dd8c1d882"), null, null, null, null, null, new DateTime(2021, 1, 3, 17, 34, 4, 461, DateTimeKind.Local).AddTicks(6076), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, null, null, null, null, null, new DateTime(2021, 1, 3, 17, 34, 4, 462, DateTimeKind.Local).AddTicks(6699) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1822cf23-1075-4e4c-bc7c-2b0dd8c1d882"));

            migrationBuilder.DropColumn(
                name: "CEP",
                table: "User");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("b29951ea-fcdf-44a3-af18-e105940a100d"), null, null, null, null, new DateTime(2021, 1, 3, 14, 5, 6, 6, DateTimeKind.Local).AddTicks(8436), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, null, null, null, null, null, new DateTime(2021, 1, 3, 14, 5, 6, 7, DateTimeKind.Local).AddTicks(8355) });
        }
    }
}
