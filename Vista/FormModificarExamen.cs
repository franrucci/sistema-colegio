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
    public partial class FormModificarExamen : Form
    {
        private Alumno alumno;
        private DetalleCalificaciones examen;
        ControladoraLibrosDeCalificaciones controladoraLibrosDeCalificaciones;

        public FormModificarExamen(Alumno alumno1, DetalleCalificaciones examen1)
        {
            InitializeComponent();

            alumno = alumno1;
            examen = examen1;
            controladoraLibrosDeCalificaciones = ControladoraLibrosDeCalificaciones.Instancia;
        }

        private void FormModificarExamen_Load(object sender, EventArgs e)
        {
            ConfigurarDatos();
        }

        // Configura los datos a mostrar del formulario.
        private void ConfigurarDatos()
        {
            txtMateria.Text = examen.Materia.NombreMateria; // Muestra el nombre de la materia en el txtMateria.
            txtMateria.Enabled = false; // Deshabilita la edición del txtMateria.

            txtTipo.Text = examen.Examen.Tipo1.ToString();
            txtTipo.ReadOnly = true;

            txtTrimestre.Text = examen.Examen.Trimestre.NumTrimestre.ToString();

            txtTrimestre.ReadOnly = true;

            txtNota.Text = examen.Nota.ToString();

            // Muestra el código de examen en el TextBox y deshabilita la edición.
            txtCodigoDeExamen.Text = examen.CodDetalle;
            txtCodigoDeExamen.Enabled = false;
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNota.Text))
            {
                MessageBox.Show("Ingrese la nota.");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() == true)
            {
                examen.Nota = Convert.ToInt32(txtNota.Text); // Actualiza la nota en el detalle del examen.

                var respuesta = controladoraLibrosDeCalificaciones.ModificarNotaDeExamen(alumno, examen);

                MessageBox.Show(respuesta);

                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Valido que solo se puedan ingresar numeros en el txtNota.
        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Verifica si la tecla presionada no es un número o la tecla de retroceso
            {
                e.Handled = true; // Si no es un número, cancela el evento para evitar que se agregue al TextBox.
            }
        }
    }
}
