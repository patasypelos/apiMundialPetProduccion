using Microsoft.EntityFrameworkCore.Migrations;

namespace MundialApiPet.Migrations
{
    public partial class Tablas_para_carcar_infor_3_45 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipoRaza",
                keyColumn: "IdTipoRazaInventario",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoRaza",
                keyColumn: "IdTipoRazaInventario",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoRaza",
                keyColumn: "IdTipoRazaInventario",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipoRaza",
                keyColumn: "IdTipoRazaInventario",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TipoRaza",
                keyColumn: "IdTipoRazaInventario",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "TipoArticulo",
                columns: new[] { "IdTipoArticulo", "Codigo", "EstadoActivo", "Nombre" },
                values: new object[,]
                {
                    { 1, "COD_MEDICAMENTO_01", true, "MEDICAMENTO" },
                    { 2, "COD_ACCESORIO_02", true, "ACCESORIO" },
                    { 3, "COD_PURINA_03", true, "PURINA" }
                });

            migrationBuilder.InsertData(
                table: "TipoBano",
                columns: new[] { "IdTipoBanoInventario", "Codigo", "EstadoActivo", "Nombre" },
                values: new object[,]
                {
                    { 1, "COD_ANTI_PULGAS_08", true, "ANTI PULGAS" },
                    { 2, "COD_GENERAL_9", true, "GENERAL" },
                    { 3, "COD_GENERAL_MASCARILLA_10", true, "GENERAL Y MASCARILLA" },
                    { 4, "COD_SOLO_BANIO_11", true, "SOLO BAÑO" }
                });

            migrationBuilder.InsertData(
                table: "TipoMarca",
                columns: new[] { "IdTipoMarca", "Codigo", "EstadoActivo", "Nombre" },
                values: new object[,]
                {
                    { 14, "COD_MONELLO_GATO_ADULTO_11", true, "MONELLO GATO ADULTO" },
                    { 15, "COD_MIRRINGO_ADULTO_11", true, "MIRRINGO ADULTO" },
                    { 16, "COD_DON_KAT_ADULTO_11", true, "DON KAT ADULTO" },
                    { 17, "COD_DON_KAT_CACHORRO_GATITOS_11", true, "DON KAT CACHORRO GATITOS" },
                    { 20, "COD_CHUNKY_GATO_ADULTO_11", true, "CHUNKY GATO ADULTO" },
                    { 19, "COD_CAT_CHOW_CARNE_ADULTO_11", true, "CAT CHOW CARNE ADULTO" },
                    { 13, "COD_OH_MAI_GAT_ADULTO_AZUL_11", true, "OH MAI GAT ADULTO AZUL" },
                    { 21, "COD_GATSY_PESCADO_11", true, "GATSY PESCADO" },
                    { 18, "COD_CIPACAT_ADULTO_11", true, "CIPACAT ADULTO" },
                    { 12, "COD_DOG_CHOW_ADULTOS_MEDIANOS_Y_GRANDES_12", true, "DOG CHOW ADULTOS MEDIANOS Y GRANDES" },
                    { 8, "COD_MONELLO_ADULTO_RAZAS_PEQUENIAS_08", true, "MONELLO ADULTO RAZAS PEQUEÑEAS" },
                    { 10, "COD_DONKAN_ADULTOS_10", true, "DONKAN ADULTOS" },
                    { 9, "COD_RINGO_CROQUETAS_ADULTO_09", true, "RINGO CROQUETAS ADULTO" },
                    { 22, "COD_NUTRE_CAN_CROQUETAS_ADULTO_11", true, "NUTRE CAN CROQUETAS ADULTO" },
                    { 7, "COD_RINGO_PREMIUN_ADULTO_07", true, "RINGO PREMIUN ADULTO" },
                    { 6, "COD_MONELLO_CACHORRO_PERRO_06", true, "MONELLO CACHORRO PERRO" },
                    { 5, "COD_MONELLO_TRADICIONAL_ADULTO_05", true, "MONELLO TRADICIONAL ADULTO" },
                    { 4, "COD_DOGOURMET_LECHE_DESLACTOSADA_CACHORRO_04", true, "DOGOURMET LECHE DESLACTOSADA CACHORRO" },
                    { 3, "COD_CHUNKY_POLLO_ADULTO_03", true, "CHUNKY POLLO ADULTO" },
                    { 2, "COD_DOGOURMET_CARNE_A_LA PARRILLA_ADULTO_02", true, "DOGOURMET CARNE A LA PARRILLA ADULTO" },
                    { 1, "COD_DOG_CHOW_ADULTOS_MINIS_Y_PEQUENIOS_01", true, "DOG CHOW ADULTOS MINIS Y PEQUEÑOS" },
                    { 11, "COD_APA_11", true, "APA" },
                    { 23, "COD_CHUNKY CACHORRO POLLO PERRO_11", true, "CHUNKY CACHORRO POLLO PERRO" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipoArticulo",
                keyColumn: "IdTipoArticulo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoArticulo",
                keyColumn: "IdTipoArticulo",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoArticulo",
                keyColumn: "IdTipoArticulo",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipoBano",
                keyColumn: "IdTipoBanoInventario",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoBano",
                keyColumn: "IdTipoBanoInventario",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoBano",
                keyColumn: "IdTipoBanoInventario",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipoBano",
                keyColumn: "IdTipoBanoInventario",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 23);

            migrationBuilder.InsertData(
                table: "TipoRaza",
                columns: new[] { "IdTipoRazaInventario", "Codigo", "EstadoActivo", "Nombre" },
                values: new object[,]
                {
                    { 1, "COD_Shih_Tzu._01", true, "Shih Tzu" },
                    { 2, "COD_Chihuahua_02", true, "Chihuahua" },
                    { 3, "COD_Beagle_03", true, "Beagle" },
                    { 4, "COD_Border_Collie_04", true, "Border Collie" },
                    { 5, "COD_Pit_Bull_05", true, "Pit Bull" }
                });
        }
    }
}
