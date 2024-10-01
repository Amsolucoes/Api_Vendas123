using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class VendasMigration_AjusteNumero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("94079bec-6f4d-472b-aa97-f28865e2ca08"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("84adb3ea-7b1f-4ecb-baf2-d6f80e56021e"), new DateTime(2024, 10, 1, 8, 44, 44, 954, DateTimeKind.Local).AddTicks(4279), "mfrinfo@mail.com", "Administrador", new DateTime(2024, 10, 1, 8, 44, 44, 954, DateTimeKind.Local).AddTicks(4292) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("84adb3ea-7b1f-4ecb-baf2-d6f80e56021e"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("94079bec-6f4d-472b-aa97-f28865e2ca08"), new DateTime(2024, 9, 30, 18, 55, 4, 691, DateTimeKind.Local).AddTicks(7038), "mfrinfo@mail.com", "Administrador", new DateTime(2024, 9, 30, 18, 55, 4, 691, DateTimeKind.Local).AddTicks(7051) });
        }
    }
}
