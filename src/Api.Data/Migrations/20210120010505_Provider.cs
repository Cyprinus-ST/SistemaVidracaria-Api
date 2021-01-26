using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class Provider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("6c1672e5-e014-464f-9148-1598d9b89138"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f6a57a66-aba7-493c-a0d8-ae24f8aef7e7"));

            migrationBuilder.CreateTable(
                name: "Provider",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Descripition = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provider", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CEP", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("ba7e403c-3c0e-4bad-94ec-bcef601ef6f3"), null, null, null, null, null, new DateTime(2021, 1, 19, 22, 5, 5, 465, DateTimeKind.Local).AddTicks(9991), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, null, null, null, null, null, new DateTime(2021, 1, 19, 22, 5, 5, 467, DateTimeKind.Local).AddTicks(568) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Provider");

            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("74cc5901-e935-45b0-bb55-82a3253ced5c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ba7e403c-3c0e-4bad-94ec-bcef601ef6f3"));

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "Id", "CreateAt", "Description", "Name", "Price", "Status", "UpdateAt" },
                values: new object[] { new Guid("6c1672e5-e014-464f-9148-1598d9b89138"), new DateTime(2021, 1, 19, 22, 2, 14, 757, DateTimeKind.Local).AddTicks(332), "Plano Experimental", "Plano Experimental", 0.0, "Ativo", new DateTime(2021, 1, 19, 22, 2, 14, 757, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CEP", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("f6a57a66-aba7-493c-a0d8-ae24f8aef7e7"), null, null, null, null, null, new DateTime(2021, 1, 19, 22, 2, 14, 754, DateTimeKind.Local).AddTicks(246), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, null, null, null, null, null, new DateTime(2021, 1, 19, 22, 2, 14, 755, DateTimeKind.Local).AddTicks(1901) });
        }
    }
}
