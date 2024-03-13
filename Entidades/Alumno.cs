using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string nombre;
        private string apellido;
        private string dni;
        private DateTime fechaNacimiento;
        private Sexo sexo;
        private string domicilio;
        private string localidad;
        private string codigoPostal;
        private string provincia;
        private string pais;
        private Grado grado;
        private Estado estado;

        public enum Sexo { Masculino, Femenino };
        public enum Estado { Promovido, MesDeRecuperacion, Reprobado };
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public Sexo Sexo1 { get => sexo; set => sexo = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Pais { get => pais; set => pais = value; }
        public Grado Grado { get => grado; set => grado = value; }
        public Estado Estado1 { get => estado; set => estado = value; }
    }
}
