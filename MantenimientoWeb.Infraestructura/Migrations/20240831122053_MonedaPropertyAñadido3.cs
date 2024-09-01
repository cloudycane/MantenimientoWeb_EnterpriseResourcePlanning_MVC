using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MantenimientoWeb.Infraestructura.Migrations
{
    public partial class MonedaPropertyAñadido3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Monedas_MonedaId",
                table: "Productos");

            migrationBuilder.AlterColumn<int>(
                name: "MonedaId",
                table: "Productos",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Monedas_MonedaId",
                table: "Productos",
                column: "MonedaId",
                principalTable: "Monedas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Monedas_MonedaId",
                table: "Productos");

            migrationBuilder.AlterColumn<int>(
                name: "MonedaId",
                table: "Productos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Monedas_MonedaId",
                table: "Productos",
                column: "MonedaId",
                principalTable: "Monedas",
                principalColumn: "Id");
        }
    }
}
