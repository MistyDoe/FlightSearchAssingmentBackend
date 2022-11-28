using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightSearchAssingment.Migrations
{
    /// <inheritdoc />
    public partial class FlightIdFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PriceList_IteneraryID",
                table: "PriceList");

            migrationBuilder.CreateIndex(
                name: "IX_PriceList_IteneraryID",
                table: "PriceList",
                column: "IteneraryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PriceList_IteneraryID",
                table: "PriceList");

            migrationBuilder.CreateIndex(
                name: "IX_PriceList_IteneraryID",
                table: "PriceList",
                column: "IteneraryID",
                unique: true);
        }
    }
}
