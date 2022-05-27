using Microsoft.EntityFrameworkCore.Migrations;

namespace TürkkannMakinaa.Migrations
{
    public partial class Entitiesdüzenlendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPhoto_Products_ProductID",
                table: "ProductPhoto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductPhoto",
                table: "ProductPhoto");

            migrationBuilder.RenameTable(
                name: "ProductPhoto",
                newName: "ProductPhotos");

            migrationBuilder.RenameColumn(
                name: "Thumbnail",
                table: "ProductPhotos",
                newName: "OrginalFileName");

            migrationBuilder.RenameColumn(
                name: "Orginal",
                table: "ProductPhotos",
                newName: "FileUrl");

            migrationBuilder.RenameIndex(
                name: "IX_ProductPhoto_ProductID",
                table: "ProductPhotos",
                newName: "IX_ProductPhotos_ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductPhotos",
                table: "ProductPhotos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPhotos_Products_ProductID",
                table: "ProductPhotos",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPhotos_Products_ProductID",
                table: "ProductPhotos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductPhotos",
                table: "ProductPhotos");

            migrationBuilder.RenameTable(
                name: "ProductPhotos",
                newName: "ProductPhoto");

            migrationBuilder.RenameColumn(
                name: "OrginalFileName",
                table: "ProductPhoto",
                newName: "Thumbnail");

            migrationBuilder.RenameColumn(
                name: "FileUrl",
                table: "ProductPhoto",
                newName: "Orginal");

            migrationBuilder.RenameIndex(
                name: "IX_ProductPhotos_ProductID",
                table: "ProductPhoto",
                newName: "IX_ProductPhoto_ProductID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductPhoto",
                table: "ProductPhoto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPhoto_Products_ProductID",
                table: "ProductPhoto",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
