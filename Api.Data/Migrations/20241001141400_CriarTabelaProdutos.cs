using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class CriarTabelaProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("94079bec-6f4d-472b-aa97-f28865e2ca08"));

            migrationBuilder.DropColumn(
                name: "Cancelado",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Desconto",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ValorTotal",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Vendas",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "ValorUnitario",
                table: "Produtos",
                newName: "Preco");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ComprarEntityProdutoEntity",
                columns: table => new
                {
                    ComprasId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProdutosId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComprarEntityProdutoEntity", x => new { x.ComprasId, x.ProdutosId });
                    table.ForeignKey(
                        name: "FK_ComprarEntityProdutoEntity_Produtos_ProdutosId",
                        column: x => x.ProdutosId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComprarEntityProdutoEntity_Vendas_ComprasId",
                        column: x => x.ComprasId,
                        principalTable: "Vendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("d28debd0-290f-4fc0-8084-501982a440ad"), new DateTime(2024, 10, 1, 11, 13, 59, 967, DateTimeKind.Local).AddTicks(9399), "mfrinfo@mail.com", "Administrador", new DateTime(2024, 10, 1, 11, 13, 59, 967, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.CreateIndex(
                name: "IX_ComprarEntityProdutoEntity_ProdutosId",
                table: "ComprarEntityProdutoEntity",
                column: "ProdutosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComprarEntityProdutoEntity");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d28debd0-290f-4fc0-8084-501982a440ad"));

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Produtos",
                newName: "ValorUnitario");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "Cancelado",
                table: "Produtos",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Desconto",
                table: "Produtos",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorTotal",
                table: "Produtos",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

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
    }
}
