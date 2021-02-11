using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class ProjectTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("f8e58981-c111-450e-bff7-d169a3b363a9"));

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 10, 20, 13, 38, 958, DateTimeKind.Local).AddTicks(6358), new DateTime(2021, 2, 10, 20, 13, 38, 958, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "Id", "CreateAt", "Description", "Installments", "Name", "Status", "UpdateAt" },
                values: new object[] { new Guid("e400fc3c-be2e-462f-bf58-b6eaea58bc33"), new DateTime(2021, 2, 10, 20, 13, 38, 958, DateTimeKind.Local).AddTicks(6579), "Plano Experimental", 0.0, "Plano Experimental", "Ativo", new DateTime(2021, 2, 10, 20, 13, 38, 958, DateTimeKind.Local).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 10, 20, 13, 38, 956, DateTimeKind.Local).AddTicks(2665), new DateTime(2021, 2, 10, 20, 13, 38, 957, DateTimeKind.Local).AddTicks(3122) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("e400fc3c-be2e-462f-bf58-b6eaea58bc33"));

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
    }
}
