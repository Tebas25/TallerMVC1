using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallerMVC1.Migrations
{
    /// <inheritdoc />
    public partial class MigracionDos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Estadios_EstadioId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Jugador_Equipos_EquipoId",
                table: "Jugador");

            migrationBuilder.AlterColumn<int>(
                name: "EquipoId",
                table: "Jugador",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EstadioId",
                table: "Equipos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Estadios_EstadioId",
                table: "Equipos",
                column: "EstadioId",
                principalTable: "Estadios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jugador_Equipos_EquipoId",
                table: "Jugador",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Estadios_EstadioId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Jugador_Equipos_EquipoId",
                table: "Jugador");

            migrationBuilder.AlterColumn<int>(
                name: "EquipoId",
                table: "Jugador",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EstadioId",
                table: "Equipos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Estadios_EstadioId",
                table: "Equipos",
                column: "EstadioId",
                principalTable: "Estadios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jugador_Equipos_EquipoId",
                table: "Jugador",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
