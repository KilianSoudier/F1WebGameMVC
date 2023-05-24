using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1WebGame.Migrations
{
    /// <inheritdoc />
    public partial class ajoutPneus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "pneusId",
                table: "Tour",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "usurePneus",
                table: "Tour",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "Pneus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    distanceMin = table.Column<int>(type: "int", nullable: false),
                    distanceMax = table.Column<int>(type: "int", nullable: false),
                    pourcentageFiable = table.Column<float>(type: "real", nullable: false),
                    SaisonidSaison = table.Column<int>(type: "int", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pneus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pneus_Saison_SaisonidSaison",
                        column: x => x.SaisonidSaison,
                        principalTable: "Saison",
                        principalColumn: "idSaison",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tour_pneusId",
                table: "Tour",
                column: "pneusId");

            migrationBuilder.CreateIndex(
                name: "IX_Pneus_SaisonidSaison",
                table: "Pneus",
                column: "SaisonidSaison");

            migrationBuilder.AddForeignKey(
                name: "FK_Tour_Pneus_pneusId",
                table: "Tour",
                column: "pneusId",
                principalTable: "Pneus",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tour_Pneus_pneusId",
                table: "Tour");

            migrationBuilder.DropTable(
                name: "Pneus");

            migrationBuilder.DropIndex(
                name: "IX_Tour_pneusId",
                table: "Tour");

            migrationBuilder.DropColumn(
                name: "pneusId",
                table: "Tour");

            migrationBuilder.DropColumn(
                name: "usurePneus",
                table: "Tour");
        }
    }
}
