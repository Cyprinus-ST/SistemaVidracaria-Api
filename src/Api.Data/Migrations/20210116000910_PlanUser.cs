using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class PlanUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9498cb07-617d-4cc9-be07-aad3d26a9605"));

            migrationBuilder.CreateTable(
                name: "PlanUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idPlan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    statusPlan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateAcquisition = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateExpired = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "Id", "CreateAt", "Description", "Name", "Price", "Status", "UpdateAt" },
                values: new object[] { new Guid("33f712d0-d8f3-4177-b0d3-7b81cffe1b2e"), new DateTime(2021, 1, 15, 21, 9, 10, 260, DateTimeKind.Local).AddTicks(9540), "Plano Experimental", "Plano Experimental", 0.0, "Ativo", new DateTime(2021, 1, 15, 21, 9, 10, 260, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CEP", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("05656d53-9f7e-48a7-a6c9-29d090b806b0"), null, null, null, null, null, new DateTime(2021, 1, 15, 21, 9, 10, 258, DateTimeKind.Local).AddTicks(4452), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, null, null, null, null, null, new DateTime(2021, 1, 15, 21, 9, 10, 259, DateTimeKind.Local).AddTicks(5200) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanUser");

            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("33f712d0-d8f3-4177-b0d3-7b81cffe1b2e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("05656d53-9f7e-48a7-a6c9-29d090b806b0"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CEP", "CPF", "City", "Complement", "Country", "CreateAt", "Email", "Name", "Neighborhood", "Number", "Password", "PathAvatar", "Phone", "State", "Street", "TokenPassword", "Type", "UpdateAt" },
                values: new object[] { new Guid("9498cb07-617d-4cc9-be07-aad3d26a9605"), null, null, null, null, null, new DateTime(2021, 1, 11, 23, 34, 12, 154, DateTimeKind.Local).AddTicks(9593), "lucas.vilas@email.com", "Administrador", null, null, "123456", null, null, null, null, null, null, new DateTime(2021, 1, 11, 23, 34, 12, 156, DateTimeKind.Local).AddTicks(7604) });
        }
    }
}
