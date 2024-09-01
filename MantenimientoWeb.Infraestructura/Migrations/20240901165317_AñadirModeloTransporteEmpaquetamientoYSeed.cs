using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MantenimientoWeb.Infraestructura.Migrations
{
    public partial class AñadirModeloTransporteEmpaquetamientoYSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empaquetamientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empaquetamientos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transportes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vehiculo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clasificaciones",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Producto de Consumo" },
                    { 2, "Producto Industriales" },
                    { 3, "Producto de Servicio" },
                    { 4, "Producto Duradero" },
                    { 5, "Producto No Duraderos" },
                    { 6, "Producto de Lujo" }
                });

            migrationBuilder.InsertData(
                table: "Empaquetamientos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Empaquetamiento Primario" },
                    { 2, "Empaquetamiento Secundario" },
                    { 3, "Empaquetamiento Terciario" },
                    { 4, "Empaquetamiento Especializado" },
                    { 5, "Empaquetamiento de Seguridad" },
                    { 6, "Empaquetamiento para Marketing" },
                    { 7, "Empaquetamiento Ecológico" }
                });

            migrationBuilder.InsertData(
                table: "Transportes",
                columns: new[] { "Id", "Vehiculo" },
                values: new object[,]
                {
                    { 1, "Vehículo de Pasajero" },
                    { 2, "Vehículo de Carga" },
                    { 3, "Vehículo Especial (Construccion y Agrícola)" },
                    { 4, "Aviones Comerciales" },
                    { 5, "Helicópteros" },
                    { 6, "Aviones Privados y de Negocios" },
                    { 7, "Barcos de Carga" },
                    { 8, "Embarcaciones Especializadas" },
                    { 9, "Trenes de Carga" },
                    { 10, "Vehículos Blindados" },
                    { 11, "Vehículos de Transporte de Carga Peligrosa" },
                    { 12, "Vehículos Eléctricos" },
                    { 13, "Vehículos Híbridos" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empaquetamientos");

            migrationBuilder.DropTable(
                name: "Transportes");

            migrationBuilder.DeleteData(
                table: "Clasificaciones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clasificaciones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clasificaciones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clasificaciones",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clasificaciones",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clasificaciones",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
