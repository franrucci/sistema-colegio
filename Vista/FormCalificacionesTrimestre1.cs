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
    public partial class FormCalificacionesTrimestre1 : Form
    {
        List<DetalleCalificaciones> calificacionesTrimestre1;
        ControladoraLibrosDeCalificaciones controladoraLibrosDeCalificaciones;
        Alumno alumno;
        int trimestre;

        public FormCalificacionesTrimestre1(List<DetalleCalificaciones> calificaciones, Alumno alumno1, int trimestre1)
        {
            InitializeComponent();
            AgregarColumnasDgvTrimestre1();

            controladoraLibrosDeCalificaciones = ControladoraLibrosDeCalificaciones.Instancia;
            calificacionesTrimestre1 = calificaciones;
            alumno = alumno1;
            trimestre = trimestre1;

            MostrarCalificacionesPromedio();
        }

        // Agrego las columnas necesarias al dgvCalificacionesTrimestre1.
        private void AgregarColumnasDgvTrimestre1()
        {
            dgvCalificacionesTrimestre1.Columns.Add("colMateria", "Materia");
            dgvCalificacionesTrimestre1.Columns.Add("colNota", "Nota");
        }

        private void MostrarCalificacionesPromedio()
        {
            // Limpio el dgvCalificacionesTrimestre1.
            dgvCalificacionesTrimestre1.Rows.Clear();

            // Muestro las calificaciones en el dgvCalificacionesTrimestre1.
            foreach (var detalle in calificacionesTrimestre1)
            {
                dgvCalificacionesTrimestre1.Rows.Add(detalle.Materia.NombreMateria, detalle.Nota);
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
