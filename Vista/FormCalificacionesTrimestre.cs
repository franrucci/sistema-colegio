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
    public partial class FormCalificacionesTrimestre : Form
    {
        List<DetalleCalificaciones> calificacionesTrimestre1;
        ControladoraLibrosDeCalificaciones controladoraLibrosDeCalificaciones;
        Alumno alumno;
        int trimestre;

        public FormCalificacionesTrimestre(List<DetalleCalificaciones> calificaciones, Alumno alumno1, int trimestre1)
        {
            InitializeComponent();
            AgregarColumnasDgvTrimestre();

            controladoraLibrosDeCalificaciones = ControladoraLibrosDeCalificaciones.Instancia;
            calificacionesTrimestre1 = calificaciones;
            alumno = alumno1;
            trimestre = trimestre1;
            ConfigurarFormTrimestre();

            MostrarCalificacionesPromedio();
        }

        private void ConfigurarFormTrimestre()
        {
            if (trimestre == 1)
            {
                this.gBoxCalificacionesTrimestre.Text = "Trimestre 1";
                this.lblPromedio.Text = "Promedio trimestre N°1: ";
            }
            else if (trimestre == 2)
            {
                this.gBoxCalificacionesTrimestre.Text = "Trimestre 2";
                this.lblPromedio.Text = "Promedio trimestre N°2: ";
            }
            else
            {
                this.gBoxCalificacionesTrimestre.Text = "Trimestre 3";
                this.lblPromedio.Text = "Promedio trimestre N°3: ";
            }
        }

        // Agrego las columnas necesarias al dgvCalificacionesTrimestre.
        private void AgregarColumnasDgvTrimestre()
        {
            dgvCalificacionesTrimestre.Columns.Add("colMateria", "Materia");
            dgvCalificacionesTrimestre.Columns.Add("colNota", "Nota");
        }

        private void MostrarCalificacionesPromedio()
        {
            // Limpio el dgvCalificacionesTrimestre.
            dgvCalificacionesTrimestre.Rows.Clear();

            // Muestro las calificaciones en el dgvCalificacionesTrimestre.
            foreach (var detalle in calificacionesTrimestre1)
            {
                dgvCalificacionesTrimestre.Rows.Add(detalle.Materia.NombreMateria, detalle.Nota);
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
