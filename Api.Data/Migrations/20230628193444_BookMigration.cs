using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class BookMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ef256aac-2b6e-48e5-a598-814a1e468b65"));

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Price = table.Column<string>(nullable: false),
                    specifications_OriginallyPublished = table.Column<string>(nullable: true),
                    specifications_Author = table.Column<string>(maxLength: 60, nullable: true),
                    specifications_PageCount = table.Column<string>(nullable: true),
                    specifications_Illustrator = table.Column<string>(nullable: true),
                    specifications_Genres = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("2df52f68-a93d-42d2-af09-c54aa302222f"), new DateTime(2023, 6, 28, 15, 34, 44, 80, DateTimeKind.Local).AddTicks(9554), "mfrinfo@mail.com", "Administrador", new DateTime(2023, 6, 28, 15, 34, 44, 82, DateTimeKind.Local).AddTicks(1867) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2df52f68-a93d-42d2-af09-c54aa302222f"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("ef256aac-2b6e-48e5-a598-814a1e468b65"), new DateTime(2020, 7, 18, 9, 49, 14, 477, DateTimeKind.Local).AddTicks(1482), "mfrinfo@mail.com", "Administrador", new DateTime(2020, 7, 18, 9, 49, 14, 477, DateTimeKind.Local).AddTicks(9678) });
        }
    }
}
