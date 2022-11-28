using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightSearchAssingment.Migrations
{
    /// <inheritdoc />
    public partial class FullInitialShema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PriceList",
                columns: table => new
                {
                    PricesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Currency = table.Column<string>(type: "TEXT", nullable: false),
                    AdultPrice = table.Column<int>(type: "INTEGER", nullable: false),
                    ChildPrice = table.Column<int>(type: "INTEGER", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    IteneraryID = table.Column<int>(type: "INTEGER", nullable: true),
                    DepartureTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ArrivalTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    AvailableSeats = table.Column<int>(type: "INTEGER", nullable: true),
                    FlightId = table.Column<int>(type: "INTEGER", nullable: true),
                    PriceListPricesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceList", x => x.PricesId);
                    table.ForeignKey(
                        name: "FK_PriceList_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PriceList_PriceList_PriceListPricesId",
                        column: x => x.PriceListPricesId,
                        principalTable: "PriceList",
                        principalColumn: "PricesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PriceList_FlightId",
                table: "PriceList",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceList_PriceListPricesId",
                table: "PriceList",
                column: "PriceListPricesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PriceList");
        }
    }
}
