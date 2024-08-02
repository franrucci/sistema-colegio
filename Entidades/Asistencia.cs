using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asistencia
    {
        public DateTime Fecha { get; set; }
        public Tipo Tipo1 { get; set; }
        public enum Tipo { Presente, Ausente, FaltaJustificada, Retiro };
        public LibroDeAsistencias LibroDeAsistencias { get; set; }
        public int LibroAlumnoId {  get; set; }

        //----------------------------------------
        public int AsistenciaId { get; set; }
        public Trimestre Trimestre { get; set; }
        public int TrimestreId { get; set; }
        //----------------------------------------
    }
}
