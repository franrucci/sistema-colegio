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
            this.gBoxTrimestres = new System.Windows.Forms.GroupBox();
            this.txtNumeroTrimestre = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDiasTotalesHabiles = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDiasTotalesHabiles = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblNumTrimestre = new System.Windows.Forms.Label();
            this.lblCodigoTrimestre = new System.Windows.Forms.Label();
            this.dgvTrimestres = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gBoxTrimestres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrimestres)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxTrimestres
            // 
            this.gBoxTrimestres.Controls.Add(this.txtNumeroTrimestre);
            this.gBoxTrimestres.Controls.Add(this.btnAceptar);
            this.gBoxTrimestres.Controls.Add(this.txtDiasTotalesHabiles);
            this.gBoxTrimestres.Controls.Add(this.txtAño);
            this.gBoxTrimestres.Controls.Add(this.txtCodigo);
            this.gBoxTrimestres.Controls.Add(this.lblDiasTotalesHabiles);
            this.gBoxTrimestres.Controls.Add(this.lblAño);
            this.gBoxTrimestres.Controls.Add(this.lblNumTrimestre);
            this.gBoxTrimestres.Controls.Add(this.lblCodigoTrimestre);
            this.gBoxTrimestres.Controls.Add(this.dgvTrimestres);
            this.gBoxTrimestres.Location = new System.Drawing.Point(12, 26);
            this.gBoxTrimestres.Name = "gBoxTrimestres";
            this.gBoxTrimestres.Size = new System.Drawing.Size(480, 351);
            this.gBoxTrimestres.TabIndex = 3;
            this.gBoxTrimestres.TabStop = false;
            this.gBoxTrimestres.Text = "Trimestres";
            // 
            // txtNumeroTrimestre
            // 
            this.txtNumeroTrimestre.Location = new System.Drawing.Point(129, 225);
            this.txtNumeroTrimestre.Name = "txtNumeroTrimestre";
            this.txtNumeroTrimestre.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroTrimestre.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(198, 312);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDiasTotalesHabiles
            // 
            this.txtDiasTotalesHabiles.Location = new System.Drawing.Point(129, 277);
            this.txtDiasTotalesHabiles.Name = "txtDiasTotalesHabiles";
            this.txtDiasTotalesHabiles.Size = new System.Drawing.Size(100, 20);
            this.txtDiasTotalesHabiles.TabIndex = 7;
            this.txtDiasTotalesHabiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiasTotalesHabiles_KeyPress);
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(57, 251);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(71, 197);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // lblDiasTotalesHabiles
            // 
            this.lblDiasTotalesHabiles.AutoSize = true;
            this.lblDiasTotalesHabiles.Location = new System.Drawing.Point(22, 279);
            this.lblDiasTotalesHabiles.Name = "lblDiasTotalesHabiles";
            this.lblDiasTotalesHabiles.Size = new System.Drawing.Size(101, 13);
            this.lblDiasTotalesHabiles.TabIndex = 4;
            this.lblDiasTotalesHabiles.Text = "Dias totales habiles:";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(22, 254);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 13);
            this.lblAño.TabIndex = 3;
            this.lblAño.Text = "Año:";
            // 
            // lblNumTrimestre
            // 
            this.lblNumTrimestre.AutoSize = true;
            this.lblNumTrimestre.Location = new System.Drawing.Point(22, 227);
            this.lblNumTrimestre.Name = "lblNumTrimestre";
            this.lblNumTrimestre.Size = new System.Drawing.Size(104, 13);
            this.lblNumTrimestre.TabIndex = 2;
            this.lblNumTrimestre.Text = "Numero de trimestre:";
            // 
            // lblCodigoTrimestre
            // 
            this.lblCodigoTrimestre.AutoSize = true;
            this.lblCodigoTrimestre.Location = new System.Drawing.Point(22, 200);
            this.lblCodigoTrimestre.Name = "lblCodigoTrimestre";
            this.lblCodigoTrimestre.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoTrimestre.TabIndex = 1;
            this.lblCodigoTrimestre.Text = "Codigo:";
            // 
            // dgvTrimestres
            // 
            this.dgvTrimestres.AllowUserToAddRows = false;
            this.dgvTrimestres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrimestres.Location = new System.Drawing.Point(6, 19);
            this.dgvTrimestres.Name = "dgvTrimestres";
            this.dgvTrimestres.ReadOnly = true;
            this.dgvTrimestres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrimestres.Size = new System.Drawing.Size(467, 150);
            this.dgvTrimestres.TabIndex = 0;
            this.dgvTrimestres.SelectionChanged += new System.EventHandler(this.dgvTrimestres_SelectionChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(18, 382);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormModificarTrimestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 417);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gBoxTrimestres);
            this.Name = "FormModificarTrimestre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar trimestre";
            this.gBoxTrimestres.ResumeLayout(false);
            this.gBoxTrimestres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrimestres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gBoxTrimestres;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtDiasTotalesHabiles;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDiasTotalesHabiles;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblNumTrimestre;
        private System.Windows.Forms.Label lblCodigoTrimestre;
        private System.Windows.Forms.DataGridView dgvTrimestres;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtNumeroTrimestre;
    }
}