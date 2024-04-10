using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormCalificacionesTrimestre2 : Form
    {
        List<DetalleCalificaciones> calificacionesTrimestre2;
        ControladoraLibrosDeCalificaciones controladoraLibrosDeCalificaciones;
        Alumno alumno;
        int trimestre;

        public FormCalificacionesTrimestre2(List<DetalleCalificaciones> calificaciones, Alumno alumno1, int trimestre2)
        {
            InitializeComponent();
            AgregarColumnasDgvTrimestre2();

            controladoraLibrosDeCalificaciones = ControladoraLibrosDeCalificaciones.Instancia;
            calificacionesTrimestre2 = calificaciones;
            alumno = alumno1;
            trimestre = trimestre2;

            MostrarCalificacionesPromedio();
        }

        // Agrega las columnas necesarias al dgvCalificacionesTrimestre2.
        private void AgregarColumnasDgvTrimestre2()
        {
            dgvCalificacionesTrimestre2.Columns.Add("colMateria", "Materia");
            dgvCalificacionesTrimestre2.Columns.Add("colNota", "Nota");
        }

        private void MostrarCalificacionesPromedio()
        {
            // Limpio el dgvCalificacionesTrimestre2.
            dgvCalificacionesTrimestre2.Rows.Clear();

            // Muestro las calificaciones en el dgvCalificacionesTrimestre2.
            foreach (var detalle in calificacionesTrimestre2)
            {
                dgvCalificacionesTrimestre2.Rows.Add(detalle.Materia.NombreMateria, detalle.Nota);
            }

            // Obtengo el promedio del trimestre y lo muestro en el txtPromedio
            var promedio = controladoraLibrosDeCalificaciones.ObtenerPromedioTrimestre(alumno, trimestre);
            txtPromedio.Text = promedio.ToString();
            txtPromedio.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
