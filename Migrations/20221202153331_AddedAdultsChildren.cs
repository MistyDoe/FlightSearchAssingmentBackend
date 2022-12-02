using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightSearchAssingment.Migrations
{
    /// <inheritdoc />
    public partial class AddedAdultsChildren : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Adults",
                table: "Flights",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Children",
                table: "Flights",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adults",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Children",
                table: "Flights");
        }
    }
}
