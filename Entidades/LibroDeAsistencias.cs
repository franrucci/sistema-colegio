using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LibroDeAsistencias : LibroAlumno
    {
        private List<Asistencia> asistencias;
        private decimal porcentajeAsistenciaTrimestre1;
        private decimal porcentajeAsistenciaTrimestre2;
        private decimal porcentajeAsistenciaTrimestre3;

        public LibroDeAsistencias()
        {
            asistencias = new List<Asistencia>();
        }

        public List<Asistencia> Asistencias { get => asistencias; set => asistencias = value; }

        public decimal PorcentajeAsistenciaTrimestre1 { get => porcentajeAsistenciaTrimestre1; set => porcentajeAsistenciaTrimestre1 = value; }
        public decimal PorcentajeAsistenciaTrimestre2 { get => porcentajeAsistenciaTrimestre2; set => porcentajeAsistenciaTrimestre2 = value; }
        public decimal PorcentajeAsistenciaTrimestre3 { get => porcentajeAsistenciaTrimestre3; set => porcentajeAsistenciaTrimestre3 = value; }

        public ReadOnlyCollection<Asistencia> ListarAsistencias()
        {
            return asistencias.AsReadOnly();
        }

        public void AgregarDetalleAsistencia(Asistencia asistencia)
        {
            asistencias.Add(asistencia);
        }

        public void ModificarDetalleAsistencia(Asistencia asistencia)
        {
            var asistenciaEncontrada = asistencias.FirstOrDefault(x => x.Fecha.Date == asistencia.Fecha.Date);
            asistenciaEncontrada.Tipo1 = asistencia.Tipo1;
        }

        public void EliminarAsistencia(Asistencia asistencia)
        {
            asistencias.RemoveAll(x => x.Fecha.Date == asistencia.Fecha.Date);
        }

        public void CalcularPorcentajeAsistencia()
        {
            decimal diasAsistidosCargadosTrimestre1 = 0;
            decimal diasAsistidosCargadosTrimestre2 = 0;
            decimal diasAsistidosCargadosTrimestre3 = 0;

            foreach (Asistencia asistencia in asistencias)
            {
                if (asistencia.Tipo1 == Asistencia.Tipo.Presente || asistencia.Tipo1 == Asistencia.Tipo.FaltaJustificada)
                {
                    if (asistencia.Trimestre.NumTrimestre == 1)
                    {
                        diasAsistidosCargadosTrimestre1 += 1;
                    }
                    else if (asistencia.Trimestre.NumTrimestre == 2)
                    {
                        diasAsistidosCargadosTrimestre2 += 1;
                    }
                    else if (asistencia.Trimestre.NumTrimestre == 3)
                    {
                        diasAsistidosCargadosTrimestre3 += 1;
                    }
                }
                else if (asistencia.Tipo1 == Asistencia.Tipo.Retiro)
                {
                    if (asistencia.Trimestre.NumTrimestre == 1)
                    {
                        diasAsistidosCargadosTrimestre1 += 0.5m;
                    }
                    else if (asistencia.Trimestre.NumTrimestre == 2)
                    {
                        diasAsistidosCargadosTrimestre2 += 0.5m;
                    }
                    else if (asistencia.Trimestre.NumTrimestre == 3)
                    {
                        diasAsistidosCargadosTrimestre3 += 0.5m;
                    }
                }
            }

            var trimestre1 = asistencias.FirstOrDefault(x => x.Trimestre.NumTrimestre == 1);
            if (trimestre1 != null)
            {
                porcentajeAsistenciaTrimestre1 = (decimal)diasAsistidosCargadosTrimestre1 / trimestre1.Trimestre.DiasTotalesHabiles * 100;
            }

            var trimestre2 = asistencias.FirstOrDefault(x => x.Trimestre.NumTrimestre == 2);
            if (trimestre2 != null)
            {
                porcentajeAsistenciaTrimestre2 = (decimal)diasAsistidosCargadosTrimestre2 / trimestre2.Trimestre.DiasTotalesHabiles * 100;
            }

            var trimestre3 = asistencias.FirstOrDefault(x => x.Trimestre.NumTrimestre == 3);
            if (trimestre3 != null)
            {
                porcentajeAsistenciaTrimestre3 = (decimal)diasAsistidosCargadosTrimestre3 / trimestre3.Trimestre.DiasTotalesHabiles * 100;
            }
        }
    }
}
