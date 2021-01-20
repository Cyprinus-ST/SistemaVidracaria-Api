using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class Costumer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("27e6ea48-087e-45e4-a729-47cafc67adbf"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("efea6c85-fc9a-4e6e-9252-8c4bf6968af2"));

            migrationBuilder.CreateTable(
                name: "Costumer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costumer", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "Id", "CreateAt", "Description", "Name", "Price", "Status", "UpdateAt" },
                values: new object[] { new Guid("6c1672e5-e014-464f-9148-1598d9b89138"), new DateTime(2021, 1, 19, 22, 2, 14, 757, DateTimeKind.Local).AddTicks(332), "Plano Experimental", "Plano Experimental", 0.0, "Ativo", new DateTime(2021, 1, 19, 22, 2, 14, 757, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CEP", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("f6a57a66-aba7-493c-a0d8-ae24f8aef7e7"), null, null, null, null, null, new DateTime(2021, 1, 19, 22, 2, 14, 754, DateTimeKind.Local).AddTicks(246), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, null, null, null, null, null, new DateTime(2021, 1, 19, 22, 2, 14, 755, DateTimeKind.Local).AddTicks(1901) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Costumer");

            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("6c1672e5-e014-464f-9148-1598d9b89138"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f6a57a66-aba7-493c-a0d8-ae24f8aef7e7"));

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "Id", "CreateAt", "Description", "Name", "Price", "Status", "UpdateAt" },
                values: new object[] { new Guid("27e6ea48-087e-45e4-a729-47cafc67adbf"), new DateTime(2021, 1, 19, 21, 57, 50, 987, DateTimeKind.Local).AddTicks(17), "Plano Experimental", "Plano Experimental", 0.0, "Ativo", new DateTime(2021, 1, 19, 21, 57, 50, 987, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CEP", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("efea6c85-fc9a-4e6e-9252-8c4bf6968af2"), null, null, null, null, null, new DateTime(2021, 1, 19, 21, 57, 50, 984, DateTimeKind.Local).AddTicks(1330), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, null, null, null, null, null, new DateTime(2021, 1, 19, 21, 57, 50, 985, DateTimeKind.Local).AddTicks(4858) });
        }
    }
}
