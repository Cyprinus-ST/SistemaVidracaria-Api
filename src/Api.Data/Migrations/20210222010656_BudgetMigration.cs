using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class BudgetMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("1aa6b613-2e5c-4024-bdb6-165cb0fc6d8b"));

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 21, 22, 6, 56, 210, DateTimeKind.Local).AddTicks(7797), new DateTime(2021, 2, 21, 22, 6, 56, 210, DateTimeKind.Local).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 21, 22, 6, 56, 208, DateTimeKind.Local).AddTicks(3607), new DateTime(2021, 2, 21, 22, 6, 56, 209, DateTimeKind.Local).AddTicks(4294) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 10, 20, 27, 33, 544, DateTimeKind.Local).AddTicks(2901), new DateTime(2021, 2, 10, 20, 27, 33, 544, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "Id", "CreateAt", "Description", "Installments", "Name", "Status", "UpdateAt" },
                values: new object[] { new Guid("1aa6b613-2e5c-4024-bdb6-165cb0fc6d8b"), new DateTime(2021, 2, 10, 20, 27, 33, 544, DateTimeKind.Local).AddTicks(3124), "Plano Experimental", 0.0, "Plano Experimental", "Ativo", new DateTime(2021, 2, 10, 20, 27, 33, 544, DateTimeKind.Local).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 10, 20, 27, 33, 541, DateTimeKind.Local).AddTicks(9328), new DateTime(2021, 2, 10, 20, 27, 33, 542, DateTimeKind.Local).AddTicks(9628) });
        }
    }
}
