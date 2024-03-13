using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class LibroAlumno
    {
        private Alumno alumno;

        public Alumno Alumno { get => alumno; set => alumno = value; }
    }
}
