using MantenimientoWeb.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoWeb.Infraestructura.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

        {

        }
        public DbSet<PaisModel> Paises { get; set; }
        public DbSet<EmpresaModel> Empresas { get; set; }
        public DbSet<TipoEmpresaModel> TipoEmpresas { get; set; }
        public DbSet<CategoriaProductoModel> Categorias { get; set; }
        public DbSet<MonedaProductoModel> Monedas { get; set; }
        public DbSet<ClasificacionProductoModel> Clasificaciones { get; set; }
        public DbSet<TransporteModel> Transportes { get; set; }
        public DbSet<EmpaquetamientoModel> Empaquetamientos { get; set; }
        public DbSet<ProductoModel> Productos { get; set; }
        public DbSet<TipoMateriaPrimaModel> TipoMateriaPrimas { get; set; }
        public DbSet<TipoProductoModel> TipoProductos { get; set; }
        public DbSet<EstadoMateriaPrimaModel> EstadoMateriaPrimas { get; set; }
        public DbSet<EstadoProductoModel> EstadoProductos { get; set; }
        public DbSet<InventarioModel> Inventario { get; set; }
        public DbSet<CompraModel> Compras { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Si quisieramos trabajar con EFCodeFirst asignando Llaves Fóraneas, Seeding, etc.
            
            modelBuilder.Entity<ProductoModel>()
                .HasOne(p => p.Proveedor)
                .WithMany()
                .HasForeignKey(p => p.ProveedorId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EstadoProductoModel>().HasData(
                new EstadoProductoModel { Id = 1, Nombre = "Activo" },
                new EstadoProductoModel { Id = 2, Nombre = "Inactivo" },
                new EstadoProductoModel { Id = 3, Nombre = "Desconocido" }
                );

            modelBuilder.Entity<EstadoMateriaPrimaModel>().HasData(
                new EstadoMateriaPrimaModel { Id = 1, Estado = "En Producción"}, 
                new EstadoMateriaPrimaModel { Id = 2, Estado = "En Transporte"},
                new EstadoMateriaPrimaModel { Id = 3, Estado = "Entregado"}, 
                new EstadoMateriaPrimaModel { Id = 4, Estado = "Expirado"}
                );

            modelBuilder.Entity<TipoProductoModel>().HasData(
                new TipoProductoModel { Id = 1, Nombre = "Insumo o Materia Prima"}, 
                new TipoProductoModel { Id = 2, Nombre = "Consumo o Producto Comercial"}
                );

            modelBuilder.Entity<TipoMateriaPrimaModel>().HasData(
                new TipoMateriaPrimaModel { Id = 1, Nombre = "Origen Vegetal"}, 
                new TipoMateriaPrimaModel { Id = 2, Nombre = "Origen Animal"}, 
                new TipoMateriaPrimaModel { Id = 3, Nombre = "Minerales"},
                new TipoMateriaPrimaModel { Id = 4, Nombre = "Origen Sintético/Derivada del petróleo"}, 
                new TipoMateriaPrimaModel { Id = 5, Nombre = "Químicas"}, 
                new TipoMateriaPrimaModel { Id = 6, Nombre = "Energéticas"},
                new TipoMateriaPrimaModel { Id = 7, Nombre = "Industriales"}
                );

            modelBuilder.Entity<EmpaquetamientoModel>().HasData(
                new EmpaquetamientoModel { Id = 1, Nombre = "Empaquetamiento Primario" }, 
                new EmpaquetamientoModel { Id = 2, Nombre = "Empaquetamiento Secundario" }, 
                new EmpaquetamientoModel { Id = 3, Nombre = "Empaquetamiento Terciario" }, 
                new EmpaquetamientoModel { Id = 4, Nombre = "Empaquetamiento Especializado" }, 
                new EmpaquetamientoModel { Id = 5, Nombre = "Empaquetamiento de Seguridad" }, 
                new EmpaquetamientoModel { Id = 6, Nombre = "Empaquetamiento para Marketing" },
                new EmpaquetamientoModel { Id = 7, Nombre = "Empaquetamiento Ecológico" }
                );

            modelBuilder.Entity<TransporteModel>().HasData(
                new TransporteModel { Id = 1, Vehiculo = "Vehículo de Pasajero"}, 
                new TransporteModel { Id = 2, Vehiculo = "Vehículo de Carga"}, 
                new TransporteModel { Id = 3, Vehiculo = "Vehículo Especial (Construccion y Agrícola)"}, 
                new TransporteModel { Id = 4, Vehiculo = "Aviones Comerciales"}, 
                new TransporteModel { Id = 5, Vehiculo = "Helicópteros"},
                new TransporteModel { Id = 6, Vehiculo = "Aviones Privados y de Negocios"}, 
                new TransporteModel { Id = 7, Vehiculo = "Barcos de Carga"},
                new TransporteModel { Id = 8, Vehiculo = "Embarcaciones Especializadas"}, 
                new TransporteModel { Id = 9, Vehiculo = "Trenes de Carga"}, 
                new TransporteModel { Id = 10, Vehiculo = "Vehículos Blindados"}, 
                new TransporteModel { Id = 11, Vehiculo = "Vehículos de Transporte de Carga Peligrosa"},
                new TransporteModel { Id = 12, Vehiculo = "Vehículos Eléctricos"}, 
                new TransporteModel { Id = 13, Vehiculo = "Vehículos Híbridos"}
                );

            modelBuilder.Entity<ClasificacionProductoModel>().HasData(
                
                new ClasificacionProductoModel { Id = 1, Nombre = "Producto de Consumo"}, 
                new ClasificacionProductoModel { Id = 2, Nombre = "Producto Industriales"}, 
                new ClasificacionProductoModel { Id = 3, Nombre = "Producto de Servicio"}, 
                new ClasificacionProductoModel { Id = 4, Nombre = "Producto Duradero"}, 
                new ClasificacionProductoModel { Id = 5, Nombre = "Producto No Duraderos"}, 
                new ClasificacionProductoModel { Id = 6, Nombre = "Producto de Lujo"}
                ); 

            modelBuilder.Entity<MonedaProductoModel>().HasData(

                new MonedaProductoModel { Id = 1, SimboloMoneda = "$" }, 
                new MonedaProductoModel { Id = 2, SimboloMoneda = "R$" }, 
                new MonedaProductoModel { Id = 3, SimboloMoneda = "C$" },
                new MonedaProductoModel { Id = 4, SimboloMoneda = "S/" }, 
                new MonedaProductoModel { Id = 5, SimboloMoneda = "Bs" }, 
                new MonedaProductoModel { Id = 6, SimboloMoneda = "€" }, 
                new MonedaProductoModel { Id = 7, SimboloMoneda = "£" }, 
                new MonedaProductoModel { Id = 8, SimboloMoneda = "₽" }, 
                new MonedaProductoModel { Id = 9, SimboloMoneda = "CHF" }, 
                new MonedaProductoModel { Id = 10, SimboloMoneda = "kr" }, 
                new MonedaProductoModel { Id = 11, SimboloMoneda = "¥" }, 
                new MonedaProductoModel { Id = 12, SimboloMoneda = "₹" }, 
                new MonedaProductoModel { Id = 13, SimboloMoneda = "₩" }, 
                new MonedaProductoModel { Id = 14, SimboloMoneda = "P"}, 
                new MonedaProductoModel { Id = 15, SimboloMoneda = "ر.س" }, 
                new MonedaProductoModel { Id = 16, SimboloMoneda = "₺" }, 
                new MonedaProductoModel { Id = 17, SimboloMoneda = "₪" }, 
                new MonedaProductoModel { Id = 18, SimboloMoneda = "Rp" }, 
                new MonedaProductoModel { Id = 19, SimboloMoneda = "฿" }, 
                new MonedaProductoModel { Id = 20, SimboloMoneda = "₵" }

                );

            modelBuilder.Entity<PaisModel>().HasData(
                // Podria hacerlo usando 'for' method, crear un diccionario o lista y indexar
                // Pero para hacerlo más simple voy a hacer un seeding en esta base de datos
                new PaisModel { Id = 1, Nombre = "Afganistán" },
                new PaisModel { Id = 2, Nombre = "Albania" },
                new PaisModel { Id = 3, Nombre = "Alemania"}, 
                new PaisModel { Id = 4, Nombre = "Angola"}, 
                new PaisModel { Id = 5, Nombre = "Argentina"}, 
                new PaisModel { Id = 6, Nombre = "Armenia"}, 
                new PaisModel { Id = 7, Nombre = "Australia"}, 
                new PaisModel { Id = 8, Nombre = "Austria"}, 
                new PaisModel { Id = 9, Nombre = "Azerbaiyán"}, 
                new PaisModel { Id = 10, Nombre = "Bahamas"}, 
                new PaisModel { Id = 11, Nombre = "Bahréin"}, 
                new PaisModel { Id = 12, Nombre = "Bangladés"}, 
                new PaisModel { Id = 13, Nombre = "Bélgica"}, 
                new PaisModel { Id = 14, Nombre = "Bután"}, 
                new PaisModel { Id = 15, Nombre = "Bolivia"}, 
                new PaisModel { Id = 16, Nombre = "Brasil"}, 
                new PaisModel { Id = 17, Nombre = "Brunéi"}, 
                new PaisModel { Id = 18, Nombre = "Bulgaria"}, 
                new PaisModel { Id = 19, Nombre = "Burundi"},
                new PaisModel { Id = 20, Nombre = "Camboya"}, 
                new PaisModel { Id = 21, Nombre = "Corea"}, 
                new PaisModel { Id = 22, Nombre = "Canadá"}, 
                new PaisModel { Id = 23, Nombre = "Chile"}, 
                new PaisModel { Id = 24, Nombre = "Colombia"}, 
                new PaisModel { Id = 25, Nombre = "Congo"}, 
                new PaisModel { Id = 26, Nombre = "Costa Rica"},
                new PaisModel { Id = 27, Nombre = "Croacia"}, 
                new PaisModel { Id = 28, Nombre = "Cuba"}, 
                new PaisModel { Id = 29, Nombre = "China"}, 
                new PaisModel { Id = 30, Nombre = "Checa"}, 
                new PaisModel { Id = 31, Nombre = "Dinamarca"}, 
                new PaisModel { Id = 32, Nombre = "Dominincana (República)"},
                new PaisModel { Id = 33, Nombre = "Ecuador"},
                new PaisModel { Id = 34, Nombre = "Egipto"}, 
                new PaisModel { Id = 35, Nombre = "El Salvador"},
                new PaisModel { Id = 36, Nombre = "Ecuatorial (Guinea)"},
                new PaisModel { Id = 37, Nombre = "España"},
                new PaisModel { Id = 38, Nombre = "Estonia"}, 
                new PaisModel { Id = 39, Nombre = "Etiopía"}, 
                new PaisModel { Id = 40, Nombre = "Filipinas"}, 
                new PaisModel { Id = 41, Nombre = "Finlandia "}, 
                new PaisModel { Id = 42, Nombre = "Francia"}, 
                new PaisModel { Id = 43, Nombre = "Gambia"}, 
                new PaisModel { Id = 44, Nombre = "Georgia"}, 
                new PaisModel { Id = 45, Nombre = "Grecia"}, 
                new PaisModel { Id = 46, Nombre = "Guatemala"}, 
                new PaisModel { Id = 47, Nombre = "Guinea"}, 
                new PaisModel { Id = 48, Nombre = "Haití"}, 
                new PaisModel { Id = 49, Nombre = "Honduras"},
                new PaisModel { Id = 50, Nombre = "Hungría"},
                new PaisModel { Id = 51, Nombre = "India"},
                new PaisModel { Id = 52, Nombre = "Indonesia"}, 
                new PaisModel { Id = 53, Nombre = "Irlandia"}, 
                new PaisModel { Id = 54, Nombre = "Irak"},
                new PaisModel { Id = 55, Nombre = "Irán"},
                new PaisModel { Id = 56, Nombre = "Israel"}, 
                new PaisModel { Id = 57, Nombre = "Italia"}, 
                new PaisModel { Id = 58, Nombre = "Jamaica"}, 
                new PaisModel { Id = 59, Nombre = "Japón"}, 
                new PaisModel { Id = 60, Nombre = "Jordán"},
                new PaisModel { Id = 61, Nombre = "Kazajstán"}, 
                new PaisModel { Id = 62, Nombre = "Kosovo"},
                new PaisModel { Id = 63, Nombre = "Kuwait"},
                new PaisModel { Id = 64, Nombre = "Kirguistán"}, 
                new PaisModel { Id = 65, Nombre = "Laos"}, 
                new PaisModel { Id = 66, Nombre = "Letonia"}, 
                new PaisModel { Id = 67, Nombre = "Líbano"}, 
                new PaisModel { Id = 68, Nombre = "Libia"}, 
                new PaisModel { Id = 69, Nombre = "Lituania"}, 
                new PaisModel { Id = 70, Nombre = "Luxemburgo"}, 
                new PaisModel { Id = 71, Nombre = "Madagascar"}, 
                new PaisModel { Id = 72, Nombre = "Malaui" }, 
                new PaisModel { Id = 73, Nombre = "Malasia"}, 
                new PaisModel { Id = 74, Nombre = "Malí"}, 
                new PaisModel { Id = 75, Nombre = "Malta"}, 
                new PaisModel { Id = 76, Nombre = "Maldivas"},
                new PaisModel { Id = 77, Nombre = "Mauricio"}, 
                new PaisModel { Id = 78, Nombre = "México"}, 
                new PaisModel { Id = 79, Nombre = "Moldavia"}, 
                new PaisModel { Id = 80, Nombre = "Mongolia"},
                new PaisModel { Id = 81, Nombre = "Montenegro"}, 
                new PaisModel { Id = 82, Nombre = "Marruecos"}, 
                new PaisModel { Id = 83, Nombre = "Myanmar"}, 
                new PaisModel { Id = 84, Nombre = "Namibia"}, 
                new PaisModel { Id = 85, Nombre = "Nepal"},
                new PaisModel { Id = 86, Nombre = "Nueva Zelanda"}, 
                new PaisModel { Id = 87, Nombre = "Nicaragua"}, 
                new PaisModel { Id = 88, Nombre = "Nigeria"}, 
                new PaisModel { Id = 89, Nombre = "Noruega" }, 
                new PaisModel { Id = 90, Nombre = "Omán"},
                new PaisModel { Id = 91, Nombre = "Pakistán"}, 
                new PaisModel { Id = 92, Nombre = "Paises Bajos"}, 
                new PaisModel { Id = 93, Nombre = "Panamá"}, 
                new PaisModel { Id = 94, Nombre = "Papúa Nueva Guinea"}, 
                new PaisModel { Id = 95, Nombre = "Paraguay"}, 
                new PaisModel { Id = 96, Nombre = "Perú"},
                new PaisModel { Id = 97, Nombre = "Polonia"}, 
                new PaisModel { Id = 98, Nombre = "Portugal"}, 
                new PaisModel { Id = 99, Nombre = "Qatar"}, 
                new PaisModel { Id = 100, Nombre = "Rumania"}, 
                new PaisModel { Id = 101, Nombre = "Rusia"}, 
                new PaisModel { Id = 102, Nombre = "Ruanda"}, 
                new PaisModel { Id = 103, Nombre = "Senegal"}, 
                new PaisModel { Id = 104, Nombre = "Saudi (Arabia Saudita)"},
                new PaisModel { Id = 105, Nombre = "Singapur"},
                new PaisModel { Id = 106, Nombre = "Serbia"}, 
                new PaisModel { Id = 107, Nombre = "Sudáfrica"}, 
                new PaisModel { Id = 108, Nombre = "Sri Lanka"}, 
                new PaisModel { Id = 109, Nombre = "Sudán"}, 
                new PaisModel { Id = 110, Nombre = "Suecia"}, 
                new PaisModel { Id = 111, Nombre = "Suiza"}, 
                new PaisModel { Id = 112, Nombre = "Siria"}, 
                new PaisModel { Id = 113, Nombre = "Taiwán"}, 
                new PaisModel { Id = 114, Nombre = "Tailandia"},
                new PaisModel { Id = 115, Nombre = "Tayikistán"},
                new PaisModel { Id = 116, Nombre = "Turkmenistán"}, 
                new PaisModel { Id = 117, Nombre = "Uganda"}, 
                new PaisModel { Id = 118, Nombre = "USA (Estados Unidos)"}, 
                new PaisModel { Id = 119, Nombre = "United Kingdom (Reino Unido)"}, 
                new PaisModel { Id = 120, Nombre = "Uruguay"}, 
                new PaisModel { Id = 121, Nombre = "UAE (Emiratos Árabes Unidos)"}, 
                new PaisModel { Id = 122, Nombre = "Uruguay"}, 
                new PaisModel { Id = 123, Nombre = "Uzbekistán"}, 
                new PaisModel { Id = 124, Nombre = "Vatican"}, 
                new PaisModel { Id = 125, Nombre = "Venezuala"}, 
                new PaisModel { Id = 126, Nombre = "Vietnam"}, 
                new PaisModel { Id = 127, Nombre = "Yemen"}, 
                new PaisModel { Id = 128, Nombre = "Zambia"}, 
                new PaisModel { Id = 129, Nombre = "Zimbabue"}

                );

            modelBuilder.Entity<TipoEmpresaModel>().HasData(
                new TipoEmpresaModel { Id = 1, Nombre = "Cliente" },
                new TipoEmpresaModel { Id = 2, Nombre = "Proveedor"});

            modelBuilder.Entity<EmpresaModel>().HasData(
                new EmpresaModel { Id = 1, CIF="12345678", RazonSocial = "Empresa Ejemplo", CorreoElectronico = "algo@email.com", Direccion = "algo", PaisId = 1, TipoEmpresaId = 2});

            modelBuilder.Entity<CategoriaProductoModel>().HasData(
                new CategoriaProductoModel { Id = 1, Nombre = "Categoría A", Descripcion = "Los productos de Categoría A son los más importantes para la empresa. " +
                                                              "Son la mayoría del movimiento habitual de almacén, con mayor rotación y también los que aportan en torno al 80% de los ingresos de la empresa." +
                                                              "\n La empresa debera destinarle más recursos para llevar a cabo contorles de stock más exhaustivos y complejos, y realizados de forma" +
                                                              "periódica y frecuente. Los productos de esta categoría se pueden almacenar en sistemas de almacenaje con acceso rápido y directo las " +
                                                              "unidades de carga, o en su caso en sitemas de almacenaje automatizados para optimizar los tiempos de carga y descarga de la mercancía."}, 
                new CategoriaProductoModel { Id = 2, Nombre = "Categoría B", Descripcion = "Los productos de Categoría B son las que tienen una importancia y rotación moderada para la empresa." +
                                                              "Componen al 30% del total de productos del almacén y no suelen generar más del 20% de los ingresos de la empresa. Es una categoría intermedia entre la A y la C, se debe revisar periódicamente su estatus," +
                                                              "valorando la posibilidad de que se convierta en una referencia de categoría A o C en el futuro. Su localización en el almacén será en los lugares más accesibles y directos disponibles una vez " +
                                                              "hayamos organizado y reservado las mejores ubicaciones para las referencias A. Generalmente, los productos de categoría B se almacenan en niveles intermedios, en los que " +
                                                              "el acceso es rápido pero no siempre directo a todas las unidades de carga."}, 
                new CategoriaProductoModel { Id = 3, Nombre = "Categoría C", Descripcion = "Los productos de Categoría C serán las más numerosas, pero también las que menos ingresos aportan a la empresa. Pueden suponer más del 50% de" +
                                                              "las referencias de productos pero en términos de ingresos no alcanzar ni el 5% del total. Se debe realizar una valoración para estudiar si merece la pena destinar recursos de la empresa a su almacenaje y stock," +
                                                              "ya que puede darse la situación de que los costes derivados de su almacenaje sean superiores a la rentabilidad obtenida con su comercialización."}
                
                );

            


                
        }
    }
}
