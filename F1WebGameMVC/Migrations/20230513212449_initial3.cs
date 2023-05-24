using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1WebGame.Migrations
{
    /// <inheritdoc />
    public partial class initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "distanceTour",
                table: "Circuit",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "nbTours",
                table: "Circuit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "premierGP",
                table: "Circuit",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "recordTour",
                table: "Circuit",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "tempsMoyen",
                table: "Circuit",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "distanceTour",
                table: "Circuit");

            migrationBuilder.DropColumn(
                name: "nbTours",
                table: "Circuit");

            migrationBuilder.DropColumn(
                name: "premierGP",
                table: "Circuit");

            migrationBuilder.DropColumn(
                name: "recordTour",
                table: "Circuit");

            migrationBuilder.DropColumn(
                name: "tempsMoyen",
                table: "Circuit");
        }
    }
}
