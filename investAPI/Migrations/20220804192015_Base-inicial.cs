using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace investAPI.Migrations
{
    public partial class Baseinicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reits",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ticker = table.Column<string>(type: "TEXT", nullable: false),
                    quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    averagePrice = table.Column<float>(type: "REAL", nullable: false),
                    total = table.Column<float>(type: "REAL", nullable: false),
                    currentQuote = table.Column<float>(type: "REAL", nullable: false),
                    profit = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reits", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ticker = table.Column<string>(type: "TEXT", nullable: false),
                    quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    averagePrice = table.Column<float>(type: "REAL", nullable: false),
                    total = table.Column<float>(type: "REAL", nullable: false),
                    currentQuote = table.Column<float>(type: "REAL", nullable: false),
                    profit = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Reits",
                columns: new[] { "id", "averagePrice", "currentQuote", "profit", "quantity", "ticker", "total" },
                values: new object[] { 1, 10f, 15f, 10f, 2, "MXRF11", 20f });

            migrationBuilder.InsertData(
                table: "Reits",
                columns: new[] { "id", "averagePrice", "currentQuote", "profit", "quantity", "ticker", "total" },
                values: new object[] { 2, 10f, 15f, 10f, 2, "HGLG11", 20f });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "id", "averagePrice", "currentQuote", "profit", "quantity", "ticker", "total" },
                values: new object[] { 1, 10f, 15f, 10f, 2, "CEMIG3", 20f });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "id", "averagePrice", "currentQuote", "profit", "quantity", "ticker", "total" },
                values: new object[] { 2, 10f, 15f, 10f, 2, "WEG3", 20f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reits");

            migrationBuilder.DropTable(
                name: "Stocks");
        }
    }
}
