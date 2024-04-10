using Controladora;
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
    public partial class FormInicio : Form
    {
        ControladoraLibrosDeCalificaciones controladoraLibrosDeCalificaciones;
        ControladoraLibrosDeAsistencias controladoraLibrosDeAsistencias;

        public FormInicio()
        {
            InitializeComponent();
            controladoraLibrosDeCalificaciones = ControladoraLibrosDeCalificaciones.Instancia;
            controladoraLibrosDeAsistencias = ControladoraLibrosDeAsistencias.Instancia;
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            // Inicializo los libros.
            controladoraLibrosDeCalificaciones.InicializarLibrosDeCalificacion();
            controladoraLibrosDeAsistencias.InicializarLibrosDeAsistencia();
        }

        private void btnTrimestres_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculto el formulario principal.
            FormTrimestres formTrimestres = new FormTrimestres();
            formTrimestres.Owner = this; // Establece el formulario principal como el propietario del formulario secundario

            formTrimestres.ShowDialog();
            this.Show();// Muestro nuevamente el formulario principal cuando se cierre el formulario secundario

        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAlumnos formAlumnos = new FormAlumnos();
            formAlumnos.Owner = this;

            formAlumnos.ShowDialog();
            this.Show();
        }
    }
}
