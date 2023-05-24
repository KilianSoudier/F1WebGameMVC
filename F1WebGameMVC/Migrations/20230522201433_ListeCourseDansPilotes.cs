using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1WebGame.Migrations
{
    /// <inheritdoc />
    public partial class ListeCourseDansPilotes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pilote_Courses_CourseidCourse",
                table: "Pilote");

            migrationBuilder.DropIndex(
                name: "IX_Pilote_CourseidCourse",
                table: "Pilote");

            migrationBuilder.DropColumn(
                name: "CourseidCourse",
                table: "Pilote");

            migrationBuilder.CreateTable(
                name: "CoursePilote",
                columns: table => new
                {
                    CoursesidCourse = table.Column<int>(type: "int", nullable: false),
                    pilotesidPilote = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursePilote", x => new { x.CoursesidCourse, x.pilotesidPilote });
                    table.ForeignKey(
                        name: "FK_CoursePilote_Courses_CoursesidCourse",
                        column: x => x.CoursesidCourse,
                        principalTable: "Courses",
                        principalColumn: "idCourse",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursePilote_Pilote_pilotesidPilote",
                        column: x => x.pilotesidPilote,
                        principalTable: "Pilote",
                        principalColumn: "idPilote",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoursePilote_pilotesidPilote",
                table: "CoursePilote",
                column: "pilotesidPilote");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoursePilote");

            migrationBuilder.AddColumn<int>(
                name: "CourseidCourse",
                table: "Pilote",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pilote_CourseidCourse",
                table: "Pilote",
                column: "CourseidCourse");

            migrationBuilder.AddForeignKey(
                name: "FK_Pilote_Courses_CourseidCourse",
                table: "Pilote",
                column: "CourseidCourse",
                principalTable: "Courses",
                principalColumn: "idCourse");
        }
    }
}
