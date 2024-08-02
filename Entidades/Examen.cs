using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Examen
    {
        public Tipo Tipo1 { get; set; }
        public enum Tipo { Parcial, Recuperatorio };

        //----------------------------------------
        public int ExamenId { get; set; }
        public Trimestre Trimestre { get; set; }
        public int TrimestreId { get; set; }
        //----------------------------------------
    }
}
