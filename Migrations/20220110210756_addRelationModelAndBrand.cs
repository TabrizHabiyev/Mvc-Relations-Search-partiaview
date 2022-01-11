using Microsoft.EntityFrameworkCore.Migrations;

namespace Select_Option_Relations.Migrations
{
    public partial class addRelationModelAndBrand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarModelId",
                table: "carBrands",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "carBrands",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_carBrands_CarModelId",
                table: "carBrands",
                column: "CarModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_carBrands_carModels_CarModelId",
                table: "carBrands",
                column: "CarModelId",
                principalTable: "carModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carBrands_carModels_CarModelId",
                table: "carBrands");

            migrationBuilder.DropIndex(
                name: "IX_carBrands_CarModelId",
                table: "carBrands");

            migrationBuilder.DropColumn(
                name: "CarModelId",
                table: "carBrands");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "carBrands");
        }
    }
}
