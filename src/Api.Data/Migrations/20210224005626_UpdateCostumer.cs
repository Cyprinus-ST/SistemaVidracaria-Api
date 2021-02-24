using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class UpdateCostumer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdUser",
                table: "Costumer",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 23, 21, 56, 25, 879, DateTimeKind.Local).AddTicks(7855), new DateTime(2021, 2, 23, 21, 56, 25, 879, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 23, 21, 56, 25, 877, DateTimeKind.Local).AddTicks(2796), new DateTime(2021, 2, 23, 21, 56, 25, 878, DateTimeKind.Local).AddTicks(3689) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Costumer");

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 21, 22, 8, 50, 135, DateTimeKind.Local).AddTicks(6744), new DateTime(2021, 2, 21, 22, 8, 50, 135, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 21, 22, 8, 50, 133, DateTimeKind.Local).AddTicks(2374), new DateTime(2021, 2, 21, 22, 8, 50, 134, DateTimeKind.Local).AddTicks(3004) });
        }
    }
}
