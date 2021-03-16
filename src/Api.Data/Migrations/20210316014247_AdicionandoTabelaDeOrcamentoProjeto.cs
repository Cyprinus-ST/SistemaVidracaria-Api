using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class AdicionandoTabelaDeOrcamentoProjeto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 3, 15, 22, 16, 6, 183, DateTimeKind.Local).AddTicks(364), new DateTime(2021, 3, 15, 22, 16, 6, 183, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 3, 15, 22, 16, 6, 180, DateTimeKind.Local).AddTicks(3049), new DateTime(2021, 3, 15, 22, 16, 6, 181, DateTimeKind.Local).AddTicks(5980) });
        }
    }
}
