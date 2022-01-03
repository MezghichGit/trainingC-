using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst_Demo.Migrations
{
    public partial class Creationdemabaseavec3entités : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Fournisseur_IdFournisseur",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fournisseur",
                table: "Fournisseur");

            migrationBuilder.RenameTable(
                name: "Fournisseur",
                newName: "Fournisseurs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fournisseurs",
                table: "Fournisseurs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Fournisseurs_IdFournisseur",
                table: "Categories",
                column: "IdFournisseur",
                principalTable: "Fournisseurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Fournisseurs_IdFournisseur",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fournisseurs",
                table: "Fournisseurs");

            migrationBuilder.RenameTable(
                name: "Fournisseurs",
                newName: "Fournisseur");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fournisseur",
                table: "Fournisseur",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Fournisseur_IdFournisseur",
                table: "Categories",
                column: "IdFournisseur",
                principalTable: "Fournisseur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
