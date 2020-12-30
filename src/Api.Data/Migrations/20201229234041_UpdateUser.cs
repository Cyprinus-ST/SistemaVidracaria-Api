using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class UpdateUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4648486c-f57a-4a6f-9ba0-226f9ffb289d"));

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "User",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "User",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Complement",
                table: "User",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "User",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Neighborhood",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "User",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PathAvatar",
                table: "User",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Phone",
                table: "User",
                type: "int",
                maxLength: 11,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "User",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "User",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TokenPassword",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "User",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("19e704b6-26ec-4ba9-b9e5-d472d28cab9f"), null, null, null, null, new DateTime(2020, 12, 29, 20, 40, 41, 79, DateTimeKind.Local).AddTicks(4965), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, 0, null, null, null, null, new DateTime(2020, 12, 29, 20, 40, 41, 80, DateTimeKind.Local).AddTicks(5199) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("19e704b6-26ec-4ba9-b9e5-d472d28cab9f"));

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "User");

            migrationBuilder.DropColumn(
                name: "City",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Complement",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Neighborhood",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PathAvatar",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "User");

            migrationBuilder.DropColumn(
                name: "State",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "User");

            migrationBuilder.DropColumn(
                name: "TokenPassword",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "User",
                newName: "Nome");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Nome", "Senha", "UpdateAt" },
                values: new object[] { new Guid("4648486c-f57a-4a6f-9ba0-226f9ffb289d"), new DateTime(2020, 12, 25, 18, 45, 39, 973, DateTimeKind.Local).AddTicks(9788), "lucas.vilas@email.com", "Administrador", "123456", new DateTime(2020, 12, 25, 18, 45, 39, 975, DateTimeKind.Local).AddTicks(297) });
        }
    }
}
