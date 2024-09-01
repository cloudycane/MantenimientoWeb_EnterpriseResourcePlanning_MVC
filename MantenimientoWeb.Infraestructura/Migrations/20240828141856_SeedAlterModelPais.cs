using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MantenimientoWeb.Infraestructura.Migrations
{
    public partial class SeedAlterModelPais : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "Afganistán");

            migrationBuilder.UpdateData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nombre",
                value: "Albania");

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 3, "Alemania" },
                    { 4, "Angola" },
                    { 5, "Argentina" },
                    { 6, "Armenia" },
                    { 7, "Australia" },
                    { 8, "Austria" },
                    { 9, "Azerbaiyán" },
                    { 10, "Bahamas" },
                    { 11, "Bahréin" },
                    { 12, "Bangladés" },
                    { 13, "Bélgica" },
                    { 14, "Bután" },
                    { 15, "Bolivia" },
                    { 16, "Brasil" },
                    { 17, "Brunéi" },
                    { 18, "Bulgaria" },
                    { 19, "Burundi" },
                    { 20, "Camboya" },
                    { 21, "Corea" },
                    { 22, "Canadá" },
                    { 23, "Chile" },
                    { 24, "Colombia" },
                    { 25, "Congo" },
                    { 26, "Costa Rica" },
                    { 27, "Croacia" },
                    { 28, "Cuba" },
                    { 29, "China" },
                    { 30, "Checa" },
                    { 31, "Dinamarca" },
                    { 32, "Dominincana (República)" },
                    { 33, "Ecuador" },
                    { 34, "Egipto" },
                    { 35, "El Salvador" },
                    { 36, "Ecuatorial (Guinea)" },
                    { 37, "España" },
                    { 38, "Estonia" },
                    { 39, "Etiopía" },
                    { 40, "Filipinas" },
                    { 41, "Finlandia " },
                    { 42, "Francia" }
                });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 43, "Gambia" },
                    { 44, "Georgia" },
                    { 45, "Grecia" },
                    { 46, "Guatemala" },
                    { 47, "Guinea" },
                    { 48, "Haití" },
                    { 49, "Honduras" },
                    { 50, "Hungría" },
                    { 51, "India" },
                    { 52, "Indonesia" },
                    { 53, "Irlandia" },
                    { 54, "Irak" },
                    { 55, "Irán" },
                    { 56, "Israel" },
                    { 57, "Italia" },
                    { 58, "Jamaica" },
                    { 59, "Japón" },
                    { 60, "Jordán" },
                    { 61, "Kazajstán" },
                    { 62, "Kosovo" },
                    { 63, "Kuwait" },
                    { 64, "Kirguistán" },
                    { 65, "Laos" },
                    { 66, "Letonia" },
                    { 67, "Líbano" },
                    { 68, "Libia" },
                    { 69, "Lituania" },
                    { 70, "Luxemburgo" },
                    { 71, "Madagascar" },
                    { 72, "Malaui" },
                    { 73, "Malasia" },
                    { 74, "Malí" },
                    { 75, "Malta" },
                    { 76, "Maldivas" },
                    { 77, "Mauricio" },
                    { 78, "México" },
                    { 79, "Moldavia" },
                    { 80, "Mongolia" },
                    { 81, "Montenegro" },
                    { 82, "Marruecos" },
                    { 83, "Myanmar" },
                    { 84, "Namibia" }
                });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 85, "Nepal" },
                    { 86, "Nueva Zelanda" },
                    { 87, "Nicaragua" },
                    { 88, "Nigeria" },
                    { 89, "Noruega" },
                    { 90, "Omán" },
                    { 91, "Pakistán" },
                    { 92, "Paises Bajos" },
                    { 93, "Panamá" },
                    { 94, "Papúa Nueva Guinea" },
                    { 95, "Paraguay" },
                    { 96, "Perú" },
                    { 97, "Polonia" },
                    { 98, "Portugal" },
                    { 99, "Qatar" },
                    { 100, "Rumania" },
                    { 101, "Rusia" },
                    { 102, "Ruanda" },
                    { 103, "Senegal" },
                    { 104, "Saudi (Arabia Saudita)" },
                    { 105, "Singapur" },
                    { 106, "Serbia" },
                    { 107, "Sudáfrica" },
                    { 108, "Sri Lanka" },
                    { 109, "Sudán" },
                    { 110, "Suecia" },
                    { 111, "Suiza" },
                    { 112, "Siria" },
                    { 113, "Taiwán" },
                    { 114, "Tailandia" },
                    { 115, "Tayikistán" },
                    { 116, "Turkmenistán" },
                    { 117, "Uganda" },
                    { 118, "USA (Estados Unidos)" },
                    { 119, "United Kingdom (Reino Unido)" },
                    { 120, "Uruguay" },
                    { 121, "UAE (Emiratos Árabes Unidos)" },
                    { 122, "Uruguay" },
                    { 123, "Uzbekistán" },
                    { 124, "Vatican" },
                    { 125, "Venezuala" },
                    { 126, "Vietnam" }
                });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 127, "Yemen" });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 128, "Zambia" });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 129, "Zimbabue" });

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_PaisId",
                table: "Empresas",
                column: "PaisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresas_Paises_PaisId",
                table: "Empresas",
                column: "PaisId",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresas_Paises_PaisId",
                table: "Empresas");

            migrationBuilder.DropIndex(
                name: "IX_Empresas_PaisId",
                table: "Empresas");

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.UpdateData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "España");

            migrationBuilder.UpdateData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nombre",
                value: "Reino Unido");
        }
    }
}
