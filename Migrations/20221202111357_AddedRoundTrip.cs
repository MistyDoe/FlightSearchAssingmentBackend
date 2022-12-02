using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightSearchAssingment.Migrations
{
    /// <inheritdoc />
    public partial class AddedRoundTrip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "RoundTrip",
                table: "Flights",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoundTrip",
                table: "Flights");
        }
    }
}
