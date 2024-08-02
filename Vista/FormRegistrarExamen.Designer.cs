namespace Vista
{
    partial class FormRegistrarExamen
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
            gBoxNuevoExamen = new GroupBox();
            btnAceptar = new Button();
            cmbTrimestre = new ComboBox();
            cmbTipo = new ComboBox();
            cmbMateria = new ComboBox();
            txtCodigoDeExamen = new TextBox();
            txtNota = new TextBox();
            txtAlumno = new TextBox();
            lblCodExamen = new Label();
            lblNota = new Label();
            lblTrimestre = new Label();
            lblTipoDeExamen = new Label();
            lblMateria = new Label();
            lblAlumno = new Label();
            btnCancelar = new Button();
            gBoxNuevoExamen.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxNuevoExamen
            // 
            gBoxNuevoExamen.Controls.Add(btnAceptar);
            gBoxNuevoExamen.Controls.Add(cmbTrimestre);
            gBoxNuevoExamen.Controls.Add(cmbTipo);
            gBoxNuevoExamen.Controls.Add(cmbMateria);
            gBoxNuevoExamen.Controls.Add(txtCodigoDeExamen);
            gBoxNuevoExamen.Controls.Add(txtNota);
            gBoxNuevoExamen.Controls.Add(txtAlumno);
            gBoxNuevoExamen.Controls.Add(lblCodExamen);
            gBoxNuevoExamen.Controls.Add(lblNota);
            gBoxNuevoExamen.Controls.Add(lblTrimestre);
            gBoxNuevoExamen.Controls.Add(lblTipoDeExamen);
            gBoxNuevoExamen.Controls.Add(lblMateria);
            gBoxNuevoExamen.Controls.Add(lblAlumno);
            gBoxNuevoExamen.Location = new Point(12, 12);
            gBoxNuevoExamen.Name = "gBoxNuevoExamen";
            gBoxNuevoExamen.Size = new Size(406, 303);
            gBoxNuevoExamen.TabIndex = 0;
            gBoxNuevoExamen.TabStop = false;
            gBoxNuevoExamen.Text = "Nuevo examen";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(160, 266);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbTrimestre
            // 
            cmbTrimestre.FormattingEnabled = true;
            cmbTrimestre.Location = new Point(83, 148);
            cmbTrimestre.Name = "cmbTrimestre";
            cmbTrimestre.Size = new Size(121, 23);
            cmbTrimestre.TabIndex = 11;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(58, 105);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 10;
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(75, 65);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(121, 23);
            cmbMateria.TabIndex = 9;
            // 
            // txtCodigoDeExamen
            // 
            txtCodigoDeExamen.Location = new Point(135, 224);
            txtCodigoDeExamen.Name = "txtCodigoDeExamen";
            txtCodigoDeExamen.Size = new Size(100, 23);
            txtCodigoDeExamen.TabIndex = 8;
            txtCodigoDeExamen.KeyPress += txtCodigoDeExamen_KeyPress;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(61, 189);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(100, 23);
            txtNota.TabIndex = 7;
            txtNota.KeyPress += txtNota_KeyPress;
            // 
            // txtAlumno
            // 
            txtAlumno.Location = new Point(78, 25);
            txtAlumno.Name = "txtAlumno";
            txtAlumno.Size = new Size(100, 23);
            txtAlumno.TabIndex = 6;
            // 
            // lblCodExamen
            // 
            lblCodExamen.AutoSize = true;
            lblCodExamen.Location = new Point(19, 227);
            lblCodExamen.Name = "lblCodExamen";
            lblCodExamen.Size = new Size(110, 15);
            lblCodExamen.TabIndex = 5;
            lblCodExamen.Text = "Codigo de examen:";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new Point(19, 189);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(36, 15);
            lblNota.TabIndex = 4;
            lblNota.Text = "Nota:";
            // 
            // lblTrimestre
            // 
            lblTrimestre.AutoSize = true;
            lblTrimestre.Location = new Point(19, 151);
            lblTrimestre.Name = "lblTrimestre";
            lblTrimestre.Size = new Size(58, 15);
            lblTrimestre.TabIndex = 3;
            lblTrimestre.Text = "Trimestre:";
            // 
            // lblTipoDeExamen
            // 
            lblTipoDeExamen.AutoSize = true;
            lblTipoDeExamen.Location = new Point(19, 108);
            lblTipoDeExamen.Name = "lblTipoDeExamen";
            lblTipoDeExamen.Size = new Size(33, 15);
            lblTipoDeExamen.TabIndex = 2;
            lblTipoDeExamen.Text = "Tipo:";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(19, 68);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(50, 15);
            lblMateria.TabIndex = 1;
            lblMateria.Text = "Materia:";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Location = new Point(19, 28);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(53, 15);
            lblAlumno.TabIndex = 0;
            lblAlumno.Text = "Alumno:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(333, 329);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormRegistrarExamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 364);
            Controls.Add(btnCancelar);
            Controls.Add(gBoxNuevoExamen);
            Name = "FormRegistrarExamen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar examen";
            Load += FormRegistrarExamen_Load;
            gBoxNuevoExamen.ResumeLayout(false);
            gBoxNuevoExamen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxNuevoExamen;
        private ComboBox cmbTrimestre;
        private ComboBox cmbTipo;
        private ComboBox cmbMateria;
        private TextBox txtCodigoDeExamen;
        private TextBox txtNota;
        private TextBox txtAlumno;
        private Label lblCodExamen;
        private Label lblNota;
        private Label lblTrimestre;
        private Label lblTipoDeExamen;
        private Label lblMateria;
        private Label lblAlumno;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}