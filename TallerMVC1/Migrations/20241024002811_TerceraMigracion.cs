using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallerMVC1.Migrations
{
    /// <inheritdoc />
    public partial class TerceraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Estadios_Estadios",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_Estadios",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "Estadios",
                table: "Equipos");

            migrationBuilder.AddColumn<string>(
                name: "Estadio",
                table: "Equipos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estadio",
                table: "Equipos");

            migrationBuilder.AddColumn<int>(
                name: "Estadios",
                table: "Equipos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_Estadios",
                table: "Equipos",
                column: "Estadios");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Estadios_Estadios",
                table: "Equipos",
                column: "Estadios",
                principalTable: "Estadios",
                principalColumn: "Id");
        }
    }
}
