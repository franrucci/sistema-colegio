using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LibroDeCalificaciones : LibroAlumno
    {
        public List<DetalleCalificaciones> DetallesCalificaciones = new List<DetalleCalificaciones>();
        public decimal NotaTrimestre1 { get; set; }
        public decimal NotaTrimestre2 { get; set; }
        public decimal NotaTrimestre3 { get; set; }
        public decimal NotaFinalAnual { get; set; }

        //----------------------------------------
    }
}
