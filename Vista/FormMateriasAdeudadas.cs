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
    public partial class FormMateriasAdeudadas : Form
    {
        private Alumno alumno;

        public FormMateriasAdeudadas(List<Materia> materiasAdeudadas, Alumno alumno1)
        {
            InitializeComponent();
            alumno = alumno1;

            ConfigurarColumnas();
            MostrarMateriasAdeudadas(materiasAdeudadas);
        }

        private void MostrarMateriasAdeudadas(List<Materia> materiasAdeudadas)
        {
            dgvMateriasAdeudadas.AutoGenerateColumns = false;
            dgvMateriasAdeudadas.DataSource = materiasAdeudadas;
        }

        private void ConfigurarColumnas()
        {
            // Verifico si la columna ya existe
            if (dgvMateriasAdeudadas.Columns["NombreMateria"] == null)
            {
                // Si no existe, agrego la columna
                DataGridViewTextBoxColumn columnaNombreMateria = new DataGridViewTextBoxColumn();
                columnaNombreMateria.Name = "NombreMateria";
                columnaNombreMateria.HeaderText = "Materia";
                dgvMateriasAdeudadas.Columns.Add(columnaNombreMateria);
            }
            // Asigno el DataPropertyName
            dgvMateriasAdeudadas.Columns["NombreMateria"].DataPropertyName = "NombreMateria";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
