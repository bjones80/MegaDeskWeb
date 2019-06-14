using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskWeb.Migrations
{
    public partial class foreignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Quote_DeliveryId",
                table: "Quote",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_Quote_DeskId",
                table: "Quote",
                column: "DeskId");

            migrationBuilder.CreateIndex(
                name: "IX_Desk_SurfaceMaterialId",
                table: "Desk",
                column: "SurfaceMaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Desk_SurfaceMaterial_SurfaceMaterialId",
                table: "Desk",
                column: "SurfaceMaterialId",
                principalTable: "SurfaceMaterial",
                principalColumn: "SurfaceMaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quote_Delivery_DeliveryId",
                table: "Quote",
                column: "DeliveryId",
                principalTable: "Delivery",
                principalColumn: "DeliveryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quote_Desk_DeskId",
                table: "Quote",
                column: "DeskId",
                principalTable: "Desk",
                principalColumn: "DeskId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Desk_SurfaceMaterial_SurfaceMaterialId",
                table: "Desk");

            migrationBuilder.DropForeignKey(
                name: "FK_Quote_Delivery_DeliveryId",
                table: "Quote");

            migrationBuilder.DropForeignKey(
                name: "FK_Quote_Desk_DeskId",
                table: "Quote");

            migrationBuilder.DropIndex(
                name: "IX_Quote_DeliveryId",
                table: "Quote");

            migrationBuilder.DropIndex(
                name: "IX_Quote_DeskId",
                table: "Quote");

            migrationBuilder.DropIndex(
                name: "IX_Desk_SurfaceMaterialId",
                table: "Desk");
        }
    }
}
