using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MantenimientoWeb.Infraestructura.Migrations
{
    public partial class AlterEmpresaModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TipoEmpresas",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 2, "Proveedor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipoEmpresas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
