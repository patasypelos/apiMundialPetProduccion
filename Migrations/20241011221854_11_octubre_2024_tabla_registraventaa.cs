using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MundialApiPet.Migrations
{
    public partial class _11_octubre_2024_tabla_registraventaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IngresaVenta",
                columns: table => new
                {
                    IdIngresaVenta = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "NVARCHAR(255)", maxLength: 300, nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: true),
                    FechaActualizacion = table.Column<DateTime>(nullable: true),
                    FechaDesactivacion = table.Column<DateTime>(nullable: true),
                    EstadoActivo = table.Column<bool>(type: "BIT", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    IdTipoArticulo = table.Column<int>(type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngresaVenta", x => x.IdIngresaVenta);
                    table.ForeignKey(
                        name: "FK_IngresaVenta_Articulo_IdTipoArticulo",
                        column: x => x.IdTipoArticulo,
                        principalTable: "Articulo",
                        principalColumn: "IdArticulo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngresaVenta_IdTipoArticulo",
                table: "IngresaVenta",
                column: "IdTipoArticulo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngresaVenta");
        }
    }
}
