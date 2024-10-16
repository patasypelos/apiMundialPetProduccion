using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MundialApiPet.Migrations
{
    public partial class Carga_tablas_baños_inventario_23_09_23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoBano",
                columns: table => new
                {
                    IdTipoBanoInventario = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "NVARCHAR(255)", maxLength: 300, nullable: true),
                    Nombre = table.Column<string>(type: "NVARCHAR(255)", maxLength: 300, nullable: true),
                    EstadoActivo = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoBano", x => x.IdTipoBanoInventario);
                });

            migrationBuilder.CreateTable(
                name: "TipoRaza",
                columns: table => new
                {
                    IdTipoRazaInventario = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "NVARCHAR(255)", maxLength: 300, nullable: true),
                    Nombre = table.Column<string>(type: "NVARCHAR(255)", maxLength: 300, nullable: true),
                    EstadoActivo = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoRaza", x => x.IdTipoRazaInventario);
                });

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    IdAnimalInventario = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "NVARCHAR(255)", maxLength: 300, nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: true),
                    FechaActualizacion = table.Column<DateTime>(nullable: true),
                    FechaDesactivacion = table.Column<DateTime>(nullable: true),
                    EstadoActivo = table.Column<bool>(type: "BIT", nullable: false),
                    Nombre = table.Column<string>(type: "NVARCHAR(255)", maxLength: 30, nullable: false),
                    Telefono = table.Column<string>(type: "NVARCHAR(255)", maxLength: 30, nullable: false),
                    TelefonoDos = table.Column<string>(type: "NVARCHAR(255)", maxLength: 30, nullable: false),
                    NombrePropietario = table.Column<string>(type: "NVARCHAR(255)", maxLength: 30, nullable: false),
                    NombrePropietarioDos = table.Column<string>(type: "NVARCHAR(255)", maxLength: 30, nullable: false),
                    Genero = table.Column<string>(type: "NVARCHAR(255)", maxLength: 30, nullable: false),
                    Edad = table.Column<string>(type: "NVARCHAR(255)", maxLength: 30, nullable: false),
                    PrecioBano = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    IdTipoRazaInventario = table.Column<int>(type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.IdAnimalInventario);
                    table.ForeignKey(
                        name: "FK_Animal_TipoRaza_IdTipoRazaInventario",
                        column: x => x.IdTipoRazaInventario,
                        principalTable: "TipoRaza",
                        principalColumn: "IdTipoRazaInventario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Banos",
                columns: table => new
                {
                    IdBanosInventario = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "NVARCHAR(255)", maxLength: 300, nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: true),
                    FechaActualizacion = table.Column<DateTime>(nullable: true),
                    FechaDesactivacion = table.Column<DateTime>(nullable: true),
                    EstadoActivo = table.Column<bool>(type: "BIT", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Transaccion = table.Column<string>(type: "NVARCHAR(255)", maxLength: 30, nullable: false),
                    IdTipoBanoInventario = table.Column<int>(type: "INT", nullable: true),
                    IdAnimalInventario = table.Column<int>(type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banos", x => x.IdBanosInventario);
                    table.ForeignKey(
                        name: "FK_Banos_Animal_IdAnimalInventario",
                        column: x => x.IdAnimalInventario,
                        principalTable: "Animal",
                        principalColumn: "IdAnimalInventario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Banos_TipoBano_IdTipoBanoInventario",
                        column: x => x.IdTipoBanoInventario,
                        principalTable: "TipoBano",
                        principalColumn: "IdTipoBanoInventario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_IdTipoRazaInventario",
                table: "Animal",
                column: "IdTipoRazaInventario");

            migrationBuilder.CreateIndex(
                name: "IX_Banos_IdAnimalInventario",
                table: "Banos",
                column: "IdAnimalInventario");

            migrationBuilder.CreateIndex(
                name: "IX_Banos_IdTipoBanoInventario",
                table: "Banos",
                column: "IdTipoBanoInventario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banos");

            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropTable(
                name: "TipoBano");

            migrationBuilder.DropTable(
                name: "TipoRaza");
        }
    }
}
