using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class UpdatePriceInPlanTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("91b8fd0b-2a5c-4c8d-82d8-794f086b27da"));

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Plan",
                type: "float",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CEP", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("9498cb07-617d-4cc9-be07-aad3d26a9605"), null, null, null, null, null, new DateTime(2021, 1, 11, 23, 34, 12, 154, DateTimeKind.Local).AddTicks(9593), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, null, null, null, null, null, new DateTime(2021, 1, 11, 23, 34, 12, 156, DateTimeKind.Local).AddTicks(7604) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9498cb07-617d-4cc9-be07-aad3d26a9605"));

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Plan",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CEP", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("91b8fd0b-2a5c-4c8d-82d8-794f086b27da"), null, null, null, null, null, new DateTime(2021, 1, 11, 21, 1, 13, 238, DateTimeKind.Local).AddTicks(4452), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, null, null, null, null, null, new DateTime(2021, 1, 11, 21, 1, 13, 240, DateTimeKind.Local).AddTicks(5866) });
        }
    }
}
