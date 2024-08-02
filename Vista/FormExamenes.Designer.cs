namespace Vista
{
    partial class FormExamenes
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
            gBoxExamenes = new GroupBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnRegistrarExamen = new Button();
            dgvExamenes = new DataGridView();
            btnVolver = new Button();
            gBoxExamenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExamenes).BeginInit();
            SuspendLayout();
            // 
            // gBoxExamenes
            // 
            gBoxExamenes.Controls.Add(btnEliminar);
            gBoxExamenes.Controls.Add(btnModificar);
            gBoxExamenes.Controls.Add(btnRegistrarExamen);
            gBoxExamenes.Controls.Add(dgvExamenes);
            gBoxExamenes.Location = new Point(12, 12);
            gBoxExamenes.Name = "gBoxExamenes";
            gBoxExamenes.Size = new Size(576, 303);
            gBoxExamenes.TabIndex = 0;
            gBoxExamenes.TabStop = false;
            gBoxExamenes.Text = "Examenes";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(438, 268);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(213, 268);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(129, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar nota";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnRegistrarExamen
            // 
            btnRegistrarExamen.Location = new Point(6, 268);
            btnRegistrarExamen.Name = "btnRegistrarExamen";
            btnRegistrarExamen.Size = new Size(129, 23);
            btnRegistrarExamen.TabIndex = 1;
            btnRegistrarExamen.Text = "Registrar examen";
            btnRegistrarExamen.UseVisualStyleBackColor = true;
            btnRegistrarExamen.Click += btnRegistrarExamen_Click;
            // 
            // dgvExamenes
            // 
            dgvExamenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExamenes.Location = new Point(6, 22);
            dgvExamenes.Name = "dgvExamenes";
            dgvExamenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExamenes.Size = new Size(561, 226);
            dgvExamenes.TabIndex = 0;
            dgvExamenes.SelectionChanged += dgvExamenes_SelectionChanged;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(18, 321);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormExamenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 354);
            Controls.Add(btnVolver);
            Controls.Add(gBoxExamenes);
            Name = "FormExamenes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Examenes";
            Activated += FormExamenes_Activated;
            gBoxExamenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExamenes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxExamenes;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnRegistrarExamen;
        private DataGridView dgvExamenes;
        private Button btnVolver;
    }
}