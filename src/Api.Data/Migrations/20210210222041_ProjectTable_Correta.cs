using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class ProjectTable_Correta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("d96bc3ad-4584-44b4-b370-7d0ef8132732"));

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NumberGlass = table.Column<int>(type: "int", nullable: false),
                    Descripition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectType = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 10, 19, 20, 41, 150, DateTimeKind.Local).AddTicks(3021), new DateTime(2021, 2, 10, 19, 20, 41, 150, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "Id", "CreateAt", "Description", "Installments", "Name", "Status", "UpdateAt" },
                values: new object[] { new Guid("f8e58981-c111-450e-bff7-d169a3b363a9"), new DateTime(2021, 2, 10, 19, 20, 41, 150, DateTimeKind.Local).AddTicks(3250), "Plano Experimental", 0.0, "Plano Experimental", "Ativo", new DateTime(2021, 2, 10, 19, 20, 41, 150, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 10, 19, 20, 41, 147, DateTimeKind.Local).AddTicks(9428), new DateTime(2021, 2, 10, 19, 20, 41, 148, DateTimeKind.Local).AddTicks(9566) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("f8e58981-c111-450e-bff7-d169a3b363a9"));

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 10, 19, 19, 52, 392, DateTimeKind.Local).AddTicks(6261), new DateTime(2021, 2, 10, 19, 19, 52, 392, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "Id", "CreateAt", "Description", "Installments", "Name", "Status", "UpdateAt" },
                values: new object[] { new Guid("d96bc3ad-4584-44b4-b370-7d0ef8132732"), new DateTime(2021, 2, 10, 19, 19, 52, 392, DateTimeKind.Local).AddTicks(6477), "Plano Experimental", 0.0, "Plano Experimental", "Ativo", new DateTime(2021, 2, 10, 19, 19, 52, 392, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 10, 19, 19, 52, 390, DateTimeKind.Local).AddTicks(2789), new DateTime(2021, 2, 10, 19, 19, 52, 391, DateTimeKind.Local).AddTicks(3313) });
        }
    }
}
