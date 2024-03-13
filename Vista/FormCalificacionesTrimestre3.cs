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
    public partial class FormCalificacionesTrimestre3 : Form
    {
        List<DetalleCalificaciones> calificacionesTrimestre3;
        ControladoraLibrosDeCalificaciones controladoraLibrosDeCalificaciones;
        Alumno alumno;
        int trimestre;
        public FormCalificacionesTrimestre3(List<DetalleCalificaciones> calificaciones, Alumno alumno1, int trimestre3)
        {
            InitializeComponent();
            AgregarColumnasDgvTrimestre3();

            controladoraLibrosDeCalificaciones = ControladoraLibrosDeCalificaciones.Instancia;
            calificacionesTrimestre3 = calificaciones;
            alumno = alumno1;
            trimestre = trimestre3;

            MostrarCalificacionesPromedio();
        }

        // Agrega las columnas necesarias al dgvCalificacionesTrimestre3.
        private void AgregarColumnasDgvTrimestre3()
        {
            dgvCalificacionesTrimestre3.Columns.Add("colMateria", "Materia");
            dgvCalificacionesTrimestre3.Columns.Add("colNota", "Nota");
        }

        private void MostrarCalificacionesPromedio()
        {
            // Limpio el dgvCalificacionesTrimestre3.
            dgvCalificacionesTrimestre3.Rows.Clear();

            // Muestro las calificaciones en el dgvCalificacionesTrimestre3.
            foreach (var detalle in calificacionesTrimestre3)
            {
                dgvCalificacionesTrimestre3.Rows.Add(detalle.Materia.NombreMateria, detalle.Nota);
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
