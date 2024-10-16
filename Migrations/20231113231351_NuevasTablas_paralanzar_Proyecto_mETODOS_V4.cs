using Microsoft.EntityFrameworkCore.Migrations;

namespace MundialApiPet.Migrations
{
    public partial class NuevasTablas_paralanzar_Proyecto_mETODOS_V4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TipoArticulo",
                columns: new[] { "IdTipoArticulo", "Codigo", "EstadoActivo", "Nombre" },
                values: new object[,]
                {
                    { 100, "COD_MEDICAMENTO_01", true, "MEDICAMENTO" },
                    { 101, "COD_ACCESORIO_02", true, "ACCESORIO" },
                    { 103, "COD_PURINA_03", true, "PURINA" }
                });

            migrationBuilder.InsertData(
                table: "TipoMarca",
                columns: new[] { "IdTipoMarca", "Codigo", "EstadoActivo", "Nombre" },
                values: new object[,]
                {
                    { 100, "COD_DOG_CHOW_ARP_01", true, "DOG CHOW ARP" },
                    { 101, "COD_RONDEL_PUPPY_02", true, "RONDEL PUPPY" },
                    { 103, "COD_PELOTA_02", true, "PELOTA" }
                });

            migrationBuilder.InsertData(
                table: "TipoRaza",
                columns: new[] { "IdTipoRazaInventario", "Codigo", "EstadoActivo", "Nombre" },
                values: new object[,]
                {
                    { 100, "COD_DOBERMAN_01", true, "DOBERMAN" },
                    { 101, "COD_PITBULL_02", true, "PITBULL" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipoArticulo",
                keyColumn: "IdTipoArticulo",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "TipoArticulo",
                keyColumn: "IdTipoArticulo",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "TipoArticulo",
                keyColumn: "IdTipoArticulo",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "TipoMarca",
                keyColumn: "IdTipoMarca",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "TipoRaza",
                keyColumn: "IdTipoRazaInventario",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "TipoRaza",
                keyColumn: "IdTipoRazaInventario",
                keyValue: 101);
        }
    }
}
