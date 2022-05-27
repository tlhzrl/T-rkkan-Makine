using Microsoft.EntityFrameworkCore.Migrations;

namespace TürkkannMakinaa.Migrations
{
    public partial class ProductPhotoupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPhotos_Products_ProductID",
                table: "ProductPhotos");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "ProductPhotos",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductPhotos_ProductID",
                table: "ProductPhotos",
                newName: "IX_ProductPhotos_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPhotos_Products_ProductId",
                table: "ProductPhotos",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPhotos_Products_ProductId",
                table: "ProductPhotos");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductPhotos",
                newName: "ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductPhotos_ProductId",
                table: "ProductPhotos",
                newName: "IX_ProductPhotos_ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPhotos_Products_ProductID",
                table: "ProductPhotos",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
