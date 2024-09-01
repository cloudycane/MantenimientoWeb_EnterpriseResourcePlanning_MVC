﻿// <auto-generated />
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
    [Migration("20240829095255_AlterEmpresaModel")]
    partial class AlterEmpresaModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.HasKey("Id");

                    b.HasIndex("PaisId");

                    b.ToTable("Empresas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CIF = "12345678",
                            CorreoElectronico = "algo@email.com",
                            Direccion = "algo",
                            PaisId = 1,
                            RazonSocial = "Empresa Ejemplo"
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

                    b.Navigation("Pais");
                });
#pragma warning restore 612, 618
        }
    }
}
