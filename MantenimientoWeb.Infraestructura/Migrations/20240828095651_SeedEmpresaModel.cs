using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MantenimientoWeb.Infraestructura.Migrations
{
    public partial class SeedEmpresaModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazonSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaisId = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Empresas",
                columns: new[] { "Id", "CorreoElectronico", "Direccion", "PaisId", "RazonSocial" },
                values: new object[] { 1, "algo@email.com", "algo", 1, "Empresa Ejemplo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
