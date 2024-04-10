using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public class RepositorioGrados
    {
        private List<Grado> grados;
        RepositorioMaterias repoMaterias = new RepositorioMaterias();

        public RepositorioGrados()
        {
            grados = new List<Grado>();

            grados.Add(new Grado { NumGrado = 1, CantidadMaterias = 8, Especialidad1 = Grado.Especialidad.CicloBasico, Materias = repoMaterias.DevolverMaterias(1, Materia.Especialidad.CicloBasico) });
            grados.Add(new Grado { NumGrado = 2, CantidadMaterias = 10, Especialidad1 = Grado.Especialidad.CicloBasico, Materias = repoMaterias.DevolverMaterias(2, Materia.Especialidad.CicloBasico) });
            grados.Add(new Grado { NumGrado = 3, CantidadMaterias = 10, Especialidad1 = Grado.Especialidad.CicloBasico, Materias = repoMaterias.DevolverMaterias(3, Materia.Especialidad.CicloBasico) });
            grados.Add(new Grado { NumGrado = 4, CantidadMaterias = 11, Especialidad1 = Grado.Especialidad.Sociales, Materias = repoMaterias.DevolverMaterias(4, Materia.Especialidad.Sociales) });
            grados.Add(new Grado { NumGrado = 4, CantidadMaterias = 12, Especialidad1 = Grado.Especialidad.Economia, Materias = repoMaterias.DevolverMaterias(4, Materia.Especialidad.Economia) });
            grados.Add(new Grado { NumGrado = 5, CantidadMaterias = 11, Especialidad1 = Grado.Especialidad.Sociales, Materias = repoMaterias.DevolverMaterias(5, Materia.Especialidad.Sociales) });
            grados.Add(new Grado { NumGrado = 5, CantidadMaterias = 12, Especialidad1 = Grado.Especialidad.Economia, Materias = repoMaterias.DevolverMaterias(5, Materia.Especialidad.Economia) });
            grados.Add(new Grado { NumGrado = 6, CantidadMaterias = 10, Especialidad1 = Grado.Especialidad.Sociales, Materias = repoMaterias.DevolverMaterias(6, Materia.Especialidad.Sociales) });
            grados.Add(new Grado { NumGrado = 6, CantidadMaterias = 9, Especialidad1 = Grado.Especialidad.Economia, Materias = repoMaterias.DevolverMaterias(6, Materia.Especialidad.Economia) });
        }


        // Me devuelve el objeto grado.
        public Grado DevolverGrado(int numGrado, Grado.Especialidad especialidad)
        {
            return grados.FirstOrDefault(x => x.NumGrado == numGrado && x.Especialidad1 == especialidad);
        }
    }
}
