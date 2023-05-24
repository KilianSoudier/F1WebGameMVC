using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1WebGame.Migrations
{
    /// <inheritdoc />
    public partial class initial6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classement",
                columns: table => new
                {
                    ClassementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    piloteidPilote = table.Column<int>(type: "int", nullable: false),
                    pointsPilotes = table.Column<int>(type: "int", nullable: false),
                    ecurieidEcurie = table.Column<int>(type: "int", nullable: false),
                    pointsConstructeur = table.Column<int>(type: "int", nullable: false),
                    CircuitidCircuit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classement", x => x.ClassementId);
                    table.ForeignKey(
                        name: "FK_Classement_Circuit_CircuitidCircuit",
                        column: x => x.CircuitidCircuit,
                        principalTable: "Circuit",
                        principalColumn: "idCircuit",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Classement_Ecuries_ecurieidEcurie",
                        column: x => x.ecurieidEcurie,
                        principalTable: "Ecuries",
                        principalColumn: "idEcurie",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Classement_Pilote_piloteidPilote",
                        column: x => x.piloteidPilote,
                        principalTable: "Pilote",
                        principalColumn: "idPilote",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classement_CircuitidCircuit",
                table: "Classement",
                column: "CircuitidCircuit");

            migrationBuilder.CreateIndex(
                name: "IX_Classement_ecurieidEcurie",
                table: "Classement",
                column: "ecurieidEcurie");

            migrationBuilder.CreateIndex(
                name: "IX_Classement_piloteidPilote",
                table: "Classement",
                column: "piloteidPilote");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classement");
        }
    }
}
