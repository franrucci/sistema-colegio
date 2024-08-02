using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LibroAlumno
    {
        //----------------------------------------
        public Alumno Alumno { get; set; }
        public int LibroAlumnoId { get; set; }
        public int AlumnoId { get; set; }
        //----------------------------------------
    }
}
