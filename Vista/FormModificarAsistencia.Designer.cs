namespace Vista
{
    partial class FormModificarAsistencia
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
            gBoxModificarAsistencia = new GroupBox();
            btnAceptar = new Button();
            cmbTipo = new ComboBox();
            dtpFecha = new DateTimePicker();
            txtTrimestre = new TextBox();
            txtAlumno = new TextBox();
            lblTrimestre = new Label();
            lblTipo = new Label();
            lblFecha = new Label();
            lblAlumno = new Label();
            btnCancelar = new Button();
            gBoxModificarAsistencia.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxModificarAsistencia
            // 
            gBoxModificarAsistencia.Controls.Add(btnAceptar);
            gBoxModificarAsistencia.Controls.Add(cmbTipo);
            gBoxModificarAsistencia.Controls.Add(dtpFecha);
            gBoxModificarAsistencia.Controls.Add(txtTrimestre);
            gBoxModificarAsistencia.Controls.Add(txtAlumno);
            gBoxModificarAsistencia.Controls.Add(lblTrimestre);
            gBoxModificarAsistencia.Controls.Add(lblTipo);
            gBoxModificarAsistencia.Controls.Add(lblFecha);
            gBoxModificarAsistencia.Controls.Add(lblAlumno);
            gBoxModificarAsistencia.Location = new Point(12, 12);
            gBoxModificarAsistencia.Name = "gBoxModificarAsistencia";
            gBoxModificarAsistencia.Size = new Size(423, 250);
            gBoxModificarAsistencia.TabIndex = 0;
            gBoxModificarAsistencia.TabStop = false;
            gBoxModificarAsistencia.Text = "Modificar asistencia";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(169, 213);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(90, 125);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 7;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(90, 82);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 6;
            // 
            // txtTrimestre
            // 
            txtTrimestre.Location = new Point(90, 168);
            txtTrimestre.Name = "txtTrimestre";
            txtTrimestre.Size = new Size(100, 23);
            txtTrimestre.TabIndex = 5;
            // 
            // txtAlumno
            // 
            txtAlumno.Location = new Point(90, 38);
            txtAlumno.Name = "txtAlumno";
            txtAlumno.Size = new Size(229, 23);
            txtAlumno.TabIndex = 4;
            // 
            // lblTrimestre
            // 
            lblTrimestre.AutoSize = true;
            lblTrimestre.Location = new Point(26, 171);
            lblTrimestre.Name = "lblTrimestre";
            lblTrimestre.Size = new Size(58, 15);
            lblTrimestre.TabIndex = 3;
            lblTrimestre.Text = "Trimestre:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(51, 128);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(33, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(43, 88);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Location = new Point(31, 41);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(53, 15);
            lblAlumno.TabIndex = 0;
            lblAlumno.Text = "Alumno:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(349, 268);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormModificarAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 295);
            Controls.Add(btnCancelar);
            Controls.Add(gBoxModificarAsistencia);
            Name = "FormModificarAsistencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar asistencia";
            Load += FormModificarAsistencia_Load;
            gBoxModificarAsistencia.ResumeLayout(false);
            gBoxModificarAsistencia.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxModificarAsistencia;
        private Label lblTrimestre;
        private Label lblTipo;
        private Label lblFecha;
        private Label lblAlumno;
        private Button btnAceptar;
        private ComboBox cmbTipo;
        private DateTimePicker dtpFecha;
        private TextBox txtTrimestre;
        private TextBox txtAlumno;
        private Button btnCancelar;
    }
}