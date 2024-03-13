using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Trimestre
    {
        private string codTrimestre;
        private int numTrimestre;
        private int diasTotalesHabiles;
        private int año;

        public string CodTrimestre { get => codTrimestre; set => codTrimestre = value; }
        public int NumTrimestre { get => numTrimestre; set => numTrimestre = value; }
        public int DiasTotalesHabiles { get => diasTotalesHabiles; set => diasTotalesHabiles = value; }
        public int Año { get => año; set => año = value; }
    }
}
