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
            this.gBoxModificarExamen = new System.Windows.Forms.GroupBox();
            this.txtTrimestre = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtCodigoDeExamen = new System.Windows.Forms.TextBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblTipoDeExamen = new System.Windows.Forms.Label();
            this.lblTrimestre = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblCodExamen = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gBoxModificarExamen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxModificarExamen
            // 
            this.gBoxModificarExamen.Controls.Add(this.txtTrimestre);
            this.gBoxModificarExamen.Controls.Add(this.txtTipo);
            this.gBoxModificarExamen.Controls.Add(this.btnAceptar);
            this.gBoxModificarExamen.Controls.Add(this.txtMateria);
            this.gBoxModificarExamen.Controls.Add(this.txtCodigoDeExamen);
            this.gBoxModificarExamen.Controls.Add(this.lblMateria);
            this.gBoxModificarExamen.Controls.Add(this.txtNota);
            this.gBoxModificarExamen.Controls.Add(this.lblTipoDeExamen);
            this.gBoxModificarExamen.Controls.Add(this.lblTrimestre);
            this.gBoxModificarExamen.Controls.Add(this.lblNota);
            this.gBoxModificarExamen.Controls.Add(this.lblCodExamen);
            this.gBoxModificarExamen.Location = new System.Drawing.Point(12, 12);
            this.gBoxModificarExamen.Name = "gBoxModificarExamen";
            this.gBoxModificarExamen.Size = new System.Drawing.Size(463, 263);
            this.gBoxModificarExamen.TabIndex = 0;
            this.gBoxModificarExamen.TabStop = false;
            this.gBoxModificarExamen.Text = "Examen";
            // 
            // txtTrimestre
            // 
            this.txtTrimestre.Location = new System.Drawing.Point(112, 113);
            this.txtTrimestre.Name = "txtTrimestre";
            this.txtTrimestre.Size = new System.Drawing.Size(100, 20);
            this.txtTrimestre.TabIndex = 26;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(112, 73);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 25;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(173, 231);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(118, 23);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(112, 31);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(236, 20);
            this.txtMateria.TabIndex = 23;
            // 
            // txtCodigoDeExamen
            // 
            this.txtCodigoDeExamen.Location = new System.Drawing.Point(112, 194);
            this.txtCodigoDeExamen.Name = "txtCodigoDeExamen";
            this.txtCodigoDeExamen.Size = new System.Drawing.Size(236, 20);
            this.txtCodigoDeExamen.TabIndex = 22;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(61, 34);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(45, 13);
            this.lblMateria.TabIndex = 14;
            this.lblMateria.Text = "Materia:";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(112, 155);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(121, 20);
            this.txtNota.TabIndex = 21;
            this.txtNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // lblTipoDeExamen
            // 
            this.lblTipoDeExamen.AutoSize = true;
            this.lblTipoDeExamen.Location = new System.Drawing.Point(73, 76);
            this.lblTipoDeExamen.Name = "lblTipoDeExamen";
            this.lblTipoDeExamen.Size = new System.Drawing.Size(31, 13);
            this.lblTipoDeExamen.TabIndex = 15;
            this.lblTipoDeExamen.Text = "Tipo:";
            // 
            // lblTrimestre
            // 
            this.lblTrimestre.AutoSize = true;
            this.lblTrimestre.Location = new System.Drawing.Point(53, 113);
            this.lblTrimestre.Name = "lblTrimestre";
            this.lblTrimestre.Size = new System.Drawing.Size(53, 13);
            this.lblTrimestre.TabIndex = 16;
            this.lblTrimestre.Text = "Trimestre:";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(73, 155);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(33, 13);
            this.lblNota.TabIndex = 17;
            this.lblNota.Text = "Nota:";
            // 
            // lblCodExamen
            // 
            this.lblCodExamen.AutoSize = true;
            this.lblCodExamen.Location = new System.Drawing.Point(8, 197);
            this.lblCodExamen.Name = "lblCodExamen";
            this.lblCodExamen.Size = new System.Drawing.Size(98, 13);
            this.lblCodExamen.TabIndex = 18;
            this.lblCodExamen.Text = "Codigo de examen:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(400, 281);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormModificarExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 310);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gBoxModificarExamen);
            this.Name = "FormModificarExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar examen";
            this.Load += new System.EventHandler(this.FormModificarExamen_Load);
            this.gBoxModificarExamen.ResumeLayout(false);
            this.gBoxModificarExamen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxModificarExamen;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.TextBox txtCodigoDeExamen;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblTipoDeExamen;
        private System.Windows.Forms.Label lblTrimestre;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblCodExamen;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtTrimestre;
    }
}