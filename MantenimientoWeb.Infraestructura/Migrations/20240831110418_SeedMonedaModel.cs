using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MantenimientoWeb.Infraestructura.Migrations
{
    public partial class SeedMonedaModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Monedas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SimboloMoneda = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monedas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Monedas",
                columns: new[] { "Id", "SimboloMoneda" },
                values: new object[,]
                {
                    { 1, "$ - USD" },
                    { 2, "€ - EUR" },
                    { 3, "£ - GBP" },
                    { 4, "¥ - JPY" },
                    { 5, "¥ - CNY" },
                    { 6, "$ - AUD" },
                    { 7, "$ - CAD" },
                    { 8, "Fr - CHF" },
                    { 9, "₽ - RUB" },
                    { 10, "₹ - INR" },
                    { 11, "R$ - BRL" },
                    { 12, "MX$ - MXN" },
                    { 13, "₩ - KRW" },
                    { 14, "R - ZAR" },
                    { 15, "kr - SEK" },
                    { 16, "kr - NOK" },
                    { 17, "kr - DKK" },
                    { 18, "₺ - TRY" },
                    { 19, "Rp - IDR" },
                    { 20, "$ - SGD" },
                    { 21, "$ - HKD" },
                    { 22, "$ - NZD" },
                    { 23, "AR$ - ARS" },
                    { 24, "CLP$ - CLP" },
                    { 25, "COL$ - COP" },
                    { 26, "S/ - PEN" },
                    { 27, "₱ - PHP" },
                    { 28, "RM - MYR" },
                    { 29, "฿ - THB" },
                    { 30, "₪ - ILS " },
                    { 31, "ر.س- SAR" },
                    { 32, "₦ - NGN" },
                    { 33, "₫ - VND" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monedas");
        }
    }
}
