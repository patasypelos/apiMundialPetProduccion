﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MundialApiPet.Modelo;

namespace MundialApiPet.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231119183307_campos_tipo_banio_tablas_v6")]
    partial class campos_tipo_banio_tablas_v6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MundialApiPet.Modelo.Inventario.AnimalInventario", b =>
                {
                    b.Property<int>("IdAnimalInventario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BanderaAnimalBañoActivo")
                        .HasColumnType("BIT");

                    b.Property<string>("Codigo")
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(300);

                    b.Property<string>("Edad")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(30);

                    b.Property<bool>("EstadoActivo")
                        .HasColumnType("BIT");

                    b.Property<DateTime?>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDesactivacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(30);

                    b.Property<int?>("IdTipoRazaInventario")
                        .HasColumnType("INT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(30);

                    b.Property<string>("NombrePropietario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(30);

                    b.Property<string>("NombrePropietarioDos")
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(30);

                    b.Property<string>("Observacion")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(30);

                    b.Property<decimal>("PrecioBano")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(30);

                    b.Property<string>("TelefonoDos")
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(30);

                    b.HasKey("IdAnimalInventario");

                    b.HasIndex("IdTipoRazaInventario");

                    b.ToTable("Animal");
                });

            modelBuilder.Entity("MundialApiPet.Modelo.Inventario.ArticuloInventario", b =>
                {
                    b.Property<int>("IdArticulo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CantidadDisponible")
                        .HasColumnType("INT");

                    b.Property<string>("Codigo")
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(300);

                    b.Property<bool>("EstadoActivo")
                        .HasColumnType("BIT");

                    b.Property<DateTime?>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDesactivacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdTipoArticulo")
                        .HasColumnType("INT");

                    b.Property<int?>("IdTipoMarca")
                        .HasColumnType("INT");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("IdArticulo");

                    b.HasIndex("IdTipoArticulo");

                    b.HasIndex("IdTipoMarca");

                    b.ToTable("Articulo");
                });

            modelBuilder.Entity("MundialApiPet.Modelo.Inventario.BanosInventario", b =>
                {
                    b.Property<int>("IdBanosInventario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(300);

                    b.Property<bool>("EstadoActivo")
                        .HasColumnType("BIT");

                    b.Property<DateTime?>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDesactivacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdAnimalInventario")
                        .HasColumnType("INT");

                    b.Property<int?>("IdTipoBanoInventario")
                        .HasColumnType("INT");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Transaccion")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(30);

                    b.HasKey("IdBanosInventario");

                    b.HasIndex("IdAnimalInventario");

                    b.HasIndex("IdTipoBanoInventario");

                    b.ToTable("Banos");
                });

            modelBuilder.Entity("MundialApiPet.Modelo.Inventario.LogArticuloInventario", b =>
                {
                    b.Property<int>("IdLogArticulo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CantidadDisponible")
                        .HasColumnType("INT");

                    b.Property<int>("CantidadVendidad")
                        .HasColumnType("INT");

                    b.Property<string>("Codigo")
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(300);

                    b.Property<bool>("EstadoActivo")
                        .HasColumnType("BIT");

                    b.Property<DateTime?>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDesactivacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdArticulo")
                        .HasColumnType("INT");

                    b.Property<int?>("IdTipoArticulo")
                        .HasColumnType("INT");

                    b.Property<int?>("IdTipoMarca")
                        .HasColumnType("INT");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("PrecioVenta")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Transaccion")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(30);

                    b.HasKey("IdLogArticulo");

                    b.HasIndex("IdArticulo");

                    b.HasIndex("IdTipoArticulo");

                    b.HasIndex("IdTipoMarca");

                    b.ToTable("LogArticulo");
                });

            modelBuilder.Entity("MundialApiPet.Modelo.Inventario.TipoArticuloInventario", b =>
                {
                    b.Property<int>("IdTipoArticulo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(300);

                    b.Property<bool>("EstadoActivo")
                        .HasColumnType("BIT");

                    b.Property<string>("Nombre")
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(300);

                    b.HasKey("IdTipoArticulo");

                    b.ToTable("TipoArticulo");
                });

            modelBuilder.Entity("MundialApiPet.Modelo.Inventario.TipoBanoInventario", b =>
                {
                    b.Property<int>("IdTipoBanoInventario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(300);

                    b.Property<bool>("EstadoActivo")
                        .HasColumnType("BIT");

                    b.Property<string>("Nombre")
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(300);

                    b.HasKey("IdTipoBanoInventario");

                    b.ToTable("TipoBano");

                    b.HasData(
                        new
                        {
                            IdTipoBanoInventario = 20,
                            Codigo = "COD_ANTI_PULGAS_08",
                            EstadoActivo = true,
                            Nombre = "ANTI PULGAS"
                        },
                        new
                        {
                            IdTipoBanoInventario = 21,
                            Codigo = "COD_GENERAL_9",
                            EstadoActivo = true,
                            Nombre = "GENERAL"
                        },
                        new
                        {
                            IdTipoBanoInventario = 22,
                            Codigo = "COD_GENERAL_MASCARILLA_10",
                            EstadoActivo = true,
                            Nombre = "GENERAL Y MASCARILLA"
                        },
                        new
                        {
                            IdTipoBanoInventario = 23,
                            Codigo = "COD_SOLO_BANIO_11",
                            EstadoActivo = true,
                            Nombre = "SOLO BAÑO"
                        });
                });

            modelBuilder.Entity("MundialApiPet.Modelo.Inventario.TipoMarcaInventario", b =>
                {
                    b.Property<int>("IdTipoMarca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(300);

                    b.Property<bool>("EstadoActivo")
                        .HasColumnType("BIT");

                    b.Property<string>("Nombre")
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(300);

                    b.HasKey("IdTipoMarca");

                    b.ToTable("TipoMarca");
                });

            modelBuilder.Entity("MundialApiPet.Modelo.Inventario.TipoRazaInventario", b =>
                {
                    b.Property<int>("IdTipoRazaInventario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(300);

                    b.Property<bool>("EstadoActivo")
                        .HasColumnType("BIT");

                    b.Property<string>("Nombre")
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(300);

                    b.HasKey("IdTipoRazaInventario");

                    b.ToTable("TipoRaza");
                });

            modelBuilder.Entity("MundialApiPet.Modelo.Inversiones.Inversion", b =>
                {
                    b.Property<int>("IdInversionTienda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("DATETIME");

                    b.Property<decimal?>("Valor")
                        .IsRequired()
                        .HasColumnType("DECIMAL");

                    b.HasKey("IdInversionTienda");

                    b.ToTable("InversionTienda");
                });

            modelBuilder.Entity("MundialApiPet.Modelo.Inventario.AnimalInventario", b =>
                {
                    b.HasOne("MundialApiPet.Modelo.Inventario.TipoRazaInventario", "FK_TipoRazaInventarioConAnimalInventario")
                        .WithMany()
                        .HasForeignKey("IdTipoRazaInventario");
                });

            modelBuilder.Entity("MundialApiPet.Modelo.Inventario.ArticuloInventario", b =>
                {
                    b.HasOne("MundialApiPet.Modelo.Inventario.TipoArticuloInventario", "FK_TipoArticuloInventarioConArticuloInventario")
                        .WithMany()
                        .HasForeignKey("IdTipoArticulo");

                    b.HasOne("MundialApiPet.Modelo.Inventario.TipoMarcaInventario", "FK_TipoMarcaInventarioConArticuloInventario")
                        .WithMany()
                        .HasForeignKey("IdTipoMarca");
                });

            modelBuilder.Entity("MundialApiPet.Modelo.Inventario.BanosInventario", b =>
                {
                    b.HasOne("MundialApiPet.Modelo.Inventario.AnimalInventario", "FK_AnimalInventarioConBanosInventario")
                        .WithMany()
                        .HasForeignKey("IdAnimalInventario");

                    b.HasOne("MundialApiPet.Modelo.Inventario.TipoBanoInventario", "FK_TipoBanoInventarioConBanosInventario")
                        .WithMany()
                        .HasForeignKey("IdTipoBanoInventario");
                });

            modelBuilder.Entity("MundialApiPet.Modelo.Inventario.LogArticuloInventario", b =>
                {
                    b.HasOne("MundialApiPet.Modelo.Inventario.ArticuloInventario", "FK_ArticuloInventarioConLogArticuloInventario")
                        .WithMany()
                        .HasForeignKey("IdArticulo");

                    b.HasOne("MundialApiPet.Modelo.Inventario.TipoArticuloInventario", "FK_TipoArticuloInventarioConLogArticuloInventario")
                        .WithMany()
                        .HasForeignKey("IdTipoArticulo");

                    b.HasOne("MundialApiPet.Modelo.Inventario.TipoMarcaInventario", "FK_TipoMarcaInventarioConLogArticuloInventario")
                        .WithMany()
                        .HasForeignKey("IdTipoMarca");
                });
#pragma warning restore 612, 618
        }
    }
}
