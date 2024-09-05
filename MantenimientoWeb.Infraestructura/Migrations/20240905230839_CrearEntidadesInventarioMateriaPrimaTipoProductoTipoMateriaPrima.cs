using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MantenimientoWeb.Infraestructura.Migrations
{
    public partial class CrearEntidadesInventarioMateriaPrimaTipoProductoTipoMateriaPrima : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoMateriaPrimas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMateriaPrimas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProductos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TipoMateriaPrimas",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Origen Vegetal" },
                    { 2, "Origen Animal" },
                    { 3, "Minerales" },
                    { 4, "Origen Sintético/Derivada del petróleo" },
                    { 5, "Químicas" },
                    { 6, "Energéticas" },
                    { 7, "Industriales" }
                });

            migrationBuilder.InsertData(
                table: "TipoProductos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Insumo o Materia Prima" },
                    { 2, "Consumo o Producto Comercial" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoMateriaPrimas");

            migrationBuilder.DropTable(
                name: "TipoProductos");
        }
    }
}
