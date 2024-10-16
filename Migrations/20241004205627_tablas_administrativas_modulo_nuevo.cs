using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MundialApiPet.Migrations
{
    public partial class tablas_administrativas_modulo_nuevo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsuariosAdministraciones",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "NVARCHAR(255)", maxLength: 300, nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: true),
                    FechaActualizacion = table.Column<DateTime>(nullable: true),
                    FechaDesactivacion = table.Column<DateTime>(nullable: true),
                    EstadoActivo = table.Column<bool>(type: "BIT", nullable: false),
                    Nombre = table.Column<string>(type: "NVARCHAR(255)", maxLength: 30, nullable: false),
                    Apellidos = table.Column<string>(type: "NVARCHAR(255)", maxLength: 30, nullable: false),
                    Correo = table.Column<string>(type: "NVARCHAR(155)", maxLength: 30, nullable: false),
                    Contraseña = table.Column<string>(type: "NVARCHAR(500)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosAdministraciones", x => x.IdUsuario);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuariosAdministraciones");
        }
    }
}
