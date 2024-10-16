using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MundialApiPet.Migrations
{
    public partial class PrimeraCargaDatossssssss222 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InversionTienda",
                columns: table => new
                {
                    IdInversionTienda = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaRegistro = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Valor = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InversionTienda", x => x.IdInversionTienda);
                });

            migrationBuilder.CreateTable(
                name: "TipoArticulo",
                columns: table => new
                {
                    IdTipoArticulo = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "NVARCHAR(255)", maxLength: 300, nullable: true),
                    Nombre = table.Column<string>(type: "NVARCHAR(255)", maxLength: 300, nullable: true),
                    EstadoActivo = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoArticulo", x => x.IdTipoArticulo);
                });

            migrationBuilder.CreateTable(
                name: "TipoMarca",
                columns: table => new
                {
                    IdTipoMarca = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "NVARCHAR(255)", maxLength: 300, nullable: true),
                    Nombre = table.Column<string>(type: "NVARCHAR(255)", maxLength: 300, nullable: true),
                    EstadoActivo = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMarca", x => x.IdTipoMarca);
                });

            migrationBuilder.CreateTable(
                name: "Articulo",
                columns: table => new
                {
                    IdArticulo = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "NVARCHAR(255)", maxLength: 300, nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: true),
                    FechaActualizacion = table.Column<DateTime>(nullable: true),
                    FechaDesactivacion = table.Column<DateTime>(nullable: true),
                    EstadoActivo = table.Column<bool>(type: "BIT", nullable: false),
                    IdTipoArticulo = table.Column<int>(type: "INT", nullable: true),
                    IdTipoMarca = table.Column<int>(type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulo", x => x.IdArticulo);
                    table.ForeignKey(
                        name: "FK_Articulo_TipoArticulo_IdTipoArticulo",
                        column: x => x.IdTipoArticulo,
                        principalTable: "TipoArticulo",
                        principalColumn: "IdTipoArticulo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articulo_TipoMarca_IdTipoMarca",
                        column: x => x.IdTipoMarca,
                        principalTable: "TipoMarca",
                        principalColumn: "IdTipoMarca",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LogArticulo",
                columns: table => new
                {
                    IdLogArticulo = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "NVARCHAR(255)", maxLength: 300, nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: true),
                    FechaActualizacion = table.Column<DateTime>(nullable: true),
                    FechaDesactivacion = table.Column<DateTime>(nullable: true),
                    EstadoActivo = table.Column<bool>(type: "BIT", nullable: false),
                    CantidadVendidad = table.Column<int>(type: "INT", nullable: false),
                    PrecioVenta = table.Column<int>(type: "INT", nullable: false),
                    Transaccion = table.Column<string>(type: "NVARCHAR(255)", maxLength: 30, nullable: false),
                    IdTipoArticulo = table.Column<int>(type: "INT", nullable: true),
                    IdTipoMarca = table.Column<int>(type: "INT", nullable: true),
                    IdArticulo = table.Column<int>(type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogArticulo", x => x.IdLogArticulo);
                    table.ForeignKey(
                        name: "FK_LogArticulo_Articulo_IdArticulo",
                        column: x => x.IdArticulo,
                        principalTable: "Articulo",
                        principalColumn: "IdArticulo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LogArticulo_TipoArticulo_IdTipoArticulo",
                        column: x => x.IdTipoArticulo,
                        principalTable: "TipoArticulo",
                        principalColumn: "IdTipoArticulo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LogArticulo_TipoMarca_IdTipoMarca",
                        column: x => x.IdTipoMarca,
                        principalTable: "TipoMarca",
                        principalColumn: "IdTipoMarca",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_IdTipoArticulo",
                table: "Articulo",
                column: "IdTipoArticulo");

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_IdTipoMarca",
                table: "Articulo",
                column: "IdTipoMarca");

            migrationBuilder.CreateIndex(
                name: "IX_LogArticulo_IdArticulo",
                table: "LogArticulo",
                column: "IdArticulo");

            migrationBuilder.CreateIndex(
                name: "IX_LogArticulo_IdTipoArticulo",
                table: "LogArticulo",
                column: "IdTipoArticulo");

            migrationBuilder.CreateIndex(
                name: "IX_LogArticulo_IdTipoMarca",
                table: "LogArticulo",
                column: "IdTipoMarca");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InversionTienda");

            migrationBuilder.DropTable(
                name: "LogArticulo");

            migrationBuilder.DropTable(
                name: "Articulo");

            migrationBuilder.DropTable(
                name: "TipoArticulo");

            migrationBuilder.DropTable(
                name: "TipoMarca");
        }
    }
}
