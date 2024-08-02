namespace Vista
{
    partial class FormAlumnos
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
            gBoxAlumnos = new GroupBox();
            btnInformacion = new Button();
            btnAsistencias = new Button();
            btnExamenes = new Button();
            dgvAlumnos = new DataGridView();
            btnVolver = new Button();
            gBoxAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // gBoxAlumnos
            // 
            gBoxAlumnos.Controls.Add(btnInformacion);
            gBoxAlumnos.Controls.Add(btnAsistencias);
            gBoxAlumnos.Controls.Add(btnExamenes);
            gBoxAlumnos.Controls.Add(dgvAlumnos);
            gBoxAlumnos.Location = new Point(12, 12);
            gBoxAlumnos.Name = "gBoxAlumnos";
            gBoxAlumnos.Size = new Size(956, 312);
            gBoxAlumnos.TabIndex = 0;
            gBoxAlumnos.TabStop = false;
            gBoxAlumnos.Text = "Alumnos";
            // 
            // btnInformacion
            // 
            btnInformacion.Location = new Point(844, 275);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Size = new Size(105, 23);
            btnInformacion.TabIndex = 3;
            btnInformacion.Text = "Información";
            btnInformacion.UseVisualStyleBackColor = true;
            btnInformacion.Click += btnInformacion_Click;
            // 
            // btnAsistencias
            // 
            btnAsistencias.Location = new Point(457, 275);
            btnAsistencias.Name = "btnAsistencias";
            btnAsistencias.Size = new Size(105, 23);
            btnAsistencias.TabIndex = 2;
            btnAsistencias.Text = "Asistencias";
            btnAsistencias.UseVisualStyleBackColor = true;
            btnAsistencias.Click += btnAsistencias_Click;
            // 
            // btnExamenes
            // 
            btnExamenes.Location = new Point(6, 275);
            btnExamenes.Name = "btnExamenes";
            btnExamenes.Size = new Size(105, 23);
            btnExamenes.TabIndex = 1;
            btnExamenes.Text = "Examenes";
            btnExamenes.UseVisualStyleBackColor = true;
            btnExamenes.Click += btnExamenes_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(6, 22);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.Size = new Size(943, 247);
            dgvAlumnos.TabIndex = 0;
            dgvAlumnos.SelectionChanged += dgvAlumnos_SelectionChanged;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(18, 330);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 363);
            Controls.Add(btnVolver);
            Controls.Add(gBoxAlumnos);
            Name = "FormAlumnos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alumnos";
            gBoxAlumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxAlumnos;
        private Button btnInformacion;
        private Button btnAsistencias;
        private Button btnExamenes;
        private DataGridView dgvAlumnos;
        private Button btnVolver;
    }
}