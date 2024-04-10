namespace Vista
{
    partial class FormAgregarTrimestre
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gBoxNuevoTrimestre = new System.Windows.Forms.GroupBox();
            this.cmbNumeroTrimestre = new System.Windows.Forms.ComboBox();
            this.txtBoxDiasTotalesHabiles = new System.Windows.Forms.TextBox();
            this.txtBoxAñoTrimestre = new System.Windows.Forms.TextBox();
            this.txtBoxCodigoTrimestre = new System.Windows.Forms.TextBox();
            this.lblCodTrimestre = new System.Windows.Forms.Label();
            this.lblDiasTotalesHabiles = new System.Windows.Forms.Label();
            this.lblNumTrimestre = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.gBoxNuevoTrimestre.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 244);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(304, 244);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gBoxNuevoTrimestre
            // 
            this.gBoxNuevoTrimestre.Controls.Add(this.cmbNumeroTrimestre);
            this.gBoxNuevoTrimestre.Controls.Add(this.txtBoxDiasTotalesHabiles);
            this.gBoxNuevoTrimestre.Controls.Add(this.txtBoxAñoTrimestre);
            this.gBoxNuevoTrimestre.Controls.Add(this.txtBoxCodigoTrimestre);
            this.gBoxNuevoTrimestre.Controls.Add(this.lblCodTrimestre);
            this.gBoxNuevoTrimestre.Controls.Add(this.lblDiasTotalesHabiles);
            this.gBoxNuevoTrimestre.Controls.Add(this.lblNumTrimestre);
            this.gBoxNuevoTrimestre.Controls.Add(this.lblAño);
            this.gBoxNuevoTrimestre.Location = new System.Drawing.Point(12, 12);
            this.gBoxNuevoTrimestre.Name = "gBoxNuevoTrimestre";
            this.gBoxNuevoTrimestre.Size = new System.Drawing.Size(367, 211);
            this.gBoxNuevoTrimestre.TabIndex = 7;
            this.gBoxNuevoTrimestre.TabStop = false;
            this.gBoxNuevoTrimestre.Text = "Nuevo trimestre";
            // 
            // cmbNumeroTrimestre
            // 
            this.cmbNumeroTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumeroTrimestre.FormattingEnabled = true;
            this.cmbNumeroTrimestre.Location = new System.Drawing.Point(127, 79);
            this.cmbNumeroTrimestre.Name = "cmbNumeroTrimestre";
            this.cmbNumeroTrimestre.Size = new System.Drawing.Size(121, 21);
            this.cmbNumeroTrimestre.TabIndex = 8;
            // 
            // txtBoxDiasTotalesHabiles
            // 
            this.txtBoxDiasTotalesHabiles.Location = new System.Drawing.Point(127, 161);
            this.txtBoxDiasTotalesHabiles.Name = "txtBoxDiasTotalesHabiles";
            this.txtBoxDiasTotalesHabiles.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDiasTotalesHabiles.TabIndex = 7;
            this.txtBoxDiasTotalesHabiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxDiasTotalesHabiles_KeyPress);
            // 
            // txtBoxAñoTrimestre
            // 
            this.txtBoxAñoTrimestre.Location = new System.Drawing.Point(55, 121);
            this.txtBoxAñoTrimestre.Name = "txtBoxAñoTrimestre";
            this.txtBoxAñoTrimestre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAñoTrimestre.TabIndex = 6;
            // 
            // txtBoxCodigoTrimestre
            // 
            this.txtBoxCodigoTrimestre.Location = new System.Drawing.Point(69, 40);
            this.txtBoxCodigoTrimestre.Name = "txtBoxCodigoTrimestre";
            this.txtBoxCodigoTrimestre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCodigoTrimestre.TabIndex = 4;
            this.txtBoxCodigoTrimestre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCodigoTrimestre_KeyPress);
            // 
            // lblCodTrimestre
            // 
            this.lblCodTrimestre.AutoSize = true;
            this.lblCodTrimestre.Location = new System.Drawing.Point(20, 40);
            this.lblCodTrimestre.Name = "lblCodTrimestre";
            this.lblCodTrimestre.Size = new System.Drawing.Size(43, 13);
            this.lblCodTrimestre.TabIndex = 0;
            this.lblCodTrimestre.Text = "Codigo:";
            // 
            // lblDiasTotalesHabiles
            // 
            this.lblDiasTotalesHabiles.AutoSize = true;
            this.lblDiasTotalesHabiles.Location = new System.Drawing.Point(20, 164);
            this.lblDiasTotalesHabiles.Name = "lblDiasTotalesHabiles";
            this.lblDiasTotalesHabiles.Size = new System.Drawing.Size(101, 13);
            this.lblDiasTotalesHabiles.TabIndex = 3;
            this.lblDiasTotalesHabiles.Text = "Dias totales habiles:";
            // 
            // lblNumTrimestre
            // 
            this.lblNumTrimestre.AutoSize = true;
            this.lblNumTrimestre.Location = new System.Drawing.Point(20, 82);
            this.lblNumTrimestre.Name = "lblNumTrimestre";
            this.lblNumTrimestre.Size = new System.Drawing.Size(104, 13);
            this.lblNumTrimestre.TabIndex = 1;
            this.lblNumTrimestre.Text = "Numero de trimestre:";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(20, 124);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 13);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Año:";
            // 
            // FormAgregarTrimestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 290);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gBoxNuevoTrimestre);
            this.Name = "FormAgregarTrimestre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar trimestre";
            this.Load += new System.EventHandler(this.FormAgregarTrimestre_Load);
            this.gBoxNuevoTrimestre.ResumeLayout(false);
            this.gBoxNuevoTrimestre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gBoxNuevoTrimestre;
        private System.Windows.Forms.ComboBox cmbNumeroTrimestre;
        private System.Windows.Forms.TextBox txtBoxDiasTotalesHabiles;
        private System.Windows.Forms.TextBox txtBoxAñoTrimestre;
        private System.Windows.Forms.TextBox txtBoxCodigoTrimestre;
        private System.Windows.Forms.Label lblCodTrimestre;
        private System.Windows.Forms.Label lblDiasTotalesHabiles;
        private System.Windows.Forms.Label lblNumTrimestre;
        private System.Windows.Forms.Label lblAño;
    }
}