using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1WebGame.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "photo",
                table: "Saison");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "photo",
                table: "Saison",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
