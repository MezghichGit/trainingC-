using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst_Demo.Migrations
{
    public partial class UpdatedelabasedeAMS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fournisseur",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NbrProduits",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fournisseur",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "NbrProduits",
                table: "Categories");
        }
    }
}
