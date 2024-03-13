using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public class RepositorioTrimestres
    {
        private static RepositorioTrimestres instancia;
        private List<Trimestre> trimestres;

        public RepositorioTrimestres()
        {
            trimestres = new List<Trimestre>();
        }

        public static RepositorioTrimestres Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new RepositorioTrimestres();
                }
                return instancia;
            }
        }

        public ReadOnlyCollection<Trimestre> ListarTrimestres()
        {
            return trimestres.AsReadOnly();
        }

        public int AgregarTrimestre(Trimestre trimestre)
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
                                trimestres.Add(trimestre);
                                return 2;
                            }

                        case 2:
                            var trimestre1Encontrado = trimestres.FirstOrDefault(x => x.NumTrimestre == 1);
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
                                    trimestres.Add(trimestre);
                                    return 2;
                                }
                            }

                        case 3:
                            var trimestre2Encontrado = trimestres.FirstOrDefault(x => x.NumTrimestre == 2);
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
                                    trimestres.Add(trimestre);
                                    return 2;
                                }
                            }
                        default:
                            return 1; // En caso de que el número de trimestre no sea válido.
                    }
                }
            }
        }

        public bool ModificarTrimestre(Trimestre trimestre)
        {
            // Obtengo el objeto trimestre a modificar.
            var trimestreEncontrado = trimestres.FirstOrDefault(x => x.CodTrimestre == trimestre.CodTrimestre);

            if (trimestre.DiasTotalesHabiles > 63)
            {
                return false;
            }
            else
            {
                trimestreEncontrado.DiasTotalesHabiles = trimestre.DiasTotalesHabiles;

                return true;
            }
        }

        public void EliminarTrimestre(Trimestre trimestre)
        {
            var trimestreEncontrado = trimestres.FirstOrDefault(x => x.CodTrimestre == trimestre.CodTrimestre);
            trimestres.Remove(trimestreEncontrado);
        }
    }
}