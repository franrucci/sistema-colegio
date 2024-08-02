using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleCalificaciones
    {
        public string CodDetalle { get; set; }
        public int Nota { get; set; }
        public LibroDeCalificaciones LibroDeCalificaciones { get; set; }
        public int LibroAlumnoId {  get; set; }
        //----------------------------------------
        public int DetalleCalificacionesId { get; set; }
        public Materia Materia { get; set; }
        public int MateriaId { get; set; }
        public Examen Examen { get; set; }
        public int ExamenId { get; set; }
        //----------------------------------------
    }
}
