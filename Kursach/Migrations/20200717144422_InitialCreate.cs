using Microsoft.EntityFrameworkCore.Migrations;

namespace Kursach.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    productId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    type = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.productId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
