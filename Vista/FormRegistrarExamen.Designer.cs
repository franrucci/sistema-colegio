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
            this.gBoxNuevoExamen = new System.Windows.Forms.GroupBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCodigoDeExamen = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.cmbTrimestre = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.lblCodExamen = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblTrimestre = new System.Windows.Forms.Label();
            this.lblTipoDeExamen = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gBoxNuevoExamen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxNuevoExamen
            // 
            this.gBoxNuevoExamen.Controls.Add(this.cmbMateria);
            this.gBoxNuevoExamen.Controls.Add(this.btnAceptar);
            this.gBoxNuevoExamen.Controls.Add(this.txtCodigoDeExamen);
            this.gBoxNuevoExamen.Controls.Add(this.txtNota);
            this.gBoxNuevoExamen.Controls.Add(this.cmbTrimestre);
            this.gBoxNuevoExamen.Controls.Add(this.cmbTipo);
            this.gBoxNuevoExamen.Controls.Add(this.txtAlumno);
            this.gBoxNuevoExamen.Controls.Add(this.lblCodExamen);
            this.gBoxNuevoExamen.Controls.Add(this.lblNota);
            this.gBoxNuevoExamen.Controls.Add(this.lblTrimestre);
            this.gBoxNuevoExamen.Controls.Add(this.lblTipoDeExamen);
            this.gBoxNuevoExamen.Controls.Add(this.lblMateria);
            this.gBoxNuevoExamen.Controls.Add(this.lblAlumno);
            this.gBoxNuevoExamen.Location = new System.Drawing.Point(12, 12);
            this.gBoxNuevoExamen.Name = "gBoxNuevoExamen";
            this.gBoxNuevoExamen.Size = new System.Drawing.Size(509, 311);
            this.gBoxNuevoExamen.TabIndex = 0;
            this.gBoxNuevoExamen.TabStop = false;
            this.gBoxNuevoExamen.Text = "Nuevo examen";
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(111, 79);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(240, 21);
            this.cmbMateria.TabIndex = 13;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(197, 277);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(118, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCodigoDeExamen
            // 
            this.txtCodigoDeExamen.Location = new System.Drawing.Point(111, 239);
            this.txtCodigoDeExamen.Name = "txtCodigoDeExamen";
            this.txtCodigoDeExamen.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoDeExamen.TabIndex = 11;
            this.txtCodigoDeExamen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoDeExamen_KeyPress);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(111, 200);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(121, 20);
            this.txtNota.TabIndex = 10;
            this.txtNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // cmbTrimestre
            // 
            this.cmbTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrimestre.FormattingEnabled = true;
            this.cmbTrimestre.Location = new System.Drawing.Point(111, 155);
            this.cmbTrimestre.Name = "cmbTrimestre";
            this.cmbTrimestre.Size = new System.Drawing.Size(121, 21);
            this.cmbTrimestre.TabIndex = 9;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(111, 121);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 8;
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(111, 41);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(240, 20);
            this.txtAlumno.TabIndex = 6;
            // 
            // lblCodExamen
            // 
            this.lblCodExamen.AutoSize = true;
            this.lblCodExamen.Location = new System.Drawing.Point(7, 242);
            this.lblCodExamen.Name = "lblCodExamen";
            this.lblCodExamen.Size = new System.Drawing.Size(98, 13);
            this.lblCodExamen.TabIndex = 5;
            this.lblCodExamen.Text = "Codigo de examen:";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(72, 200);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(33, 13);
            this.lblNota.TabIndex = 4;
            this.lblNota.Text = "Nota:";
            // 
            // lblTrimestre
            // 
            this.lblTrimestre.AutoSize = true;
            this.lblTrimestre.Location = new System.Drawing.Point(52, 158);
            this.lblTrimestre.Name = "lblTrimestre";
            this.lblTrimestre.Size = new System.Drawing.Size(53, 13);
            this.lblTrimestre.TabIndex = 3;
            this.lblTrimestre.Text = "Trimestre:";
            // 
            // lblTipoDeExamen
            // 
            this.lblTipoDeExamen.AutoSize = true;
            this.lblTipoDeExamen.Location = new System.Drawing.Point(72, 121);
            this.lblTipoDeExamen.Name = "lblTipoDeExamen";
            this.lblTipoDeExamen.Size = new System.Drawing.Size(31, 13);
            this.lblTipoDeExamen.TabIndex = 2;
            this.lblTipoDeExamen.Text = "Tipo:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(60, 79);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(45, 13);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "Materia:";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(60, 41);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(45, 13);
            this.lblAlumno.TabIndex = 0;
            this.lblAlumno.Text = "Alumno:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(431, 333);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormRegistrarExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 363);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gBoxNuevoExamen);
            this.Name = "FormRegistrarExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar examen";
            this.Load += new System.EventHandler(this.FormRegistrarExamen_Load);
            this.gBoxNuevoExamen.ResumeLayout(false);
            this.gBoxNuevoExamen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxNuevoExamen;
        private System.Windows.Forms.Label lblTrimestre;
        private System.Windows.Forms.Label lblTipoDeExamen;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblCodExamen;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCodigoDeExamen;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.ComboBox cmbTrimestre;
        private System.Windows.Forms.Button btnCancelar;
    }
}