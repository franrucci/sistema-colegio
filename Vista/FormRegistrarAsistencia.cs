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
            var trimestres = controladoraTrimestres.ListarTrimestres();
            cmbTrimestre.Items.Clear();

            // Agrego los trimestres al cmbTrimestre.
            foreach (var trimestre in trimestres)
            {
                cmbTrimestre.Items.Add(trimestre.NumTrimestre);
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
            if (ValidarDatos())
            {
                // Crear una nueva instancia de Asistencia
                Asistencia asistencia = new Asistencia
                {
                    Tipo1 = (Asistencia.Tipo)cmbTipo.SelectedItem, // Tipo de asistencia
                    Fecha = dtpFecha.Value // Fecha de la asistencia
                };

                // Verificar que se haya seleccionado un trimestre
                if (cmbTrimestre.SelectedItem != null)
                {
                    int numeroTrimestreSeleccionado = (int)cmbTrimestre.SelectedItem;
                    Trimestre trimestreSeleccionado = controladoraTrimestres.RecuperarTrimestrePorNumero(numeroTrimestreSeleccionado);
                    asistencia.Trimestre = trimestreSeleccionado;

                    // Registrar la asistencia en el libro de asistencias
                    var respuesta = controladoraLibrosDeAsistencias.AgregarNuevaAsistencia(alumno, asistencia);
                    MessageBox.Show(respuesta);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error: No se ha seleccionado ningún trimestre.");
                }
            }
            else
            {
                MessageBox.Show("Error: Los datos proporcionados no son válidos.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
