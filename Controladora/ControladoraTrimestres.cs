using Entidades;
using Repositorios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraTrimestres
    {
        private ControladoraTrimestres() { }
        private static ControladoraTrimestres instancia;

        public static ControladoraTrimestres Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraTrimestres();
                }
                return instancia;
            }
        }

        public ReadOnlyCollection<Trimestre> RecuperarTrimestres()
        {
            return RepositorioTrimestres.Instancia.ListarTrimestres();
        }

        public string AgregarNuevoTrimestre(Trimestre trimestre)
        {
            var listaTrimestres = RepositorioTrimestres.Instancia.ListarTrimestres();

            //Busco si existe algun trimestre con ese codigo.
            var trimestreEncontrado = listaTrimestres.FirstOrDefault(x => (x.CodTrimestre == trimestre.CodTrimestre));
            if (trimestreEncontrado == null)
            {
                //Busco si existe algun trimestre con el mismo numero de trimestre en el mismo año.
                var trimestreEncontrado1 = listaTrimestres.FirstOrDefault(x => (x.NumTrimestre == trimestre.NumTrimestre) && (x.Año == trimestre.Año));
                if (trimestreEncontrado1 == null)
                {
                    int trimestreAgregado = RepositorioTrimestres.Instancia.AgregarTrimestre(trimestre);
                    switch (trimestreAgregado)
                    {
                        case 0:
                            return "Error: El año a ingresar debe ser el actual.";

                        case 1:
                            return "Error: El numero de trimestre debe ser 1, 2 o 3.";

                        case 2:
                            return "Trimestre agregado con exito.";

                        case 3:
                            return "Error: Antes de ingresar el trimestre N°2 primero debe ingresar el trimestre N°1.";

                        case 4:
                            return "Error: El maximo de dias a ingresar son 63.";

                        case 5:
                            return "Error: Antes de ingresar el trimestre N°3 primero debe ingresar el trimestre N°2.";

                        default:
                            return "Error: no se ha podido registrar el trimestre.";
                    }
                }
                else
                {
                    return $"Error: Ya existe un trimestre con ese numero de trimestre en el año {trimestre.Año}.";
                }
            }
            else
            {
                return "Error: El codigo ya existe.";
            }
        }

        public string ModificarTrimestre(Trimestre trimestre)
        {
            var listaTrimestres = RepositorioTrimestres.Instancia.ListarTrimestres();
            var trimestreEncontrado = listaTrimestres.FirstOrDefault(x => x.CodTrimestre == trimestre.CodTrimestre);

            if (trimestreEncontrado != null)
            {
                bool trimestreModificado = RepositorioTrimestres.Instancia.ModificarTrimestre(trimestre);
                if (trimestreModificado == true)
                {
                    return "Trimestre modificado correctamente.";
                }
                else
                {
                    return "El trimestre no se ha podido modificar.";
                }
            }
            else
            {
                return "Error: El trimestre no existe.";
            }
        }

        public string EliminarTrimestre(Trimestre trimestre)
        {
            var listaTrimestres = RepositorioTrimestres.Instancia.ListarTrimestres();
            var trimestreEncontrado = listaTrimestres.FirstOrDefault(x => x.CodTrimestre == trimestre.CodTrimestre);

            if (trimestreEncontrado != null)
            {
                if (trimestre.NumTrimestre == 1)
                {
                    var trimestreSiguiente = listaTrimestres.FirstOrDefault(x => x.NumTrimestre == 2);
                    if (trimestreSiguiente == null) 
                    {
                        bool examenEncontradoEnTrimestre = RepositorioLibrosDeCalificaciones.Instancia.BuscarExamenEnTrimestre(1); // Valido si el trimestre a eliminar no tiene algun examen ya cargado en su numero de trimestre.
                        if (examenEncontradoEnTrimestre == false)
                        {
                            RepositorioTrimestres.Instancia.EliminarTrimestre(trimestreEncontrado);
                            return "El trimestre ha sido eliminado correctamente.";
                        }
                        else
                        {
                            return "Error: No se puede eliminar el trimestre porque hay examenes registrados en el mismo.";
                        }
                    }
                    else
                    {
                        return "Error: No se puede eliminar el trimestre N°1 porque existe el trimestre N°2";
                    }
                }
                else if (trimestre.NumTrimestre == 2)
                {
                    var trimestreSiguiente = listaTrimestres.FirstOrDefault(x => x.NumTrimestre == 3);
                    if (trimestreSiguiente == null)
                    {
                        bool examenEncontradoEnTrimestre = RepositorioLibrosDeCalificaciones.Instancia.BuscarExamenEnTrimestre(2);
                        if (examenEncontradoEnTrimestre == false)
                        {
                            RepositorioTrimestres.Instancia.EliminarTrimestre(trimestreEncontrado);
                            return "El trimestre ha sido eliminado correctamente.";
                        }
                        else
                        {
                            return "Error: No se puede eliminar el trimestre porque hay examenes registrados en el mismo.";
                        }
                    }
                    else
                    {
                        return "Error: Para eliminar el trimestre N°2 debe primero eliminar el trimestre N°3.";
                    }
                }
                else if (trimestre.NumTrimestre == 3)
                {
                    bool examenEncontradoEnTrimestre = RepositorioLibrosDeCalificaciones.Instancia.BuscarExamenEnTrimestre(3);
                    if (examenEncontradoEnTrimestre == false)
                    {
                        RepositorioTrimestres.Instancia.EliminarTrimestre(trimestreEncontrado);
                        return "El trimestre ha sido eliminado correctamente.";
                    }
                    else
                    {
                        return "Error: No se puede eliminar el trimestre porque hay examenes registrados en el mismo.";
                    }
                }
            }
            return "Error: El trimestre no existe.";
        }


        // Sirve para recuperar un trimestre según su número.
        public Trimestre RecuperarTrimestrePorNumero(int numeroTrimestre)
        {
            var listaTrimestres = RepositorioTrimestres.Instancia.ListarTrimestres();
            foreach (var trimestre in listaTrimestres)
            {
                if (trimestre.NumTrimestre== numeroTrimestre)
                {
                    return trimestre; // Retorna el trimestre encontrado.
                }
            }
            return null;
        }
    }
}
