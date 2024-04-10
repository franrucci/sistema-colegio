using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Examen
    {
        private Tipo tipo;
        private Trimestre trimestre;

        public enum Tipo { Parcial, Recuperatorio };
        public Tipo Tipo1 { get => tipo; set => tipo = value; }
        public Trimestre Trimestre { get => trimestre; set => trimestre = value; }
    }
}
