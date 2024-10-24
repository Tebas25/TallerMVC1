using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallerMVC1.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigracion : Migration
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

            migrationBuilder.RenameColumn(
                name: "EquipoId",
                table: "Jugador",
                newName: "Equipos");

            migrationBuilder.RenameIndex(
                name: "IX_Jugador_EquipoId",
                table: "Jugador",
                newName: "IX_Jugador_Equipos");

            migrationBuilder.RenameColumn(
                name: "EstadioId",
                table: "Equipos",
                newName: "Estadios");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_EstadioId",
                table: "Equipos",
                newName: "IX_Equipos_Estadios");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Estadios_Estadios",
                table: "Equipos",
                column: "Estadios",
                principalTable: "Estadios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jugador_Equipos_Equipos",
                table: "Jugador",
                column: "Equipos",
                principalTable: "Equipos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Estadios_Estadios",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Jugador_Equipos_Equipos",
                table: "Jugador");

            migrationBuilder.RenameColumn(
                name: "Equipos",
                table: "Jugador",
                newName: "EquipoId");

            migrationBuilder.RenameIndex(
                name: "IX_Jugador_Equipos",
                table: "Jugador",
                newName: "IX_Jugador_EquipoId");

            migrationBuilder.RenameColumn(
                name: "Estadios",
                table: "Equipos",
                newName: "EstadioId");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_Estadios",
                table: "Equipos",
                newName: "IX_Equipos_EstadioId");

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
    }
}
