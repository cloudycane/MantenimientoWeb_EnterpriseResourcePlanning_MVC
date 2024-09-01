using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MantenimientoWeb.Infraestructura.Migrations
{
    public partial class AlterProductoModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EsEstacional",
                table: "Productos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EsFragil",
                table: "Productos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EsPeligroso",
                table: "Productos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EsPerecedero",
                table: "Productos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EstaSujetoAInflacion",
                table: "Productos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FastDelivery",
                table: "Productos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RequiereRefrigeracion",
                table: "Productos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TieneAltaValor",
                table: "Productos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EsEstacional",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "EsFragil",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "EsPeligroso",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "EsPerecedero",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "EstaSujetoAInflacion",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "FastDelivery",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "RequiereRefrigeracion",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "TieneAltaValor",
                table: "Productos");
        }
    }
}
