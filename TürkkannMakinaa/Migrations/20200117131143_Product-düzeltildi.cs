using Microsoft.EntityFrameworkCore.Migrations;

namespace TürkkannMakinaa.Migrations
{
    public partial class Productdüzeltildi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OriginalName",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OriginalName",
                table: "Products");
        }
    }
}
