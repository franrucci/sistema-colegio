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
    public partial class FormAlumnos : Form
    {
        ControladoraAlumnos controladoraAlumnos;
        Alumno alumnoSeleccionado;
        public FormAlumnos()
        {
            controladoraAlumnos = ControladoraAlumnos.Instancia;

            InitializeComponent();
            ActualizarGrilla();
            ConfigurarColumnas();
        }

        public void ActualizarGrilla()
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = controladoraAlumnos.ListarAlumnos();
        }

        private void ConfigurarColumnas()
        {
            dgvAlumnos.Columns["Nombre"].HeaderText = "Nombre";
            dgvAlumnos.Columns["Apellido"].HeaderText = "Apellido";
            dgvAlumnos.Columns["Dni"].HeaderText = "DNI";
            dgvAlumnos.Columns["FechaNacimiento"].HeaderText = "Fecha de Nacimiento";
            dgvAlumnos.Columns["Sexo"].HeaderText = "Sexo";
            dgvAlumnos.Columns["Domicilio"].HeaderText = "Domicilio";
            dgvAlumnos.Columns["Localidad"].HeaderText = "Localidad";
            dgvAlumnos.Columns["CodigoPostal"].HeaderText = "Código Postal";
            dgvAlumnos.Columns["Provincia"].HeaderText = "Provincia";
            dgvAlumnos.Columns["Pais"].HeaderText = "País";

            // Columnas que no se muestran.
            dgvAlumnos.Columns["FechaNacimiento"].Visible = false;
            dgvAlumnos.Columns["Grado"].Visible = false;
            dgvAlumnos.Columns["GradoId"].Visible = false;
            dgvAlumnos.Columns["AlumnoId"].Visible = false;
            dgvAlumnos.Columns["Estado"].Visible = false;
            dgvAlumnos.Columns["LibroDeCalificaciones"].Visible = false;
            dgvAlumnos.Columns["LibroDeAsistencias"].Visible = false;
        }

        // Obtengo el objeto alumno seleccionado en el dgvAlumnos.
        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvAlumnos.SelectedRows[0];
                alumnoSeleccionado = (Alumno)row.DataBoundItem;
            }
        }

        private void btnExamenes_Click(object sender, EventArgs e)
        {
            // Verifico si se ha seleccionado un alumno.
            if (alumnoSeleccionado != null)
            {
                // Creo una instancia del formulario de exámenes y paso el objeto del alumno seleccionado.
                FormExamenes formExamenes = new FormExamenes(alumnoSeleccionado);
                formExamenes.Show();
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un alumno.");
            }
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            if (alumnoSeleccionado != null)
            {
                // Creo una instancia del formulario de asistencias y paso el objeto del alumno seleccionado.
                FormAsistencias formAsistencias = new FormAsistencias(alumnoSeleccionado);
                formAsistencias.Show();
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un alumno.");
            }
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            if (alumnoSeleccionado != null)
            {
                // Creo una instancia del formInformacion y paso el objeto del alumno seleccionado.
                FormInformacion formInformacion = new FormInformacion(alumnoSeleccionado);
                formInformacion.Show();
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un alumno.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
