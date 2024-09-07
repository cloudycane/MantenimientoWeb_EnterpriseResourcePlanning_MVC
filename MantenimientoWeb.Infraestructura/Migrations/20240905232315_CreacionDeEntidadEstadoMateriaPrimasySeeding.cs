using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MantenimientoWeb.Infraestructura.Migrations
{
    public partial class CreacionDeEntidadEstadoMateriaPrimasySeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstadoMateriaPrimas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoMateriaPrimas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EstadoMateriaPrimas",
                columns: new[] { "Id", "Estado" },
                values: new object[,]
                {
                    { 1, "En Producción" },
                    { 2, "En Transporte" },
                    { 3, "Entregado" },
                    { 4, "Expirado" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstadoMateriaPrimas");
        }
    }
}
