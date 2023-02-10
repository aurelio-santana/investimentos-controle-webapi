using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace investAPI.Migrations
{
    public partial class verificaProjeto2023 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "total",
                table: "Stocks",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "ticker",
                table: "Stocks",
                newName: "Ticker");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "Stocks",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "profit",
                table: "Stocks",
                newName: "Profit");

            migrationBuilder.RenameColumn(
                name: "currentQuote",
                table: "Stocks",
                newName: "CurrentQuote");

            migrationBuilder.RenameColumn(
                name: "averagePrice",
                table: "Stocks",
                newName: "AveragePrice");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Stocks",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "total",
                table: "Reits",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "ticker",
                table: "Reits",
                newName: "Ticker");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "Reits",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "profit",
                table: "Reits",
                newName: "Profit");

            migrationBuilder.RenameColumn(
                name: "currentQuote",
                table: "Reits",
                newName: "CurrentQuote");

            migrationBuilder.RenameColumn(
                name: "averagePrice",
                table: "Reits",
                newName: "AveragePrice");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Reits",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Profit", "Ticker" },
                values: new object[] { 105f, "CEMIG3 api" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Stocks",
                newName: "total");

            migrationBuilder.RenameColumn(
                name: "Ticker",
                table: "Stocks",
                newName: "ticker");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Stocks",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Profit",
                table: "Stocks",
                newName: "profit");

            migrationBuilder.RenameColumn(
                name: "CurrentQuote",
                table: "Stocks",
                newName: "currentQuote");

            migrationBuilder.RenameColumn(
                name: "AveragePrice",
                table: "Stocks",
                newName: "averagePrice");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Stocks",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Reits",
                newName: "total");

            migrationBuilder.RenameColumn(
                name: "Ticker",
                table: "Reits",
                newName: "ticker");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Reits",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Profit",
                table: "Reits",
                newName: "profit");

            migrationBuilder.RenameColumn(
                name: "CurrentQuote",
                table: "Reits",
                newName: "currentQuote");

            migrationBuilder.RenameColumn(
                name: "AveragePrice",
                table: "Reits",
                newName: "averagePrice");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Reits",
                newName: "id");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "profit", "ticker" },
                values: new object[] { 10f, "CEMIG3" });
        }
    }
}
