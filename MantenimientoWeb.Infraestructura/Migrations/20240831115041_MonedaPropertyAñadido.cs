using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MantenimientoWeb.Infraestructura.Migrations
{
    public partial class MonedaPropertyAñadido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MonedaId",
                table: "Productos",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SimboloMoneda",
                table: "Monedas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_MonedaId",
                table: "Productos",
                column: "MonedaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Monedas_MonedaId",
                table: "Productos",
                column: "MonedaId",
                principalTable: "Monedas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "SimboloMoneda",
                table: "Monedas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
