using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MantenimientoWeb.Infraestructura.Migrations
{
    public partial class SeedEntityCategoriaProductoModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Descripcion", "Nombre" },
                values: new object[] { 1, "Los productos de Categoría A son los más importantes para la empresa. Son la mayoría del movimiento habitual de almacén, con mayor rotación y también los que aportan en torno al 80% de los ingresos de la empresa.\n La empresa debera destinarle más recursos para llevar a cabo contorles de stock más exhaustivos y complejos, y realizados de formaperiódica y frecuente. Los productos de esta categoría se pueden almacenar en sistemas de almacenaje con acceso rápido y directo las unidades de carga, o en su caso en sitemas de almacenaje automatizados para optimizar los tiempos de carga y descarga de la mercancía.", "Productos de Categoría A" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Descripcion", "Nombre" },
                values: new object[] { 2, "Los productos de Categoría B son las que tienen una importancia y rotación moderada para la empresa.Componen al 30% del total de productos del almacén y no suelen generar más del 20% de los ingresos de la empresa. Es una categoría intermedia entre la A y la C, se debe revisar periódicamente su estatus,valorando la posibilidad de que se convierta en una referencia de categoría A o C en el futuro. Su localización en el almacén será en los lugares más accesibles y directos disponibles una vez hayamos organizado y reservado las mejores ubicaciones para las referencias A. Generalmente, los productos de categoría B se almacenan en niveles intermedios, en los que el acceso es rápido pero no siempre directo a todas las unidades de carga.", "Productos de Categoría B" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Descripcion", "Nombre" },
                values: new object[] { 3, "Los productos de Categoría C serán las más numerosas, pero también las que menos ingresos aportan a la empresa. Pueden suponer más del 50% delas referencias de productos pero en términos de ingresos no alcanzar ni el 5% del total. Se debe realizar una valoración para estudiar si merece la pena destinar recursos de la empresa a su almacenaje y stock,ya que puede darse la situación de que los costes derivados de su almacenaje sean superiores a la rentabilidad obtenida con su comercialización.", "Productos de Categoría C" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
