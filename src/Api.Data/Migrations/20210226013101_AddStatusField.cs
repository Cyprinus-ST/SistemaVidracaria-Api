using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class AddStatusField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "IdProject",
                table: "Budget",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "Budget",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "HeightValue",
                table: "Budget",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MeterValue",
                table: "Budget",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Budget",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Total",
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
                values: new object[] { new DateTime(2021, 2, 25, 22, 31, 1, 459, DateTimeKind.Local).AddTicks(9377), new DateTime(2021, 2, 25, 22, 31, 1, 459, DateTimeKind.Local).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 25, 22, 31, 1, 457, DateTimeKind.Local).AddTicks(5437), new DateTime(2021, 2, 25, 22, 31, 1, 458, DateTimeKind.Local).AddTicks(6011) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Budget");

            migrationBuilder.DropColumn(
                name: "HeightValue",
                table: "Budget");

            migrationBuilder.DropColumn(
                name: "MeterValue",
                table: "Budget");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Budget");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Budget");

            migrationBuilder.DropColumn(
                name: "WidthValue",
                table: "Budget");

            migrationBuilder.AlterColumn<int>(
                name: "IdProject",
                table: "Budget",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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
    }
}
