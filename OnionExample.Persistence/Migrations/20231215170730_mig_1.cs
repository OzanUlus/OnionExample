using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnionExample.Persistence.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("1dddaca5-89ee-4a21-b023-1392cb5eceb5"), "d4", "p4", 40m, 400 },
                    { new Guid("54f769e8-9e35-44b3-af1a-7378c2715e3d"), "d1", "p1", 10m, 100 },
                    { new Guid("70584e0d-8788-44c3-9032-2af7002ef898"), "d3", "p3", 30m, 300 },
                    { new Guid("cd4a6f82-6530-47a9-b269-f9edc28fcbbc"), "d2", "p2", 20m, 200 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
