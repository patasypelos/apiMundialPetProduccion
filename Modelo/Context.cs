using Microsoft.EntityFrameworkCore;
using MundialApiPet.Modelo.AdministracionUsuario;
using MundialApiPet.Modelo.Inventario;
using MundialApiPet.Modelo.Inversiones;
using MundialApiPet.Modelo.ProductosServicios;
using MundialApiPet.Modelo.Ventas;

namespace MundialApiPet.Modelo
{
    public class Context : DbContext
    {
     

        public Context(DbContextOptions<Context> options)
                : base(options)
            {
            }

         

            public DbSet<Inversion> Inversiones { get; set; }
            public DbSet<TipoMarcaInventario> TiposMarcasInventarios { get; set; }
            public DbSet<TipoArticuloInventario> TiposArticulosInventarios { get; set; }
            public DbSet<ArticuloInventario> ArticulosInventarios { get; set; }
            public DbSet<LogArticuloInventario> LogsArticulosInventarios { get; set; }
            public DbSet<TipoBanoInventario> TiposBanosInventarios { get; set; }
            public DbSet<BanosInventario> BanosInventarios { get; set; }
            public DbSet<AnimalInventario> AnimalesInventarios { get; set; }
            public DbSet<TipoRazaInventario> TiposRazasInventarios { get; set; }
            public DbSet<UsuarioAdministracion> UsuariosAdministraciones { get; set; }
            public DbSet<DocumentoAdjuntoArticulo> DocumentosAdjuntosArticulos { get; set; }
            public DbSet<IngresaVentaTH> IngresasVentasTHs { get; set; }
        // Define otras entidades y DbSet según sea necesario

         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {

            #region carga tipos de razas
            //modelBuilder.Entity<TipoRazaInventario>().HasData(
            //          new TipoRazaInventario
            //          {
            //              IdTipoRazaInventario = 1,
            //              EstadoActivo = true,
            //              Codigo = "COD_Shih_Tzu._01",
            //              Nombre = "Shih Tzu"
            //          },
            //          new TipoRazaInventario
            //          {
            //              IdTipoRazaInventario = 2,
            //              EstadoActivo = true,
            //              Codigo = "COD_Chihuahua_02",
            //              Nombre = "Chihuahua"
            //          },
            //          new TipoRazaInventario
            //          {IdTipoRazaInventario = 3,
            //              EstadoActivo = true,
            //              Codigo = "COD_Beagle_03",
            //              Nombre = "Beagle"
            //          },
            //          new TipoRazaInventario
            //          {IdTipoRazaInventario = 4,
            //              EstadoActivo = true,
            //              Codigo = "COD_Border_Collie_04",
            //              Nombre = "Border Collie"
            //          },
            //          new TipoRazaInventario
            //          {IdTipoRazaInventario = 5,
            //              EstadoActivo = true,
            //              Codigo = "COD_Pit_Bull_05",
            //              Nombre = "Pit Bull"
            //          }
            //          );
            #endregion


            #region carga tipo de marca
            //modelBuilder.Entity<TipoMarcaInventario>().HasData(
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 1,
            //       EstadoActivo = true,
            //       Codigo = "COD_DOG_CHOW_ADULTOS_MINIS_Y_PEQUENIOS_01",
            //       Nombre = "DOG CHOW ADULTOS MINIS Y PEQUEÑOS"
            //   },
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 2,
            //       EstadoActivo = true,
            //       Codigo = "COD_DOGOURMET_CARNE_A_LA PARRILLA_ADULTO_02",
            //       Nombre = "DOGOURMET CARNE A LA PARRILLA ADULTO"
            //   },
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 3,
            //       EstadoActivo = true,
            //       Codigo = "COD_CHUNKY_POLLO_ADULTO_03",
            //       Nombre = "CHUNKY POLLO ADULTO"
            //   },
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 4,
            //       EstadoActivo = true,
            //       Codigo = "COD_DOGOURMET_LECHE_DESLACTOSADA_CACHORRO_04",
            //       Nombre = "DOGOURMET LECHE DESLACTOSADA CACHORRO"
            //   },
            //   new TipoMarcaInventario
            //   {
            //        IdTipoMarca = 5,
            //       EstadoActivo = true,
            //       Codigo = "COD_MONELLO_TRADICIONAL_ADULTO_05",
            //       Nombre = "MONELLO TRADICIONAL ADULTO"
            //   },
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 6,
            //       EstadoActivo = true,
            //       Codigo = "COD_MONELLO_CACHORRO_PERRO_06",
            //       Nombre = "MONELLO CACHORRO PERRO"
            //   },
            //   new TipoMarcaInventario
            //   {
            //        IdTipoMarca = 7,
            //       EstadoActivo = true,
            //       Codigo = "COD_RINGO_PREMIUN_ADULTO_07",
            //       Nombre = "RINGO PREMIUN ADULTO"
            //   },
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 8,
            //       EstadoActivo = true,
            //       Codigo = "COD_MONELLO_ADULTO_RAZAS_PEQUENIAS_08",
            //       Nombre = "MONELLO ADULTO RAZAS PEQUEÑEAS"
            //   },
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 9,
            //       EstadoActivo = true,
            //       Codigo = "COD_RINGO_CROQUETAS_ADULTO_09",
            //       Nombre = "RINGO CROQUETAS ADULTO"
            //   },
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 10,
            //       EstadoActivo = true,
            //       Codigo = "COD_DONKAN_ADULTOS_10",
            //       Nombre = "DONKAN ADULTOS"
            //   },
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 11,
            //       EstadoActivo = true,
            //       Codigo = "COD_APA_11",
            //       Nombre = "APA"
            //   },
            //   new TipoMarcaInventario
            //   {
            //        IdTipoMarca = 12,
            //       EstadoActivo = true,
            //       Codigo = "COD_DOG_CHOW_ADULTOS_MEDIANOS_Y_GRANDES_12",
            //       Nombre = "DOG CHOW ADULTOS MEDIANOS Y GRANDES"
            //   },
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 13,
            //       EstadoActivo = true,
            //       Codigo = "COD_OH_MAI_GAT_ADULTO_AZUL_11",
            //       Nombre = "OH MAI GAT ADULTO AZUL"
            //   },
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 14,
            //       EstadoActivo = true,
            //       Codigo = "COD_MONELLO_GATO_ADULTO_11",
            //       Nombre = "MONELLO GATO ADULTO"
            //   },
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 15,
            //       EstadoActivo = true,
            //       Codigo = "COD_MIRRINGO_ADULTO_11",
            //       Nombre = "MIRRINGO ADULTO"
            //   },
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 16,
            //       EstadoActivo = true,
            //       Codigo = "COD_DON_KAT_ADULTO_11",
            //       Nombre = "DON KAT ADULTO"
            //   },
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 17,
            //       EstadoActivo = true,
            //       Codigo = "COD_DON_KAT_CACHORRO_GATITOS_11",
            //       Nombre = "DON KAT CACHORRO GATITOS"
            //   },
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 18,
            //       EstadoActivo = true,
            //       Codigo = "COD_CIPACAT_ADULTO_11",
            //       Nombre = "CIPACAT ADULTO"
            //   },
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 19,
            //       EstadoActivo = true,
            //       Codigo = "COD_CAT_CHOW_CARNE_ADULTO_11",
            //       Nombre = "CAT CHOW CARNE ADULTO"
            //   },
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 20,
            //       EstadoActivo = true,
            //       Codigo = "COD_CHUNKY_GATO_ADULTO_11",
            //       Nombre = "CHUNKY GATO ADULTO"
            //   },
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 21,
            //       EstadoActivo = true,
            //       Codigo = "COD_GATSY_PESCADO_11",
            //       Nombre = "GATSY PESCADO"
            //   },
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 22,
            //       EstadoActivo = true,
            //       Codigo = "COD_NUTRE_CAN_CROQUETAS_ADULTO_11",
            //       Nombre = "NUTRE CAN CROQUETAS ADULTO"
            //   },
            //   new TipoMarcaInventario
            //   {
            //       IdTipoMarca = 23,
            //       EstadoActivo = true,
            //       Codigo = "COD_CHUNKY CACHORRO POLLO PERRO_11",
            //       Nombre = "CHUNKY CACHORRO POLLO PERRO"
            //   }
            //   );
            #endregion

            #region carga tipo de artivculo
            //modelBuilder.Entity<TipoArticuloInventario>().HasData(
            //  new TipoArticuloInventario
            //  {
            //      IdTipoArticulo = 1,
            //      EstadoActivo = true,
            //      Codigo = "COD_MEDICAMENTO_01",
            //      Nombre = "MEDICAMENTO"
            //  },
            //  new TipoArticuloInventario
            //  {
            //      IdTipoArticulo = 2,
            //      EstadoActivo = true,
            //      Codigo = "COD_ACCESORIO_02",
            //      Nombre = "ACCESORIO"
            //  },
            //  new TipoArticuloInventario
            //  {
            //      IdTipoArticulo = 3,
            //      EstadoActivo = true,
            //      Codigo = "COD_PURINA_03",
            //      Nombre = "PURINA"
            //  }
            //   );
            #endregion

            #region carga los tipos de baños
           // modelBuilder.Entity<TipoBanoInventario>().HasData(
           //new TipoBanoInventario
           //{
           //    IdTipoBanoInventario = 1,
           //    EstadoActivo = true,
           //    Codigo = "COD_ANTI_PULGAS_08",
           //    Nombre = "ANTI PULGAS"
           //},
           //new TipoBanoInventario
           //{
           //    IdTipoBanoInventario = 2,
           //    EstadoActivo = true,
           //    Codigo = "COD_GENERAL_9",
           //    Nombre = "GENERAL"
           //},
           //new TipoBanoInventario
           //{
           //    IdTipoBanoInventario = 3,
           //    EstadoActivo = true,
           //    Codigo = "COD_GENERAL_MASCARILLA_10",
           //    Nombre = "GENERAL Y MASCARILLA"
           //},
           //new TipoBanoInventario
           //{
           //    IdTipoBanoInventario = 4,
           //    EstadoActivo = true,
           //    Codigo = "COD_SOLO_BANIO_11",
           //    Nombre = "SOLO BAÑO"
           //}

           //);
            #endregion


        }

    }
}
