using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleCalificaciones
    {
        private string codDetalle;
        private Materia materia;
        private Examen examen;
        private int nota;

        public DetalleCalificaciones()
        {
            examen = new Examen();
        }

        public string CodDetalle { get => codDetalle; set => codDetalle = value; }
        public Materia Materia { get => materia; set => materia = value; }
        public Examen Examen { get => examen; set => examen = value; }
        public int Nota { get => nota; set => nota = value; }
    }
}
