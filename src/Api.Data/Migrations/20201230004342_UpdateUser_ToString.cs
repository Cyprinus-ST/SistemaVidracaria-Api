using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class UpdateUser_ToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("19e704b6-26ec-4ba9-b9e5-d472d28cab9f"));

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "User",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 11);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("6baa032b-23cb-4fc3-9418-04b08cf2067c"), null, null, null, null, new DateTime(2020, 12, 29, 21, 43, 41, 859, DateTimeKind.Local).AddTicks(222), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, null, null, null, null, null, new DateTime(2020, 12, 29, 21, 43, 41, 860, DateTimeKind.Local).AddTicks(630) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6baa032b-23cb-4fc3-9418-04b08cf2067c"));

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "User",
                type: "int",
                maxLength: 11,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("19e704b6-26ec-4ba9-b9e5-d472d28cab9f"), null, null, null, null, new DateTime(2020, 12, 29, 20, 40, 41, 79, DateTimeKind.Local).AddTicks(4965), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, 0, null, null, null, null, new DateTime(2020, 12, 29, 20, 40, 41, 80, DateTimeKind.Local).AddTicks(5199) });
        }
    }
}
