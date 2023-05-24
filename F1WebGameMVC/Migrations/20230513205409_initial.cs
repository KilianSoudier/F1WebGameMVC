using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1WebGame.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ecuries",
                columns: table => new
                {
                    idEcurie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomEcurie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ecuries", x => x.idEcurie);
                });

            migrationBuilder.CreateTable(
                name: "Saison",
                columns: table => new
                {
                    idSaison = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libelleSaison = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saison", x => x.idSaison);
                });

            migrationBuilder.CreateTable(
                name: "Circuit",
                columns: table => new
                {
                    idCircuit = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    saisonidSaison = table.Column<int>(type: "int", nullable: false),
                    usurePneus = table.Column<int>(type: "int", nullable: false),
                    usureEssence = table.Column<int>(type: "int", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circuit", x => x.idCircuit);
                    table.ForeignKey(
                        name: "FK_Circuit_Saison_saisonidSaison",
                        column: x => x.saisonidSaison,
                        principalTable: "Saison",
                        principalColumn: "idSaison",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voiture",
                columns: table => new
                {
                    idVoiture = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomVoiture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ecurieidEcurie = table.Column<int>(type: "int", nullable: false),
                    vitessePointe = table.Column<int>(type: "int", nullable: false),
                    maniabilite = table.Column<int>(type: "int", nullable: false),
                    economieEssence = table.Column<int>(type: "int", nullable: false),
                    economiePneus = table.Column<int>(type: "int", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    saisonidSaison = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voiture", x => x.idVoiture);
                    table.ForeignKey(
                        name: "FK_Voiture_Ecuries_ecurieidEcurie",
                        column: x => x.ecurieidEcurie,
                        principalTable: "Ecuries",
                        principalColumn: "idEcurie",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Voiture_Saison_saisonidSaison",
                        column: x => x.saisonidSaison,
                        principalTable: "Saison",
                        principalColumn: "idSaison",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pilote",
                columns: table => new
                {
                    idPilote = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoitureidVoiture = table.Column<int>(type: "int", nullable: false),
                    vitessePointe = table.Column<int>(type: "int", nullable: false),
                    vitesseVirage = table.Column<int>(type: "int", nullable: false),
                    economiePneus = table.Column<int>(type: "int", nullable: false),
                    economieEssence = table.Column<int>(type: "int", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pilote", x => x.idPilote);
                    table.ForeignKey(
                        name: "FK_Pilote_Voiture_VoitureidVoiture",
                        column: x => x.VoitureidVoiture,
                        principalTable: "Voiture",
                        principalColumn: "idVoiture",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Circuit_saisonidSaison",
                table: "Circuit",
                column: "saisonidSaison");

            migrationBuilder.CreateIndex(
                name: "IX_Pilote_VoitureidVoiture",
                table: "Pilote",
                column: "VoitureidVoiture");

            migrationBuilder.CreateIndex(
                name: "IX_Voiture_ecurieidEcurie",
                table: "Voiture",
                column: "ecurieidEcurie");

            migrationBuilder.CreateIndex(
                name: "IX_Voiture_saisonidSaison",
                table: "Voiture",
                column: "saisonidSaison");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Circuit");

            migrationBuilder.DropTable(
                name: "Pilote");

            migrationBuilder.DropTable(
                name: "Voiture");

            migrationBuilder.DropTable(
                name: "Ecuries");

            migrationBuilder.DropTable(
                name: "Saison");
        }
    }
}
