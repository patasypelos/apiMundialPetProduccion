using Microsoft.EntityFrameworkCore.Migrations;

namespace MundialApiPet.Migrations
{
    public partial class Modificar_tablas_inventario_17_09_t_3_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioVenta",
                table: "LogArticulo",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AddColumn<int>(
                name: "CantidadDisponible",
                table: "LogArticulo",
                type: "INT",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "LogArticulo",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "CantidadDisponible",
                table: "Articulo",
                type: "INT",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "Articulo",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadDisponible",
                table: "LogArticulo");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "LogArticulo");

            migrationBuilder.DropColumn(
                name: "CantidadDisponible",
                table: "Articulo");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Articulo");

            migrationBuilder.AlterColumn<int>(
                name: "PrecioVenta",
                table: "LogArticulo",
                type: "INT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");
        }
    }
}
