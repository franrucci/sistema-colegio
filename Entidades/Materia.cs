using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia
    {
        public string CodigoMateria { get; set; }
        public Grado Grado { get; set; }
        public string NombreMateria { get; set; }
        public int HorasAnuales { get; set; }
        public Especialidad Especialidad1 { get; set; }
        public enum Especialidad { CicloBasico, Economia, Sociales };

        //----------------------------------------
        public int MateriaId { get; set; }
        public int GradoId {  get; set; }
        //----------------------------------------
    }
}
