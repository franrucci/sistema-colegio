using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Context : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<DetalleCalificaciones> DetallesDeCalificaciones { get; set; }
        public DbSet<Examen> Examenes { get; set; }
        public DbSet<Grado> Grados { get; set; }
        public DbSet<LibroAlumno> LibrosAlumnos { get; set; }
        public DbSet<LibroDeAsistencias> LibrosDeAsistencias { get; set; }
        public DbSet<LibroDeCalificaciones> LibrosDeCalificaciones { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Trimestre> Trimestres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SistemaColegioDAS;
        Integrated Security=True;MultipleActiveResultSets=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LibroDeAsistencias>()
                .Property(l => l.PorcentajeAsistenciaTrimestre1)
                .HasColumnType("decimal(4, 1)");

            modelBuilder.Entity<LibroDeAsistencias>()
                .Property(l => l.PorcentajeAsistenciaTrimestre2)
                .HasColumnType("decimal(4, 1)");

            modelBuilder.Entity<LibroDeAsistencias>()
                .Property(l => l.PorcentajeAsistenciaTrimestre3)
                .HasColumnType("decimal(4, 1)");

            modelBuilder.Entity<LibroDeCalificaciones>()
                .Property(l => l.NotaTrimestre1)
                .HasColumnType("decimal(4, 1)");

            modelBuilder.Entity<LibroDeCalificaciones>()
                .Property(l => l.NotaTrimestre2)
                .HasColumnType("decimal(4, 1)");

            modelBuilder.Entity<LibroDeCalificaciones>()
                .Property(l => l.NotaTrimestre3)
                .HasColumnType("decimal(4, 1)");

            modelBuilder.Entity<LibroDeCalificaciones>()
                .Property(l => l.NotaFinalAnual)
                .HasColumnType("decimal(4, 1)");

            modelBuilder.Entity<LibroDeCalificaciones>()
                .HasBaseType<LibroAlumno>();

            modelBuilder.Entity<LibroDeAsistencias>()
                .HasBaseType<LibroAlumno>();

            modelBuilder.Entity<Alumno>()
                .HasOne(a => a.LibroDeCalificaciones)
                .WithOne(l => l.Alumno)
                .HasForeignKey<LibroDeCalificaciones>(l => l.LibroAlumnoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Alumno>()
                .HasOne(a => a.LibroDeAsistencias)
                .WithOne(l => l.Alumno)
                .HasForeignKey<LibroDeAsistencias>(l => l.LibroAlumnoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LibroDeCalificaciones>()
                .HasMany(l => l.DetallesCalificaciones)
                .WithOne(d => d.LibroDeCalificaciones)
                .HasForeignKey(d => d.LibroAlumnoId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DetalleCalificaciones>()
                .HasOne(d => d.LibroDeCalificaciones)
                .WithMany(l => l.DetallesCalificaciones)
                .HasForeignKey(d => d.LibroAlumnoId);

            modelBuilder.Entity<LibroDeAsistencias>()
                .HasMany(l => l.Asistencias)
                .WithOne(a => a.LibroDeAsistencias)
                .HasForeignKey(a => a.LibroAlumnoId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Asistencia>()
                .HasOne(a => a.Trimestre)
                .WithMany()
                .HasForeignKey(a => a.TrimestreId);

            modelBuilder.Entity<Alumno>()
                .HasOne(a => a.Grado)
                .WithMany()
                .HasForeignKey(a => a.GradoId)
                .OnDelete(DeleteBehavior.Restrict);            
        }
    }
}