using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class AdicionandoTabelaDeOrcamentoProjeto1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectBudget",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdProject = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdBudget = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGlassColor = table.Column<int>(type: "int", nullable: false),
                    IdAluminumColor = table.Column<int>(type: "int", nullable: false),
                    IdStructureColor = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeterValue = table.Column<double>(type: "float", nullable: false),
                    HeightValue = table.Column<double>(type: "float", nullable: false),
                    WidthValue = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitValue = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectBudget", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 3, 15, 22, 44, 16, 64, DateTimeKind.Local).AddTicks(4034), new DateTime(2021, 3, 15, 22, 44, 16, 64, DateTimeKind.Local).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 3, 15, 22, 44, 16, 61, DateTimeKind.Local).AddTicks(6745), new DateTime(2021, 3, 15, 22, 44, 16, 62, DateTimeKind.Local).AddTicks(9566) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectBudget");

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 3, 15, 22, 42, 46, 975, DateTimeKind.Local).AddTicks(8249), new DateTime(2021, 3, 15, 22, 42, 46, 975, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 3, 15, 22, 42, 46, 973, DateTimeKind.Local).AddTicks(945), new DateTime(2021, 3, 15, 22, 42, 46, 974, DateTimeKind.Local).AddTicks(3217) });
        }
    }
}
