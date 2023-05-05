using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace investAPI.Migrations
{
    public partial class crudreityield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Reits",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OrderType",
                table: "Reits",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Yields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    YieldType = table.Column<int>(type: "INTEGER", nullable: false),
                    Ticker = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<double>(type: "REAL", nullable: false),
                    DividendYield = table.Column<double>(type: "REAL", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yields", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Reits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "OrderType" },
                values: new object[] { new DateTime(2001, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Reits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "OrderType" },
                values: new object[] { new DateTime(2001, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2001, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2001, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Yields",
                columns: new[] { "Id", "Date", "DividendYield", "Ticker", "Value", "YieldType" },
                values: new object[] { 1, new DateTime(2001, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.59999999999999998, "MXRF11", 2.5, 0 });

            migrationBuilder.InsertData(
                table: "Yields",
                columns: new[] { "Id", "Date", "DividendYield", "Ticker", "Value", "YieldType" },
                values: new object[] { 2, new DateTime(2001, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.40000000000000002, "HGLG11", 1.8, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Yields");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Reits");

            migrationBuilder.DropColumn(
                name: "OrderType",
                table: "Reits");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateOnly(2001, 11, 10));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateOnly(2001, 11, 10));
        }
    }
}
