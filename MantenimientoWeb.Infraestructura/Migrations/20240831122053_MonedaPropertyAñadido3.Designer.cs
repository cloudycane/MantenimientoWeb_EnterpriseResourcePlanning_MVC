﻿// <auto-generated />
using System;
using MantenimientoWeb.Infraestructura.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MantenimientoWeb.Infraestructura.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240831122053_MonedaPropertyAñadido3")]
    partial class MonedaPropertyAñadido3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MantenimientoWeb.Dominio.Entidades.CategoriaProductoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Los productos de Categoría A son los más importantes para la empresa. Son la mayoría del movimiento habitual de almacén, con mayor rotación y también los que aportan en torno al 80% de los ingresos de la empresa.\n La empresa debera destinarle más recursos para llevar a cabo contorles de stock más exhaustivos y complejos, y realizados de formaperiódica y frecuente. Los productos de esta categoría se pueden almacenar en sistemas de almacenaje con acceso rápido y directo las unidades de carga, o en su caso en sitemas de almacenaje automatizados para optimizar los tiempos de carga y descarga de la mercancía.",
                            Nombre = "Productos de Categoría A"
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Los productos de Categoría B son las que tienen una importancia y rotación moderada para la empresa.Componen al 30% del total de productos del almacén y no suelen generar más del 20% de los ingresos de la empresa. Es una categoría intermedia entre la A y la C, se debe revisar periódicamente su estatus,valorando la posibilidad de que se convierta en una referencia de categoría A o C en el futuro. Su localización en el almacén será en los lugares más accesibles y directos disponibles una vez hayamos organizado y reservado las mejores ubicaciones para las referencias A. Generalmente, los productos de categoría B se almacenan en niveles intermedios, en los que el acceso es rápido pero no siempre directo a todas las unidades de carga.",
                            Nombre = "Productos de Categoría B"
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Los productos de Categoría C serán las más numerosas, pero también las que menos ingresos aportan a la empresa. Pueden suponer más del 50% delas referencias de productos pero en términos de ingresos no alcanzar ni el 5% del total. Se debe realizar una valoración para estudiar si merece la pena destinar recursos de la empresa a su almacenaje y stock,ya que puede darse la situación de que los costes derivados de su almacenaje sean superiores a la rentabilidad obtenida con su comercialización.",
                            Nombre = "Productos de Categoría C"
                        });
                });

            modelBuilder.Entity("MantenimientoWeb.Dominio.Entidades.EmpresaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CIF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaisId")
                        .HasColumnType("int");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipoEmpresaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PaisId");

                    b.HasIndex("TipoEmpresaId");

                    b.ToTable("Empresas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CIF = "12345678",
                            CorreoElectronico = "algo@email.com",
                            Direccion = "algo",
                            PaisId = 1,
                            RazonSocial = "Empresa Ejemplo",
                            TipoEmpresaId = 2
                        });
                });

            modelBuilder.Entity("MantenimientoWeb.Dominio.Entidades.MonedaProductoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("SimboloMoneda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Monedas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SimboloMoneda = "$ - USD"
                        },
                        new
                        {
                            Id = 2,
                            SimboloMoneda = "€ - EUR"
                        },
                        new
                        {
                            Id = 3,
                            SimboloMoneda = "£ - GBP"
                        },
                        new
                        {
                            Id = 4,
                            SimboloMoneda = "¥ - JPY"
                        },
                        new
                        {
                            Id = 5,
                            SimboloMoneda = "¥ - CNY"
                        },
                        new
                        {
                            Id = 6,
                            SimboloMoneda = "$ - AUD"
                        },
                        new
                        {
                            Id = 7,
                            SimboloMoneda = "$ - CAD"
                        },
                        new
                        {
                            Id = 8,
                            SimboloMoneda = "Fr - CHF"
                        },
                        new
                        {
                            Id = 9,
                            SimboloMoneda = "₽ - RUB"
                        },
                        new
                        {
                            Id = 10,
                            SimboloMoneda = "₹ - INR"
                        },
                        new
                        {
                            Id = 11,
                            SimboloMoneda = "R$ - BRL"
                        },
                        new
                        {
                            Id = 12,
                            SimboloMoneda = "MX$ - MXN"
                        },
                        new
                        {
                            Id = 13,
                            SimboloMoneda = "₩ - KRW"
                        },
                        new
                        {
                            Id = 14,
                            SimboloMoneda = "R - ZAR"
                        },
                        new
                        {
                            Id = 15,
                            SimboloMoneda = "kr - SEK"
                        },
                        new
                        {
                            Id = 16,
                            SimboloMoneda = "kr - NOK"
                        },
                        new
                        {
                            Id = 17,
                            SimboloMoneda = "kr - DKK"
                        },
                        new
                        {
                            Id = 18,
                            SimboloMoneda = "₺ - TRY"
                        },
                        new
                        {
                            Id = 19,
                            SimboloMoneda = "Rp - IDR"
                        },
                        new
                        {
                            Id = 20,
                            SimboloMoneda = "$ - SGD"
                        },
                        new
                        {
                            Id = 21,
                            SimboloMoneda = "$ - HKD"
                        },
                        new
                        {
                            Id = 22,
                            SimboloMoneda = "$ - NZD"
                        },
                        new
                        {
                            Id = 23,
                            SimboloMoneda = "AR$ - ARS"
                        },
                        new
                        {
                            Id = 24,
                            SimboloMoneda = "CLP$ - CLP"
                        },
                        new
                        {
                            Id = 25,
                            SimboloMoneda = "COL$ - COP"
                        },
                        new
                        {
                            Id = 26,
                            SimboloMoneda = "S/ - PEN"
                        },
                        new
                        {
                            Id = 27,
                            SimboloMoneda = "₱ - PHP"
                        },
                        new
                        {
                            Id = 28,
                            SimboloMoneda = "RM - MYR"
                        },
                        new
                        {
                            Id = 29,
                            SimboloMoneda = "฿ - THB"
                        },
                        new
                        {
                            Id = 30,
                            SimboloMoneda = "₪ - ILS "
                        },
                        new
                        {
                            Id = 31,
                            SimboloMoneda = "ر.س- SAR"
                        },
                        new
                        {
                            Id = 32,
                            SimboloMoneda = "₦ - NGN"
                        },
                        new
                        {
                            Id = 33,
                            SimboloMoneda = "₫ - VND"
                        });
                });

            modelBuilder.Entity("MantenimientoWeb.Dominio.Entidades.PaisModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Paises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Afganistán"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Albania"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Alemania"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Angola"
                        },
                        new
                        {
                            Id = 5,
                            Nombre = "Argentina"
                        },
                        new
                        {
                            Id = 6,
                            Nombre = "Armenia"
                        },
                        new
                        {
                            Id = 7,
                            Nombre = "Australia"
                        },
                        new
                        {
                            Id = 8,
                            Nombre = "Austria"
                        },
                        new
                        {
                            Id = 9,
                            Nombre = "Azerbaiyán"
                        },
                        new
                        {
                            Id = 10,
                            Nombre = "Bahamas"
                        },
                        new
                        {
                            Id = 11,
                            Nombre = "Bahréin"
                        },
                        new
                        {
                            Id = 12,
                            Nombre = "Bangladés"
                        },
                        new
                        {
                            Id = 13,
                            Nombre = "Bélgica"
                        },
                        new
                        {
                            Id = 14,
                            Nombre = "Bután"
                        },
                        new
                        {
                            Id = 15,
                            Nombre = "Bolivia"
                        },
                        new
                        {
                            Id = 16,
                            Nombre = "Brasil"
                        },
                        new
                        {
                            Id = 17,
                            Nombre = "Brunéi"
                        },
                        new
                        {
                            Id = 18,
                            Nombre = "Bulgaria"
                        },
                        new
                        {
                            Id = 19,
                            Nombre = "Burundi"
                        },
                        new
                        {
                            Id = 20,
                            Nombre = "Camboya"
                        },
                        new
                        {
                            Id = 21,
                            Nombre = "Corea"
                        },
                        new
                        {
                            Id = 22,
                            Nombre = "Canadá"
                        },
                        new
                        {
                            Id = 23,
                            Nombre = "Chile"
                        },
                        new
                        {
                            Id = 24,
                            Nombre = "Colombia"
                        },
                        new
                        {
                            Id = 25,
                            Nombre = "Congo"
                        },
                        new
                        {
                            Id = 26,
                            Nombre = "Costa Rica"
                        },
                        new
                        {
                            Id = 27,
                            Nombre = "Croacia"
                        },
                        new
                        {
                            Id = 28,
                            Nombre = "Cuba"
                        },
                        new
                        {
                            Id = 29,
                            Nombre = "China"
                        },
                        new
                        {
                            Id = 30,
                            Nombre = "Checa"
                        },
                        new
                        {
                            Id = 31,
                            Nombre = "Dinamarca"
                        },
                        new
                        {
                            Id = 32,
                            Nombre = "Dominincana (República)"
                        },
                        new
                        {
                            Id = 33,
                            Nombre = "Ecuador"
                        },
                        new
                        {
                            Id = 34,
                            Nombre = "Egipto"
                        },
                        new
                        {
                            Id = 35,
                            Nombre = "El Salvador"
                        },
                        new
                        {
                            Id = 36,
                            Nombre = "Ecuatorial (Guinea)"
                        },
                        new
                        {
                            Id = 37,
                            Nombre = "España"
                        },
                        new
                        {
                            Id = 38,
                            Nombre = "Estonia"
                        },
                        new
                        {
                            Id = 39,
                            Nombre = "Etiopía"
                        },
                        new
                        {
                            Id = 40,
                            Nombre = "Filipinas"
                        },
                        new
                        {
                            Id = 41,
                            Nombre = "Finlandia "
                        },
                        new
                        {
                            Id = 42,
                            Nombre = "Francia"
                        },
                        new
                        {
                            Id = 43,
                            Nombre = "Gambia"
                        },
                        new
                        {
                            Id = 44,
                            Nombre = "Georgia"
                        },
                        new
                        {
                            Id = 45,
                            Nombre = "Grecia"
                        },
                        new
                        {
                            Id = 46,
                            Nombre = "Guatemala"
                        },
                        new
                        {
                            Id = 47,
                            Nombre = "Guinea"
                        },
                        new
                        {
                            Id = 48,
                            Nombre = "Haití"
                        },
                        new
                        {
                            Id = 49,
                            Nombre = "Honduras"
                        },
                        new
                        {
                            Id = 50,
                            Nombre = "Hungría"
                        },
                        new
                        {
                            Id = 51,
                            Nombre = "India"
                        },
                        new
                        {
                            Id = 52,
                            Nombre = "Indonesia"
                        },
                        new
                        {
                            Id = 53,
                            Nombre = "Irlandia"
                        },
                        new
                        {
                            Id = 54,
                            Nombre = "Irak"
                        },
                        new
                        {
                            Id = 55,
                            Nombre = "Irán"
                        },
                        new
                        {
                            Id = 56,
                            Nombre = "Israel"
                        },
                        new
                        {
                            Id = 57,
                            Nombre = "Italia"
                        },
                        new
                        {
                            Id = 58,
                            Nombre = "Jamaica"
                        },
                        new
                        {
                            Id = 59,
                            Nombre = "Japón"
                        },
                        new
                        {
                            Id = 60,
                            Nombre = "Jordán"
                        },
                        new
                        {
                            Id = 61,
                            Nombre = "Kazajstán"
                        },
                        new
                        {
                            Id = 62,
                            Nombre = "Kosovo"
                        },
                        new
                        {
                            Id = 63,
                            Nombre = "Kuwait"
                        },
                        new
                        {
                            Id = 64,
                            Nombre = "Kirguistán"
                        },
                        new
                        {
                            Id = 65,
                            Nombre = "Laos"
                        },
                        new
                        {
                            Id = 66,
                            Nombre = "Letonia"
                        },
                        new
                        {
                            Id = 67,
                            Nombre = "Líbano"
                        },
                        new
                        {
                            Id = 68,
                            Nombre = "Libia"
                        },
                        new
                        {
                            Id = 69,
                            Nombre = "Lituania"
                        },
                        new
                        {
                            Id = 70,
                            Nombre = "Luxemburgo"
                        },
                        new
                        {
                            Id = 71,
                            Nombre = "Madagascar"
                        },
                        new
                        {
                            Id = 72,
                            Nombre = "Malaui"
                        },
                        new
                        {
                            Id = 73,
                            Nombre = "Malasia"
                        },
                        new
                        {
                            Id = 74,
                            Nombre = "Malí"
                        },
                        new
                        {
                            Id = 75,
                            Nombre = "Malta"
                        },
                        new
                        {
                            Id = 76,
                            Nombre = "Maldivas"
                        },
                        new
                        {
                            Id = 77,
                            Nombre = "Mauricio"
                        },
                        new
                        {
                            Id = 78,
                            Nombre = "México"
                        },
                        new
                        {
                            Id = 79,
                            Nombre = "Moldavia"
                        },
                        new
                        {
                            Id = 80,
                            Nombre = "Mongolia"
                        },
                        new
                        {
                            Id = 81,
                            Nombre = "Montenegro"
                        },
                        new
                        {
                            Id = 82,
                            Nombre = "Marruecos"
                        },
                        new
                        {
                            Id = 83,
                            Nombre = "Myanmar"
                        },
                        new
                        {
                            Id = 84,
                            Nombre = "Namibia"
                        },
                        new
                        {
                            Id = 85,
                            Nombre = "Nepal"
                        },
                        new
                        {
                            Id = 86,
                            Nombre = "Nueva Zelanda"
                        },
                        new
                        {
                            Id = 87,
                            Nombre = "Nicaragua"
                        },
                        new
                        {
                            Id = 88,
                            Nombre = "Nigeria"
                        },
                        new
                        {
                            Id = 89,
                            Nombre = "Noruega"
                        },
                        new
                        {
                            Id = 90,
                            Nombre = "Omán"
                        },
                        new
                        {
                            Id = 91,
                            Nombre = "Pakistán"
                        },
                        new
                        {
                            Id = 92,
                            Nombre = "Paises Bajos"
                        },
                        new
                        {
                            Id = 93,
                            Nombre = "Panamá"
                        },
                        new
                        {
                            Id = 94,
                            Nombre = "Papúa Nueva Guinea"
                        },
                        new
                        {
                            Id = 95,
                            Nombre = "Paraguay"
                        },
                        new
                        {
                            Id = 96,
                            Nombre = "Perú"
                        },
                        new
                        {
                            Id = 97,
                            Nombre = "Polonia"
                        },
                        new
                        {
                            Id = 98,
                            Nombre = "Portugal"
                        },
                        new
                        {
                            Id = 99,
                            Nombre = "Qatar"
                        },
                        new
                        {
                            Id = 100,
                            Nombre = "Rumania"
                        },
                        new
                        {
                            Id = 101,
                            Nombre = "Rusia"
                        },
                        new
                        {
                            Id = 102,
                            Nombre = "Ruanda"
                        },
                        new
                        {
                            Id = 103,
                            Nombre = "Senegal"
                        },
                        new
                        {
                            Id = 104,
                            Nombre = "Saudi (Arabia Saudita)"
                        },
                        new
                        {
                            Id = 105,
                            Nombre = "Singapur"
                        },
                        new
                        {
                            Id = 106,
                            Nombre = "Serbia"
                        },
                        new
                        {
                            Id = 107,
                            Nombre = "Sudáfrica"
                        },
                        new
                        {
                            Id = 108,
                            Nombre = "Sri Lanka"
                        },
                        new
                        {
                            Id = 109,
                            Nombre = "Sudán"
                        },
                        new
                        {
                            Id = 110,
                            Nombre = "Suecia"
                        },
                        new
                        {
                            Id = 111,
                            Nombre = "Suiza"
                        },
                        new
                        {
                            Id = 112,
                            Nombre = "Siria"
                        },
                        new
                        {
                            Id = 113,
                            Nombre = "Taiwán"
                        },
                        new
                        {
                            Id = 114,
                            Nombre = "Tailandia"
                        },
                        new
                        {
                            Id = 115,
                            Nombre = "Tayikistán"
                        },
                        new
                        {
                            Id = 116,
                            Nombre = "Turkmenistán"
                        },
                        new
                        {
                            Id = 117,
                            Nombre = "Uganda"
                        },
                        new
                        {
                            Id = 118,
                            Nombre = "USA (Estados Unidos)"
                        },
                        new
                        {
                            Id = 119,
                            Nombre = "United Kingdom (Reino Unido)"
                        },
                        new
                        {
                            Id = 120,
                            Nombre = "Uruguay"
                        },
                        new
                        {
                            Id = 121,
                            Nombre = "UAE (Emiratos Árabes Unidos)"
                        },
                        new
                        {
                            Id = 122,
                            Nombre = "Uruguay"
                        },
                        new
                        {
                            Id = 123,
                            Nombre = "Uzbekistán"
                        },
                        new
                        {
                            Id = 124,
                            Nombre = "Vatican"
                        },
                        new
                        {
                            Id = 125,
                            Nombre = "Venezuala"
                        },
                        new
                        {
                            Id = 126,
                            Nombre = "Vietnam"
                        },
                        new
                        {
                            Id = 127,
                            Nombre = "Yemen"
                        },
                        new
                        {
                            Id = 128,
                            Nombre = "Zambia"
                        },
                        new
                        {
                            Id = 129,
                            Nombre = "Zimbabue"
                        });
                });

            modelBuilder.Entity("MantenimientoWeb.Dominio.Entidades.ProductoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("ColchonSeguridad")
                        .HasColumnType("int");

                    b.Property<int>("DemandaPromedioDiaria")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EsEstacional")
                        .HasColumnType("bit");

                    b.Property<bool>("EsFragil")
                        .HasColumnType("bit");

                    b.Property<bool>("EsPeligroso")
                        .HasColumnType("bit");

                    b.Property<bool>("EsPerecedero")
                        .HasColumnType("bit");

                    b.Property<bool>("EstaSujetoAInflacion")
                        .HasColumnType("bit");

                    b.Property<bool>("FastDelivery")
                        .HasColumnType("bit");

                    b.Property<int>("MonedaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecioCosto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("RequiereRefrigeracion")
                        .HasColumnType("bit");

                    b.Property<int>("StockActual")
                        .HasColumnType("int");

                    b.Property<int>("StockMinimo")
                        .HasColumnType("int");

                    b.Property<int>("StockSeguridad")
                        .HasColumnType("int");

                    b.Property<int>("TiempoRestockDias")
                        .HasColumnType("int");

                    b.Property<bool>("TieneAltaValor")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("MonedaId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("MantenimientoWeb.Dominio.Entidades.TipoEmpresaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoEmpresas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Cliente"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Proveedor"
                        });
                });

            modelBuilder.Entity("MantenimientoWeb.Dominio.Entidades.EmpresaModel", b =>
                {
                    b.HasOne("MantenimientoWeb.Dominio.Entidades.PaisModel", "Pais")
                        .WithMany()
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MantenimientoWeb.Dominio.Entidades.TipoEmpresaModel", "TipoEmpresa")
                        .WithMany()
                        .HasForeignKey("TipoEmpresaId");

                    b.Navigation("Pais");

                    b.Navigation("TipoEmpresa");
                });

            modelBuilder.Entity("MantenimientoWeb.Dominio.Entidades.ProductoModel", b =>
                {
                    b.HasOne("MantenimientoWeb.Dominio.Entidades.CategoriaProductoModel", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MantenimientoWeb.Dominio.Entidades.MonedaProductoModel", "Moneda")
                        .WithMany()
                        .HasForeignKey("MonedaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Moneda");
                });
#pragma warning restore 612, 618
        }
    }
}
