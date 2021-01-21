using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class AddIdOnMaterial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("74cc5901-e935-45b0-bb55-82a3253ced5c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ba7e403c-3c0e-4bad-94ec-bcef601ef6f3"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdUser",
                table: "Material",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "Id", "CreateAt", "Description", "Name", "Price", "Status", "UpdateAt" },
                values: new object[] { new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"), new DateTime(2021, 1, 20, 22, 15, 54, 100, DateTimeKind.Local).AddTicks(683), "Plano Experimental", "Plano Experimental", 0.0, "Ativo", new DateTime(2021, 1, 20, 22, 15, 54, 100, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CEP", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("d767ebd4-ae18-4435-8c79-55822ed7301c"), null, null, null, null, null, new DateTime(2021, 1, 20, 22, 15, 54, 97, DateTimeKind.Local).AddTicks(6138), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, null, null, null, null, null, new DateTime(2021, 1, 20, 22, 15, 54, 98, DateTimeKind.Local).AddTicks(6396) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d767ebd4-ae18-4435-8c79-55822ed7301c"));

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Material");

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "Id", "CreateAt", "Description", "Name", "Price", "Status", "UpdateAt" },
                values: new object[] { new Guid("74cc5901-e935-45b0-bb55-82a3253ced5c"), new DateTime(2021, 1, 19, 22, 5, 5, 468, DateTimeKind.Local).AddTicks(4035), "Plano Experimental", "Plano Experimental", 0.0, "Ativo", new DateTime(2021, 1, 19, 22, 5, 5, 468, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CEP", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("ba7e403c-3c0e-4bad-94ec-bcef601ef6f3"), null, null, null, null, null, new DateTime(2021, 1, 19, 22, 5, 5, 465, DateTimeKind.Local).AddTicks(9991), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, null, null, null, null, null, new DateTime(2021, 1, 19, 22, 5, 5, 467, DateTimeKind.Local).AddTicks(568) });
        }
    }
}
