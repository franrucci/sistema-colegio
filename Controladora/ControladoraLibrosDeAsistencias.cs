using Repositorios;
using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraLibrosDeAsistencias
    {
        private ControladoraLibrosDeAsistencias() { }
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

        public ReadOnlyCollection<LibroDeAsistencias> RecuperarLibrosDeAsistencias()
        {
            return RepositorioLibrosDeAsistencias.Instancia.ListarLibrosDeAsistencias();
        }


        // Sirve para recuperar un libro de asistencias de un alumno.
        public LibroDeAsistencias RecuperarLibroAlumno(Alumno alumno)
        {
            var listaDeAlumnos = RepositorioLibrosDeAsistencias.Instancia.ListarLibrosDeAsistencias();
            var libroAlumnoEncontrado = listaDeAlumnos.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);
            return libroAlumnoEncontrado;
        }


        // Es para crear los libros de asistencia de los alumnos.
        public void InicializarLibrosDeAsistencia()
        {
            var listaDeAlumnos = RepositorioAlumnos.Instancia.ListarAlumnos();

            foreach (Alumno alumno in listaDeAlumnos)
            {
                LibroDeAsistencias libroDeAsistencias = new LibroDeAsistencias();
                libroDeAsistencias.Alumno = alumno;

                RepositorioLibrosDeAsistencias.Instancia.AgregarNuevoLibro(libroDeAsistencias);
            }
        }

        public string AgregarNuevaAsistencia(Alumno alumno, Asistencia asistencia)
        {
            var listaLibrosAsistencia = RepositorioLibrosDeAsistencias.Instancia.ListarLibrosDeAsistencias();

            //Valido si existe el libro de asistencia para el alumno.
            var libroDeAsistenciaEncontrado = listaLibrosAsistencia.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);
            if (libroDeAsistenciaEncontrado != null)
            {
                //Valido que la misma asistencia no este ya cargada.
                var asistenciaEncontrada = libroDeAsistenciaEncontrado.ListarAsistencias().FirstOrDefault(x => x.Fecha.Date == asistencia.Fecha.Date);
                if (asistenciaEncontrada == null)
                {
                    int diasHabiles = asistencia.Trimestre.DiasTotalesHabiles; // Obtengo los dias habiles ya cargados en el trimestre.

                    // Obtengo la cantidad de asistencias ya registradas en el trimestre para luego comparar.
                    int diasAsistidosCargados = libroDeAsistenciaEncontrado.ListarAsistencias().Count(a => a.Trimestre.NumTrimestre == asistencia.Trimestre.NumTrimestre);
                    if (diasAsistidosCargados + 1 > diasHabiles)
                    {
                        return $"Error: Ya se llego al maximo de dias a cargar en el trimestre {asistencia.Trimestre.NumTrimestre}";
                    }
                    else
                    {
                        RepositorioLibrosDeAsistencias.Instancia.AgregarAsistencia(alumno, asistencia);
                        return "Asistencia agregada correctamente.";
                    }
                }
                else
                {
                    return "Error: La asistencia a ingresar ya se encuentra registrada.";
                }
            }
            else
            {
                return "Error: No se ha encontrado el libro de asistencias para el alumno.";
            }
        }

        public string ModificarAsistencia(Alumno alumno, Asistencia asistencia)
        {
            var listaLibrosAsistencia = RepositorioLibrosDeAsistencias.Instancia.ListarLibrosDeAsistencias();

            // Valido si existe el libro de asistencia para el alumno.
            var libroDeAsistenciaEncontrado = listaLibrosAsistencia.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);
            if (libroDeAsistenciaEncontrado != null)
            {
                // Verifico si la asistencia existe en el libro de asistencia encontrado.
                var asistenciaEncontrada = libroDeAsistenciaEncontrado.ListarAsistencias().FirstOrDefault(x => x.Fecha.Date == asistencia.Fecha.Date);

                if (asistenciaEncontrada != null)
                {
                    libroDeAsistenciaEncontrado.ModificarDetalleAsistencia(asistencia);
                    return "Asistencia modificada correctamente.";
                }
                else
                {
                    return "Error: La asistencia no fue encontrada.";
                }
            }
            else
            {
                return "Error: No se ha encontrado el libro de asistencias.";
            }
        }

        public string EliminarAsistencia(Alumno alumno, Asistencia asistencia)
        {
            var listaLibrosAsistencia = RepositorioLibrosDeAsistencias.Instancia.ListarLibrosDeAsistencias();

            //Valido si existe el libro de asistencia para el alumno.
            var libroDeAsistenciaEncontrado = listaLibrosAsistencia.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);
            if (libroDeAsistenciaEncontrado != null)
            {
                var asistenciaEncontrada = libroDeAsistenciaEncontrado.ListarAsistencias().FirstOrDefault(x => x.Fecha.Date == asistencia.Fecha.Date);
                if (asistenciaEncontrada != null)
                {
                    RepositorioLibrosDeAsistencias.Instancia.EliminarAsistencia(alumno, asistencia);
                    return "Asistencia eliminada correctamente.";
                }
                else
                {
                    return "Error: Asistencia no encontrada.";
                }
            }
            else
            {
                return "Error: No se ha encontrado el libro de asistencias.";
            }
        }

        public bool CalcularPorcentajeAsistencia(Alumno alumno, int numTrimestre)
        {
            var listaLibrosAsistencia = RepositorioLibrosDeAsistencias.Instancia.ListarLibrosDeAsistencias();

            // Busco el libro de asistencia para el alumno.
            var libroDeAsistenciaEncontrado = listaLibrosAsistencia.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);

            if (libroDeAsistenciaEncontrado != null)
            {
                // Busco la cantidad de días registrados para el alumno en el trimestre especificado.
                int diasRegistradosDeAlumno = RepositorioLibrosDeAsistencias.Instancia.ObtenerCantidadDeDiasCargados(alumno, numTrimestre);

                // Busco el trimestre con el mismo numero de trimestre.
                var trimestreEncontrado = RepositorioTrimestres.Instancia.ListarTrimestres().FirstOrDefault(x => x.NumTrimestre == numTrimestre);
                if (trimestreEncontrado != null)
                {
                    if (trimestreEncontrado.DiasTotalesHabiles == diasRegistradosDeAlumno)
                    {
                        libroDeAsistenciaEncontrado.CalcularPorcentajeAsistencia();
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
    }
}
