using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraLibrosDeAsistencias
    {
        public Context context;
        private static ControladoraLibrosDeAsistencias instancia;

        public static ControladoraLibrosDeAsistencias Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraLibrosDeAsistencias();
                }
                return instancia;
            }
        }

        public ControladoraLibrosDeAsistencias()
        {
            context = new Context();
        }

        public LibroDeAsistencias RecuperarLibroAlumno(Alumno alumno)
        {
            // Busco el libro de asistencias para el alumno.
            var libroDeAsistenciasEncontrado = context.LibrosDeAsistencias
                .Include(l => l.Asistencias)
                .FirstOrDefault(l => l.AlumnoId == alumno.AlumnoId);
            return libroDeAsistenciasEncontrado;
        }

        public List<Asistencia> ListarAsistencias(Alumno alumno)
        {
            var libroDeAsistencias = context.LibrosDeAsistencias
                .FirstOrDefault(l => l.AlumnoId == alumno.AlumnoId);

            if (libroDeAsistencias == null)
            {
                throw new Exception("No se encontró el libro de asistencias para el alumno.");
            }

            // Cargo la lista de asistencias.
            context.Entry(libroDeAsistencias)
                .Collection(l => l.Asistencias)
                .Query()
                .Include(a => a.Trimestre)
                .Load();

            return libroDeAsistencias.Asistencias.ToList();
        }

        public string AgregarNuevaAsistencia(Alumno alumno, Asistencia asistencia)
        {
            try
            {
                //Busca el libro de asistencias del alumno.
                var libroDeAsistencias = context.LibrosDeAsistencias
                    .Include(l => l.Asistencias)
                    .FirstOrDefault(l => l.AlumnoId == alumno.AlumnoId);

                if (libroDeAsistencias == null)
                {
                    return "Error: No se encontró el libro de asistencias del alumno.";
                }

                // Busca el trimestre.
                var trimestreExistente = context.Trimestres
                    .FirstOrDefault(t => t.TrimestreId == asistencia.Trimestre.TrimestreId);

                if (trimestreExistente == null)
                {
                    return "Error: El trimestre no se encontró en la base de datos.";
                }

                // Verifica si la asistencia ya existe.
                var asistenciaExistente = libroDeAsistencias.Asistencias
                    .FirstOrDefault(a => a.Fecha.Date == asistencia.Fecha.Date);

                if (asistenciaExistente != null)
                {
                    return "Error: La asistencia ya está registrada.";
                }

                // Verifica el límite de días para el trimestre.
                int diasHabiles = trimestreExistente.DiasTotalesHabiles;
                int diasAsistidosCargados = libroDeAsistencias.Asistencias
                    .Count(a => a.Trimestre.NumTrimestre == asistencia.Trimestre.NumTrimestre);

                if (diasAsistidosCargados + 1 > diasHabiles)
                {
                    return $"Error: Ya se alcanzó el máximo de días a cargar en el trimestre {asistencia.Trimestre.NumTrimestre}.";
                }

                // Asigna el trimestre al objeto asistencia.
                asistencia.Trimestre = trimestreExistente;

                // Agrega la nueva asistencia
                libroDeAsistencias.Asistencias.Add(asistencia);
                context.SaveChanges();

                return "Asistencia agregada correctamente.";
            }
            catch (Exception ex)
            {
                return $"Ocurrió un error: {ex.Message}";
            }
        }

        public string ModificarAsistencia(Alumno alumno, Asistencia asistencia)
        {
            try
            {
                // Recupera el libro de asistencias del alumno.
                var libroDeAsistencias = context.LibrosDeAsistencias
                    .Include(l => l.Asistencias)
                    .ThenInclude(a => a.Trimestre)
                    .FirstOrDefault(l => l.AlumnoId == alumno.AlumnoId);

                if (libroDeAsistencias == null)
                {
                    return "Error: No se encontró el libro de asistencias del alumno.";
                }

                // Busca la asistencia a modificar.
                var asistenciaEncontrada = libroDeAsistencias.Asistencias
                    .FirstOrDefault(a => a.Fecha.Date == asistencia.Fecha.Date);

                if (asistenciaEncontrada == null)
                {
                    return "Error: La asistencia no fue encontrada.";
                }

                // Modifica el tipo de asistencia.
                asistenciaEncontrada.Tipo1 = asistencia.Tipo1;

                context.SaveChanges();
                return "Asistencia modificada correctamente.";
            }
            catch (Exception ex)
            {
                return $"Ocurrió un error desconocido.";
            }
        }


        public string EliminarAsistencia(Alumno alumno, Asistencia asistencia)
        {
            try
            {
                //Busca el libro de asistencias del alumno.
                var libroDeAsistencias = context.LibrosDeAsistencias
                    .Include(l => l.Asistencias)
                    .ThenInclude(a => a.Trimestre)
                    .FirstOrDefault(l => l.AlumnoId == alumno.AlumnoId);

                if (libroDeAsistencias == null)
                {
                    return $"Error: No se encontró el libro de asistencias del alumno.";
                }

                // Busca la asistencia a eliminar en el libro de asistencias.
                var asistenciaEncontrada = libroDeAsistencias.Asistencias
                    .FirstOrDefault(a => a.Fecha.Date == asistencia.Fecha.Date);

                if (asistenciaEncontrada == null)
                {
                    return $"Error: No se encontró la asistencia para la fecha {asistencia.Fecha.ToShortDateString()}.";
                }

                // Verifica si existen asistencias posteriores en el mismo trimestre.
                var trimestreActual = asistenciaEncontrada.Trimestre;
                var asistenciaPosterior = libroDeAsistencias.Asistencias
                    .Any(a => a.Trimestre.TrimestreId == trimestreActual.TrimestreId && a.Fecha.Date > asistencia.Fecha.Date);

                if (asistenciaPosterior)
                {
                    return $"Error: No se puede eliminar la asistencia del {asistencia.Fecha.ToShortDateString()} porque existen asistencias posteriores en el trimestre.";
                }

                // Elimina la asistencia encontrada.
                context.Asistencias.Remove(asistenciaEncontrada);

                context.SaveChanges();
                return "Asistencia eliminada correctamente.";
            }
            catch (Exception ex)
            {
                return $"Ocurrio un error desconocido.";
            }
        }

        public bool CalcularPorcentajeAsistencia(Alumno alumno, int numTrimestre)
        {
            try
            {
                // Busco el libro de asistencias del alumno.
                var libroDeAsistenciasEncontrado = context.LibrosDeAsistencias
                    .Include(l => l.Asistencias)
                    .FirstOrDefault(l => l.AlumnoId == alumno.AlumnoId);

                if (libroDeAsistenciasEncontrado != null)
                {
                    // Busco la cantidad de días registrados para el alumno en el trimestre especificado.
                    int diasRegistradosDeAlumno = ObtenerCantidadDeDiasCargados(alumno, numTrimestre);

                    // Busco el trimestre con el mismo numero de trimestre.
                    var trimestreEncontrado = context.Trimestres.FirstOrDefault(x => x.NumTrimestre == numTrimestre);
                    if (trimestreEncontrado != null)
                    {
                        if (trimestreEncontrado.DiasTotalesHabiles == diasRegistradosDeAlumno)
                        {
                            CalcularPorcentajesAsistencias(alumno);
                            return true; // Si son iguales, se pudo calcular el porcentaje de asistencia.
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Obtengo la cantidad de asistencias registradas que tiene un alumno.
        public int ObtenerCantidadDeDiasCargados(Alumno alumno, int trimestre)
        {
            try
            {
                // Busco el libro de asistencias del alumno.
                var libroDeAsistenciasEncontrado = context.LibrosDeAsistencias
                    .Include(l => l.Asistencias)
                    .ThenInclude(a => a.Trimestre)
                    .FirstOrDefault(l => l.AlumnoId == alumno.AlumnoId);

                if (libroDeAsistenciasEncontrado == null)
                {
                    return 0; // Si no se encuentra el libro de asistencias, devuelve 0.
                }

                // Suma la cantidad de asistencias registradas para el trimestre especificado.
                int cantidadAsistencias = 0;
                foreach (var asistencia in libroDeAsistenciasEncontrado.Asistencias)
                {
                    if (asistencia.Trimestre != null && asistencia.Trimestre.NumTrimestre == trimestre)
                    {
                        cantidadAsistencias++;
                    }
                }
                return cantidadAsistencias;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void CalcularPorcentajesAsistencias(Alumno alumno)
        {
            try
            {
                var libroDeAsistencias = RecuperarLibroAlumno(alumno);


                decimal diasAsistidosCargadosTrimestre1 = 0;
                decimal diasAsistidosCargadosTrimestre2 = 0;
                decimal diasAsistidosCargadosTrimestre3 = 0;

                foreach (Asistencia asistencia in libroDeAsistencias.Asistencias)
                {
                    if (asistencia.Tipo1 == Asistencia.Tipo.Presente || asistencia.Tipo1 == Asistencia.Tipo.FaltaJustificada)
                    {
                        if (asistencia.Trimestre.NumTrimestre == 1)
                        {
                            diasAsistidosCargadosTrimestre1 += 1;
                        }
                        else if (asistencia.Trimestre.NumTrimestre == 2)
                        {
                            diasAsistidosCargadosTrimestre2 += 1;
                        }
                        else if (asistencia.Trimestre.NumTrimestre == 3)
                        {
                            diasAsistidosCargadosTrimestre3 += 1;
                        }
                    }
                    else if (asistencia.Tipo1 == Asistencia.Tipo.Retiro)
                    {
                        if (asistencia.Trimestre.NumTrimestre == 1)
                        {
                            diasAsistidosCargadosTrimestre1 += 0.5m;
                        }
                        else if (asistencia.Trimestre.NumTrimestre == 2)
                        {
                            diasAsistidosCargadosTrimestre2 += 0.5m;
                        }
                        else if (asistencia.Trimestre.NumTrimestre == 3)
                        {
                            diasAsistidosCargadosTrimestre3 += 0.5m;
                        }
                    }
                }

                var trimestre1 = libroDeAsistencias.Asistencias.FirstOrDefault(x => x.Trimestre.NumTrimestre == 1);
                if (trimestre1 != null)
                {
                    libroDeAsistencias.PorcentajeAsistenciaTrimestre1 = (decimal)diasAsistidosCargadosTrimestre1 / trimestre1.Trimestre.DiasTotalesHabiles * 100;
                }

                var trimestre2 = libroDeAsistencias.Asistencias.FirstOrDefault(x => x.Trimestre.NumTrimestre == 2);
                if (trimestre2 != null)
                {
                    libroDeAsistencias.PorcentajeAsistenciaTrimestre2 = (decimal)diasAsistidosCargadosTrimestre2 / trimestre2.Trimestre.DiasTotalesHabiles * 100;
                }

                var trimestre3 = libroDeAsistencias.Asistencias.FirstOrDefault(x => x.Trimestre.NumTrimestre == 3);
                if (trimestre3 != null)
                {
                    libroDeAsistencias.PorcentajeAsistenciaTrimestre3 = (decimal)diasAsistidosCargadosTrimestre3 / trimestre3.Trimestre.DiasTotalesHabiles * 100;
                }

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}