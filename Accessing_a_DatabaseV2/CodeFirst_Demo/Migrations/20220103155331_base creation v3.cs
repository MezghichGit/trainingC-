using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst_Demo.Migrations
{
    public partial class basecreationv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdFournisseur",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Fournisseur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fournisseur", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_IdFournisseur",
                table: "Categories",
                column: "IdFournisseur");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Fournisseur_IdFournisseur",
                table: "Categories",
                column: "IdFournisseur",
                principalTable: "Fournisseur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Fournisseur_IdFournisseur",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "Fournisseur");

            migrationBuilder.DropIndex(
                name: "IX_Categories_IdFournisseur",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IdFournisseur",
                table: "Categories");
        }
    }
}
