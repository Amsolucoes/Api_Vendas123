using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class VendasMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2df52f68-a93d-42d2-af09-c54aa302222f"));

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Numero = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    DataVenda = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Cliente = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorTotalVendas = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Filial = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Desconto = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Cancelado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Id_Vendas = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Id_Produtos = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "Fk_Id_Vendas_Produtos",
                        column: x => x.Id_Vendas,
                        principalTable: "Vendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("dc680c81-2817-4e9b-b97a-a9d928046176"), new DateTime(2024, 9, 30, 17, 12, 39, 505, DateTimeKind.Local).AddTicks(8404), "mfrinfo@mail.com", "Administrador", new DateTime(2024, 9, 30, 17, 12, 39, 505, DateTimeKind.Local).AddTicks(8422) });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_Id_Vendas",
                table: "Produtos",
                column: "Id_Vendas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dc680c81-2817-4e9b-b97a-a9d928046176"));

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    specifications_Author = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    specifications_Genres = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    specifications_Illustrator = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    specifications_OriginallyPublished = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    specifications_PageCount = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("2df52f68-a93d-42d2-af09-c54aa302222f"), new DateTime(2023, 6, 28, 15, 34, 44, 80, DateTimeKind.Local).AddTicks(9554), "mfrinfo@mail.com", "Administrador", new DateTime(2023, 6, 28, 15, 34, 44, 82, DateTimeKind.Local).AddTicks(1867) });
        }
    }
}
