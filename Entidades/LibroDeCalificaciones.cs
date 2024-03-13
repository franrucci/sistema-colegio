using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LibroDeCalificaciones : LibroAlumno
    {
        private List<DetalleCalificaciones> detallesCalificaciones;
        private decimal notaTrimestre1;
        private decimal notaTrimestre2;
        private decimal notaTrimestre3;
        private decimal notaFinalAnual;

        public LibroDeCalificaciones()
        {
            detallesCalificaciones = new List<DetalleCalificaciones>();
        }

        public List<DetalleCalificaciones> DetallesCalificaciones { get => detallesCalificaciones; set => detallesCalificaciones = value; }
        public decimal NotaTrimestre1 { get => notaTrimestre1; set => notaTrimestre1 = value; }
        public decimal NotaTrimestre2 { get => notaTrimestre2; set => notaTrimestre2 = value; }
        public decimal NotaTrimestre3 { get => notaTrimestre3; set => notaTrimestre3 = value; }
        public decimal NotaFinalAnual { get => notaFinalAnual; set => notaFinalAnual = value; }

        public ReadOnlyCollection<DetalleCalificaciones> ListarDetallesCalificaciones()
        {
            return detallesCalificaciones.AsReadOnly();
        }

        public void AgregarDetalleNotaExamen(DetalleCalificaciones detalle)
        {
            detallesCalificaciones.Add(detalle);
        }

        public void ModificarDetalle(DetalleCalificaciones detalle)
        {
            var detalleEncontrado = detallesCalificaciones.FirstOrDefault(x => x.CodDetalle == detalle.CodDetalle);
            detalleEncontrado.Nota = detalle.Nota;
        }

        public void EliminarDetalle(DetalleCalificaciones detalle)
        {
            detallesCalificaciones.RemoveAll(d => d.CodDetalle == detalle.CodDetalle);
        }


        // Sirve para saber si algun examen ya fue cargado con un trimestre existente.
        public bool BuscarExamenEnTrimestre(int numDeTrimestre)
        {
            foreach (var detalle in detallesCalificaciones)
            {
                if (detalle.Examen.Trimestre.NumTrimestre == numDeTrimestre)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
