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
            gBoxAsistencias = new GroupBox();
            btnEliminarAsistencia = new Button();
            btnModificarAsistencia = new Button();
            btnRegistrarAsistencia = new Button();
            dgvAsistencias = new DataGridView();
            btnVolver = new Button();
            gBoxAsistencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).BeginInit();
            SuspendLayout();
            // 
            // gBoxAsistencias
            // 
            gBoxAsistencias.Controls.Add(btnEliminarAsistencia);
            gBoxAsistencias.Controls.Add(btnModificarAsistencia);
            gBoxAsistencias.Controls.Add(btnRegistrarAsistencia);
            gBoxAsistencias.Controls.Add(dgvAsistencias);
            gBoxAsistencias.Location = new Point(12, 12);
            gBoxAsistencias.Name = "gBoxAsistencias";
            gBoxAsistencias.Size = new Size(406, 325);
            gBoxAsistencias.TabIndex = 0;
            gBoxAsistencias.TabStop = false;
            gBoxAsistencias.Text = "Asistencias";
            // 
            // btnEliminarAsistencia
            // 
            btnEliminarAsistencia.Location = new Point(280, 296);
            btnEliminarAsistencia.Name = "btnEliminarAsistencia";
            btnEliminarAsistencia.Size = new Size(120, 23);
            btnEliminarAsistencia.TabIndex = 3;
            btnEliminarAsistencia.Text = "Eliminar asistencia";
            btnEliminarAsistencia.UseVisualStyleBackColor = true;
            btnEliminarAsistencia.Click += btnEliminarAsistencia_Click;
            // 
            // btnModificarAsistencia
            // 
            btnModificarAsistencia.Location = new Point(143, 296);
            btnModificarAsistencia.Name = "btnModificarAsistencia";
            btnModificarAsistencia.Size = new Size(120, 23);
            btnModificarAsistencia.TabIndex = 2;
            btnModificarAsistencia.Text = "Modificar asistencia";
            btnModificarAsistencia.UseVisualStyleBackColor = true;
            btnModificarAsistencia.Click += btnModificarAsistencia_Click;
            // 
            // btnRegistrarAsistencia
            // 
            btnRegistrarAsistencia.Location = new Point(6, 296);
            btnRegistrarAsistencia.Name = "btnRegistrarAsistencia";
            btnRegistrarAsistencia.Size = new Size(120, 23);
            btnRegistrarAsistencia.TabIndex = 1;
            btnRegistrarAsistencia.Text = "Registrar asistencia";
            btnRegistrarAsistencia.UseVisualStyleBackColor = true;
            btnRegistrarAsistencia.Click += btnRegistrarAsistencia_Click;
            // 
            // dgvAsistencias
            // 
            dgvAsistencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencias.Location = new Point(29, 22);
            dgvAsistencias.Name = "dgvAsistencias";
            dgvAsistencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAsistencias.Size = new Size(343, 259);
            dgvAsistencias.TabIndex = 0;
            dgvAsistencias.SelectionChanged += dgvAsistencias_SelectionChanged;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(18, 344);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormAsistencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 372);
            Controls.Add(btnVolver);
            Controls.Add(gBoxAsistencias);
            Name = "FormAsistencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asistencias";
            Activated += FormAsistencias_Activated;
            gBoxAsistencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxAsistencias;
        private Button btnEliminarAsistencia;
        private Button btnModificarAsistencia;
        private Button btnRegistrarAsistencia;
        private DataGridView dgvAsistencias;
        private Button btnVolver;
    }
}