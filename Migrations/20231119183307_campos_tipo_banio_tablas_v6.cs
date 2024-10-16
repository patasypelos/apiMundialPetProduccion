using Microsoft.EntityFrameworkCore.Migrations;

namespace MundialApiPet.Migrations
{
    public partial class campos_tipo_banio_tablas_v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipoBano",
                keyColumn: "IdTipoBanoInventario",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TipoBano",
                keyColumn: "IdTipoBanoInventario",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TipoBano",
                keyColumn: "IdTipoBanoInventario",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TipoBano",
                keyColumn: "IdTipoBanoInventario",
                keyValue: 11);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "TipoBano",
                columns: new[] { "IdTipoBanoInventario", "Codigo", "EstadoActivo", "Nombre" },
                values: new object[,]
                {
                    { 8, "COD_ANTI_PULGAS_08", true, "ANTI PULGAS" },
                    { 9, "COD_GENERAL_9", true, "GENERAL" },
                    { 10, "COD_GENERAL_MASCARILLA_10", true, "GENERAL Y MASCARILLA" },
                    { 11, "COD_SOLO_BANIO_11", true, "SOLO BAÑO" }
                });
        }
    }
}
