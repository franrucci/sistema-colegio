using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraAlumnos
    {
        private Context context;
        private static ControladoraAlumnos instancia;

        public static ControladoraAlumnos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraAlumnos();
                }
                return instancia;
            }
        }

        ControladoraAlumnos()
        {
            context = new Context();
        }

        public ReadOnlyCollection<Alumno> ListarAlumnos()
        {
            try
            {
                return context.Alumnos.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
        // Retorna las materias del grado al que cursa un alumno determinado.
        public ReadOnlyCollection<Materia> RetornarMateriasDeGradoDeAlumno(Alumno alumno)
        {
            try
            {
                var alumnoEncontrado = context.Alumnos.FirstOrDefault(x => x.Dni == alumno.Dni);
                var listaDeMaterias = ControladoraMaterias.Instancia.ListarMateriasDeGrado(alumno.GradoId);
                return listaDeMaterias.AsReadOnly();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
        // Metodo para obtener alumno con su grado.
        public Alumno ObtenerAlumno(int alumnoId)
        {
            try
            {
                return context.Alumnos.Include(a => a.Grado).FirstOrDefault(a => a.AlumnoId == alumnoId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool AsignarEstado(Alumno alumno)
        {
            try
            {
                // Busca el libro de calificaciones del alumno.
                var libroDeAlumnoEncontrado = context.LibrosDeCalificaciones
                    .Include(l => l.Alumno)
                    .FirstOrDefault(x => x.Alumno.AlumnoId == alumno.AlumnoId);

                if (libroDeAlumnoEncontrado == null)
                {
                    return false;
                }

                if (libroDeAlumnoEncontrado.NotaFinalAnual == default(decimal))
                {
                    return false;
                }

                // Verifico si los días registrados en los trimestres coinciden con los días totales habiles.
                bool todosTrimestresCompleto = true;
                for (int trimestreNum = 1; trimestreNum <= 3; trimestreNum++)
                {
                    int diasRegistradosDeAlumno = ControladoraLibrosDeAsistencias.Instancia.ObtenerCantidadDeDiasCargados(alumno, trimestreNum);
                    var trimestre = context.Trimestres.FirstOrDefault(x => x.NumTrimestre == trimestreNum);
                    if (trimestre == null || trimestre.DiasTotalesHabiles != diasRegistradosDeAlumno)
                    {
                        todosTrimestresCompleto = false;
                        break;
                    }
                }

                if (!todosTrimestresCompleto)
                {
                    return false;
                }

                // Calcula el porcentaje de asistencia anual.
                var libroDeAsistenciasAlumno = ControladoraLibrosDeAsistencias.Instancia.RecuperarLibroAlumno(alumno);

                if (libroDeAsistenciasAlumno == null)
                {
                    return false;
                }

                decimal porcentajeAsistenciaAnual = (libroDeAsistenciasAlumno.PorcentajeAsistenciaTrimestre1
                                                     + libroDeAsistenciasAlumno.PorcentajeAsistenciaTrimestre2
                                                     + libroDeAsistenciasAlumno.PorcentajeAsistenciaTrimestre3) / 3;

                // Obtiene las materias adeudadas.
                var materiasAdeudadas = ObtenerMateriasAdeudadas(alumno);

                // Asigna el estado al alumno.
                return AsignarEstado(alumno, libroDeAlumnoEncontrado.NotaFinalAnual, porcentajeAsistenciaAnual, materiasAdeudadas);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private bool AsignarEstado(Alumno alumno, decimal notaFinalAnual, decimal porcentajeAsistenciaAnual, List<Materia> materiasAdeudadas)
        {
            try
            {
                // Busca el alumno.
                var alumnoEncontrado = context.Alumnos.FirstOrDefault(x => x.AlumnoId == alumno.AlumnoId);
                if (alumnoEncontrado != null)
                {
                    if (porcentajeAsistenciaAnual >= 70 && materiasAdeudadas.Count == 0)
                    {
                        alumnoEncontrado.Estado = Alumno.EstadoEnum.Promovido;
                        context.SaveChanges();
                        return true;
                    }
                    else if (porcentajeAsistenciaAnual >= 70 && materiasAdeudadas.Count >= 1)
                    {
                        alumnoEncontrado.Estado = Alumno.EstadoEnum.MesDeRecuperacion;
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        alumnoEncontrado.Estado = Alumno.EstadoEnum.Reprobado;
                        context.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Materia> ObtenerMateriasAdeudadas(Alumno alumno)
        {
            try
            {
                var materiasAdeudadas = new List<Materia>();

                var libroDeCalificaciones = ControladoraLibrosDeCalificaciones.Instancia.RecuperarLibroAlumno(alumno);

                if (libroDeCalificaciones == null)
                {
                    return materiasAdeudadas;
                }

                // Obtengo todos los trimestres disponibles.
                var trimestresConExamen = context.Trimestres
                    .Select(t => t.NumTrimestre)
                    .ToList();

                var listaDeMaterias = ControladoraMaterias.Instancia.ListarMateriasDeGrado(alumno.GradoId);

                foreach (var materia in listaDeMaterias)
                {
                    var sumaNotas = 0m;
                    var cantidadExamenes = 0;

                    // Filtro los detalles de calificaciones para la materia específica.
                    var detallesMateria = libroDeCalificaciones.DetallesCalificaciones
                        .Where(detalle => detalle.Materia != null && detalle.Materia.MateriaId == materia.MateriaId)
                        .ToList();

                    foreach (var trimestre in trimestresConExamen)
                    {
                        var examenesTrimestre = detallesMateria
                            .Where(detalle => detalle.Examen != null && detalle.Examen.Trimestre != null && detalle.Examen.Trimestre.NumTrimestre == trimestre)
                            .ToList();

                        foreach (var examen in examenesTrimestre)
                        {
                            sumaNotas += examen.Nota;
                            cantidadExamenes++;
                        }
                    }

                    var promedioAnual = cantidadExamenes > 0 ? sumaNotas / cantidadExamenes : 0;

                    if (promedioAnual < 6)
                    {
                        materiasAdeudadas.Add(materia);
                    }
                }

                return materiasAdeudadas;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

}