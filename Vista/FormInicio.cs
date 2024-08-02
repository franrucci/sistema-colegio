using Controladora;

namespace Vista
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAlumnos formAlumnos = new FormAlumnos();
            formAlumnos.Owner = this;

            formAlumnos.ShowDialog();
            this.Show();
        }

        private void btnTrimestres_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculto el formulario principal.
            FormTrimestres formTrimestres = new FormTrimestres();
            formTrimestres.Owner = this; // Establece el formulario principal como el propietario del formulario secundario

            formTrimestres.ShowDialog();
            this.Show();// Muestro nuevamente el formulario principal cuando se cierre el formulario secundario
        }
    }
}
