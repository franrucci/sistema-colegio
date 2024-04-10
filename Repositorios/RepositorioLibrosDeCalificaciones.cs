using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public class RepositorioLibrosDeCalificaciones
    {
        private static RepositorioLibrosDeCalificaciones instancia;
        private List<LibroDeCalificaciones> librosDeCalificaciones;

        public RepositorioLibrosDeCalificaciones()
        {
            librosDeCalificaciones = new List<LibroDeCalificaciones>();
        }

        public static RepositorioLibrosDeCalificaciones Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new RepositorioLibrosDeCalificaciones();
                }
                return instancia;
            }
        }

        public ReadOnlyCollection<LibroDeCalificaciones> ListarLibrosDeCalificaciones()
        {
            return librosDeCalificaciones.AsReadOnly();
        }


        //Agrega un libro nuevo de cada alumno a la lista de librosDeCalificaciones.
        public void AgregarNuevoLibro(LibroDeCalificaciones libro)
        {
            librosDeCalificaciones.Add(libro);
        }

        public void AgregarNota(Alumno alumno, DetalleCalificaciones detalle)
        {
            var libroAlumnoEncontrado = librosDeCalificaciones.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);
            libroAlumnoEncontrado.AgregarDetalleNotaExamen(detalle);
        }

        public void ModificarNota(Alumno alumno, DetalleCalificaciones detalle)
        {
            var libroAlumnoEncontrado = librosDeCalificaciones.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);
            libroAlumnoEncontrado.ModificarDetalle(detalle);
        }

        public void EliminarExamen(Alumno alumno, DetalleCalificaciones detalle)
        {
            var libroAlumnoEncontrado = librosDeCalificaciones.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);
            libroAlumnoEncontrado.EliminarDetalle(detalle);
        }

        //Obtiene el promedio anual.
        public decimal? ObtenerPromedioAnual(Alumno alumno)
        {
            var libroDeAlumnoEncontrado = librosDeCalificaciones.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);

            decimal sumaDePromedios = 0;
            if (libroDeAlumnoEncontrado.NotaTrimestre1 != default(decimal)) // Verifica si NotaTrimestre1 tiene un valor decimal diferente de 0.
            {
                sumaDePromedios += libroDeAlumnoEncontrado.NotaTrimestre1;

                if (libroDeAlumnoEncontrado.NotaTrimestre2 != default(decimal))
                {
                    sumaDePromedios += libroDeAlumnoEncontrado.NotaTrimestre2;

                    if (libroDeAlumnoEncontrado.NotaTrimestre3 != default(decimal))
                    {
                        sumaDePromedios += libroDeAlumnoEncontrado.NotaTrimestre3;

                        libroDeAlumnoEncontrado.NotaFinalAnual = sumaDePromedios / 3;
                        return libroDeAlumnoEncontrado.NotaFinalAnual;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }


        // Obtiene todas las notas finales de las materias en un trimestre especifico y obtiene el promedio en ese trimestre.
        public List<DetalleCalificaciones> ObtenerCalificacionesPorTrimestre(Alumno alumno, int numTrimestre)
        {
            var libroDeAlumnoEncontrado = librosDeCalificaciones.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);

            var listaDeDetalles = libroDeAlumnoEncontrado.ListarDetallesCalificaciones();

            // Filtro los detalles por el trimestre seleccionado.
            var detallesTrimestre = listaDeDetalles.Where(x => x.Examen.Trimestre.NumTrimestre == numTrimestre).ToList();

            // Verifico si hay detalles para todas las materias en el trimestre seleccionado.
            //Con All verifico si todas las materias del grado del alumno cumplen con la condicion de Any. Luego con Any verifico si la materia actual que itera tiene por lo menos un detalle de calificacion.
            var materiasConDetalles = libroDeAlumnoEncontrado.Alumno.Grado.ListarMaterias().All(materia => detallesTrimestre.Any(detalle => detalle.Materia.CodigoMateria == materia.CodigoMateria));

            if (materiasConDetalles == false) //Si no se encuentran detalles para todas las materias
            {
                return null;
            }
            else
            {
                // Filtro los detalles para obtener solo los exámenes de tipo parcial.
                var parcialesTrimestre = detallesTrimestre.Where(detalle => detalle.Examen.Tipo1 == Examen.Tipo.Parcial).ToList();

                // Filtro los detalles para obtener solo los exámenes de tipo recuperatorio.
                var recuperatoriosTrimestre = detallesTrimestre.Where(detalle => detalle.Examen.Tipo1 == Examen.Tipo.Recuperatorio).ToList();

                // Creo una lista para almacenar los detalles finales a mostrar.
                var detallesFinales = new List<DetalleCalificaciones>();

                decimal promedioNotas = 0; //Es para calcular el promedio de las notas.

                // Itero sobre las materias y determino la nota final de cada una en el trimestre.
                foreach (var materia in libroDeAlumnoEncontrado.Alumno.Grado.ListarMaterias())
                {
                    // Obtengo el detalle de examen parcial para la materia.
                    var detalleParcial = parcialesTrimestre.FirstOrDefault(detalle => detalle.Materia.CodigoMateria == materia.CodigoMateria);

                    // Obtengo el detalle de examen recuperatorio para la materia.
                    var detalleRecuperatorio = recuperatoriosTrimestre.FirstOrDefault(detalle => detalle.Materia.CodigoMateria == materia.CodigoMateria);

                    // Determino la nota final de la materia en el trimestre.
                    if (detalleRecuperatorio != null)
                    {
                        // Si hay examen recuperatorio, la nota final es la del recuperatorio.
                        detallesFinales.Add(detalleRecuperatorio);
                        promedioNotas += detalleRecuperatorio.Nota;
                    }
                    else if (detalleParcial != null)
                    {
                        // Si hay examen parcial, la nota final es la del parcial.
                        detallesFinales.Add(detalleParcial);
                        promedioNotas += detalleParcial.Nota;
                    }
                }

                // Calculo el promedio de las notas.
                if (detallesFinales.Count > 0)
                {
                    promedioNotas /= alumno.Grado.CantidadMaterias;
                }

                // Asigno el promedio de notas al libro de calificaciones según el trimestre.
                switch (numTrimestre)
                {
                    case 1:
                        libroDeAlumnoEncontrado.NotaTrimestre1 = promedioNotas;
                        break;
                    case 2:
                        libroDeAlumnoEncontrado.NotaTrimestre2 = promedioNotas;
                        break;
                    case 3:
                        libroDeAlumnoEncontrado.NotaTrimestre3 = promedioNotas;
                        break;
                }

                // Retorno la lista de detalles finales.
                return detallesFinales;
            }
        }

        public List<Materia> ObtenerMateriasAdeudadas(Alumno alumno)
        {
            List<Materia> materiasAdeudadas = new List<Materia>();

            var libroDeCalificacionesEncontrado = librosDeCalificaciones.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);

            var trimestresConExamen = new List<int> { 1, 2, 3 };

            foreach (var materia in libroDeCalificacionesEncontrado.Alumno.Grado.ListarMaterias())
            {
                var sumaNotas = 0m;
                var cantidadExamenes = 0;

                // Obtengo los detalles de calificaciones para esta materia.
                var detallesMateria = libroDeCalificacionesEncontrado.ListarDetallesCalificaciones().Where(detalle => detalle.Materia.CodigoMateria == materia.CodigoMateria);

                // Calculo la suma de notas y la cantidad de exámenes por trimestre.
                foreach (var trimestre in trimestresConExamen)
                {
                    var examenesTrimestre = detallesMateria.Where(detalle => detalle.Examen.Trimestre.NumTrimestre == trimestre);

                    foreach (var examen in examenesTrimestre)
                    {
                        sumaNotas += examen.Nota;
                        cantidadExamenes++;
                    }
                }

                // Calculo el promedio anual.
                var promedioAnual = cantidadExamenes > 0 ? sumaNotas / cantidadExamenes : 0;

                // Si el promedio anual es menor a 6, agrego la materia a la lista de materias adeudadas.
                if (promedioAnual < 6)
                {
                    materiasAdeudadas.Add(materia);
                }
            }
            return materiasAdeudadas;
        }

        public decimal ObtenerPromedioPorTrimestre(Alumno alumno, int trimestre)
        {
            var libroDeAlumnoEncontrado = librosDeCalificaciones.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);

            decimal promedioTrimestre = 0;

            switch (trimestre)
            {
                case 1:
                    promedioTrimestre = libroDeAlumnoEncontrado.NotaTrimestre1;
                    break;
                case 2:
                    promedioTrimestre = libroDeAlumnoEncontrado.NotaTrimestre2;
                    break;
                case 3:
                    promedioTrimestre = libroDeAlumnoEncontrado.NotaTrimestre3;
                    break;
            }
            return promedioTrimestre;
        }


        // Sirve para saber si algun examen ya fue cargado con un trimestre existente.
        public bool BuscarExamenEnTrimestre(int numTrimestre)
        {
            foreach (var libroDeCalificaciones in librosDeCalificaciones)
            {
                bool examenEncontrado = libroDeCalificaciones.BuscarExamenEnTrimestre(numTrimestre);
                if (examenEncontrado == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
