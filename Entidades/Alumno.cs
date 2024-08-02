using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public SexoEnum Sexo { get; set; }
        public string Domicilio { get; set; }
        public string Localidad { get; set; }
        public string CodigoPostal { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public EstadoEnum Estado { get; set; }

        public enum SexoEnum { Masculino, Femenino }
        public enum EstadoEnum { Promovido, MesDeRecuperacion, Reprobado }

        //----------------------------------------
        public int AlumnoId { get; set; }
        public Grado Grado { get; set; }
        public int GradoId { get; set; }
        //----------------------------------------
        public LibroDeCalificaciones LibroDeCalificaciones { get; set; }
        public LibroDeAsistencias LibroDeAsistencias { get; set; }
    }
}
