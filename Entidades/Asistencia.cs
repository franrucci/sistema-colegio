using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asistencia
    {
        private DateTime fecha;
        private Tipo tipo;
        private Trimestre trimestre;

        public enum Tipo { Presente, Ausente, FaltaJustificada, Retiro };
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Tipo Tipo1 { get => tipo; set => tipo = value; }
        public Trimestre Trimestre { get => trimestre; set => trimestre = value; }
    }
}
