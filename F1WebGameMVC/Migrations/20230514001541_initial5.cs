using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1WebGame.Migrations
{
    /// <inheritdoc />
    public partial class initial5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ordre",
                table: "Pilote",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ordre",
                table: "Ecuries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ligneDroite",
                table: "Circuit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ordre",
                table: "Circuit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "virages",
                table: "Circuit",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ordre",
                table: "Pilote");

            migrationBuilder.DropColumn(
                name: "ordre",
                table: "Ecuries");

            migrationBuilder.DropColumn(
                name: "ligneDroite",
                table: "Circuit");

            migrationBuilder.DropColumn(
                name: "ordre",
                table: "Circuit");

            migrationBuilder.DropColumn(
                name: "virages",
                table: "Circuit");
        }
    }
}
