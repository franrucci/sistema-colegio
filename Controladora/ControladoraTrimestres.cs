using Entidades;
using Modelo;
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
        private Context context;
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

        ControladoraTrimestres()
        {
            context = new Context();
        }

        public ReadOnlyCollection<Trimestre> ListarTrimestres()
        {
            try
            {
                return context.Trimestres.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string AgregarNuevoTrimestre(Trimestre trimestre)
        {
            try
            {
                //Busco si existe algun trimestre con ese codigo.
                var trimestreEncontrado = context.Trimestres.FirstOrDefault(x => (x.CodTrimestre == trimestre.CodTrimestre));
                if (trimestreEncontrado == null)
                {
                    //Busco si existe algun trimestre con el mismo numero de trimestre en el mismo año.
                    var trimestreEncontrado1 = context.Trimestres.FirstOrDefault(x => (x.NumTrimestre == trimestre.NumTrimestre) && (x.Año == trimestre.Año));
                    if (trimestreEncontrado1 == null)
                    {
                        int trimestreAgregado = AgregarTrimestre(trimestre);
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
            catch (Exception ex)
            {
                return "Error desconocido.";
            }
        }

        public int AgregarTrimestre(Trimestre trimestre)
        {
            try
            {
                int añoActual = DateTime.Now.Year;
                if (trimestre.Año != añoActual)
                {
                    return 0;
                }
                else
                {
                    if ((trimestre.NumTrimestre != 1) && (trimestre.NumTrimestre != 2) && (trimestre.NumTrimestre != 3))
                    {
                        return 1;
                    }
                    else
                    {
                        switch (trimestre.NumTrimestre)
                        {
                            case 1:
                                if (trimestre.DiasTotalesHabiles > 63)
                                {
                                    return 4;
                                }
                                else
                                {
                                    context.Trimestres.Add(trimestre);
                                    context.SaveChanges();
                                    return 2;
                                }

                            case 2:
                                var trimestre1Encontrado = context.Trimestres.FirstOrDefault(x => x.NumTrimestre == 1);
                                if (trimestre1Encontrado == null)
                                {
                                    return 3;
                                }
                                else
                                {
                                    if (trimestre.DiasTotalesHabiles > 63)
                                    {
                                        return 4;
                                    }
                                    else
                                    {
                                        context.Trimestres.Add(trimestre);
                                        context.SaveChanges();
                                        return 2;
                                    }
                                }

                            case 3:
                                var trimestre2Encontrado = context.Trimestres.FirstOrDefault(x => x.NumTrimestre == 2);
                                if (trimestre2Encontrado == null)
                                {
                                    return 5;
                                }
                                else
                                {
                                    if (trimestre.DiasTotalesHabiles > 63)
                                    {
                                        return 4;
                                    }
                                    else
                                    {
                                        context.Trimestres.Add(trimestre);
                                        context.SaveChanges();
                                        return 2;
                                    }
                                }
                            default:
                                return 1; // Retorna 1 en caso de que el número de trimestre no sea válido.
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string ModificarTrimestre(Trimestre trimestre)
        {
            try
            {
                var trimestreEncontrado = context.Trimestres.FirstOrDefault(x => x.CodTrimestre == trimestre.CodTrimestre);

                if (trimestreEncontrado != null)
                {
                    bool trimestreModificado = ModificarTrimestreSeleccionado(trimestre);
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
            catch (Exception ex)
            {
                return "Error desconocido.";
            }
        }

        public bool ModificarTrimestreSeleccionado(Trimestre trimestre)
        {
            try
            {
                // Busco el trimestre a modificar.
                var trimestreEncontrado = context.Trimestres.FirstOrDefault(x => x.CodTrimestre == trimestre.CodTrimestre);

                if (trimestre.DiasTotalesHabiles > 63)
                {
                    return false;
                }
                else
                {
                    trimestreEncontrado.DiasTotalesHabiles = trimestre.DiasTotalesHabiles;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string EliminarTrimestre(Trimestre trimestre)
        {
            try
            {
                var trimestreEncontrado = context.Trimestres.FirstOrDefault(x => x.CodTrimestre == trimestre.CodTrimestre);

                if (trimestreEncontrado != null)
                {
                    if (trimestre.NumTrimestre == 1)
                    {
                        var trimestreSiguiente = context.Trimestres.FirstOrDefault(x => x.NumTrimestre == 2);
                        if (trimestreSiguiente == null)
                        {
                            bool examenEncontradoEnTrimestre = ControladoraLibrosDeCalificaciones.Instancia.BuscarExamenEnTrimestre(1); // Valido si el trimestre a eliminar no tiene algun examen ya cargado con ese numero de trimestre.
                            if (examenEncontradoEnTrimestre == false)
                            {
                                context.Trimestres.Remove(trimestreEncontrado);
                                context.SaveChanges();
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
                        var trimestreSiguiente = context.Trimestres.FirstOrDefault(x => x.NumTrimestre == 3);
                        if (trimestreSiguiente == null)
                        {
                            bool examenEncontradoEnTrimestre = ControladoraLibrosDeCalificaciones.Instancia.BuscarExamenEnTrimestre(2); // Valido si el trimestre a eliminar no tiene algun examen ya cargado en su numero de trimestre.
                            if (examenEncontradoEnTrimestre == false)
                            {
                                context.Trimestres.Remove(trimestreEncontrado);
                                context.SaveChanges();
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
                        bool examenEncontradoEnTrimestre = ControladoraLibrosDeCalificaciones.Instancia.BuscarExamenEnTrimestre(3); // Valido si el trimestre a eliminar no tiene algun examen ya cargado en su numero de trimestre.
                        if (examenEncontradoEnTrimestre == false)
                        {
                            context.Trimestres.Remove(trimestreEncontrado);
                            context.SaveChanges();
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
            catch (Exception ex)
            {
                return "Error desconocido.";
            }
        }

        // Sirve para recuperar un trimestre según su número.
        public Trimestre RecuperarTrimestrePorNumero(int numeroTrimestre)
        {
            try
            {
                foreach (var trimestre in context.Trimestres)
                {
                    if (trimestre.NumTrimestre == numeroTrimestre)
                    {
                        return trimestre;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}