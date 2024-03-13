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
    public partial class FormExamenes : Form
    {
        ControladoraLibrosDeCalificaciones controladoraLibrosDeCalificaciones;
        Alumno alumno;
        DetalleCalificaciones examenSeleccionado; // Es para almacenar el examen seleccionado.

        public FormExamenes(Alumno alumno1)
        {
            controladoraLibrosDeCalificaciones = ControladoraLibrosDeCalificaciones.Instancia;
            alumno = alumno1;

            InitializeComponent();
            ActualizarGrilla();

            Activated += FormExamenes_Activated; // Se llama cada vez que el form se active.
        }

        private void FormExamenes_Activated(object sender, EventArgs e)
        {
            // Actualizo la grilla de asistencias cada vez que el formulario se active
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            dgvExamenes.DataSource = null;

            // Recupero el libro de calificaciones del alumno.
            var libroDeCalificaciones = controladoraLibrosDeCalificaciones.RecuperarAlumno(alumno);

            // Creo una lista con los datos necesarios para el dgvExamenes.
            var datosGrilla = libroDeCalificaciones.DetallesCalificaciones.Select(detalle => new
            {
                detalle.CodDetalle,
                detalle.Materia.NombreMateria,
                ExamenTipo = detalle.Examen.Tipo1.ToString(),
                detalle.Nota,
                detalle.Examen.Trimestre.NumTrimestre     
            }).ToList();

            dgvExamenes.DataSource = datosGrilla;
            dgvExamenes.Refresh();
        }

        private void btnRegistrarExamen_Click(object sender, EventArgs e)
        {
            FormRegistrarExamen formRegistrarExamen = new FormRegistrarExamen(alumno);
            formRegistrarExamen.ShowDialog();
        }


        // Obtengo el examen seleccionado.
        private void dgvExamenes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvExamenes.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvExamenes.SelectedRows[0];

                examenSeleccionado = new DetalleCalificaciones();
                examenSeleccionado.CodDetalle = filaSeleccionada.Cells["CodDetalle"].Value.ToString();
                examenSeleccionado.Materia = new Materia { NombreMateria = filaSeleccionada.Cells["NombreMateria"].Value.ToString() };
                examenSeleccionado.Examen = new Examen
                {
                    Tipo1 = (Examen.Tipo)Enum.Parse(typeof(Examen.Tipo), filaSeleccionada.Cells["ExamenTipo"].Value.ToString()),
                    Trimestre = new Trimestre { NumTrimestre = Convert.ToInt32(filaSeleccionada.Cells["NumTrimestre"].Value) }
                };
                examenSeleccionado.Nota = Convert.ToInt32(filaSeleccionada.Cells["Nota"].Value);
            }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (examenSeleccionado != null)
            {
                // Creo una instancia del formModificarExamen y paso el examen seleccionado.
                FormModificarExamen formModificarExamen = new FormModificarExamen(alumno, examenSeleccionado);
                formModificarExamen.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error: Por favor, seleccione un examen antes de continuar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifico si se ha seleccionado un examen.
            if (examenSeleccionado != null)
            {
                string resultado = controladoraLibrosDeCalificaciones.EliminarExamen(alumno, examenSeleccionado);
                MessageBox.Show(resultado);

                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Error: Por favor, seleccione un examen antes de continuar.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}