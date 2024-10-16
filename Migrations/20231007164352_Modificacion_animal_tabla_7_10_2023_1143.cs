using Microsoft.EntityFrameworkCore.Migrations;

namespace MundialApiPet.Migrations
{
    public partial class Modificacion_animal_tabla_7_10_2023_1143 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TelefonoDos",
                table: "Animal",
                type: "NVARCHAR(255)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(255)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "NombrePropietarioDos",
                table: "Animal",
                type: "NVARCHAR(255)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(255)",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<bool>(
                name: "BanderaAnimalBañoActivo",
                table: "Animal",
                type: "BIT",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Observacion",
                table: "Animal",
                type: "NVARCHAR(255)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BanderaAnimalBañoActivo",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "Observacion",
                table: "Animal");

            migrationBuilder.AlterColumn<string>(
                name: "TelefonoDos",
                table: "Animal",
                type: "NVARCHAR(255)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(255)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombrePropietarioDos",
                table: "Animal",
                type: "NVARCHAR(255)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(255)",
                oldMaxLength: 30,
                oldNullable: true);
        }
    }
}
