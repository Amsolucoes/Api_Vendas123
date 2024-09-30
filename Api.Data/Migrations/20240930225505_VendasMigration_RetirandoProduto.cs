using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class VendasMigration_RetirandoProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Fk_Id_Vendas_Produtos",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_Id_Vendas",
                table: "Produtos");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dc680c81-2817-4e9b-b97a-a9d928046176"));

            migrationBuilder.DropColumn(
                name: "Id_Produtos",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Id_Vendas",
                table: "Produtos");

            migrationBuilder.AddColumn<Guid>(
                name: "Vendas",
                table: "Produtos",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("94079bec-6f4d-472b-aa97-f28865e2ca08"), new DateTime(2024, 9, 30, 18, 55, 4, 691, DateTimeKind.Local).AddTicks(7038), "mfrinfo@mail.com", "Administrador", new DateTime(2024, 9, 30, 18, 55, 4, 691, DateTimeKind.Local).AddTicks(7051) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("94079bec-6f4d-472b-aa97-f28865e2ca08"));

            migrationBuilder.DropColumn(
                name: "Vendas",
                table: "Produtos");

            migrationBuilder.AddColumn<Guid>(
                name: "Id_Produtos",
                table: "Produtos",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "Id_Vendas",
                table: "Produtos",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("dc680c81-2817-4e9b-b97a-a9d928046176"), new DateTime(2024, 9, 30, 17, 12, 39, 505, DateTimeKind.Local).AddTicks(8404), "mfrinfo@mail.com", "Administrador", new DateTime(2024, 9, 30, 17, 12, 39, 505, DateTimeKind.Local).AddTicks(8422) });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_Id_Vendas",
                table: "Produtos",
                column: "Id_Vendas");

            migrationBuilder.AddForeignKey(
                name: "Fk_Id_Vendas_Produtos",
                table: "Produtos",
                column: "Id_Vendas",
                principalTable: "Vendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
