using Microsoft.EntityFrameworkCore.Migrations;

namespace MundialApiPet.Migrations
{
    public partial class Tablas_para_carcar_infor_3_17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipoBano",
                keyColumn: "IdTipoBanoInventario",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TipoBano",
                keyColumn: "IdTipoBanoInventario",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TipoBano",
                keyColumn: "IdTipoBanoInventario",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TipoBano",
                keyColumn: "IdTipoBanoInventario",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "TipoBano",
                columns: new[] { "IdTipoBanoInventario", "Codigo", "EstadoActivo", "Nombre" },
                values: new object[,]
                {
                    { 20, "COD_ANTI_PULGAS_08", true, "ANTI PULGAS" },
                    { 21, "COD_GENERAL_9", true, "GENERAL" },
                    { 22, "COD_GENERAL_MASCARILLA_10", true, "GENERAL Y MASCARILLA" },
                    { 23, "COD_SOLO_BANIO_11", true, "SOLO BAÑO" }
                });
        }
    }
}
