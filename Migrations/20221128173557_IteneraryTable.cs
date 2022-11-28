using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightSearchAssingment.Migrations
{
    /// <inheritdoc />
    public partial class IteneraryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PriceList_Flights_FlightId",
                table: "PriceList");

            migrationBuilder.DropForeignKey(
                name: "FK_PriceList_PriceList_PriceListPricesId",
                table: "PriceList");

            migrationBuilder.DropIndex(
                name: "IX_PriceList_FlightId",
                table: "PriceList");

            migrationBuilder.DropIndex(
                name: "IX_PriceList_PriceListPricesId",
                table: "PriceList");

            migrationBuilder.DropColumn(
                name: "ArrivalTime",
                table: "PriceList");

            migrationBuilder.DropColumn(
                name: "AvailableSeats",
                table: "PriceList");

            migrationBuilder.DropColumn(
                name: "DepartureTime",
                table: "PriceList");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "PriceList");

            migrationBuilder.DropColumn(
                name: "FlightId",
                table: "PriceList");

            migrationBuilder.DropColumn(
                name: "IteneraryID",
                table: "PriceList");

            migrationBuilder.DropColumn(
                name: "PriceListPricesId",
                table: "PriceList");

            migrationBuilder.CreateTable(
                name: "Iteneraries",
                columns: table => new
                {
                    IteneraryID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DepartureTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AvailableSeats = table.Column<int>(type: "INTEGER", nullable: false),
                    FlightId = table.Column<int>(type: "INTEGER", nullable: false),
                    PriceListPricesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iteneraries", x => x.IteneraryID);
                    table.ForeignKey(
                        name: "FK_Iteneraries_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Iteneraries_PriceList_PriceListPricesId",
                        column: x => x.PriceListPricesId,
                        principalTable: "PriceList",
                        principalColumn: "PricesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Iteneraries_FlightId",
                table: "Iteneraries",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Iteneraries_PriceListPricesId",
                table: "Iteneraries",
                column: "PriceListPricesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Iteneraries");

            migrationBuilder.AddColumn<DateTime>(
                name: "ArrivalTime",
                table: "PriceList",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AvailableSeats",
                table: "PriceList",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DepartureTime",
                table: "PriceList",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "PriceList",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FlightId",
                table: "PriceList",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IteneraryID",
                table: "PriceList",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PriceListPricesId",
                table: "PriceList",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PriceList_FlightId",
                table: "PriceList",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceList_PriceListPricesId",
                table: "PriceList",
                column: "PriceListPricesId");

            migrationBuilder.AddForeignKey(
                name: "FK_PriceList_Flights_FlightId",
                table: "PriceList",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PriceList_PriceList_PriceListPricesId",
                table: "PriceList",
                column: "PriceListPricesId",
                principalTable: "PriceList",
                principalColumn: "PricesId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
