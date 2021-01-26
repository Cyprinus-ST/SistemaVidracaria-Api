using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class AdicionandoRegistroDePlano : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Costumer");

            migrationBuilder.UpdateData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("2216f112-4c4e-4fdc-b300-eda19d5de4e4"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 1, 25, 22, 8, 37, 235, DateTimeKind.Local).AddTicks(1327), new DateTime(2021, 1, 25, 22, 8, 37, 235, DateTimeKind.Local).AddTicks(1343) });

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "Id", "CreateAt", "Description", "Installments", "Name", "Status", "UpdateAt" },
                values: new object[] { new Guid("6325a89c-4297-415e-bd8f-3cdcf830c435"), new DateTime(2021, 1, 25, 22, 8, 37, 235, DateTimeKind.Local).AddTicks(1528), "Plano Experimental", 0.0, "Plano Experimental", "Ativo", new DateTime(2021, 1, 25, 22, 8, 37, 235, DateTimeKind.Local).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 1, 25, 22, 8, 37, 232, DateTimeKind.Local).AddTicks(6241), new DateTime(2021, 1, 25, 22, 8, 37, 233, DateTimeKind.Local).AddTicks(6858) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("6325a89c-4297-415e-bd8f-3cdcf830c435"));

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
    }
}
