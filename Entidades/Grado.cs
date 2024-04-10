using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grado
    {
        private int numGrado;
        private Especialidad especialidad;
        private int cantidadMaterias;
        private List<Materia> materias;
        private List<Trimestre> trimestres;

        public Grado()
        {
            materias = new List<Materia>();
            trimestres = new List<Trimestre>();
        }

        public enum Especialidad { CicloBasico, Economia, Sociales };
        public int NumGrado { get => numGrado; set => numGrado = value; }
        public Especialidad Especialidad1 { get => especialidad; set => especialidad = value; }
        public int CantidadMaterias { get => cantidadMaterias; set => cantidadMaterias = value; }
        public List<Materia> Materias { get => materias; set => materias = value; }

        public ReadOnlyCollection<Materia> ListarMaterias()
        {
            return materias.AsReadOnly();
        }
    }
}
