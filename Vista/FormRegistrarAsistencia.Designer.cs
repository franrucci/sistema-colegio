namespace Vista
{
    partial class FormRegistrarAsistencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gBoxAsistencia = new GroupBox();
            btnAceptar = new Button();
            cmbTrimestre = new ComboBox();
            cmbTipo = new ComboBox();
            dtpFecha = new DateTimePicker();
            txtAlumno = new TextBox();
            lblTrimestre = new Label();
            lblTipo = new Label();
            lblFecha = new Label();
            lblAlumno = new Label();
            btnCancelar = new Button();
            gBoxAsistencia.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxAsistencia
            // 
            gBoxAsistencia.Controls.Add(btnAceptar);
            gBoxAsistencia.Controls.Add(cmbTrimestre);
            gBoxAsistencia.Controls.Add(cmbTipo);
            gBoxAsistencia.Controls.Add(dtpFecha);
            gBoxAsistencia.Controls.Add(txtAlumno);
            gBoxAsistencia.Controls.Add(lblTrimestre);
            gBoxAsistencia.Controls.Add(lblTipo);
            gBoxAsistencia.Controls.Add(lblFecha);
            gBoxAsistencia.Controls.Add(lblAlumno);
            gBoxAsistencia.Location = new Point(12, 12);
            gBoxAsistencia.Name = "gBoxAsistencia";
            gBoxAsistencia.Size = new Size(542, 242);
            gBoxAsistencia.TabIndex = 0;
            gBoxAsistencia.TabStop = false;
            gBoxAsistencia.Text = "Nueva asistencia";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(219, 204);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(102, 23);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbTrimestre
            // 
            cmbTrimestre.FormattingEnabled = true;
            cmbTrimestre.Location = new Point(89, 162);
            cmbTrimestre.Name = "cmbTrimestre";
            cmbTrimestre.Size = new Size(121, 23);
            cmbTrimestre.TabIndex = 7;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(89, 123);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 6;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(89, 85);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 5;
            // 
            // txtAlumno
            // 
            txtAlumno.Location = new Point(89, 39);
            txtAlumno.Name = "txtAlumno";
            txtAlumno.Size = new Size(232, 23);
            txtAlumno.TabIndex = 4;
            // 
            // lblTrimestre
            // 
            lblTrimestre.AutoSize = true;
            lblTrimestre.Location = new Point(17, 165);
            lblTrimestre.Name = "lblTrimestre";
            lblTrimestre.Size = new Size(58, 15);
            lblTrimestre.TabIndex = 3;
            lblTrimestre.Text = "Trimestre:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(42, 126);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(33, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(42, 85);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Location = new Point(30, 42);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(53, 15);
            lblAlumno.TabIndex = 0;
            lblAlumno.Text = "Alumno:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(465, 261);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormRegistrarAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 292);
            Controls.Add(btnCancelar);
            Controls.Add(gBoxAsistencia);
            Name = "FormRegistrarAsistencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar asistencia";
            Load += FormRegistrarAsistencia_Load;
            gBoxAsistencia.ResumeLayout(false);
            gBoxAsistencia.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxAsistencia;
        private Label lblTrimestre;
        private Label lblTipo;
        private Label lblFecha;
        private Label lblAlumno;
        private Button btnAceptar;
        private ComboBox cmbTrimestre;
        private ComboBox cmbTipo;
        private DateTimePicker dtpFecha;
        private TextBox txtAlumno;
        private Button btnCancelar;
    }
}