using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public class RepositorioLibrosDeAsistencias
    {
        private static RepositorioLibrosDeAsistencias instancia;
        private List<LibroDeAsistencias> librosDeAsistencias;

        public RepositorioLibrosDeAsistencias()
        {
            librosDeAsistencias = new List<LibroDeAsistencias>();
        }

        public static RepositorioLibrosDeAsistencias Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new RepositorioLibrosDeAsistencias();
                }
                return instancia;
            }
        }

        public ReadOnlyCollection<LibroDeAsistencias> ListarLibrosDeAsistencias()
        {
            return librosDeAsistencias.AsReadOnly();
        }

        public void AgregarNuevoLibro(LibroDeAsistencias libro)
        {
            librosDeAsistencias.Add(libro);
        }

        public void AgregarAsistencia(Alumno alumno, Asistencia asistencia)
        {
            var libroDeAsistenciaEncontrado = librosDeAsistencias.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);
            libroDeAsistenciaEncontrado.AgregarDetalleAsistencia(asistencia);
        }

        public void ModificarAsistencia(Alumno alumno, Asistencia asistencia)
        {
            var libroDeAsistenciaEncontrado = librosDeAsistencias.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);
            libroDeAsistenciaEncontrado.ModificarDetalleAsistencia(asistencia);
        }

        public void EliminarAsistencia(Alumno alumno, Asistencia asistencia)
        {
            var libroDeAsistenciaEncontrado = librosDeAsistencias.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);
            libroDeAsistenciaEncontrado.EliminarAsistencia(asistencia);
        }


        // Obtengo la cantidad de asistencias registradas que tiene un alumno.
        public int ObtenerCantidadDeDiasCargados(Alumno alumno, int trimestre)
        {
            // Busca el libro de asistencia para el alumno.
            var libroDeAsistenciaEncontrado = librosDeAsistencias.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);

            // Suma la cantidad de asistencias registradas para el trimestre especificado.
            int cantidadAsistencias = 0;
            foreach (var asistencia in libroDeAsistenciaEncontrado.Asistencias)
            {
                if (asistencia.Trimestre.NumTrimestre == trimestre)
                {
                    cantidadAsistencias++;
                }
            }
            return cantidadAsistencias;
        }
    }
}
