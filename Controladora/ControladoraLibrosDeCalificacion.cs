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
    public class ControladoraLibrosDeCalificaciones
    {
        private Context context;
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

        public ControladoraLibrosDeCalificaciones()
        {
            context = new Context();
        }

        public LibroDeCalificaciones RecuperarLibroAlumno(Alumno alumno)
        {
            try
            {
                // Busco el libro de calificaciones del alumno.
                var libroDeCalificacionesEncontrado = context.LibrosDeCalificaciones
                    .Include(l => l.DetallesCalificaciones)
                    .FirstOrDefault(l => l.AlumnoId == alumno.AlumnoId);

                return libroDeCalificacionesEncontrado;
            }
            catch
            {
                throw;
            }
        }

        // Sirve para saber si algun examen ya fue cargado con un trimestre existente.
        public bool BuscarExamenEnTrimestre(int numTrimestre)
        {
            try
            {
                // Verifica si existe algún detalle de calificación asociado a un examen en el trimestre especificado.
                var examenEncontrado = context.DetallesDeCalificaciones
                    .Any(detalle => detalle.Examen.Trimestre.NumTrimestre == numTrimestre);

                return examenEncontrado;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<DetalleCalificaciones> ListarDetallesDeCalificaciones(Alumno alumno)
        {
            try
            {
                // Busca el libro de calificaciones del alumno.
                var libroDeCalificaciones = context.LibrosDeCalificaciones
                    .Include(l => l.DetallesCalificaciones)
                    .ThenInclude(d => d.Examen)
                    .ThenInclude(e => e.Trimestre)
                    .Include(l => l.DetallesCalificaciones)
                    .ThenInclude(d => d.Materia)
                    .FirstOrDefault(l => l.AlumnoId == alumno.AlumnoId);

                if (libroDeCalificaciones == null)
                {
                    throw new Exception("No se encontró el libro de calificaciones para el alumno.");
                }

                // Devuelve la lista de detalles de calificaciones.
                return libroDeCalificaciones.DetallesCalificaciones.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string CargarNotaDeExamen(Alumno alumno, DetalleCalificaciones detalle)
        {
            try
            {
                if (detalle.Nota < 1 || detalle.Nota > 10)
                {
                    return "Error: La nota ingresada no es válida.";
                }
                else
                {
                    var libroDeAlumnoEncontrado = context.LibrosDeCalificaciones
                        .Include(l => l.DetallesCalificaciones)
                        .ThenInclude(d => d.Examen)
                        .ThenInclude(e => e.Trimestre)
                        .FirstOrDefault(x => x.Alumno.AlumnoId == alumno.AlumnoId);

                    if (libroDeAlumnoEncontrado == null)
                    {
                        return "Error: No se encontró el libro de calificaciones del alumno.";
                    }

                    // Cargo los detalles de calificaciones.
                    context.Entry(libroDeAlumnoEncontrado)
                        .Collection(x => x.DetallesCalificaciones)
                        .Load();

                    // Recupero la materia.
                    var materiaExistente = context.Materias
                        .FirstOrDefault(m => m.MateriaId == detalle.Materia.MateriaId);

                    if (materiaExistente == null)
                    {
                        return "Error: La materia especificada no existe.";
                    }

                    // Recupero el trimestre del examen.
                    var trimestreExistente = context.Trimestres
                        .FirstOrDefault(t => t.NumTrimestre == detalle.Examen.Trimestre.NumTrimestre);

                    if (trimestreExistente == null)
                    {
                        return "Error: El trimestre especificado no existe.";
                    }

                    // Actualizo el detalle con los objetos.
                    detalle.Materia = materiaExistente;
                    detalle.Examen.Trimestre = trimestreExistente;

                    var examenExistente = libroDeAlumnoEncontrado.DetallesCalificaciones
                        .FirstOrDefault(x => x.Examen.Tipo1 == detalle.Examen.Tipo1
                            && x.Materia.MateriaId == detalle.Materia.MateriaId
                            && x.Examen.Trimestre.NumTrimestre == detalle.Examen.Trimestre.NumTrimestre);

                    if (examenExistente != null)
                    {
                        return $"Error: Ya existe un examen {detalle.Examen.Tipo1} de la materia {detalle.Materia.NombreMateria} en el trimestre {detalle.Examen.Trimestre.NumTrimestre}.";
                    }
                    else
                    {
                        switch (detalle.Examen.Tipo1)
                        {
                            case Examen.Tipo.Parcial:
                                if (detalle.Examen.Trimestre.NumTrimestre > 1)
                                {
                                    var trimestreAnterior = detalle.Examen.Trimestre.NumTrimestre - 1;
                                    var examenParcialTrimestreAnterior = libroDeAlumnoEncontrado.DetallesCalificaciones
                                        .FirstOrDefault(x => x.Examen.Tipo1 == Examen.Tipo.Parcial
                                            && x.Materia.MateriaId == detalle.Materia.MateriaId
                                            && x.Examen.Trimestre.NumTrimestre == trimestreAnterior);

                                    if (trimestreAnterior > 0 && examenParcialTrimestreAnterior == null)
                                    {
                                        return $"Error: No se puede cargar un examen del trimestre {detalle.Examen.Trimestre.NumTrimestre} sin haber cargado un examen parcial en el trimestre {trimestreAnterior} para la misma materia.";
                                    }
                                }
                                break;

                            case Examen.Tipo.Recuperatorio:
                                var examenParcial = libroDeAlumnoEncontrado.DetallesCalificaciones
                                    .FirstOrDefault(x => x.Examen.Tipo1 == Examen.Tipo.Parcial
                                        && x.Materia.MateriaId == detalle.Materia.MateriaId
                                        && x.Examen.Trimestre.NumTrimestre == detalle.Examen.Trimestre.NumTrimestre);

                                if (examenParcial == null)
                                {
                                    return $"Error: No se puede cargar un examen recuperatorio sin haber cargado un examen parcial previo en el mismo trimestre y para la misma materia.";
                                }
                                break;
                        }

                        var examenConCodigoExistente = libroDeAlumnoEncontrado.DetallesCalificaciones
                            .FirstOrDefault(x => x.CodDetalle == detalle.CodDetalle);

                        if (examenConCodigoExistente == null)
                        {
                            detalle.LibroDeCalificaciones = libroDeAlumnoEncontrado;

                            context.DetallesDeCalificaciones.Add(detalle);
                            context.SaveChanges();

                            return "Nota cargada correctamente.";
                        }
                        else
                        {
                            return "Error: El código a ingresar ya existe en otro examen.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Ocurrió un error desconocido.";
            }
        }


        public string ModificarNotaDeExamen(Alumno alumno, DetalleCalificaciones detalle)
        {
            try
            {
                if (detalle.Nota < 1 || detalle.Nota > 10)
                {
                    return "Error: La nota ingresada no es válida.";
                }
                else
                {
                    var libroDeAlumnoEncontrado = context.LibrosDeCalificaciones
                        .Include(l => l.DetallesCalificaciones)
                        .ThenInclude(d => d.Examen)
                        .ThenInclude(e => e.Trimestre)
                        .FirstOrDefault(x => x.Alumno.AlumnoId == alumno.AlumnoId);

                    if (libroDeAlumnoEncontrado == null)
                    {
                        return "Error: No se encontró el libro de calificaciones del alumno.";
                    }

                    var detalleEncontrado = libroDeAlumnoEncontrado.DetallesCalificaciones
                        .FirstOrDefault(d => d.DetalleCalificacionesId == detalle.DetalleCalificacionesId);

                    if (detalleEncontrado == null)
                    {
                        return $"Error: No se ha encontrado el examen.";
                    }

                    detalleEncontrado.Nota = detalle.Nota;
                    context.SaveChanges();

                    return "Nota modificada correctamente.";
                }
            }
            catch (Exception ex)
            {
                return $"Ocurrió un error desconocido.";
            }
        }

        public string EliminarExamen(Alumno alumno, DetalleCalificaciones detalle)
        {
            try
            {
                // Busco el libro de calificaciones del alumno.
                var libroDeAlumnoEncontrado = context.LibrosDeCalificaciones
                    .Include(l => l.DetallesCalificaciones)
                    .ThenInclude(d => d.Examen)
                    .ThenInclude(e => e.Trimestre)
                    .Include(l => l.DetallesCalificaciones)
                    .ThenInclude(d => d.Materia)
                    .FirstOrDefault(x => x.Alumno.AlumnoId == alumno.AlumnoId);

                if (libroDeAlumnoEncontrado == null)
                {
                    return "Error: No se ha encontrado el libro de calificaciones del alumno.";
                }

                var detalleEncontrado = libroDeAlumnoEncontrado.DetallesCalificaciones
                    .FirstOrDefault(d => d.DetalleCalificacionesId == detalle.DetalleCalificacionesId);

                if (detalleEncontrado == null)
                {
                    return "Error: No se ha encontrado el examen.";
                }

                // Verifico si es un examen parcial o recuperatorio.
                switch (detalleEncontrado.Examen.Tipo1)
                {
                    case Examen.Tipo.Parcial:
                        // Verifico si hay un examen recuperatorio en el mismo trimestre y para la misma materia.
                        var examenRecuperatorio = libroDeAlumnoEncontrado.DetallesCalificaciones
                            .FirstOrDefault(x => x.Examen.Tipo1 == Examen.Tipo.Recuperatorio
                                && x.Materia.MateriaId == detalleEncontrado.Materia.MateriaId
                                && x.Examen.Trimestre.NumTrimestre == detalleEncontrado.Examen.Trimestre.NumTrimestre);

                        if (examenRecuperatorio != null)
                        {
                            return "Error: No se puede eliminar un examen parcial si hay un examen recuperatorio en el mismo trimestre y para la misma materia.";
                        }
                        break;

                    case Examen.Tipo.Recuperatorio:
                        if (detalleEncontrado.Examen.Trimestre.NumTrimestre == 3)
                        {
                            context.DetallesDeCalificaciones.Remove(detalleEncontrado);
                            context.SaveChanges();
                            return "Examen eliminado correctamente.";
                        }
                        else
                        {
                            // Verifico si hay exámenes en el trimestre posterior.
                            var examenTrimestrePosterior = libroDeAlumnoEncontrado.DetallesCalificaciones
                                .FirstOrDefault(x => x.Examen.Trimestre.NumTrimestre == detalleEncontrado.Examen.Trimestre.NumTrimestre + 1);

                            if (examenTrimestrePosterior != null)
                            {
                                return "Error: No se puede eliminar un examen recuperatorio si hay exámenes en el trimestre posterior.";
                            }
                        }
                        break;
                }

                // Verifico si hay exámenes en el trimestre posterior.
                var examenesTrimestrePosterior = libroDeAlumnoEncontrado.DetallesCalificaciones
                    .Any(x => x.Examen.Trimestre.NumTrimestre == detalleEncontrado.Examen.Trimestre.NumTrimestre + 1);

                if (examenesTrimestrePosterior)
                {
                    return "Error: No se puede eliminar un examen si hay exámenes en el trimestre posterior.";
                }

                // Si no se cumple ninguna condicion se elimina el examen.
                context.DetallesDeCalificaciones.Remove(detalleEncontrado);
                context.SaveChanges();
                return "Examen eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return $"Ocurrió un error desconocido.";
            }
        }

        // Obtiene todas las notas finales de las materias en un trimestre específico y calcula el promedio en ese trimestre.
        public List<DetalleCalificaciones> MostrarCalificacionesPorTrimestre(Alumno alumno, int numTrimestre)
        {
            try
            {
                var libroDeAlumnoEncontrado = context.LibrosDeCalificaciones
                    .Include(l => l.DetallesCalificaciones)
                    .ThenInclude(d => d.Examen)
                    .ThenInclude(e => e.Trimestre)
                    .Include(l => l.DetallesCalificaciones)
                    .ThenInclude(d => d.Materia)
                    .FirstOrDefault(x => x.Alumno.AlumnoId == alumno.AlumnoId);

                if (libroDeAlumnoEncontrado == null)
                {
                    return null;
                }

                var calificaciones = ObtenerCalificacionesPorTrimestre(alumno, numTrimestre);
                return calificaciones;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Obtiene todas las notas finales de las materias en un trimestre específico y obtiene el promedio en ese trimestre.
        public List<DetalleCalificaciones> ObtenerCalificacionesPorTrimestre(Alumno alumno, int numTrimestre)
        {
            try
            {
                // Busco el libro de calificaciones del alumno.
                var libroDeAlumnoEncontrado = context.LibrosDeCalificaciones
                    .Include(l => l.DetallesCalificaciones)
                    .ThenInclude(d => d.Examen)
                    .ThenInclude(e => e.Trimestre)
                    .Include(l => l.DetallesCalificaciones)
                    .ThenInclude(d => d.Materia)
                    .Include(l => l.Alumno)
                    .ThenInclude(a => a.Grado)
                    .FirstOrDefault(x => x.Alumno.AlumnoId == alumno.AlumnoId);

                if (libroDeAlumnoEncontrado == null)
                {
                    return null;
                }

                // Obtengo lista de detalles de calificaciones.
                var listaDeDetalles = libroDeAlumnoEncontrado.DetallesCalificaciones;

                // Filtro los detalles por el trimestre seleccionado.
                var detallesTrimestre = listaDeDetalles
                    .Where(a => a.Examen.Trimestre.NumTrimestre == numTrimestre)
                    .ToList();

                // Verifico si hay detalles para todas las materias en el trimestre seleccionado
                var listaDeMaterias = ControladoraMaterias.Instancia.ListarMateriasDeGrado(alumno.GradoId);
                var materiasConDetalles = listaDeMaterias
                    .All(materia => detallesTrimestre.Any(detalle => detalle.Materia.MateriaId == materia.MateriaId));

                if (materiasConDetalles == false)
                {
                    return null;
                }

                // Filtro los detalles para obtener solo los exámenes de tipo parcial y recuperatorio.
                var parcialesTrimestre = detallesTrimestre
                    .Where(detalle => detalle.Examen.Tipo1 == Examen.Tipo.Parcial)
                    .ToList();

                var recuperatoriosTrimestre = detallesTrimestre
                    .Where(detalle => detalle.Examen.Tipo1 == Examen.Tipo.Recuperatorio)
                    .ToList();

                // Creo una lista para almacenar detalles finales a mostrar.
                var detallesFinales = new List<DetalleCalificaciones>();

                decimal promedioNotas = 0; // Es para calcular el promedio de las notas.

                // Itero sobre las materias y determino la nota final de cada una en el trimestre.
                var listaMaterias = ControladoraMaterias.Instancia.ListarMateriasDeGrado(libroDeAlumnoEncontrado.Alumno.GradoId);
                foreach (var materia in listaMaterias)
                {
                    // Obtengo el detalle de examen parcial para la materia.
                    var detalleParcial = parcialesTrimestre
                        .FirstOrDefault(detalle => detalle.Materia.MateriaId == materia.MateriaId);

                    // Obtengo el detalle de examen recuperatorio para la materia.
                    var detalleRecuperatorio = recuperatoriosTrimestre
                        .FirstOrDefault(detalle => detalle.Materia.MateriaId == materia.MateriaId);

                    // Determino la nota final de la materia en el trimestre.
                    if (detalleRecuperatorio != null)
                    {
                        // Si hay examen recuperatorio, la nota final es la del recuperatorio
                        detallesFinales.Add(detalleRecuperatorio);
                        promedioNotas += detalleRecuperatorio.Nota;
                    }
                    else if (detalleParcial != null)
                    {
                        // Si hay examen parcial, la nota final es la del parcial
                        detallesFinales.Add(detalleParcial);
                        promedioNotas += detalleParcial.Nota;
                    }
                }

                // Calculo el promedio de las notas
                if (detallesFinales.Count > 0)
                {

                    promedioNotas /= listaMaterias.Count; // Divido por la cantidad de materias
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

                context.SaveChanges();

                // Retorna la lista de detalles finales.
                return detallesFinales;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public decimal ObtenerPromedioAnual(Alumno alumno)
        {
            try
            {
                // Busco el libro de calificaciones del alumno.
                var libroDeAlumnoEncontrado = context.LibrosDeCalificaciones
                    .Include(l => l.DetallesCalificaciones)
                    .FirstOrDefault(l => l.AlumnoId == alumno.AlumnoId);

                if (libroDeAlumnoEncontrado == null)
                {
                    // Si no se encuentra el libro de calificaciones, devuelve 0.
                    return 0;
                }
                else
                {
                    // Obtengo el promedio anual.
                    var promedioAnual = ObtenerPromedioAnualInterno(libroDeAlumnoEncontrado);
                    return promedioAnual ?? 0;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private decimal? ObtenerPromedioAnualInterno(LibroDeCalificaciones libroDeAlumno)
        {
            try
            {
                decimal sumaDePromedios = 0;

                if (libroDeAlumno.NotaTrimestre1 != default(decimal)) // Verifico si NotaTrimestre1 tiene un valor decimal diferente de 0.
                {
                    sumaDePromedios += libroDeAlumno.NotaTrimestre1;
                }

                if (libroDeAlumno.NotaTrimestre2 != default(decimal))
                {
                    sumaDePromedios += libroDeAlumno.NotaTrimestre2;
                }

                if (libroDeAlumno.NotaTrimestre3 != default(decimal))
                {
                    sumaDePromedios += libroDeAlumno.NotaTrimestre3;

                    libroDeAlumno.NotaFinalAnual = sumaDePromedios / 3;
                    return libroDeAlumno.NotaFinalAnual;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Es para buscar el promedio de un trimestre especifico.
        public decimal ObtenerPromedioTrimestre(Alumno alumno, int trimestre)
        {
            try
            {
                // Busco el libro de calificaciones del alumno.
                var libroDeAlumnoEncontrado = context.LibrosDeCalificaciones.FirstOrDefault(x => x.Alumno.AlumnoId == alumno.AlumnoId);

                if (libroDeAlumnoEncontrado == null)
                {
                    // Si no se encuentra el libro de calificaciones devuelve 0.
                    return 0;
                }
                else
                {
                    decimal promedio = 0;

                    switch (trimestre)
                    {
                        case 1:
                            promedio = libroDeAlumnoEncontrado.NotaTrimestre1;
                            break;
                        case 2:
                            promedio = libroDeAlumnoEncontrado.NotaTrimestre2;
                            break;
                        case 3:
                            promedio = libroDeAlumnoEncontrado.NotaTrimestre3;
                            break;
                    }
                    return promedio;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        public dynamic DevolverMateriasAdeudadas(Alumno alumno)
        {
            try
            {
                // Busca el libro de calificaciones del alumno.
                var libroDeCalificaciones = context.LibrosDeCalificaciones
                    .Include(l => l.DetallesCalificaciones)
                    .FirstOrDefault(l => l.AlumnoId == alumno.AlumnoId);

                if (libroDeCalificaciones == null)
                {
                    return 0; // Retorna 0 si no se encontró el libro de calificaciones.
                }

                // Verifico si se cargaron los exámenes en los tres trimestres para todas las materias.
                var trimestresConExamen = new List<int> { 1, 2, 3 };
                var listaDeMaterias = ControladoraMaterias.Instancia.ListarMateriasDeGrado(alumno.GradoId);
                var materiasConExamenEnTodosLosTrimestres = listaDeMaterias
                    .All(materia => trimestresConExamen
                    .All(trimestre => libroDeCalificaciones.DetallesCalificaciones
                    .Any(detalle => detalle.MateriaId == materia.MateriaId &&
                    detalle.Examen.Trimestre.NumTrimestre == trimestre)));

                if (!materiasConExamenEnTodosLosTrimestres)
                {
                    return 1; // Retorna 1 si faltan cargar exámenes.
                }

                // Obtengo las materias adeudadas.
                var materiasAdeudadas = ObtenerMateriasAdeudadas(alumno);

                // Verifico si hay materias adeudadas.
                if (materiasAdeudadas.Count == 0)
                {
                    return 2; // Retorna 2 s no hay materias adeudadas.
                }
                else
                {
                    return materiasAdeudadas; // Devuelvo la lista de materias adeudadas.
                }
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
                List<Materia> materiasAdeudadas = new List<Materia>();

                // Busca el libro de calificaciones del alumno.
                var libroDeCalificacionesEncontrado = context.LibrosDeCalificaciones
                    .Include(l => l.DetallesCalificaciones)
                    .FirstOrDefault(l => l.AlumnoId == alumno.AlumnoId);

                if (libroDeCalificacionesEncontrado != null)
                {
                    var trimestresConExamen = new List<int> { 1, 2, 3 };

                    var listaDeMaterias = ControladoraMaterias.Instancia.ListarMateriasDeGrado(alumno.Grado.GradoId);
                    foreach (var materia in listaDeMaterias)
                    {
                        var sumaNotas = 0m;
                        var cantidadExamenes = 0;

                        // Obtengo los detalles de calificaciones para esta materia.
                        var detallesMateria = libroDeCalificacionesEncontrado.DetallesCalificaciones
                            .Where(detalle => detalle.MateriaId == materia.MateriaId);

                        // Calculo la suma de notas y la cantidad de exámenes por trimestre.
                        foreach (var trimestre in trimestresConExamen)
                        {
                            var examenesTrimestre = detallesMateria
                                .Where(detalle => detalle.Examen.Trimestre.NumTrimestre == trimestre);

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