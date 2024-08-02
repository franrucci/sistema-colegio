using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class Migracion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grados",
                columns: table => new
                {
                    GradoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumGrado = table.Column<int>(type: "int", nullable: false),
                    CantidadMaterias = table.Column<int>(type: "int", nullable: false),
                    Especialidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grados", x => x.GradoId);
                });

            migrationBuilder.CreateTable(
                name: "Trimestres",
                columns: table => new
                {
                    TrimestreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodTrimestre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumTrimestre = table.Column<int>(type: "int", nullable: false),
                    DiasTotalesHabiles = table.Column<int>(type: "int", nullable: false),
                    Año = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trimestres", x => x.TrimestreId);
                });

            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    AlumnoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sexo = table.Column<int>(type: "int", nullable: false),
                    Domicilio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    GradoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.AlumnoId);
                    table.ForeignKey(
                        name: "FK_Alumnos_Grados_GradoId",
                        column: x => x.GradoId,
                        principalTable: "Grados",
                        principalColumn: "GradoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    MateriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoMateria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreMateria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorasAnuales = table.Column<int>(type: "int", nullable: false),
                    Especialidad1 = table.Column<int>(type: "int", nullable: false),
                    GradoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.MateriaId);
                    table.ForeignKey(
                        name: "FK_Materias_Grados_GradoId",
                        column: x => x.GradoId,
                        principalTable: "Grados",
                        principalColumn: "GradoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asistencias",
                columns: table => new
                {
                    AsistenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo1 = table.Column<int>(type: "int", nullable: false),
                    TrimestreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencias", x => x.AsistenciaId);
                    table.ForeignKey(
                        name: "FK_Asistencias_Trimestres_TrimestreId",
                        column: x => x.TrimestreId,
                        principalTable: "Trimestres",
                        principalColumn: "TrimestreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Examenes",
                columns: table => new
                {
                    ExamenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo1 = table.Column<int>(type: "int", nullable: false),
                    TrimestreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examenes", x => x.ExamenId);
                    table.ForeignKey(
                        name: "FK_Examenes_Trimestres_TrimestreId",
                        column: x => x.TrimestreId,
                        principalTable: "Trimestres",
                        principalColumn: "TrimestreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LibrosAlumnos",
                columns: table => new
                {
                    LibroAlumnoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlumnoId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    PorcentajeAsistenciaTrimestre1 = table.Column<decimal>(type: "decimal(4,1)", nullable: true),
                    PorcentajeAsistenciaTrimestre2 = table.Column<decimal>(type: "decimal(4,1)", nullable: true),
                    PorcentajeAsistenciaTrimestre3 = table.Column<decimal>(type: "decimal(4,1)", nullable: true),
                    NotaTrimestre1 = table.Column<decimal>(type: "decimal(4,1)", nullable: true),
                    NotaTrimestre2 = table.Column<decimal>(type: "decimal(4,1)", nullable: true),
                    NotaTrimestre3 = table.Column<decimal>(type: "decimal(4,1)", nullable: true),
                    NotaFinalAnual = table.Column<decimal>(type: "decimal(4,1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibrosAlumnos", x => x.LibroAlumnoId);
                    table.ForeignKey(
                        name: "FK_LibrosAlumnos_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "AlumnoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesDeCalificaciones",
                columns: table => new
                {
                    DetalleCalificacionesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codDetalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nota = table.Column<int>(type: "int", nullable: false),
                    MateriaId = table.Column<int>(type: "int", nullable: false),
                    ExamenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesDeCalificaciones", x => x.DetalleCalificacionesId);
                    table.ForeignKey(
                        name: "FK_DetallesDeCalificaciones_Examenes_ExamenId",
                        column: x => x.ExamenId,
                        principalTable: "Examenes",
                        principalColumn: "ExamenId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesDeCalificaciones_Materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materias",
                        principalColumn: "MateriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Grados",
                columns: new[] { "GradoId", "CantidadMaterias", "Especialidad", "NumGrado" },
                values: new object[,]
                {
                    { 1, 8, 0, 1 },
                    { 2, 10, 0, 2 },
                    { 3, 10, 0, 3 },
                    { 4, 11, 2, 4 },
                    { 5, 11, 2, 5 },
                    { 6, 10, 2, 6 }
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "AlumnoId", "Apellido", "CodigoPostal", "Dni", "Domicilio", "Estado", "FechaNacimiento", "GradoId", "Localidad", "Nombre", "Pais", "Provincia", "Sexo" },
                values: new object[,]
                {
                    { 1, "Pérez", "2000", "12345678", "San Martin 1234", 0, new DateTime(2005, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Rosario", "Juan", "Argentina", "Santa Fe", 0 },
                    { 2, "Gómez", "1406", "23456789", "Calle 5 de Mayo 567", 0, new DateTime(2006, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Buenos Aires", "María", "Argentina", "Buenos Aires", 1 }
                });

            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "MateriaId", "CodigoMateria", "Especialidad1", "GradoId", "HorasAnuales", "NombreMateria" },
                values: new object[,]
                {
                    { 1, "A01", 0, 1, 0, "Ciencias Naturales" },
                    { 2, "A02", 0, 1, 0, "Ciencias Sociales" },
                    { 3, "A03", 0, 1, 0, "Educación Artística" },
                    { 4, "A04", 0, 1, 0, "Educación Física" },
                    { 5, "A05", 0, 1, 0, "Inglés" },
                    { 6, "A06", 0, 1, 0, "Matemática" },
                    { 7, "A07", 0, 1, 0, "Prácticas del Lenguaje" },
                    { 8, "A08", 0, 1, 0, "Construcción de Ciudadanía" },
                    { 9, "B01", 0, 2, 0, "Biología" },
                    { 10, "B02", 0, 2, 0, "Construcción de Ciudadanía" },
                    { 11, "B03", 0, 2, 0, "Educación Artística" },
                    { 12, "B04", 0, 2, 0, "Educación Física" },
                    { 13, "B05", 0, 2, 0, "Físico Química" },
                    { 14, "B06", 0, 2, 0, "Geografía" },
                    { 15, "B07", 0, 2, 0, "Historia" },
                    { 16, "B08", 0, 2, 0, "Inglés" },
                    { 17, "B09", 0, 2, 0, "Matemática" },
                    { 18, "B10", 0, 2, 0, "Prácticas del Lenguaje" },
                    { 19, "C01", 0, 3, 0, "Biología" },
                    { 20, "C02", 0, 3, 0, "Construcción de Ciudadanía" },
                    { 21, "C03", 0, 3, 0, "Educación Artística" },
                    { 22, "C04", 0, 3, 0, "Educación Física" },
                    { 23, "C05", 0, 3, 0, "Físico Química" },
                    { 24, "C06", 0, 3, 0, "Geografía" },
                    { 25, "C07", 0, 3, 0, "Historia" },
                    { 26, "C08", 0, 3, 0, "Inglés" },
                    { 27, "C09", 0, 3, 0, "Matemática" },
                    { 28, "C10", 0, 3, 0, "Prácticas del Lenguaje" },
                    { 29, "D01", 0, 4, 0, "Matemática" },
                    { 30, "D02", 0, 4, 0, "Literatura" },
                    { 31, "D03", 0, 4, 0, "Educación Física" },
                    { 32, "D04", 0, 4, 0, "Inglés" },
                    { 33, "D05", 0, 4, 0, "Salud y Adolescencia" },
                    { 34, "D06", 0, 4, 0, "Biología" },
                    { 35, "D07", 0, 4, 0, "Historia" },
                    { 36, "D08", 0, 4, 0, "Geografía" },
                    { 37, "D09", 0, 4, 0, "NTICx" },
                    { 38, "D10", 0, 4, 0, "Psicología" },
                    { 39, "E01", 0, 5, 0, "Matemática" },
                    { 40, "E02", 0, 5, 0, "Literatura" },
                    { 41, "E03", 0, 5, 0, "Educación Física" },
                    { 42, "E04", 0, 5, 0, "Inglés" },
                    { 43, "E05", 0, 5, 0, "Política y Ciudadanía" },
                    { 44, "E06", 0, 5, 0, "Introducción a la Química" },
                    { 45, "E07", 0, 5, 0, "Comunicación, Cultura y Sociedad" },
                    { 46, "E08", 0, 5, 0, "Historia" },
                    { 47, "E09", 0, 5, 0, "Geografía" },
                    { 48, "E10", 0, 5, 0, "Economía Política" },
                    { 49, "E11", 0, 5, 0, "Sociología" },
                    { 50, "F01", 0, 6, 0, "Matemática" },
                    { 51, "F02", 0, 6, 0, "Literatura" },
                    { 52, "F03", 0, 6, 0, "Educación Física" },
                    { 53, "F04", 0, 6, 0, "Inglés" },
                    { 54, "F05", 0, 6, 0, "Trabajo y Ciudadanía" },
                    { 55, "F06", 0, 6, 0, "Proyecto de Investigación en Ciencias Sociales" },
                    { 56, "F07", 0, 6, 0, "Historia" },
                    { 57, "F08", 0, 6, 0, "Geografía" },
                    { 58, "F09", 0, 6, 0, "Arte" },
                    { 59, "F10", 0, 6, 0, "Filosofía" }
                });

            migrationBuilder.InsertData(
                table: "LibrosAlumnos",
                columns: new[] { "LibroAlumnoId", "AlumnoId", "Discriminator", "NotaFinalAnual", "NotaTrimestre1", "NotaTrimestre2", "NotaTrimestre3" },
                values: new object[,]
                {
                    { 1, 1, "LibroDeCalificaciones", 0m, 0m, 0m, 0m },
                    { 2, 2, "LibroDeCalificaciones", 0m, 0m, 0m, 0m }
                });

            migrationBuilder.InsertData(
                table: "LibrosAlumnos",
                columns: new[] { "LibroAlumnoId", "AlumnoId", "Discriminator", "PorcentajeAsistenciaTrimestre1", "PorcentajeAsistenciaTrimestre2", "PorcentajeAsistenciaTrimestre3" },
                values: new object[,]
                {
                    { 3, 1, "LibroDeAsistencias", 0m, 0m, 0m },
                    { 4, 2, "LibroDeAsistencias", 0m, 0m, 0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_GradoId",
                table: "Alumnos",
                column: "GradoId");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencias_TrimestreId",
                table: "Asistencias",
                column: "TrimestreId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesDeCalificaciones_ExamenId",
                table: "DetallesDeCalificaciones",
                column: "ExamenId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesDeCalificaciones_MateriaId",
                table: "DetallesDeCalificaciones",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Examenes_TrimestreId",
                table: "Examenes",
                column: "TrimestreId");

            migrationBuilder.CreateIndex(
                name: "IX_LibrosAlumnos_AlumnoId",
                table: "LibrosAlumnos",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Materias_GradoId",
                table: "Materias",
                column: "GradoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asistencias");

            migrationBuilder.DropTable(
                name: "DetallesDeCalificaciones");

            migrationBuilder.DropTable(
                name: "LibrosAlumnos");

            migrationBuilder.DropTable(
                name: "Examenes");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "Alumnos");

            migrationBuilder.DropTable(
                name: "Trimestres");

            migrationBuilder.DropTable(
                name: "Grados");
        }
    }
}
