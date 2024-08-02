using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Trimestre
    {
        public string CodTrimestre { get; set; }
        public int NumTrimestre { get; set; }
        public int DiasTotalesHabiles { get; set; }
        public int Año { get; set; }

        //----------------------------------------
        public int TrimestreId { get; set; }
        //----------------------------------------
    }
}
