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
    public partial class FormEliminarTrimestre : Form
    {
        ControladoraTrimestres controladoraTrimestres;
        public FormEliminarTrimestre()
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

        private void btnEliminarTrimestre_Click(object sender, EventArgs e)
        {
            if (dgvTrimestres.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvTrimestres.SelectedRows[0];

                // Obtengo el trimestre seleccionado.
                Trimestre trimestreSeleccionado = new Trimestre
                {
                    CodTrimestre = filaSeleccionada.Cells["CodTrimestre"].Value.ToString(),
                    Año = Convert.ToInt32(filaSeleccionada.Cells["Año"].Value),
                    NumTrimestre = Convert.ToInt32(filaSeleccionada.Cells["NumTrimestre"].Value),
                    DiasTotalesHabiles = Convert.ToInt32(filaSeleccionada.Cells["DiasTotalesHabiles"].Value)
                };

                string resultado = controladoraTrimestres.EliminarTrimestre(trimestreSeleccionado);
                MessageBox.Show(resultado);
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un trimestre para eliminar.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
