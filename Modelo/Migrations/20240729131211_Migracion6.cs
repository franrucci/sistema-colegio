using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class Migracion6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alumnos_Grados_GradoId",
                table: "Alumnos");

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnos_Grados_GradoId",
                table: "Alumnos",
                column: "GradoId",
                principalTable: "Grados",
                principalColumn: "GradoId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alumnos_Grados_GradoId",
                table: "Alumnos");

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnos_Grados_GradoId",
                table: "Alumnos",
                column: "GradoId",
                principalTable: "Grados",
                principalColumn: "GradoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
