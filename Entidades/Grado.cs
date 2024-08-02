using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grado
    {
        public List<Materia> Materias = new List<Materia>();
        public List<Trimestre> Trimestres = new List<Trimestre>();
        public int NumGrado { get; set; }
        public int CantidadMaterias { get; set; }
        public EspecialidadEnum Especialidad { get; set; }
        public enum EspecialidadEnum { CicloBasico, Economia, Sociales }

        //----------------------------------------
        public int GradoId { get; set; }

        //----------------------------------------
    }
}
