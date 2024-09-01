using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MantenimientoWeb.Infraestructura.Migrations
{
    public partial class DropMonedaTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Monedas_MonedaId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_MonedaId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "MonedaId",
                table: "Productos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MonedaId",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_MonedaId",
                table: "Productos",
                column: "MonedaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Monedas_MonedaId",
                table: "Productos",
                column: "MonedaId",
                principalTable: "Monedas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
