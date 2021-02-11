using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class ProjectTypeTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("e400fc3c-be2e-462f-bf58-b6eaea58bc33"));

            migrationBuilder.CreateTable(
                name: "ProjectType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectType", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 10, 20, 15, 34, 389, DateTimeKind.Local).AddTicks(8294), new DateTime(2021, 2, 10, 20, 15, 34, 389, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "Id", "CreateAt", "Description", "Installments", "Name", "Status", "UpdateAt" },
                values: new object[] { new Guid("89342620-fc21-4e73-9ef5-343c5509a262"), new DateTime(2021, 2, 10, 20, 15, 34, 389, DateTimeKind.Local).AddTicks(8488), "Plano Experimental", 0.0, "Plano Experimental", "Ativo", new DateTime(2021, 2, 10, 20, 15, 34, 389, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 10, 20, 15, 34, 387, DateTimeKind.Local).AddTicks(3074), new DateTime(2021, 2, 10, 20, 15, 34, 388, DateTimeKind.Local).AddTicks(4415) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectType");

            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("89342620-fc21-4e73-9ef5-343c5509a262"));

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
    }
}
