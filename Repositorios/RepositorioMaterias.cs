using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public class RepositorioMaterias
    {
        private List<Materia> materias;

        public RepositorioMaterias()
        {
            materias = new List<Materia>();
            // 1er grado (Ciclo Básico)
            materias.Add(new Materia { CodigoMateria = "A01", NombreMateria = "Ciencias Naturales", HorasAnuales = 10, AñoDeGrado = 1, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "A02", NombreMateria = "Ciencias Sociales", HorasAnuales = 10, AñoDeGrado = 1, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "A03", NombreMateria = "Educación Artística", HorasAnuales = 10, AñoDeGrado = 1, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "A04", NombreMateria = "Educación Física", HorasAnuales = 10, AñoDeGrado = 1, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "A05", NombreMateria = "Inglés", HorasAnuales = 10, AñoDeGrado = 1, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "A06", NombreMateria = "Matemática", HorasAnuales = 10, AñoDeGrado = 1, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "A07", NombreMateria = "Prácticas del Lenguaje", HorasAnuales = 10, AñoDeGrado = 1, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "A08", NombreMateria = "Construcción de Ciudadanía", HorasAnuales = 10, AñoDeGrado = 1, Especialidad1 = Materia.Especialidad.CicloBasico });

            // 2do grado (Ciclo Básico)
            materias.Add(new Materia { CodigoMateria = "B01", NombreMateria = "Biología", HorasAnuales = 10, AñoDeGrado = 2, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "B02", NombreMateria = "Construcción de Ciudadanía", HorasAnuales = 10, AñoDeGrado = 2, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "B03", NombreMateria = "Educación Artística", HorasAnuales = 10, AñoDeGrado = 2, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "B04", NombreMateria = "Educación Física", HorasAnuales = 10, AñoDeGrado = 2, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "B05", NombreMateria = "Físico Química", HorasAnuales = 10, AñoDeGrado = 2, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "B06", NombreMateria = "Geografía", HorasAnuales = 10, AñoDeGrado = 2, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "B07", NombreMateria = "Historia", HorasAnuales = 10, AñoDeGrado = 2, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "B08", NombreMateria = "Inglés", HorasAnuales = 10, AñoDeGrado = 2, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "B09", NombreMateria = "Matemática", HorasAnuales = 10, AñoDeGrado = 2, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "B10", NombreMateria = "Prácticas del Lenguaje", HorasAnuales = 10, AñoDeGrado = 2, Especialidad1 = Materia.Especialidad.CicloBasico });

            // 3er grado (Ciclo Básico)
            materias.Add(new Materia { CodigoMateria = "C01", NombreMateria = "Biología", HorasAnuales = 10, AñoDeGrado = 3, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "C02", NombreMateria = "Construcción de Ciudadanía", HorasAnuales = 10, AñoDeGrado = 3, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "C03", NombreMateria = "Educación Artística", HorasAnuales = 10, AñoDeGrado = 3, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "C04", NombreMateria = "Educación Física", HorasAnuales = 10, AñoDeGrado = 3, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "C05", NombreMateria = "Físico Química", HorasAnuales = 10, AñoDeGrado = 3, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "C06", NombreMateria = "Geografía", HorasAnuales = 10, AñoDeGrado = 3, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "C07", NombreMateria = "Historia", HorasAnuales = 10, AñoDeGrado = 3, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "C08", NombreMateria = "Inglés", HorasAnuales = 10, AñoDeGrado = 3, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "C09", NombreMateria = "Matemática", HorasAnuales = 10, AñoDeGrado = 3, Especialidad1 = Materia.Especialidad.CicloBasico });
            materias.Add(new Materia { CodigoMateria = "C10", NombreMateria = "Prácticas del Lenguaje", HorasAnuales = 10, AñoDeGrado = 3, Especialidad1 = Materia.Especialidad.CicloBasico });

            // 4to grado (Sociales)
            materias.Add(new Materia { CodigoMateria = "D01", NombreMateria = "Matemática", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "D02", NombreMateria = "Literatura", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "D03", NombreMateria = "Educación Física", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "D04", NombreMateria = "Inglés", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "D05", NombreMateria = "Salud y Adolescencia", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "D06", NombreMateria = "Biología", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "D07", NombreMateria = "Historia", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "D08", NombreMateria = "Geografía", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "D09", NombreMateria = "NTICx", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "D10", NombreMateria = "Psicología", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Sociales });


            // 4to grado (Economía)
            materias.Add(new Materia { CodigoMateria = "E01", NombreMateria = "Matemática", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "E02", NombreMateria = "Literatura", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "E03", NombreMateria = "Educación Física", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "E04", NombreMateria = "Inglés", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "E05", NombreMateria = "Salud y Adolescencia", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "E06", NombreMateria = "Historia", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "E07", NombreMateria = "Geografía", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "E08", NombreMateria = "Biología", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "E09", NombreMateria = "NTICx", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "E10", NombreMateria = "Sistema de Información Contable", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "E11", NombreMateria = "Teoría de las Organizaciones", HorasAnuales = 10, AñoDeGrado = 4, Especialidad1 = Materia.Especialidad.Economia });


            // 5to grado (Sociales)
            materias.Add(new Materia { CodigoMateria = "F01", NombreMateria = "Matemática", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "F02", NombreMateria = "Literatura", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "F03", NombreMateria = "Educación Física", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "F04", NombreMateria = "Inglés", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "F05", NombreMateria = "Política y Ciudadanía", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "F06", NombreMateria = "Introducción a la Química", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "F07", NombreMateria = "Comunicación, Cultura y Sociedad", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "F08", NombreMateria = "Historia", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "F09", NombreMateria = "Geografía", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "F10", NombreMateria = "Economía Política", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "F11", NombreMateria = "Sociología", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Sociales });

            // 5to grado (Economia)
            materias.Add(new Materia { CodigoMateria = "G01", NombreMateria = "Matemática", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "G02", NombreMateria = "Literatura", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "G03", NombreMateria = "Educación Física", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "G04", NombreMateria = "Inglés", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "G05", NombreMateria = "Política y Ciudadanía", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "G06", NombreMateria = "Introducción a la Química", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "G07", NombreMateria = "Historia", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "G08", NombreMateria = "Geografía", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "G09", NombreMateria = "Elementos de micro y macroeconomía", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "G10", NombreMateria = "Derecho", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "G11", NombreMateria = "Sistemas de Información Contable", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "G12", NombreMateria = "Gestión Organizacional", HorasAnuales = 10, AñoDeGrado = 5, Especialidad1 = Materia.Especialidad.Economia });


            // 6to grado (Sociales)
            materias.Add(new Materia { CodigoMateria = "H01", NombreMateria = "Matemática", HorasAnuales = 10, AñoDeGrado = 6, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "H02", NombreMateria = "Literatura", HorasAnuales = 10, AñoDeGrado = 6, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "H03", NombreMateria = "Educación Física", HorasAnuales = 10, AñoDeGrado = 6, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "H04", NombreMateria = "Inglés", HorasAnuales = 10, AñoDeGrado = 6, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "H05", NombreMateria = "Trabajo y Ciudadanía", HorasAnuales = 10, AñoDeGrado = 6, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "H06", NombreMateria = "Proyecto de Investigación en Ciencias Sociales", HorasAnuales = 10, AñoDeGrado = 6, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "H07", NombreMateria = "Historia", HorasAnuales = 10, AñoDeGrado = 6, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "H08", NombreMateria = "Geografía", HorasAnuales = 10, AñoDeGrado = 6, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "H09", NombreMateria = "Arte", HorasAnuales = 10, AñoDeGrado = 6, Especialidad1 = Materia.Especialidad.Sociales });
            materias.Add(new Materia { CodigoMateria = "H10", NombreMateria = "Filosofía", HorasAnuales = 10, AñoDeGrado = 6, Especialidad1 = Materia.Especialidad.Sociales });


            // 6to grado (Economía)
            materias.Add(new Materia { CodigoMateria = "I01", NombreMateria = "Matemática", HorasAnuales = 10, AñoDeGrado = 6, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "I02", NombreMateria = "Literatura", HorasAnuales = 10, AñoDeGrado = 6, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "I03", NombreMateria = "Educación Física", HorasAnuales = 10, AñoDeGrado = 6, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "I04", NombreMateria = "Inglés", HorasAnuales = 10, AñoDeGrado = 6, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "I05", NombreMateria = "Trabajo y Ciudadanía", HorasAnuales = 10, AñoDeGrado = 6, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "I06", NombreMateria = "Arte", HorasAnuales = 10, AñoDeGrado = 6, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "I07", NombreMateria = "Filosofía", HorasAnuales = 10, AñoDeGrado = 6, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "I08", NombreMateria = "Economía Política", HorasAnuales = 10, AñoDeGrado = 6, Especialidad1 = Materia.Especialidad.Economia });
            materias.Add(new Materia { CodigoMateria = "I09", NombreMateria = "Proyectos Organizacionales", HorasAnuales = 10, AñoDeGrado = 6, Especialidad1 = Materia.Especialidad.Economia });
        }

        // Sirve para devolver la lista de materias en un grado especifico.
        public List<Materia> DevolverMaterias(int año, Materia.Especialidad especialidad)
        {
            List<Materia> listaMateriasEncontradas = new List<Materia>();

            foreach (Materia materia in materias)
            {
                // Verificar si la materia cumple con las condiciones especificadas
                if (materia.AñoDeGrado == año && materia.Especialidad1 == especialidad)
                {
                    listaMateriasEncontradas.Add(materia);
                }
            }
            return listaMateriasEncontradas;
        }
    }
}
