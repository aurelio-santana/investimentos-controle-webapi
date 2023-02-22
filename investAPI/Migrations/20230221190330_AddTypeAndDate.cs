using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace investAPI.Migrations
{
    public partial class AddTypeAndDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "Date",
                table: "Stocks",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<int>(
                name: "OrderType",
                table: "Stocks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "OrderType" },
                values: new object[] { new DateOnly(2001, 11, 10), 1 });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "OrderType" },
                values: new object[] { new DateOnly(2001, 11, 10), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "OrderType",
                table: "Stocks");
        }
    }
}
