using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public class RepositorioAlumnos
    {
        private static RepositorioAlumnos instancia;
        private List<Alumno> alumnos;

        public RepositorioAlumnos()
        {
            alumnos = new List<Alumno>();

            RepositorioGrados repositorioGrados = new RepositorioGrados();
            alumnos.Add(new Alumno { Nombre = "Jorge", Apellido = "Lopez", Dni = "44651986", FechaNacimiento = new DateTime(2001, 12, 28), Sexo1 = Alumno.Sexo.Masculino, Domicilio = "Callao 569", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(1, Grado.Especialidad.CicloBasico) });
            alumnos.Add(new Alumno { Nombre = "Marcelo", Apellido = "Rocca", Dni = "40569845", FechaNacimiento = new DateTime(2001, 09, 18), Sexo1 = Alumno.Sexo.Masculino, Domicilio = "Italia 1259", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(1, Grado.Especialidad.CicloBasico) });
            alumnos.Add(new Alumno { Nombre = "Miguel", Apellido = "Martinez", Dni = "41758147", FechaNacimiento = new DateTime(2001, 10, 08), Sexo1 = Alumno.Sexo.Masculino, Domicilio = "San Martin 1216", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(1, Grado.Especialidad.CicloBasico) });
            alumnos.Add(new Alumno { Nombre = "María", Apellido = "Gómez", Dni = "41234567", FechaNacimiento = new DateTime(2002, 5, 15), Sexo1 = Alumno.Sexo.Femenino, Domicilio = "San Martín 123", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(2, Grado.Especialidad.CicloBasico) });
            alumnos.Add(new Alumno { Nombre = "Lucas", Apellido = "Martínez", Dni = "42123456", FechaNacimiento = new DateTime(2003, 7, 28), Sexo1 = Alumno.Sexo.Masculino, Domicilio = "Belgrano 456", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(3, Grado.Especialidad.CicloBasico) });
            alumnos.Add(new Alumno { Nombre = "Sofía", Apellido = "Fernández", Dni = "43234567", FechaNacimiento = new DateTime(2001, 9, 10), Sexo1 = Alumno.Sexo.Femenino, Domicilio = "Rivadavia 789", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(4, Grado.Especialidad.Sociales) });
            alumnos.Add(new Alumno { Nombre = "Mateo", Apellido = "García", Dni = "41456789", FechaNacimiento = new DateTime(2002, 11, 23), Sexo1 = Alumno.Sexo.Masculino, Domicilio = "Urquiza 234", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(5, Grado.Especialidad.Economia) });
            alumnos.Add(new Alumno { Nombre = "Valentina", Apellido = "Pérez", Dni = "42456789", FechaNacimiento = new DateTime(2003, 4, 5), Sexo1 = Alumno.Sexo.Femenino, Domicilio = "Sarmiento 345", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(6, Grado.Especialidad.Economia) });
            alumnos.Add(new Alumno { Nombre = "Juan", Apellido = "Rodríguez", Dni = "41345678", FechaNacimiento = new DateTime(2001, 8, 12), Sexo1 = Alumno.Sexo.Masculino, Domicilio = "Laprida 678", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(1, Grado.Especialidad.CicloBasico) });
            alumnos.Add(new Alumno { Nombre = "Camila", Apellido = "González", Dni = "42234567", FechaNacimiento = new DateTime(2002, 6, 7), Sexo1 = Alumno.Sexo.Femenino, Domicilio = "San Juan 456", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(2, Grado.Especialidad.CicloBasico) });
            alumnos.Add(new Alumno { Nombre = "Agustín", Apellido = "López", Dni = "43456789", FechaNacimiento = new DateTime(2003, 10, 19), Sexo1 = Alumno.Sexo.Masculino, Domicilio = "Pueyrredón 890", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(3, Grado.Especialidad.CicloBasico) });
            alumnos.Add(new Alumno { Nombre = "Martina", Apellido = "Martínez", Dni = "41234567", FechaNacimiento = new DateTime(2001, 7, 15), Sexo1 = Alumno.Sexo.Femenino, Domicilio = "Maipú 567", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(4, Grado.Especialidad.Sociales) });
            alumnos.Add(new Alumno { Nombre = "Tomás", Apellido = "Fernández", Dni = "42345678", FechaNacimiento = new DateTime(2002, 5, 3), Sexo1 = Alumno.Sexo.Masculino, Domicilio = "Mitre 234", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(5, Grado.Especialidad.Economia) });
            alumnos.Add(new Alumno { Nombre = "Lucía", Apellido = "García", Dni = "43234567", FechaNacimiento = new DateTime(2003, 9, 8), Sexo1 = Alumno.Sexo.Femenino, Domicilio = "San Luis 789", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(6, Grado.Especialidad.Economia) });
            alumnos.Add(new Alumno { Nombre = "Marcos", Apellido = "Pérez", Dni = "41567890", FechaNacimiento = new DateTime(2001, 12, 21), Sexo1 = Alumno.Sexo.Masculino, Domicilio = "Belgrano 456", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(1, Grado.Especialidad.CicloBasico) });
            alumnos.Add(new Alumno { Nombre = "Abril", Apellido = "Rodríguez", Dni = "42456789", FechaNacimiento = new DateTime(2002, 8, 11), Sexo1 = Alumno.Sexo.Femenino, Domicilio = "Chacabuco 678", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(2, Grado.Especialidad.CicloBasico) });
            alumnos.Add(new Alumno { Nombre = "Lautaro", Apellido = "González", Dni = "43345678", FechaNacimiento = new DateTime(2003, 7, 17), Sexo1 = Alumno.Sexo.Masculino, Domicilio = "9 de Julio 890", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(3, Grado.Especialidad.CicloBasico) });
            alumnos.Add(new Alumno { Nombre = "Valentín", Apellido = "López", Dni = "41456789", FechaNacimiento = new DateTime(2001, 11, 25), Sexo1 = Alumno.Sexo.Masculino, Domicilio = "San Martín 123", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(4, Grado.Especialidad.Sociales) });
            alumnos.Add(new Alumno { Nombre = "Delfina", Apellido = "Martínez", Dni = "42567890", FechaNacimiento = new DateTime(2002, 9, 6), Sexo1 = Alumno.Sexo.Femenino, Domicilio = "Belgrano 456", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(5, Grado.Especialidad.Economia) });
            alumnos.Add(new Alumno { Nombre = "Benjamín", Apellido = "Fernández", Dni = "43456789", FechaNacimiento = new DateTime(2003, 12, 2), Sexo1 = Alumno.Sexo.Masculino, Domicilio = "San Juan 789", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(6, Grado.Especialidad.Economia) });
            alumnos.Add(new Alumno { Nombre = "Renata", Apellido = "García", Dni = "41678901", FechaNacimiento = new DateTime(2001, 10, 29), Sexo1 = Alumno.Sexo.Femenino, Domicilio = "Mitre 234", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(1, Grado.Especialidad.CicloBasico) });
            alumnos.Add(new Alumno { Nombre = "Ramiro", Apellido = "Pérez", Dni = "42345678", FechaNacimiento = new DateTime(2002, 7, 18), Sexo1 = Alumno.Sexo.Masculino, Domicilio = "Maipú 567", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(2, Grado.Especialidad.CicloBasico) });
            alumnos.Add(new Alumno { Nombre = "Catalina", Apellido = "Rodríguez", Dni = "43234567", FechaNacimiento = new DateTime(2003, 5, 7), Sexo1 = Alumno.Sexo.Femenino, Domicilio = "San Juan 123", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(3, Grado.Especialidad.CicloBasico) });
            alumnos.Add(new Alumno { Nombre = "Francisco", Apellido = "González", Dni = "41567890", FechaNacimiento = new DateTime(2001, 11, 22), Sexo1 = Alumno.Sexo.Masculino, Domicilio = "Laprida 456", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(4, Grado.Especialidad.Sociales) });
            alumnos.Add(new Alumno { Nombre = "Isabella", Apellido = "López", Dni = "42678901", FechaNacimiento = new DateTime(2002, 8, 14), Sexo1 = Alumno.Sexo.Femenino, Domicilio = "9 de Julio 678", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(5, Grado.Especialidad.Economia) });
            alumnos.Add(new Alumno { Nombre = "Santiago", Apellido = "Martínez", Dni = "43345678", FechaNacimiento = new DateTime(2003, 6, 2), Sexo1 = Alumno.Sexo.Masculino, Domicilio = "Pueyrredón 234", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(6, Grado.Especialidad.Economia) });
            alumnos.Add(new Alumno { Nombre = "Valeria", Apellido = "Fernández", Dni = "41789012", FechaNacimiento = new DateTime(2001, 12, 9), Sexo1 = Alumno.Sexo.Femenino, Domicilio = "San Luis 456", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(1, Grado.Especialidad.CicloBasico) });
            alumnos.Add(new Alumno { Nombre = "Luciano", Apellido = "García", Dni = "42678901", FechaNacimiento = new DateTime(2002, 9, 7), Sexo1 = Alumno.Sexo.Masculino, Domicilio = "San Martín 890", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(2, Grado.Especialidad.CicloBasico) });
            alumnos.Add(new Alumno { Nombre = "Micaela", Apellido = "Pérez", Dni = "43456789", FechaNacimiento = new DateTime(2003, 10, 22), Sexo1 = Alumno.Sexo.Femenino, Domicilio = "Belgrano 123", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(3, Grado.Especialidad.CicloBasico) });
            alumnos.Add(new Alumno { Nombre = "Juan Pablo", Apellido = "Rodríguez", Dni = "41890123", FechaNacimiento = new DateTime(2001, 12, 1), Sexo1 = Alumno.Sexo.Masculino, Domicilio = "Laprida 567", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(4, Grado.Especialidad.Sociales) });
            alumnos.Add(new Alumno { Nombre = "Florencia", Apellido = "González", Dni = "42789012", FechaNacimiento = new DateTime(2002, 10, 10), Sexo1 = Alumno.Sexo.Femenino, Domicilio = "Chacabuco 234", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(5, Grado.Especialidad.Economia) });
            alumnos.Add(new Alumno { Nombre = "Facundo", Apellido = "López", Dni = "43567890", FechaNacimiento = new DateTime(2003, 11, 15), Sexo1 = Alumno.Sexo.Masculino, Domicilio = "San Juan 789", Localidad = "Rosario", CodigoPostal = "A2000", Provincia = "Santa Fe", Pais = "Argentina", Grado = repositorioGrados.DevolverGrado(6, Grado.Especialidad.Economia) });
        }

        public static RepositorioAlumnos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new RepositorioAlumnos();
                }
                return instancia;
            }
        }

        public ReadOnlyCollection<Alumno> ListarAlumnos()
        {
            return alumnos.AsReadOnly();
        }


        // Asigna un estado al alumno.
        public bool AsignarEstado(Alumno alumno, decimal notaFinalAnual, decimal porcentajeAsistenciaAnual, List<Materia> materiasAdeudadas)
        {
            var alumnoEncontrado = alumnos.FirstOrDefault(x => x.Dni == alumno.Dni);
            if (alumnoEncontrado != null)
            {
                if ((porcentajeAsistenciaAnual >= 70) && (materiasAdeudadas.Count == 0))
                {
                    alumnoEncontrado.Estado1 = Alumno.Estado.Promovido;
                    return true;
                }
                else if ((porcentajeAsistenciaAnual >= 70) && (materiasAdeudadas.Count >= 1))
                {
                    alumnoEncontrado.Estado1 = Alumno.Estado.MesDeRecuperacion;
                    return true;
                }
                else
                {
                    if (porcentajeAsistenciaAnual <= 70)
                    {
                        alumnoEncontrado.Estado1 = Alumno.Estado.Reprobado;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }
    }
}
