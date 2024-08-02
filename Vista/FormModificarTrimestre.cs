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
    public partial class FormModificarTrimestre : Form
    {
        ControladoraTrimestres controladoraTrimestres;
        public FormModificarTrimestre()
        {
            controladoraTrimestres = ControladoraTrimestres.Instancia;

            InitializeComponent();
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            dgvTrimestres.DataSource = null;
            dgvTrimestres.DataSource = controladoraTrimestres.ListarTrimestres();

            // Columnas visibles.
            dgvTrimestres.Columns["CodTrimestre"].HeaderText = "Codigo";
            dgvTrimestres.Columns["NumTrimestre"].HeaderText = "Numero";
            dgvTrimestres.Columns["DiasTotalesHabiles"].HeaderText = "Dias totales habiles";

            // Columnas que no se muestran.
            dgvTrimestres.Columns["TrimestreId"].Visible = false;
        }

        //Obtengo los datos del objeto seleccionado en el dgv para completar los txt y modificarlos.
        private void dgvTrimestres_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTrimestres.SelectedRows.Count > 0)
            {
                // Obtengo la fila seleccionada.
                DataGridViewRow filaSeleccionada = dgvTrimestres.SelectedRows[0];

                // Obtengo los valores de las celdas y los coloco en los TextBox.
                txtCodigo.Text = filaSeleccionada.Cells["CodTrimestre"].Value.ToString();
                txtAño.Text = filaSeleccionada.Cells["Año"].Value.ToString();
                txtDiasTotalesHabiles.Text = filaSeleccionada.Cells["DiasTotalesHabiles"].Value.ToString();
                txtNumeroTrimestre.Text = filaSeleccionada.Cells["NumTrimestre"].Value.ToString();

                // Obtengo el valor seleccionado del ComboBox.
                string valorSeleccionado = filaSeleccionada.Cells["NumTrimestre"].Value.ToString();

                txtCodigo.ReadOnly = true;
                txtAño.ReadOnly = true;
                txtNumeroTrimestre.ReadOnly = true;
                txtDiasTotalesHabiles.ReadOnly = false;
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtDiasTotalesHabiles.Text))
            {
                MessageBox.Show("Ingrese los dias totales habiles.");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvTrimestres.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvTrimestres.SelectedRows[0];
                if (ValidarDatos() == true)
                {
                    // Creo un objeto Trimestre con los datos actualizados.
                    Trimestre trimestreModificado = new Trimestre
                    {
                        CodTrimestre = txtCodigo.Text,
                        Año = int.Parse(txtAño.Text),
                        NumTrimestre = Convert.ToInt32(txtNumeroTrimestre.Text),
                        DiasTotalesHabiles = int.Parse(txtDiasTotalesHabiles.Text),
                        //GradoId = null
                    };
                    string resultado = controladoraTrimestres.ModificarTrimestre(trimestreModificado);
                    MessageBox.Show(resultado);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Error: Por favor seleccione un trimestre para modificar.");
            }
        }

        //Valida que solo se ingresen numeros al txtDiasTotalesHabiles.
        private void txtDiasTotalesHabiles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
