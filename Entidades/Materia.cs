using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Grado;

namespace Entidades
{
    public class Materia
    {
        private string codigoMateria;
        private string nombreMateria;
        private int horasAnuales;
        private int añoDeGrado;
        private Especialidad especialidad;

        public enum Especialidad { CicloBasico, Economia, Sociales };

        public string CodigoMateria { get => codigoMateria; set => codigoMateria = value; }
        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }
        public int HorasAnuales { get => horasAnuales; set => horasAnuales = value; }
        public int AñoDeGrado { get => añoDeGrado; set => añoDeGrado = value; }
        public Especialidad Especialidad1 { get => especialidad; set => especialidad = value; }
    }
}
