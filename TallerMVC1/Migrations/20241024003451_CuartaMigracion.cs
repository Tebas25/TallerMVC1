using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallerMVC1.Migrations
{
    /// <inheritdoc />
    public partial class CuartaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estadio",
                table: "Equipos");

            migrationBuilder.AddColumn<int>(
                name: "EstadioId",
                table: "Equipos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_EstadioId",
                table: "Equipos",
                column: "EstadioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Estadios_EstadioId",
                table: "Equipos",
                column: "EstadioId",
                principalTable: "Estadios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Estadios_EstadioId",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_EstadioId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "EstadioId",
                table: "Equipos");

            migrationBuilder.AddColumn<string>(
                name: "Estadio",
                table: "Equipos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
