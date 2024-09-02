using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MantenimientoWeb.Infraestructura.Migrations
{
    public partial class AddProductoModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaExpiracion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MonedaId = table.Column<int>(type: "int", nullable: false),
                    PrecioOriginal = table.Column<double>(type: "float", nullable: false),
                    LugarFabricacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    ClasificacionId = table.Column<int>(type: "int", nullable: false),
                    CostoMantenimiento = table.Column<double>(type: "float", nullable: false),
                    NivelActual = table.Column<int>(type: "int", nullable: false),
                    PlazoEntrega = table.Column<int>(type: "int", nullable: false),
                    DemandaAnual = table.Column<int>(type: "int", nullable: false),
                    StockActual = table.Column<int>(type: "int", nullable: false),
                    ConsunmoDiarioPromedio = table.Column<int>(type: "int", nullable: false),
                    LeadTime = table.Column<int>(type: "int", nullable: false),
                    StockSeguridad = table.Column<int>(type: "int", nullable: false),
                    StockMinimo = table.Column<int>(type: "int", nullable: false),
                    EsPerecedero = table.Column<bool>(type: "bit", nullable: false),
                    EsFragil = table.Column<bool>(type: "bit", nullable: false),
                    RequiereRefrigacion = table.Column<bool>(type: "bit", nullable: false),
                    ProductoPeligrosa = table.Column<bool>(type: "bit", nullable: false),
                    VidaUtil = table.Column<int>(type: "int", nullable: false),
                    TemperaturaAlmacenimiento = table.Column<int>(type: "int", nullable: false),
                    InstruccionesDeManejo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransporteId = table.Column<int>(type: "int", nullable: false),
                    EmpaquetamientoId = table.Column<int>(type: "int", nullable: false),
                    NotasAdicionales = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Clasificaciones_ClasificacionId",
                        column: x => x.ClasificacionId,
                        principalTable: "Clasificaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Empaquetamientos_EmpaquetamientoId",
                        column: x => x.EmpaquetamientoId,
                        principalTable: "Empaquetamientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Monedas_MonedaId",
                        column: x => x.MonedaId,
                        principalTable: "Monedas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Transportes_TransporteId",
                        column: x => x.TransporteId,
                        principalTable: "Transportes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriaId",
                table: "Productos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ClasificacionId",
                table: "Productos",
                column: "ClasificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_EmpaquetamientoId",
                table: "Productos",
                column: "EmpaquetamientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_MonedaId",
                table: "Productos",
                column: "MonedaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_TransporteId",
                table: "Productos",
                column: "TransporteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
