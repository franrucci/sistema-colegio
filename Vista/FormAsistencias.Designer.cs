namespace Vista
{
    partial class FormAsistencias
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
            this.gBoxAsistencias = new System.Windows.Forms.GroupBox();
            this.btnEliminarAsistencia = new System.Windows.Forms.Button();
            this.btnModificarAsistencia = new System.Windows.Forms.Button();
            this.btnRegistrarAsistencia = new System.Windows.Forms.Button();
            this.dgvAsistencias = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gBoxAsistencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxAsistencias
            // 
            this.gBoxAsistencias.Controls.Add(this.btnEliminarAsistencia);
            this.gBoxAsistencias.Controls.Add(this.btnModificarAsistencia);
            this.gBoxAsistencias.Controls.Add(this.btnRegistrarAsistencia);
            this.gBoxAsistencias.Controls.Add(this.dgvAsistencias);
            this.gBoxAsistencias.Location = new System.Drawing.Point(12, 12);
            this.gBoxAsistencias.Name = "gBoxAsistencias";
            this.gBoxAsistencias.Size = new System.Drawing.Size(400, 271);
            this.gBoxAsistencias.TabIndex = 0;
            this.gBoxAsistencias.TabStop = false;
            this.gBoxAsistencias.Text = "Asistencias";
            // 
            // btnEliminarAsistencia
            // 
            this.btnEliminarAsistencia.Location = new System.Drawing.Point(280, 229);
            this.btnEliminarAsistencia.Name = "btnEliminarAsistencia";
            this.btnEliminarAsistencia.Size = new System.Drawing.Size(114, 23);
            this.btnEliminarAsistencia.TabIndex = 5;
            this.btnEliminarAsistencia.Text = "Eliminar asistencia";
            this.btnEliminarAsistencia.UseVisualStyleBackColor = true;
            this.btnEliminarAsistencia.Click += new System.EventHandler(this.btnEliminarAsistencia_Click);
            // 
            // btnModificarAsistencia
            // 
            this.btnModificarAsistencia.Location = new System.Drawing.Point(144, 229);
            this.btnModificarAsistencia.Name = "btnModificarAsistencia";
            this.btnModificarAsistencia.Size = new System.Drawing.Size(114, 23);
            this.btnModificarAsistencia.TabIndex = 4;
            this.btnModificarAsistencia.Text = "Modificar asistencia";
            this.btnModificarAsistencia.UseVisualStyleBackColor = true;
            this.btnModificarAsistencia.Click += new System.EventHandler(this.btnModificarAsistencia_Click);
            // 
            // btnRegistrarAsistencia
            // 
            this.btnRegistrarAsistencia.Location = new System.Drawing.Point(6, 229);
            this.btnRegistrarAsistencia.Name = "btnRegistrarAsistencia";
            this.btnRegistrarAsistencia.Size = new System.Drawing.Size(114, 23);
            this.btnRegistrarAsistencia.TabIndex = 3;
            this.btnRegistrarAsistencia.Text = "Registrar asistencia";
            this.btnRegistrarAsistencia.UseVisualStyleBackColor = true;
            this.btnRegistrarAsistencia.Click += new System.EventHandler(this.btnRegistrarAsistencia_Click);
            // 
            // dgvAsistencias
            // 
            this.dgvAsistencias.AllowUserToAddRows = false;
            this.dgvAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencias.Location = new System.Drawing.Point(6, 19);
            this.dgvAsistencias.Name = "dgvAsistencias";
            this.dgvAsistencias.ReadOnly = true;
            this.dgvAsistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsistencias.Size = new System.Drawing.Size(388, 191);
            this.dgvAsistencias.TabIndex = 0;
            this.dgvAsistencias.SelectionChanged += new System.EventHandler(this.dgvAsistencias_SelectionChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(18, 293);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 328);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gBoxAsistencias);
            this.Name = "FormAsistencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAsistencias";
            this.gBoxAsistencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxAsistencias;
        private System.Windows.Forms.DataGridView dgvAsistencias;
        private System.Windows.Forms.Button btnEliminarAsistencia;
        private System.Windows.Forms.Button btnModificarAsistencia;
        private System.Windows.Forms.Button btnRegistrarAsistencia;
        private System.Windows.Forms.Button btnVolver;
    }
}