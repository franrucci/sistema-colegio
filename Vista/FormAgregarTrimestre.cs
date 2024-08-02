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
    public partial class FormAgregarTrimestre : Form
    {
        public FormAgregarTrimestre()
        {
            InitializeComponent();
        }

        private void FormAgregarTrimestre_Load(object sender, EventArgs e)
        {
            EstablecerAñoActual(); //Establece el año actual siempre.
            InicializarComboBox();
        }

        private void EstablecerAñoActual()
        {
            // Establece el texto del TextBox con el año actual.
            txtBoxAñoTrimestre.Text = DateTime.Now.Year.ToString();

            // Deshabilita poder editar el txtBox.
            txtBoxAñoTrimestre.Enabled = false;
        }

        //Cargo los datos para que muestre el ComboBox.
        private void InicializarComboBox()
        {
            cmbNumeroTrimestre.Items.Add(1);
            cmbNumeroTrimestre.Items.Add(2);
            cmbNumeroTrimestre.Items.Add(3);
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtBoxCodigoTrimestre.Text))
            {
                MessageBox.Show("Ingrese el codigo");
                return false;
            }
            if (string.IsNullOrEmpty(txtBoxAñoTrimestre.Text))
            {
                MessageBox.Show("Ingrese el año del trimestre.");
                return false;
            }
            if (string.IsNullOrEmpty(txtBoxDiasTotalesHabiles.Text))
            {
                MessageBox.Show("Ingrese los dias totales habiles.");
                return false;
            }
            if (cmbNumeroTrimestre.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un número de trimestre.");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() == true)
            {
                Trimestre trimestre = new Trimestre();
                trimestre.CodTrimestre = txtBoxCodigoTrimestre.Text;
                trimestre.NumTrimestre = Convert.ToInt32(cmbNumeroTrimestre.SelectedItem);
                trimestre.DiasTotalesHabiles = Convert.ToInt32(txtBoxDiasTotalesHabiles.Text);
                trimestre.Año = Convert.ToInt32(txtBoxAñoTrimestre.Text);
                //trimestre.GradoId = null;

                var mensaje = ControladoraTrimestres.Instancia.AgregarNuevoTrimestre(trimestre);
                MessageBox.Show(mensaje);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxCodigoTrimestre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es una letra o un número.
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si la tecla presionada no es una letra ni un número, se desecha.
                e.Handled = true;
            }
        }

        // Valida que solo se puedan ingresar numeros en el txtBoxDiasTotalesHabiles.
        private void txtBoxDiasTotalesHabiles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
