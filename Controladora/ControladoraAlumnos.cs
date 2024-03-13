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
    public class ControladoraAlumnos
    {
        private ControladoraAlumnos() { }
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

        public ReadOnlyCollection<Alumno> RecuperarAlumnos()
        {
            return RepositorioAlumnos.Instancia.ListarAlumnos();
        }

        // Retorna las materias del grado al que cursa un alumno determinado.
        public ReadOnlyCollection<Materia> RetornarMateriasDeGradoDeAlumno(Alumno alumno)
        {
            var listaDeAlumnos = RepositorioAlumnos.Instancia.ListarAlumnos();
            var alumnoEncontrado = listaDeAlumnos.FirstOrDefault(x => x.Dni == alumno.Dni);
            return alumnoEncontrado.Grado.ListarMaterias();
        } 

        // Sirve para asignarle un estado al alumno.
        public bool AsignarEstado(Alumno alumno)
        {

            var librosDeCalificaciones = ControladoraLibrosDeCalificaciones.Instancia.RecuperarLibrosDeCalificaciones();
            var libroDeAlumnoEncontrado = librosDeCalificaciones.FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);

            if (libroDeAlumnoEncontrado != null)
            {

                if (libroDeAlumnoEncontrado.NotaFinalAnual != default(decimal)) // Verifica si existe la nota anual, si tiene un valor decimal diferente de 0.
                {
                    // Busca la cantidad de días registrados para el alumno en el trimestre especificado.
                    int diasRegistradosDeAlumnoTrimestre1 = RepositorioLibrosDeAsistencias.Instancia.ObtenerCantidadDeDiasCargados(alumno, 1);
                    // Busco el trimestre con el mismo numero de trimestre.
                    var trimestreEncontrado1 = RepositorioTrimestres.Instancia.ListarTrimestres().FirstOrDefault(x => x.NumTrimestre == 1);
                    if (trimestreEncontrado1 != null)
                    {
                        if (trimestreEncontrado1.DiasTotalesHabiles == diasRegistradosDeAlumnoTrimestre1)
                        {
                            // Busca la cantidad de días registrados para el alumno en el trimestre especificado.
                            int diasRegistradosDeAlumnoTrimestre2 = RepositorioLibrosDeAsistencias.Instancia.ObtenerCantidadDeDiasCargados(alumno, 2);
                            // Busco el trimestre con el mismo numero de trimestre.
                            var trimestreEncontrado2 = RepositorioTrimestres.Instancia.ListarTrimestres().FirstOrDefault(x => x.NumTrimestre == 2);
                            if (trimestreEncontrado2 != null)
                            {
                                if (trimestreEncontrado2.DiasTotalesHabiles == diasRegistradosDeAlumnoTrimestre2)
                                {
                                    // Busca la cantidad de días registrados para el alumno en el trimestre especificado.
                                    int diasRegistradosDeAlumnoTrimestre3 = RepositorioLibrosDeAsistencias.Instancia.ObtenerCantidadDeDiasCargados(alumno, 3);

                                    // Busco el trimestre con el mismo numero de trimestre.
                                    var trimestreEncontrado3 = RepositorioTrimestres.Instancia.ListarTrimestres().FirstOrDefault(x => x.NumTrimestre == 3);
                                    if (trimestreEncontrado3 != null)
                                    {
                                        if (trimestreEncontrado3.DiasTotalesHabiles == diasRegistradosDeAlumnoTrimestre3) // Valido que el alumno tenga la misma cantidad de asistencias registradas que la cantidad de dias habiles del trimestre.
                                        {
                                            decimal notaFinalAnual = libroDeAlumnoEncontrado.NotaFinalAnual;
                                            var libroDeAsistenciasAlumno = RepositorioLibrosDeAsistencias.Instancia.ListarLibrosDeAsistencias().FirstOrDefault(x => x.Alumno.Dni == alumno.Dni);
                                            decimal porcentajeAsistenciaAnual = (libroDeAsistenciasAlumno.PorcentajeAsistenciaTrimestre1 + libroDeAsistenciasAlumno.PorcentajeAsistenciaTrimestre2 + libroDeAsistenciasAlumno.PorcentajeAsistenciaTrimestre3) / 3;

                                            var materiasAdeudadas = RepositorioLibrosDeCalificaciones.Instancia.ObtenerMateriasAdeudadas(alumno);

                                            bool estadoCompleto = RepositorioAlumnos.Instancia.AsignarEstado(alumno, notaFinalAnual, porcentajeAsistenciaAnual, materiasAdeudadas);
                                            if (estadoCompleto == true)
                                            {
                                                return true;
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
