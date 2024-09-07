using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MantenimientoWeb.Infraestructura.Migrations
{
    public partial class CreacionDeEntidadEstadoProductoYSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstadoProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoProductos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EstadoProductos",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Activo" });

            migrationBuilder.InsertData(
                table: "EstadoProductos",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 2, "Inactivo" });

            migrationBuilder.InsertData(
                table: "EstadoProductos",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 3, "Desconocido" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstadoProductos");
        }
    }
}
