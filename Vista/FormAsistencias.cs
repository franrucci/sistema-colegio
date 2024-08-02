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
    public partial class FormAsistencias : Form
    {
        Alumno alumno;
        ControladoraLibrosDeAsistencias controladoraLibrosDeAsistencias;
        Asistencia asistenciaSeleccionada;
        public FormAsistencias(Alumno alumno1)
        {
            alumno = alumno1;
            controladoraLibrosDeAsistencias = ControladoraLibrosDeAsistencias.Instancia;

            InitializeComponent();

            ActualizarGrillaAsistencias();

            this.Activated += FormAsistencias_Activated; // Cuando el form pasa a primer plano se ejecuta.
        }

        private void FormAsistencias_Activated(object sender, EventArgs e)
        {
            ActualizarGrillaAsistencias();
        }

        public void ActualizarGrillaAsistencias()
        {
            // Obtener la lista de asistencias del controlador
            var asistencias = controladoraLibrosDeAsistencias.ListarAsistencias(alumno);

            // Transformar los datos en un formato adecuado para el DataGridView
            var datosGrilla = asistencias.Select(asistencia => new
            {
                Fecha = asistencia.Fecha.ToShortDateString(),
                TipoAsistencia = asistencia.Tipo1.ToString(),
                Trimestre = asistencia.Trimestre != null ? asistencia.Trimestre.NumTrimestre.ToString() : "Desconocido"
            }).ToList();

            // Asignar la lista transformada al DataGridView
            dgvAsistencias.DataSource = null;
            dgvAsistencias.DataSource = datosGrilla;

            dgvAsistencias.Columns["TipoAsistencia"].HeaderText = "Tipo";
        }

        private void dgvAsistencias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAsistencias.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvAsistencias.SelectedRows[0];

                asistenciaSeleccionada = new Asistencia
                {
                    Fecha = DateTime.Parse(filaSeleccionada.Cells["Fecha"].Value.ToString()),
                    Tipo1 = (Asistencia.Tipo)Enum.Parse(typeof(Asistencia.Tipo), filaSeleccionada.Cells["TipoAsistencia"].Value.ToString()),
                    Trimestre = new Trimestre { NumTrimestre = Convert.ToInt32(filaSeleccionada.Cells["Trimestre"].Value) }
                };
            }
        }

        private void btnRegistrarAsistencia_Click(object sender, EventArgs e)
        {
            FormRegistrarAsistencia formRegistrarAsistencia = new FormRegistrarAsistencia(alumno);
            formRegistrarAsistencia.ShowDialog();
        }

        private void btnModificarAsistencia_Click(object sender, EventArgs e)
        {
            if (asistenciaSeleccionada != null)
            {
                // Creo una instancia del FormModificarAsistencia y pasa el examen seleccionado.
                FormModificarAsistencia formModificarAsistencia = new FormModificarAsistencia(alumno, asistenciaSeleccionada);
                formModificarAsistencia.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar una asistencia.");
            }
        }

        private void btnEliminarAsistencia_Click(object sender, EventArgs e)
        {
            if (asistenciaSeleccionada != null)
            {
                string resultado = controladoraLibrosDeAsistencias.EliminarAsistencia(alumno, asistenciaSeleccionada);
                MessageBox.Show(resultado);
                ActualizarGrillaAsistencias();
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar una asistencia.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
