using Microsoft.EntityFrameworkCore.Migrations;

namespace MundialApiPet.Migrations
{
    public partial class _11_octubre_2024_tabla_registraventaDos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngresaVenta_Articulo_IdTipoArticulo",
                table: "IngresaVenta");

            migrationBuilder.RenameColumn(
                name: "IdTipoArticulo",
                table: "IngresaVenta",
                newName: "IdArticulo");

            migrationBuilder.RenameIndex(
                name: "IX_IngresaVenta_IdTipoArticulo",
                table: "IngresaVenta",
                newName: "IX_IngresaVenta_IdArticulo");

            migrationBuilder.AddForeignKey(
                name: "FK_IngresaVenta_Articulo_IdArticulo",
                table: "IngresaVenta",
                column: "IdArticulo",
                principalTable: "Articulo",
                principalColumn: "IdArticulo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngresaVenta_Articulo_IdArticulo",
                table: "IngresaVenta");

            migrationBuilder.RenameColumn(
                name: "IdArticulo",
                table: "IngresaVenta",
                newName: "IdTipoArticulo");

            migrationBuilder.RenameIndex(
                name: "IX_IngresaVenta_IdArticulo",
                table: "IngresaVenta",
                newName: "IX_IngresaVenta_IdTipoArticulo");

            migrationBuilder.AddForeignKey(
                name: "FK_IngresaVenta_Articulo_IdTipoArticulo",
                table: "IngresaVenta",
                column: "IdTipoArticulo",
                principalTable: "Articulo",
                principalColumn: "IdArticulo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
