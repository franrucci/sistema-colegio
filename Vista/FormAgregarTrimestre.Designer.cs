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
            gBoxNuevoTrimestre = new GroupBox();
            cmbNumeroTrimestre = new ComboBox();
            txtBoxDiasTotalesHabiles = new TextBox();
            txtBoxAñoTrimestre = new TextBox();
            txtBoxCodigoTrimestre = new TextBox();
            lblDiasTotalesHabiles = new Label();
            lblAño = new Label();
            lblNumTrimestre = new Label();
            lblCodTrimestre = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            gBoxNuevoTrimestre.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxNuevoTrimestre
            // 
            gBoxNuevoTrimestre.Controls.Add(btnAceptar);
            gBoxNuevoTrimestre.Controls.Add(cmbNumeroTrimestre);
            gBoxNuevoTrimestre.Controls.Add(txtBoxDiasTotalesHabiles);
            gBoxNuevoTrimestre.Controls.Add(txtBoxAñoTrimestre);
            gBoxNuevoTrimestre.Controls.Add(txtBoxCodigoTrimestre);
            gBoxNuevoTrimestre.Controls.Add(lblDiasTotalesHabiles);
            gBoxNuevoTrimestre.Controls.Add(lblAño);
            gBoxNuevoTrimestre.Controls.Add(lblNumTrimestre);
            gBoxNuevoTrimestre.Controls.Add(lblCodTrimestre);
            gBoxNuevoTrimestre.Location = new Point(12, 12);
            gBoxNuevoTrimestre.Name = "gBoxNuevoTrimestre";
            gBoxNuevoTrimestre.Size = new Size(400, 234);
            gBoxNuevoTrimestre.TabIndex = 0;
            gBoxNuevoTrimestre.TabStop = false;
            gBoxNuevoTrimestre.Text = "Nuevo trimestre";
            // 
            // cmbNumeroTrimestre
            // 
            cmbNumeroTrimestre.FormattingEnabled = true;
            cmbNumeroTrimestre.Location = new Point(160, 75);
            cmbNumeroTrimestre.Name = "cmbNumeroTrimestre";
            cmbNumeroTrimestre.Size = new Size(121, 23);
            cmbNumeroTrimestre.TabIndex = 7;
            // 
            // txtBoxDiasTotalesHabiles
            // 
            txtBoxDiasTotalesHabiles.Location = new Point(150, 159);
            txtBoxDiasTotalesHabiles.Name = "txtBoxDiasTotalesHabiles";
            txtBoxDiasTotalesHabiles.Size = new Size(100, 23);
            txtBoxDiasTotalesHabiles.TabIndex = 6;
            txtBoxDiasTotalesHabiles.KeyPress += txtBoxDiasTotalesHabiles_KeyPress;
            // 
            // txtBoxAñoTrimestre
            // 
            txtBoxAñoTrimestre.Location = new Point(72, 118);
            txtBoxAñoTrimestre.Name = "txtBoxAñoTrimestre";
            txtBoxAñoTrimestre.Size = new Size(100, 23);
            txtBoxAñoTrimestre.TabIndex = 5;
            // 
            // txtBoxCodigoTrimestre
            // 
            txtBoxCodigoTrimestre.Location = new Point(89, 34);
            txtBoxCodigoTrimestre.Name = "txtBoxCodigoTrimestre";
            txtBoxCodigoTrimestre.Size = new Size(100, 23);
            txtBoxCodigoTrimestre.TabIndex = 4;
            txtBoxCodigoTrimestre.KeyPress += txtBoxCodigoTrimestre_KeyPress;
            // 
            // lblDiasTotalesHabiles
            // 
            lblDiasTotalesHabiles.AutoSize = true;
            lblDiasTotalesHabiles.Location = new Point(34, 162);
            lblDiasTotalesHabiles.Name = "lblDiasTotalesHabiles";
            lblDiasTotalesHabiles.Size = new Size(110, 15);
            lblDiasTotalesHabiles.TabIndex = 3;
            lblDiasTotalesHabiles.Text = "Dias totales habiles:";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(34, 121);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(32, 15);
            lblAño.TabIndex = 2;
            lblAño.Text = "Año:";
            // 
            // lblNumTrimestre
            // 
            lblNumTrimestre.AutoSize = true;
            lblNumTrimestre.Location = new Point(34, 78);
            lblNumTrimestre.Name = "lblNumTrimestre";
            lblNumTrimestre.Size = new Size(120, 15);
            lblNumTrimestre.TabIndex = 1;
            lblNumTrimestre.Text = "Numero de trimestre:";
            // 
            // lblCodTrimestre
            // 
            lblCodTrimestre.AutoSize = true;
            lblCodTrimestre.Location = new Point(34, 37);
            lblCodTrimestre.Name = "lblCodTrimestre";
            lblCodTrimestre.Size = new Size(49, 15);
            lblCodTrimestre.TabIndex = 0;
            lblCodTrimestre.Text = "Codigo:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(20, 252);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(160, 199);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FormAgregarTrimestre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 283);
            Controls.Add(btnCancelar);
            Controls.Add(gBoxNuevoTrimestre);
            Name = "FormAgregarTrimestre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar trimestre";
            Load += FormAgregarTrimestre_Load;
            gBoxNuevoTrimestre.ResumeLayout(false);
            gBoxNuevoTrimestre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxNuevoTrimestre;
        private ComboBox cmbNumeroTrimestre;
        private TextBox txtBoxDiasTotalesHabiles;
        private TextBox txtBoxAñoTrimestre;
        private TextBox txtBoxCodigoTrimestre;
        private Label lblDiasTotalesHabiles;
        private Label lblAño;
        private Label lblNumTrimestre;
        private Label lblCodTrimestre;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}