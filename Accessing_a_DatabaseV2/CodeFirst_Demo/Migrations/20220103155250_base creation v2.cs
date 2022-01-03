using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst_Demo.Migrations
{
    public partial class basecreationv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCategorie",
                table: "Produits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Produits_IdCategorie",
                table: "Produits",
                column: "IdCategorie");

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Categories_IdCategorie",
                table: "Produits",
                column: "IdCategorie",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Categories_IdCategorie",
                table: "Produits");

            migrationBuilder.DropIndex(
                name: "IX_Produits_IdCategorie",
                table: "Produits");

            migrationBuilder.DropColumn(
                name: "IdCategorie",
                table: "Produits");
        }
    }
}
