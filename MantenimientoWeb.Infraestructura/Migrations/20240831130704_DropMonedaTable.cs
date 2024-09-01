using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MantenimientoWeb.Infraestructura.Migrations
{
    public partial class DropMonedaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Monedas",
                keyColumn: "Id",
                keyValue: 33);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
