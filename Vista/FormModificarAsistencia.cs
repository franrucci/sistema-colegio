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
    public partial class FormModificarAsistencia : Form
    {
        private Alumno alumno;
        private Asistencia asistencia;
        ControladoraLibrosDeAsistencias controladoraLibrosDeAsistencias;
        public FormModificarAsistencia(Alumno alumno1, Asistencia asistencia1)
        {
            InitializeComponent();
            alumno = alumno1;
            asistencia = asistencia1;

            controladoraLibrosDeAsistencias = ControladoraLibrosDeAsistencias.Instancia;
        }

        private void FormModificarAsistencia_Load(object sender, EventArgs e)
        {
            ConfigurarDatos();
        }

        private void ConfigurarDatos()
        {
            txtAlumno.Text = $"{alumno.Nombre} {alumno.Apellido}";
            txtAlumno.Enabled = false;

            dtpFecha.Value = asistencia.Fecha;
            dtpFecha.Enabled = false;

            cmbTipo.Enabled = true;

            // Agrego los tipos de asistencia al cmbTipo.
            cmbTipo.Items.Clear();
            foreach (var tipo in Enum.GetValues(typeof(Asistencia.Tipo)))
            {
                cmbTipo.Items.Add(tipo);
            }

            // Establece el tipo de asistencia actual como el elemento seleccionado en el ComboBox.
            cmbTipo.SelectedItem = asistencia.Tipo1;
            txtTrimestre.Text = asistencia.Trimestre.NumTrimestre.ToString();

            txtTrimestre.Enabled = false;
        }

        private bool ValidarDatos()
        {
            if (cmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el tipo de asistencia.");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() == true)
            {
                string resultado = controladoraLibrosDeAsistencias.ModificarAsistencia(alumno, asistencia);
                MessageBox.Show(resultado);
                this.Close();
            }
        }

        //Este metodo actualiza el valor de asistencia.Tipo1 con el nuevo tipo seleccionado en el ComboBox.
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedItem != null)
            {
                asistencia.Tipo1 = (Asistencia.Tipo)cmbTipo.SelectedItem;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
