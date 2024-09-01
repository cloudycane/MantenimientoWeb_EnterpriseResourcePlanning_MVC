using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MantenimientoWeb.Infraestructura.Migrations
{
    public partial class AlterEmpresaModel3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Empresas",
                keyColumn: "Id",
                keyValue: 1,
                column: "TipoEmpresaId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Empresas",
                keyColumn: "Id",
                keyValue: 1,
                column: "TipoEmpresaId",
                value: null);
        }
    }
}
