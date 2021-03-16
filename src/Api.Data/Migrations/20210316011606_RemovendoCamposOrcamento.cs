using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class RemovendoCamposOrcamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Budget");

            migrationBuilder.DropColumn(
                name: "HeightValue",
                table: "Budget");

            migrationBuilder.DropColumn(
                name: "IdProject",
                table: "Budget");

            migrationBuilder.DropColumn(
                name: "MeterValue",
                table: "Budget");

            migrationBuilder.DropColumn(
                name: "WidthValue",
                table: "Budget");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Budget",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HeightValue",
                table: "Budget",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<Guid>(
                name: "IdProject",
                table: "Budget",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<double>(
                name: "MeterValue",
                table: "Budget",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "WidthValue",
                table: "Budget",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 3, 15, 19, 39, 24, 728, DateTimeKind.Local).AddTicks(7422), new DateTime(2021, 3, 15, 19, 39, 24, 728, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 3, 15, 19, 39, 24, 726, DateTimeKind.Local).AddTicks(429), new DateTime(2021, 3, 15, 19, 39, 24, 727, DateTimeKind.Local).AddTicks(2817) });
        }
    }
}
