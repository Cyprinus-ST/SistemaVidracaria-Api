using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class AtualizandoProvider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripition",
                table: "Provider",
                newName: "Description");

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
                values: new object[] { new DateTime(2021, 1, 25, 21, 2, 10, 263, DateTimeKind.Local).AddTicks(9755), new DateTime(2021, 1, 25, 21, 2, 10, 263, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 1, 25, 21, 2, 10, 261, DateTimeKind.Local).AddTicks(5558), new DateTime(2021, 1, 25, 21, 2, 10, 262, DateTimeKind.Local).AddTicks(6028) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Costumer");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Provider",
                newName: "Descripition");

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 1, 22, 19, 57, 2, 383, DateTimeKind.Local).AddTicks(817), new DateTime(2021, 1, 22, 19, 57, 2, 383, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 1, 22, 19, 57, 2, 380, DateTimeKind.Local).AddTicks(6083), new DateTime(2021, 1, 22, 19, 57, 2, 381, DateTimeKind.Local).AddTicks(6766) });
        }
    }
}
