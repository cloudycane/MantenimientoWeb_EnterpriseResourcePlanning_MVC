using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MantenimientoWeb.Infraestructura.Migrations
{
    public partial class AlterEmpresaModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoEmpresaId",
                table: "Empresas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_TipoEmpresaId",
                table: "Empresas",
                column: "TipoEmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresas_TipoEmpresas_TipoEmpresaId",
                table: "Empresas",
                column: "TipoEmpresaId",
                principalTable: "TipoEmpresas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresas_TipoEmpresas_TipoEmpresaId",
                table: "Empresas");

            migrationBuilder.DropIndex(
                name: "IX_Empresas_TipoEmpresaId",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "TipoEmpresaId",
                table: "Empresas");
        }
    }
}
