namespace Vista
{
    partial class FormModificarTrimestre
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
            gBoxTrimestres = new GroupBox();
            btnAceptar = new Button();
            txtDiasTotalesHabiles = new TextBox();
            txtAño = new TextBox();
            txtNumeroTrimestre = new TextBox();
            txtCodigo = new TextBox();
            lblDiasTotalesHabiles = new Label();
            lblAño = new Label();
            lblNumTrimestre = new Label();
            lblCodigoTrimestre = new Label();
            dgvTrimestres = new DataGridView();
            btnVolver = new Button();
            gBoxTrimestres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrimestres).BeginInit();
            SuspendLayout();
            // 
            // gBoxTrimestres
            // 
            gBoxTrimestres.Controls.Add(btnAceptar);
            gBoxTrimestres.Controls.Add(txtDiasTotalesHabiles);
            gBoxTrimestres.Controls.Add(txtAño);
            gBoxTrimestres.Controls.Add(txtNumeroTrimestre);
            gBoxTrimestres.Controls.Add(txtCodigo);
            gBoxTrimestres.Controls.Add(lblDiasTotalesHabiles);
            gBoxTrimestres.Controls.Add(lblAño);
            gBoxTrimestres.Controls.Add(lblNumTrimestre);
            gBoxTrimestres.Controls.Add(lblCodigoTrimestre);
            gBoxTrimestres.Controls.Add(dgvTrimestres);
            gBoxTrimestres.Location = new Point(12, 12);
            gBoxTrimestres.Name = "gBoxTrimestres";
            gBoxTrimestres.Size = new Size(455, 350);
            gBoxTrimestres.TabIndex = 0;
            gBoxTrimestres.TabStop = false;
            gBoxTrimestres.Text = "Trimestres";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(189, 321);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtDiasTotalesHabiles
            // 
            txtDiasTotalesHabiles.Location = new Point(132, 286);
            txtDiasTotalesHabiles.Name = "txtDiasTotalesHabiles";
            txtDiasTotalesHabiles.Size = new Size(132, 23);
            txtDiasTotalesHabiles.TabIndex = 8;
            txtDiasTotalesHabiles.KeyPress += txtDiasTotalesHabiles_KeyPress;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(54, 258);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(132, 23);
            txtAño.TabIndex = 7;
            // 
            // txtNumeroTrimestre
            // 
            txtNumeroTrimestre.Location = new Point(142, 226);
            txtNumeroTrimestre.Name = "txtNumeroTrimestre";
            txtNumeroTrimestre.Size = new Size(132, 23);
            txtNumeroTrimestre.TabIndex = 6;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(71, 196);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(132, 23);
            txtCodigo.TabIndex = 5;
            // 
            // lblDiasTotalesHabiles
            // 
            lblDiasTotalesHabiles.AutoSize = true;
            lblDiasTotalesHabiles.Location = new Point(16, 289);
            lblDiasTotalesHabiles.Name = "lblDiasTotalesHabiles";
            lblDiasTotalesHabiles.Size = new Size(110, 15);
            lblDiasTotalesHabiles.TabIndex = 4;
            lblDiasTotalesHabiles.Text = "Dias totales habiles:";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(16, 261);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(32, 15);
            lblAño.TabIndex = 3;
            lblAño.Text = "Año:";
            // 
            // lblNumTrimestre
            // 
            lblNumTrimestre.AutoSize = true;
            lblNumTrimestre.Location = new Point(16, 229);
            lblNumTrimestre.Name = "lblNumTrimestre";
            lblNumTrimestre.Size = new Size(120, 15);
            lblNumTrimestre.TabIndex = 2;
            lblNumTrimestre.Text = "Numero de trimestre:";
            // 
            // lblCodigoTrimestre
            // 
            lblCodigoTrimestre.AutoSize = true;
            lblCodigoTrimestre.Location = new Point(16, 199);
            lblCodigoTrimestre.Name = "lblCodigoTrimestre";
            lblCodigoTrimestre.Size = new Size(49, 15);
            lblCodigoTrimestre.TabIndex = 1;
            lblCodigoTrimestre.Text = "Codigo:";
            // 
            // dgvTrimestres
            // 
            dgvTrimestres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrimestres.Location = new Point(6, 22);
            dgvTrimestres.Name = "dgvTrimestres";
            dgvTrimestres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrimestres.Size = new Size(443, 158);
            dgvTrimestres.TabIndex = 0;
            dgvTrimestres.SelectionChanged += dgvTrimestres_SelectionChanged;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(18, 368);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormModificarTrimestre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 403);
            Controls.Add(btnVolver);
            Controls.Add(gBoxTrimestres);
            Name = "FormModificarTrimestre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar trimestre";
            gBoxTrimestres.ResumeLayout(false);
            gBoxTrimestres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrimestres).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxTrimestres;
        private Label lblDiasTotalesHabiles;
        private Label lblAño;
        private Label lblNumTrimestre;
        private Label lblCodigoTrimestre;
        private DataGridView dgvTrimestres;
        private Button btnAceptar;
        private TextBox txtDiasTotalesHabiles;
        private TextBox txtAño;
        private TextBox txtNumeroTrimestre;
        private TextBox txtCodigo;
        private Button btnVolver;
    }
}