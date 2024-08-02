using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LibroDeAsistencias : LibroAlumno
    {
        public List<Asistencia> Asistencias = new List<Asistencia>();
        public decimal PorcentajeAsistenciaTrimestre1 { get; set; }
        public decimal PorcentajeAsistenciaTrimestre2 { get; set; }
        public decimal PorcentajeAsistenciaTrimestre3 { get; set; }

        //----------------------------------------
    }
}
