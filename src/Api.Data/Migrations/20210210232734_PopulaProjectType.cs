using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class PopulaProjectType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("89342620-fc21-4e73-9ef5-343c5509a262"));

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

            migrationBuilder.InsertData(
                table: "ProjectType",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 99, "Não selecionar" },
                    { 17, "Sacadas" },
                    { 16, "Ideia Glass" },
                    { 15, "Portas Retráteis" },
                    { 14, "Projeto Personalizado" },
                    { 13, "Slide Door" },
                    { 12, "Versatik kits" },
                    { 11, "Reposição" },
                    { 10, "Janelas Staley" },
                    { 8, "Guarda-Corpo" },
                    { 7, "Bascula/Maxian-ar" },
                    { 6, "Espelho" },
                    { 5, "Fechamento de Pia" },
                    { 4, "Box" },
                    { 3, "Fixo" },
                    { 2, "Porta" },
                    { 1, "Janela" },
                    { 9, "Portas Staley" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd43824d-95de-4b40-be71-f634b75c47be"),
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 10, 20, 27, 33, 541, DateTimeKind.Local).AddTicks(9328), new DateTime(2021, 2, 10, 20, 27, 33, 542, DateTimeKind.Local).AddTicks(9628) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("1aa6b613-2e5c-4024-bdb6-165cb0fc6d8b"));

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProjectType",
                keyColumn: "Id",
                keyValue: 99);

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
    }
}
