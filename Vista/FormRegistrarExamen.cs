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
    public partial class FormRegistrarExamen : Form
    {
        private Alumno alumno;
        ControladoraTrimestres controladoraTrimestres;
        ControladoraLibrosDeCalificaciones controladoraLibrosDeCalificaciones;
        ControladoraAlumnos controladoraAlumnos;

        public FormRegistrarExamen(Alumno alumno1)
        {
            alumno = alumno1;
            controladoraTrimestres = ControladoraTrimestres.Instancia;
            controladoraLibrosDeCalificaciones = ControladoraLibrosDeCalificaciones.Instancia;
            controladoraAlumnos = ControladoraAlumnos.Instancia;

            InitializeComponent();
        }

        private void FormRegistrarExamen_Load(object sender, EventArgs e)
        {
            txtAlumno.Text = $"{alumno.Nombre} {alumno.Apellido}";
            txtAlumno.Enabled = false;

            //----------------------------------------------------------------------------------

            cmbMateria.DataSource = controladoraAlumnos.RetornarMateriasDeGradoDeAlumno(alumno);
            cmbMateria.DisplayMember = "NombreMateria";

            //----------------------------------------------------------------------------------

            cmbTipo.DataSource = Enum.GetValues(typeof(Examen.Tipo));

            //----------------------------------------------------------------------------------

            ConfigurarComboBoxTrimestre();
        }

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
            if (cmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el tipo de examen.");
                return false;
            }
            if (cmbTrimestre.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el numero de trimestre.");
                return false;
            }
            if (string.IsNullOrEmpty(txtNota.Text))
            {
                MessageBox.Show("Ingrese la nota.");
                return false;
            }
            if (string.IsNullOrEmpty(txtCodigoDeExamen.Text))
            {
                MessageBox.Show("Ingrese el codigo de examen.");
                return false;
            }
            return true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() == true)
            {
                DetalleCalificaciones detalle = new DetalleCalificaciones();

                detalle.CodDetalle = txtCodigoDeExamen.Text;
                detalle.Materia = (Materia)cmbMateria.SelectedItem;


                detalle.Examen = new Examen();
                detalle.Examen.Tipo1 = (Examen.Tipo)cmbTipo.SelectedItem;

                if (cmbTrimestre.SelectedItem != null && cmbTipo.SelectedItem != null)
                {
                    int numeroTrimestreSeleccionado = (int)cmbTrimestre.SelectedItem;
                    Trimestre trimestreSeleccionado = controladoraTrimestres.RecuperarTrimestrePorNumero(numeroTrimestreSeleccionado);
                    detalle.Examen.Trimestre = trimestreSeleccionado;

                    detalle.Nota = Convert.ToInt32(txtNota.Text);

                    var respuesta = controladoraLibrosDeCalificaciones.CargarNotaDeExamen(alumno, detalle);
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

        // Valida que en el txtNota solo se puedan ingresar numeros.
        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Verifica si el caracter presionado no es un número o una tecla de control.
            {
                e.Handled = true; // Si no es un número ni una tecla de control, cancela la entrada del caracter.
            }
        }

        private void txtCodigoDeExamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // Verifica si el caracter presionado no es alfanumérico o una tecla de control.
            {
                e.Handled = true; // Si no es alfanumérico ni una tecla de control, cancela la entrada del caracter.
            }
        }
    }
}
