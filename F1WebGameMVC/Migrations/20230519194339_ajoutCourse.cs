using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1WebGame.Migrations
{
    /// <inheritdoc />
    public partial class ajoutCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseidCourse",
                table: "Pilote",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    idCourse = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    saisonidSaison = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CircuitidCircuit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.idCourse);
                    table.ForeignKey(
                        name: "FK_Courses_Circuit_CircuitidCircuit",
                        column: x => x.CircuitidCircuit,
                        principalTable: "Circuit",
                        principalColumn: "idCircuit",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Courses_Saison_saisonidSaison",
                        column: x => x.saisonidSaison,
                        principalTable: "Saison",
                        principalColumn: "idSaison",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tour",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nb = table.Column<int>(type: "int", nullable: false),
                    PiloteidPilote = table.Column<int>(type: "int", nullable: false),
                    CourseidCourse = table.Column<int>(type: "int", nullable: false),
                    tempsTour = table.Column<TimeSpan>(type: "time", nullable: false),
                    abandon = table.Column<bool>(type: "bit", nullable: false),
                    erreurMajeure = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tour_Courses_CourseidCourse",
                        column: x => x.CourseidCourse,
                        principalTable: "Courses",
                        principalColumn: "idCourse",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tour_Pilote_PiloteidPilote",
                        column: x => x.PiloteidPilote,
                        principalTable: "Pilote",
                        principalColumn: "idPilote",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pilote_CourseidCourse",
                table: "Pilote",
                column: "CourseidCourse");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CircuitidCircuit",
                table: "Courses",
                column: "CircuitidCircuit");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_saisonidSaison",
                table: "Courses",
                column: "saisonidSaison");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_CourseidCourse",
                table: "Tour",
                column: "CourseidCourse");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_PiloteidPilote",
                table: "Tour",
                column: "PiloteidPilote");

            migrationBuilder.AddForeignKey(
                name: "FK_Pilote_Courses_CourseidCourse",
                table: "Pilote",
                column: "CourseidCourse",
                principalTable: "Courses",
                principalColumn: "idCourse");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pilote_Courses_CourseidCourse",
                table: "Pilote");

            migrationBuilder.DropTable(
                name: "Tour");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Pilote_CourseidCourse",
                table: "Pilote");

            migrationBuilder.DropColumn(
                name: "CourseidCourse",
                table: "Pilote");
        }
    }
}
