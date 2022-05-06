using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KapsamliProje.Dal.Migrations
{
    public partial class fk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FatDetail_Products_ProductId",
                table: "FatDetail");

            migrationBuilder.DropIndex(
                name: "IX_FatDetail_ProductId",
                table: "FatDetail");

            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "FatDetail",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FatDetail_ProductsId",
                table: "FatDetail",
                column: "ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_FatDetail_Products_ProductsId",
                table: "FatDetail",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FatDetail_Products_ProductsId",
                table: "FatDetail");

            migrationBuilder.DropIndex(
                name: "IX_FatDetail_ProductsId",
                table: "FatDetail");

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "FatDetail");

            migrationBuilder.CreateIndex(
                name: "IX_FatDetail_ProductId",
                table: "FatDetail",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_FatDetail_Products_ProductId",
                table: "FatDetail",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
