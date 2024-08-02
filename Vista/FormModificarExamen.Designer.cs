namespace Vista
{
    partial class FormModificarExamen
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
            gBoxModificarExamen = new GroupBox();
            btnAceptar = new Button();
            txtCodigoDeExamen = new TextBox();
            txtNota = new TextBox();
            txtTrimestre = new TextBox();
            txtTipo = new TextBox();
            txtMateria = new TextBox();
            lblCodExamen = new Label();
            lblNota = new Label();
            lblTrimestre = new Label();
            lblTipoDeExamen = new Label();
            lblMateria = new Label();
            btnCancelar = new Button();
            gBoxModificarExamen.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxModificarExamen
            // 
            gBoxModificarExamen.Controls.Add(btnAceptar);
            gBoxModificarExamen.Controls.Add(txtCodigoDeExamen);
            gBoxModificarExamen.Controls.Add(txtNota);
            gBoxModificarExamen.Controls.Add(txtTrimestre);
            gBoxModificarExamen.Controls.Add(txtTipo);
            gBoxModificarExamen.Controls.Add(txtMateria);
            gBoxModificarExamen.Controls.Add(lblCodExamen);
            gBoxModificarExamen.Controls.Add(lblNota);
            gBoxModificarExamen.Controls.Add(lblTrimestre);
            gBoxModificarExamen.Controls.Add(lblTipoDeExamen);
            gBoxModificarExamen.Controls.Add(lblMateria);
            gBoxModificarExamen.Location = new Point(12, 12);
            gBoxModificarExamen.Name = "gBoxModificarExamen";
            gBoxModificarExamen.Size = new Size(502, 270);
            gBoxModificarExamen.TabIndex = 0;
            gBoxModificarExamen.TabStop = false;
            gBoxModificarExamen.Text = "Examen";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(203, 232);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtCodigoDeExamen
            // 
            txtCodigoDeExamen.Location = new Point(122, 187);
            txtCodigoDeExamen.Name = "txtCodigoDeExamen";
            txtCodigoDeExamen.Size = new Size(126, 23);
            txtCodigoDeExamen.TabIndex = 9;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(122, 148);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(100, 23);
            txtNota.TabIndex = 8;
            // 
            // txtTrimestre
            // 
            txtTrimestre.Location = new Point(122, 112);
            txtTrimestre.Name = "txtTrimestre";
            txtTrimestre.Size = new Size(100, 23);
            txtTrimestre.TabIndex = 7;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(122, 78);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 6;
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(122, 40);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(227, 23);
            txtMateria.TabIndex = 5;
            // 
            // lblCodExamen
            // 
            lblCodExamen.AutoSize = true;
            lblCodExamen.Location = new Point(6, 190);
            lblCodExamen.Name = "lblCodExamen";
            lblCodExamen.Size = new Size(110, 15);
            lblCodExamen.TabIndex = 4;
            lblCodExamen.Text = "Codigo de examen:";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new Point(80, 151);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(36, 15);
            lblNota.TabIndex = 3;
            lblNota.Text = "Nota:";
            // 
            // lblTrimestre
            // 
            lblTrimestre.AutoSize = true;
            lblTrimestre.Location = new Point(58, 115);
            lblTrimestre.Name = "lblTrimestre";
            lblTrimestre.Size = new Size(58, 15);
            lblTrimestre.TabIndex = 2;
            lblTrimestre.Text = "Trimestre:";
            // 
            // lblTipoDeExamen
            // 
            lblTipoDeExamen.AutoSize = true;
            lblTipoDeExamen.Location = new Point(83, 81);
            lblTipoDeExamen.Name = "lblTipoDeExamen";
            lblTipoDeExamen.Size = new Size(33, 15);
            lblTipoDeExamen.TabIndex = 1;
            lblTipoDeExamen.Text = "Tipo:";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(66, 43);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(50, 15);
            lblMateria.TabIndex = 0;
            lblMateria.Text = "Materia:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(427, 288);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormModificarExamen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 318);
            Controls.Add(btnCancelar);
            Controls.Add(gBoxModificarExamen);
            Name = "FormModificarExamen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar examen";
            Load += FormModificarExamen_Load;
            gBoxModificarExamen.ResumeLayout(false);
            gBoxModificarExamen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxModificarExamen;
        private TextBox txtCodigoDeExamen;
        private TextBox txtNota;
        private TextBox txtTrimestre;
        private TextBox txtTipo;
        private TextBox txtMateria;
        private Label lblCodExamen;
        private Label lblNota;
        private Label lblTrimestre;
        private Label lblTipoDeExamen;
        private Label lblMateria;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}