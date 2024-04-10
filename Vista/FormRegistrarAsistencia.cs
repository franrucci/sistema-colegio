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
    public partial class FormRegistrarAsistencia : Form
    {
        private Alumno alumno;
        ControladoraTrimestres controladoraTrimestres;
        ControladoraLibrosDeAsistencias controladoraLibrosDeAsistencias;
        public FormRegistrarAsistencia(Alumno alumno1)
        {
            alumno = alumno1;
            controladoraTrimestres = ControladoraTrimestres.Instancia;
            controladoraLibrosDeAsistencias = ControladoraLibrosDeAsistencias.Instancia;

            InitializeComponent();
        }

        private void FormRegistrarAsistencia_Load(object sender, EventArgs e)
        {
            txtAlumno.Text = $"{alumno.Nombre} {alumno.Apellido}";
            txtAlumno.Enabled = false;

            //----------------------------------------------------------------------------------

            cmbTipo.DataSource = Enum.GetValues(typeof(Asistencia.Tipo));

            //----------------------------------------------------------------------------------

            // Establece el rango mínimo y máximo del dtpFecha para el año actual.
            dtpFecha.MinDate = new DateTime(DateTime.Now.Year, 1, 1);
            dtpFecha.MaxDate = new DateTime(DateTime.Now.Year, 12, 31);

            //----------------------------------------------------------------------------------

            ConfigurarComboBoxTrimestre();
        }

        // Configuro el cmbTrimestre con los trimestres existentes.
        private void ConfigurarComboBoxTrimestre()
        {
            // Obtengo la lista de trimestres desde la controladoraTrimestres.
            var trimestres = controladoraTrimestres.RecuperarTrimestres();

            cmbTrimestre.Items.Clear();

            foreach (var trimestre in trimestres)
            {
                cmbTrimestre.Items.Add(trimestre.NumTrimestre); // Agrega el número del trimestre.
            }
        }
        private bool ValidarDatos()
        {
            if (dtpFecha.Value.Date == DateTime.MinValue)
            {
                MessageBox.Show("Seleccione una fecha.");
                return false;
            }
            if (cmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el tipo de asistencia.");
                return false;
            }
            if (cmbTrimestre.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el trimestre.");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() == true)
            {
                Alumno alumno1 = new Alumno();
                Asistencia asistencia = new Asistencia();

                asistencia.Tipo1 = (Asistencia.Tipo)cmbTipo.SelectedItem;
                asistencia.Fecha = dtpFecha.Value;

                if (cmbTrimestre.SelectedItem != null)
                {
                    int numeroTrimestreSeleccionado = (int)cmbTrimestre.SelectedItem;
                    Trimestre trimestreSeleccionado = controladoraTrimestres.RecuperarTrimestrePorNumero(numeroTrimestreSeleccionado);
                    asistencia.Trimestre = trimestreSeleccionado; //Asigno el trimestre.

                    var respuesta = controladoraLibrosDeAsistencias.AgregarNuevaAsistencia(alumno, asistencia);
                    MessageBox.Show(respuesta);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error: No hay ningun trimestre seleccionado.");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
