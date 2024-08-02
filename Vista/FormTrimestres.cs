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
    public partial class FormTrimestres : Form
    {
        public FormTrimestres()
        {
            InitializeComponent();
        }

        private void btnAgregarNuevoTrimestre_Click(object sender, EventArgs e)
        {
            this.Hide(); //Oculta el formulario actual.

            FormAgregarTrimestre formAgregarTrimestre = new FormAgregarTrimestre();

            formAgregarTrimestre.Owner = this;// Establece el formulario actual como el propietario del formulario secundario.
            formAgregarTrimestre.ShowDialog();

            this.Show(); // Muestra nuevamente el formulario actual cuando se cierra el formulario secundario.
        }
        
        private void btnModificarTrimestre_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormModificarTrimestre formModificarTrimestre = new FormModificarTrimestre();

            formModificarTrimestre.Owner = this;
            formModificarTrimestre.ShowDialog();

            this.Show();
        }

        private void btnEliminarTrimestre_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormEliminarTrimestre formEliminarTrimestre = new FormEliminarTrimestre();

            formEliminarTrimestre.Owner = this;
            formEliminarTrimestre.ShowDialog();

            this.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
