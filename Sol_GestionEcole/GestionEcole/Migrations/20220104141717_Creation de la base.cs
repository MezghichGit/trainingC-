using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionEcole.Migrations
{
    public partial class Creationdelabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DAOGroupes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DAOGroupes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DAOEtudiants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    IdGroupe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DAOEtudiants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DAOEtudiants_DAOGroupes_IdGroupe",
                        column: x => x.IdGroupe,
                        principalTable: "DAOGroupes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DAOEtudiants_IdGroupe",
                table: "DAOEtudiants",
                column: "IdGroupe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DAOEtudiants");

            migrationBuilder.DropTable(
                name: "DAOGroupes");
        }
    }
}
