using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class ProjectTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("819c4405-447c-44f2-aa78-d970486d5c0c"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("d96bc3ad-4584-44b4-b370-7d0ef8132732"));

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 10, 19, 16, 7, 646, DateTimeKind.Local).AddTicks(1105), new DateTime(2021, 2, 10, 19, 16, 7, 646, DateTimeKind.Local).AddTicks(1121) });

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "Id", "CreateAt", "Description", "Installments", "Name", "Status", "UpdateAt" },
                values: new object[] { new Guid("819c4405-447c-44f2-aa78-d970486d5c0c"), new DateTime(2021, 2, 10, 19, 16, 7, 646, DateTimeKind.Local).AddTicks(1374), "Plano Experimental", 0.0, "Plano Experimental", "Ativo", new DateTime(2021, 2, 10, 19, 16, 7, 646, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 10, 19, 16, 7, 643, DateTimeKind.Local).AddTicks(6666), new DateTime(2021, 2, 10, 19, 16, 7, 644, DateTimeKind.Local).AddTicks(7225) });
        }
    }
}
