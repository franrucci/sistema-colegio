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
    public partial class FormInformacion : Form
    {
        Alumno alumno;
        ControladoraLibrosDeAsistencias controladoraLibrosDeAsistencias;
        ControladoraAlumnos controladoraAlumnos;
        LibroDeAsistencias libroDeAsistencias;

        List<DetalleCalificaciones> calificacionesTrimestre1;
        List<DetalleCalificaciones> calificacionesTrimestre2;
        List<DetalleCalificaciones> calificacionesTrimestre3;

        public FormInformacion(Alumno alumno1)
        {
            alumno = alumno1;
            controladoraLibrosDeAsistencias = ControladoraLibrosDeAsistencias.Instancia;
            controladoraAlumnos = ControladoraAlumnos.Instancia;

            calificacionesTrimestre1 = new List<DetalleCalificaciones>();
            calificacionesTrimestre2 = new List<DetalleCalificaciones>();
            calificacionesTrimestre3 = new List<DetalleCalificaciones>();

            InitializeComponent();

            ActivarMetodosDeCalificacionesPorTrimestre();
        }


        private void FormInformacion_Load(object sender, EventArgs e)
        {
            ConfigurarDatos();
        }

        private void ActivarMetodosDeCalificacionesPorTrimestre()
        {
            calificacionesTrimestre1 = ControladoraLibrosDeCalificaciones.Instancia.MostrarCalificacionesPorTrimestre(alumno, 1);
            calificacionesTrimestre2 = ControladoraLibrosDeCalificaciones.Instancia.MostrarCalificacionesPorTrimestre(alumno, 2);
            calificacionesTrimestre3 = ControladoraLibrosDeCalificaciones.Instancia.MostrarCalificacionesPorTrimestre(alumno, 3);
        }

        private void ConfigurarDatos()
        {
            var alumnoSeleccionado = controladoraAlumnos.ObtenerAlumno(alumno.AlumnoId);

            if (alumnoSeleccionado != null)
            {
                txtAlumno.Text = $"{alumnoSeleccionado.Nombre} {alumnoSeleccionado.Apellido}";
                txtAlumno.Enabled = false;

                if (alumnoSeleccionado.Grado != null)
                {
                    txtGrado.Text = alumnoSeleccionado.Grado.NumGrado.ToString();
                }
                else
                {
                    txtGrado.Text = "No disponible";
                }
                txtGrado.Enabled = false;
            }
            else
            {
                txtAlumno.Text = "No disponible";
                txtGrado.Text = string.Empty;
            }
            //--------------------------------------------------------------------------------------------------------------------

            libroDeAsistencias = controladoraLibrosDeAsistencias.RecuperarLibroAlumno(alumno);

            //--------------------------------------------------------------------------------------------------------------------

            var respuesta1 = controladoraLibrosDeAsistencias.CalcularPorcentajeAsistencia(alumno, 1);
            if (respuesta1 == true)
            {
                txtAsistenciaTrimestre1.Text = libroDeAsistencias.PorcentajeAsistenciaTrimestre1.ToString("0.##") + "%";
            }
            else
            {
                txtAsistenciaTrimestre1.Text = "No disponible";
            }
            txtAsistenciaTrimestre1.Enabled = false;


            var respuesta2 = controladoraLibrosDeAsistencias.CalcularPorcentajeAsistencia(alumno, 2);
            if (respuesta2 == true)
            {
                txtAsistenciaTrimestre2.Text = libroDeAsistencias.PorcentajeAsistenciaTrimestre2.ToString("0.##") + "%";
            }
            else
            {
                txtAsistenciaTrimestre2.Text = "No disponible";
            }
            txtAsistenciaTrimestre2.Enabled = false;


            var respuesta3 = controladoraLibrosDeAsistencias.CalcularPorcentajeAsistencia(alumno, 3);
            if (respuesta3 == true)
            {
                txtAsistenciaTrimestre3.Text = libroDeAsistencias.PorcentajeAsistenciaTrimestre3.ToString("0.##") + "%";
            }
            else
            {
                txtAsistenciaTrimestre3.Text = "No disponible";
            }
            txtAsistenciaTrimestre3.Enabled = false;

            //--------------------------------------------------------------------------------------------------------------------

            // Verifico si puedo mostrar el promedio anual.
            var respuestaPromedioAnual = ControladoraLibrosDeCalificaciones.Instancia.ObtenerPromedioAnual(alumno);
            if (respuestaPromedioAnual != 0)
            {
                if (calificacionesTrimestre1 != null && calificacionesTrimestre2 != null && calificacionesTrimestre3 != null)
                {
                    if (respuesta1 == true && respuesta2 == true && respuesta3 == true) // Valido si están calculados los porcentajes de asistencia.
                    {
                        txtPromedioAnual.Text = respuestaPromedioAnual.ToString();
                    }
                    else
                    {
                        txtPromedioAnual.Text = "No disponible";
                    }
                }
                else
                {
                    txtPromedioAnual.Text = "No disponible";
                }
            }
            else
            {
                txtPromedioAnual.Text = "No disponible";
            }
            txtPromedioAnual.Enabled = false;

            //--------------------------------------------------------------------------------------------------------------------

            // Asigno el estado del alumno.
            bool estado = ControladoraAlumnos.Instancia.AsignarEstado(alumno);
            if (calificacionesTrimestre1 != null && calificacionesTrimestre2 != null && calificacionesTrimestre3 != null)
            {
                if (estado == true)
                {
                    txtEstado.Text = alumno.Estado.ToString();
                }
                else
                {
                    txtEstado.Text = "No disponible";
                }
            }
            else
            {
                txtEstado.Text = "No disponible";
            }
            txtEstado.Enabled = false;
        }

        private void btnCalificacionesTrimestre1_Click(object sender, EventArgs e)
        {
            // calificacionesTriemstre1 es una variable del metodo ActivarMetodosDeCalificacionesPorTriemstre.
            if (calificacionesTrimestre1 != null)
            {
                // Si se obtienen las calificaciones, se abre el formulario para mostrarlas.
                FormCalificacionesTrimestre formCalificacionesTrimestre = new FormCalificacionesTrimestre(calificacionesTrimestre1, alumno, 1);
                formCalificacionesTrimestre.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error: debe registrar la nota de todas las materias en el trimestre 1.");
            }
        }

        private void button1btnCalificacionesTrimestre2_Click(object sender, EventArgs e)
        {
            // calificacionesTriemstre2 es una variable del metodo ActivarMetodosDeCalificacionesPorTriemstre.
            if (calificacionesTrimestre2 != null)
            {
                // Si se obtienen las calificaciones, se abre el formulario para mostrarlas.
                FormCalificacionesTrimestre formCalificacionesTrimestre = new FormCalificacionesTrimestre(calificacionesTrimestre2, alumno, 2);
                formCalificacionesTrimestre.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error: debe registrar la nota de todas las materias en el trimestre 2.");
            }
        }

        private void btnCalificacionesTrimestre3_Click(object sender, EventArgs e)
        {
            // calificacionesTriemstre3 es una variable del metodo ActivarMetodosDeCalificacionesPorTriemstre.
            if (calificacionesTrimestre3 != null)
            {
                // Si se obtienen las calificaciones, se abre el formulario para mostrarlas.
                FormCalificacionesTrimestre formCalificacionesTrimestre = new FormCalificacionesTrimestre(calificacionesTrimestre3, alumno, 3);
                formCalificacionesTrimestre.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error: debe registrar la nota de todas las materias en el trimestre 3.");
            }
        }

        private void btnMateriasAdeudadas_Click(object sender, EventArgs e)
        {
            var resultado = ControladoraLibrosDeCalificaciones.Instancia.DevolverMateriasAdeudadas(alumno);

            // Verifico el resultado del método DevolverMateriasAdeudadas.
            switch (resultado)
            {
                case 0:
                    MessageBox.Show("Error: No se encontró el libro de calificaciones del alumno.");
                    break;

                case 1:
                    MessageBox.Show("Error: Primero debe cargar los exámenes en los tres trimestres.");
                    break;

                case 2:
                    MessageBox.Show("El alumno no tiene materias adeudadas.");
                    break;

                default:
                    // Verifica si el resultado es una lista de materias.
                    if (resultado is List<Materia> materiasAdeudadas)
                    {
                        // Si hay materias adeudadas, abro el formulario para mostrarlas.
                        FormMateriasAdeudadas formMateriasAdeudadas = new FormMateriasAdeudadas(materiasAdeudadas, alumno);
                        formMateriasAdeudadas.ShowDialog();
                    }
                    break;
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
