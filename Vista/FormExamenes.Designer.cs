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
            this.gBoxExamenes = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrarExamen = new System.Windows.Forms.Button();
            this.dgvExamenes = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gBoxExamenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamenes)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxExamenes
            // 
            this.gBoxExamenes.Controls.Add(this.btnEliminar);
            this.gBoxExamenes.Controls.Add(this.btnModificar);
            this.gBoxExamenes.Controls.Add(this.btnRegistrarExamen);
            this.gBoxExamenes.Controls.Add(this.dgvExamenes);
            this.gBoxExamenes.Location = new System.Drawing.Point(12, 12);
            this.gBoxExamenes.Name = "gBoxExamenes";
            this.gBoxExamenes.Size = new System.Drawing.Size(557, 262);
            this.gBoxExamenes.TabIndex = 0;
            this.gBoxExamenes.TabStop = false;
            this.gBoxExamenes.Text = "Examenes";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(408, 222);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(207, 222);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(141, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar nota";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrarExamen
            // 
            this.btnRegistrarExamen.Location = new System.Drawing.Point(6, 222);
            this.btnRegistrarExamen.Name = "btnRegistrarExamen";
            this.btnRegistrarExamen.Size = new System.Drawing.Size(141, 23);
            this.btnRegistrarExamen.TabIndex = 2;
            this.btnRegistrarExamen.Text = "Registrar examen";
            this.btnRegistrarExamen.UseVisualStyleBackColor = true;
            this.btnRegistrarExamen.Click += new System.EventHandler(this.btnRegistrarExamen_Click);
            // 
            // dgvExamenes
            // 
            this.dgvExamenes.AllowUserToAddRows = false;
            this.dgvExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamenes.Location = new System.Drawing.Point(6, 19);
            this.dgvExamenes.Name = "dgvExamenes";
            this.dgvExamenes.ReadOnly = true;
            this.dgvExamenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExamenes.Size = new System.Drawing.Size(543, 181);
            this.dgvExamenes.TabIndex = 0;
            this.dgvExamenes.SelectionChanged += new System.EventHandler(this.dgvExamenes_SelectionChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(18, 292);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 327);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gBoxExamenes);
            this.Name = "FormExamenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examenes";
            this.gBoxExamenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxExamenes;
        private System.Windows.Forms.DataGridView dgvExamenes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrarExamen;
        private System.Windows.Forms.Button btnVolver;
    }
}