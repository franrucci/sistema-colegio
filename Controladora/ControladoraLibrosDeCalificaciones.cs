using Entidades;
using Repositorios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraLibrosDeCalificaciones
    {
        private ControladoraLibrosDeCalificaciones() { }
        private static ControladoraLibrosDeCalificaciones instancia;

        public static ControladoraLibrosDeCalificaciones Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraLibrosDeCalificaciones();
                }
                return instancia;
            }
        }

        public ReadOnlyCollection<LibroDeCalificaciones> RecuperarLibrosDeCalificaciones()
        {
            return RepositorioLibrosDeCalificaciones.Instancia.ListarLibrosDeCalificaciones();
        }


        // Sirve para obtener el libro de calificaciones de un alumno en particular.
        public LibroDeCalificaciones RecuperarAlumno(Alumno alumno)
        {
            var listaDeAlumnos = RepositorioLibrosDeCalificaciones.Instancia.ListarLibrosDeCalificaciones();
            var libroAlumnoEncontrado = listaDeAlumnos.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);
            return libroAlumnoEncontrado;
        }


        // Es para crear los libros de calificaciones de los alumnos.
        public void InicializarLibrosDeCalificacion()
        {
            var listaDeAlumnos = RepositorioAlumnos.Instancia.ListarAlumnos();

            foreach (Alumno alumno in listaDeAlumnos)
            {
                LibroDeCalificaciones libroDeCalificaciones = new LibroDeCalificaciones();
                libroDeCalificaciones.Alumno = alumno;

                RepositorioLibrosDeCalificaciones.Instancia.AgregarNuevoLibro(libroDeCalificaciones);
            }
        }

        public string CargarNotaDeExamen(Alumno alumno, DetalleCalificaciones detalle)
        {
            if (detalle.Nota < 1 || detalle.Nota > 10)
            {
                return "Error: La nota ingresada no es válida.";
            }

            var listaDeLibrosCalificaciones = RepositorioLibrosDeCalificaciones.Instancia.ListarLibrosDeCalificaciones();
            var libroDeAlumnoEncontrado = listaDeLibrosCalificaciones.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);

            if (libroDeAlumnoEncontrado == null)
            {
                return "Error: No se encontró el libro de calificaciones del alumno.";
            }

            // Valido si la materia seleccionada pertenece al grado del alumno.
            var materiaEncontradaValida = libroDeAlumnoEncontrado.Alumno.Grado.ListarMaterias().FirstOrDefault(x => x.CodigoMateria == detalle.Materia.CodigoMateria);
            if (materiaEncontradaValida == null)
            {
                return "Error: La materia ingresada no es válida para el alumno.";
            }

            // Verifico si ya existe un examen de ese tipo para esa materia en ese trimestre.
            var examenExistente = libroDeAlumnoEncontrado.ListarDetallesCalificaciones().FirstOrDefault(x => x.Examen.Tipo1 == detalle.Examen.Tipo1 && x.Materia.CodigoMateria == detalle.Materia.CodigoMateria && x.Examen.Trimestre.NumTrimestre == detalle.Examen.Trimestre.NumTrimestre);

            if (examenExistente != null)
            {
                return $"Error: Ya existe un examen {detalle.Examen.Tipo1} de la materia {detalle.Materia.NombreMateria} en el trimestre {detalle.Examen.Trimestre.NumTrimestre}.";
            }

            switch (detalle.Examen.Tipo1)
            {
                case Examen.Tipo.Parcial:
                    if (detalle.Examen.Trimestre.NumTrimestre > 1)
                    {
                        var trimestreAnterior = detalle.Examen.Trimestre.NumTrimestre - 1;
                        var examenParcialTrimestreAnterior = libroDeAlumnoEncontrado.ListarDetallesCalificaciones().FirstOrDefault(x => x.Examen.Tipo1 == Examen.Tipo.Parcial && x.Materia.CodigoMateria == detalle.Materia.CodigoMateria && x.Examen.Trimestre.NumTrimestre == trimestreAnterior);

                        if (trimestreAnterior > 0 && examenParcialTrimestreAnterior == null)
                        {
                            return $"Error: No se puede cargar un examen del trimestre {detalle.Examen.Trimestre.NumTrimestre} sin haber cargado un examen parcial en el trimestre {trimestreAnterior} para la misma materia.";
                        }
                    }
                    break;

                case Examen.Tipo.Recuperatorio:
                    var examenParcial = libroDeAlumnoEncontrado.ListarDetallesCalificaciones().FirstOrDefault(x => x.Examen.Tipo1 == Examen.Tipo.Parcial && x.Materia.CodigoMateria == detalle.Materia.CodigoMateria && x.Examen.Trimestre.NumTrimestre == detalle.Examen.Trimestre.NumTrimestre);

                    if (examenParcial == null)
                    {
                        return $"Error: No se puede cargar un examen recuperatorio sin haber cargado un examen parcial previo en el mismo trimestre y para la misma materia.";
                    }
                    break;
            }

            var materiaConCodigoExistente = libroDeAlumnoEncontrado.ListarDetallesCalificaciones().FirstOrDefault(x => x.CodDetalle.ToLower() == detalle.CodDetalle.ToLower());
            if (materiaConCodigoExistente == null)
            {
                // Agrego la nota del examen.
                RepositorioLibrosDeCalificaciones.Instancia.AgregarNota(alumno, detalle);
                return "Nota cargada correctamente.";
            }
            else
            {
                return "Error: El codigo a ingresar ya existe en otro examen.";
            }
        }


        // Sirve para modificar la nota de un examen (SOLO LA NOTA).
        public string ModificarNotaDeExamen(Alumno alumno, DetalleCalificaciones detalle)
        {
            if (detalle.Nota < 1 || detalle.Nota > 10)
            {
                return "Error: La nota ingresada no es valida.";
            }
            else
            {
                var listaDeLibrosCalificaciones = RepositorioLibrosDeCalificaciones.Instancia.ListarLibrosDeCalificaciones();

                //Busco si existe el libro del alumno.
                var libroDeAlumnoEncontrado = listaDeLibrosCalificaciones.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);
                if (libroDeAlumnoEncontrado != null)
                {
                    var detalleEncontrado = libroDeAlumnoEncontrado.ListarDetallesCalificaciones().FirstOrDefault(x => (x.CodDetalle == detalle.CodDetalle));
                    if (detalleEncontrado != null)
                    {
                        RepositorioLibrosDeCalificaciones.Instancia.ModificarNota(alumno, detalle);
                        return "Nota modificada correctamente";
                    }
                    else
                    {
                        return "Error: No se ha encontrado el examen.";
                    }
                }
                else
                {
                    return "Error: No se ha encontrado el libro de calificaciones del alumno.";
                }
            }
        }

        public string EliminarExamen(Alumno alumno, DetalleCalificaciones detalle)
        {
            var listaDeLibrosCalificaciones = RepositorioLibrosDeCalificaciones.Instancia.ListarLibrosDeCalificaciones();

            // Busco si existe el libro del alumno.
            var libroDeAlumnoEncontrado = listaDeLibrosCalificaciones.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);

            if (libroDeAlumnoEncontrado != null)
            {
                var listaDeDetalles = libroDeAlumnoEncontrado.ListarDetallesCalificaciones();
                var detalleEncontrado = listaDeDetalles.FirstOrDefault(x => x.CodDetalle == detalle.CodDetalle); // Busco el detalle (examen).
                if (detalleEncontrado != null)
                {
                    // Verifico si es un examen parcial o recuperatorio.
                    switch (detalleEncontrado.Examen.Tipo1)
                    {
                        case Examen.Tipo.Parcial:
                            // Verifico si hay un examen recuperatorio en el mismo trimestre y para la misma materia.
                            var examenRecuperatorio = listaDeDetalles.FirstOrDefault(x => x.Examen.Tipo1 == Examen.Tipo.Recuperatorio && x.Materia.CodigoMateria == detalleEncontrado.Materia.CodigoMateria && x.Examen.Trimestre.NumTrimestre == detalleEncontrado.Examen.Trimestre.NumTrimestre);
                            if (examenRecuperatorio != null)
                            {
                                return "Error: No se puede eliminar un examen parcial si hay un examen recuperatorio en el mismo trimestre y para la misma materia.";
                            }
                            break;

                        case Examen.Tipo.Recuperatorio:
                            if (detalleEncontrado.Examen.Trimestre.NumTrimestre == 3)
                            {
                                RepositorioLibrosDeCalificaciones.Instancia.EliminarExamen(alumno, detalle);
                                return "Examen eliminado correctamente.";
                            }
                            else
                            {
                                // Verifico si hay exámenes en el trimestre posterior.
                                var examenTrimestrePosterior = listaDeDetalles.FirstOrDefault(x => x.Examen.Trimestre.NumTrimestre == detalleEncontrado.Examen.Trimestre.NumTrimestre + 1);
                                if (examenTrimestrePosterior != null)
                                {
                                    return "Error: No se puede eliminar un examen recuperatorio si hay exámenes en el trimestre posterior.";
                                }
                            }
                            break;
                    }

                    // Verifico si hay exámenes en el trimestre posterior.
                    var examenesTrimestrePosterior = listaDeDetalles.Any(x => x.Examen.Trimestre.NumTrimestre == detalleEncontrado.Examen.Trimestre.NumTrimestre + 1);
                    if (examenesTrimestrePosterior == true)
                    {
                        return "Error: No se puede eliminar un examen si hay exámenes en el trimestre posterior.";
                    }

                    // Si no se cumple ninguna condicion se elimina el examen.
                    RepositorioLibrosDeCalificaciones.Instancia.EliminarExamen(alumno, detalle);
                    return "Examen eliminado correctamente.";
                }
                else
                {
                    return "Error: No se ha encontrado el examen.";
                }
            }
            else
            {
                return "Error: No se ha encontrado el libro de calificaciones del alumno.";
            }
        }


        // Obtiene todas las notas finales de las materias en un trimestre especifico y calcula el promedio en ese trimestre.
        public List<DetalleCalificaciones> MostrarCalificacionesPorTrimestre(Alumno alumno, int numTrimestre)
        {
            var listaDeLibrosCalificaciones = RepositorioLibrosDeCalificaciones.Instancia.ListarLibrosDeCalificaciones();

            // Busco el libro de calificaciones del alumno.
            var libroDeAlumnoEncontrado = listaDeLibrosCalificaciones.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);

            if (libroDeAlumnoEncontrado == null)
            {
                return null;
            }
            else
            {
                var calificaciones = RepositorioLibrosDeCalificaciones.Instancia.ObtenerCalificacionesPorTrimestre(alumno, numTrimestre);
                if (calificaciones != null)
                {
                    return calificaciones;
                }
                else
                {
                    return null;
                }
            }
        }


        // Es para buscar el promedio de un trimestre especifico.
        public decimal ObtenerPromedioTrimestre(Alumno alumno, int trimestre)
        {
            var listaDeLibrosCalificaciones = RepositorioLibrosDeCalificaciones.Instancia.ListarLibrosDeCalificaciones();

            // Busco el libro de calificaciones del alumno.
            var libroDeAlumnoEncontrado = listaDeLibrosCalificaciones.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);

            if (libroDeAlumnoEncontrado == null)
            {
                // Si no se encuentra el libro de calificaciones devuelve 0.
                return 0;
            }
            else
            {
                decimal promedio = RepositorioLibrosDeCalificaciones.Instancia.ObtenerPromedioPorTrimestre(alumno, trimestre);
                return promedio;
            }

        }


        // Obtiene el promedio anual.
        public decimal ObtenerPromedioAnual(Alumno alumno)
        {
            var listaDeLibrosCalificaciones = RepositorioLibrosDeCalificaciones.Instancia.ListarLibrosDeCalificaciones();

            // Busco el libro de calificaciones del alumno.
            var libroDeAlumnoEncontrado = listaDeLibrosCalificaciones.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);

            if (libroDeAlumnoEncontrado == null)
            {
                // Si no se encuentra el libro de calificaciones devuelve 0.
                return 0;
            }
            else
            {
                var promedioAnual = RepositorioLibrosDeCalificaciones.Instancia.ObtenerPromedioAnual(alumno);
                if (promedioAnual != null)
                {
                    return promedioAnual.Value;
                }
                else
                {
                    return 0;
                }
            }
        }


        // Sirve para devolver las materias adeudadas.
        public dynamic DevolverMateriasAdeudadas(Alumno alumno)
        {
            // Busco el libro de calificaciones del alumno.
            var libroDeCalificaciones = RecuperarAlumno(alumno);

            // Verifico si el libro de calificaciones está.
            if (libroDeCalificaciones == null)
            {
                return 0; // Con 0 significa que no tengo el libro de calificaciones.
            }
            else
            {
                // Verifico si se cargaron los exámenes en los tres trimestres para todas las materias.
                var trimestresConExamen = new List<int> { 1, 2, 3 };
                var materiasConExamenEnTodosLosTrimestres = libroDeCalificaciones.Alumno.Grado.ListarMaterias().All(materia => trimestresConExamen.All(trimestre => libroDeCalificaciones.ListarDetallesCalificaciones().Any(detalle => detalle.Materia.CodigoMateria == materia.CodigoMateria && detalle.Examen.Trimestre.NumTrimestre == trimestre)));

                if (!materiasConExamenEnTodosLosTrimestres)
                {
                    return 1; // Con 1 significa que faltan cargar exámenes.
                }
                else
                {
                    var materiasAdeudadas = RepositorioLibrosDeCalificaciones.Instancia.ObtenerMateriasAdeudadas(alumno);

                    // Verifico si hay materias adeudadas.
                    if (materiasAdeudadas.Count == 0)
                    {
                        return 2; // Con 2 no hay materias adeudadas.
                    }
                    else
                    {
                        return materiasAdeudadas; // Devuelvo la lista de materias adeudadas.
                    }
                }
            }
        }
    }
}
