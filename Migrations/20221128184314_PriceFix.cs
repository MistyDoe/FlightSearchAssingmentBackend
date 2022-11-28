using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightSearchAssingment.Migrations
{
    /// <inheritdoc />
    public partial class PriceFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Iteneraries_PriceList_PriceListPricesId",
                table: "Iteneraries");

            migrationBuilder.DropIndex(
                name: "IX_Iteneraries_PriceListPricesId",
                table: "Iteneraries");

            migrationBuilder.DropColumn(
                name: "PriceListPricesId",
                table: "Iteneraries");

            migrationBuilder.AlterColumn<string>(
                name: "PricesId",
                table: "PriceList",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "IteneraryID",
                table: "PriceList",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "FlightId",
                table: "Iteneraries",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "IteneraryID",
                table: "Iteneraries",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "FlightId",
                table: "Flights",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateIndex(
                name: "IX_PriceList_IteneraryID",
                table: "PriceList",
                column: "IteneraryID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PriceList_Iteneraries_IteneraryID",
                table: "PriceList",
                column: "IteneraryID",
                principalTable: "Iteneraries",
                principalColumn: "IteneraryID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PriceList_Iteneraries_IteneraryID",
                table: "PriceList");

            migrationBuilder.DropIndex(
                name: "IX_PriceList_IteneraryID",
                table: "PriceList");

            migrationBuilder.DropColumn(
                name: "IteneraryID",
                table: "PriceList");

            migrationBuilder.AlterColumn<int>(
                name: "PricesId",
                table: "PriceList",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "FlightId",
                table: "Iteneraries",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "IteneraryID",
                table: "Iteneraries",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "PriceListPricesId",
                table: "Iteneraries",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "FlightId",
                table: "Flights",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateIndex(
                name: "IX_Iteneraries_PriceListPricesId",
                table: "Iteneraries",
                column: "PriceListPricesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Iteneraries_PriceList_PriceListPricesId",
                table: "Iteneraries",
                column: "PriceListPricesId",
                principalTable: "PriceList",
                principalColumn: "PricesId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
