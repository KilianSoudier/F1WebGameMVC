using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1WebGame.Migrations
{
    /// <inheritdoc />
    public partial class initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pays",
                columns: table => new
                {
                    idPays = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    photoDrapeau = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pays", x => x.idPays);
                });

            migrationBuilder.AddColumn<int>(
                name: "PaysidPays",
                table: "Pilote",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaysidPays",
                table: "Ecuries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaysidPays",
                table: "Circuit",
                type: "int",
                nullable: false,
                defaultValue: 0);


            migrationBuilder.CreateIndex(
                name: "IX_Pilote_PaysidPays",
                table: "Pilote",
                column: "PaysidPays");

            migrationBuilder.CreateIndex(
                name: "IX_Ecuries_PaysidPays",
                table: "Ecuries",
                column: "PaysidPays");

            migrationBuilder.CreateIndex(
                name: "IX_Circuit_PaysidPays",
                table: "Circuit",
                column: "PaysidPays");

            migrationBuilder.AddForeignKey(
                name: "FK_Circuit_Pays_PaysidPays",
                table: "Circuit",
                column: "PaysidPays",
                principalTable: "Pays",
                principalColumn: "idPays",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Ecuries_Pays_PaysidPays",
                table: "Ecuries",
                column: "PaysidPays",
                principalTable: "Pays",
                principalColumn: "idPays",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Pilote_Pays_PaysidPays",
                table: "Pilote",
                column: "PaysidPays",
                principalTable: "Pays",
                principalColumn: "idPays",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Circuit_Pays_PaysidPays",
                table: "Circuit");

            migrationBuilder.DropForeignKey(
                name: "FK_Ecuries_Pays_PaysidPays",
                table: "Ecuries");

            migrationBuilder.DropForeignKey(
                name: "FK_Pilote_Pays_PaysidPays",
                table: "Pilote");

            migrationBuilder.DropTable(
                name: "Pays");

            migrationBuilder.DropIndex(
                name: "IX_Pilote_PaysidPays",
                table: "Pilote");

            migrationBuilder.DropIndex(
                name: "IX_Ecuries_PaysidPays",
                table: "Ecuries");

            migrationBuilder.DropIndex(
                name: "IX_Circuit_PaysidPays",
                table: "Circuit");

            migrationBuilder.DropColumn(
                name: "PaysidPays",
                table: "Pilote");

            migrationBuilder.DropColumn(
                name: "PaysidPays",
                table: "Ecuries");

            migrationBuilder.DropColumn(
                name: "PaysidPays",
                table: "Circuit");
        }
    }
}
