using Microsoft.EntityFrameworkCore.Migrations;

namespace MundialApiPet.Migrations
{
    public partial class _8_octubre_2024_tabla_imagenes_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocumentoAdjuntoArticuloTH",
                columns: table => new
                {
                    IdDocumentoAdjuntoArticulo = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "NVARCHAR(255)", maxLength: 300, nullable: true),
                    Archivo = table.Column<string>(type: "NVARCHAR(255)", maxLength: 300, nullable: true),
                    EstadoActivo = table.Column<bool>(type: "BIT", nullable: false),
                    IdArticulo = table.Column<int>(type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentoAdjuntoArticuloTH", x => x.IdDocumentoAdjuntoArticulo);
                    table.ForeignKey(
                        name: "FK_DocumentoAdjuntoArticuloTH_Articulo_IdArticulo",
                        column: x => x.IdArticulo,
                        principalTable: "Articulo",
                        principalColumn: "IdArticulo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DocumentoAdjuntoArticuloTH_IdArticulo",
                table: "DocumentoAdjuntoArticuloTH",
                column: "IdArticulo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentoAdjuntoArticuloTH");
        }
    }
}
