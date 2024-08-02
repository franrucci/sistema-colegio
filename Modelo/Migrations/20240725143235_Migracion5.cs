using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class Migracion5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LibroAlumnoId",
                table: "Asistencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Asistencias_LibroAlumnoId",
                table: "Asistencias",
                column: "LibroAlumnoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencias_LibrosAlumnos_LibroAlumnoId",
                table: "Asistencias",
                column: "LibroAlumnoId",
                principalTable: "LibrosAlumnos",
                principalColumn: "LibroAlumnoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asistencias_LibrosAlumnos_LibroAlumnoId",
                table: "Asistencias");

            migrationBuilder.DropIndex(
                name: "IX_Asistencias_LibroAlumnoId",
                table: "Asistencias");

            migrationBuilder.DropColumn(
                name: "LibroAlumnoId",
                table: "Asistencias");
        }
    }
}
