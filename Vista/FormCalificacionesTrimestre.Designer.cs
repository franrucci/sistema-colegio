namespace Vista
{
    partial class FormCalificacionesTrimestre
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
            gBoxCalificacionesTrimestre = new GroupBox();
            dgvCalificacionesTrimestre = new DataGridView();
            lblPromedio = new Label();
            txtPromedio = new TextBox();
            btnVolver = new Button();
            gBoxCalificacionesTrimestre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalificacionesTrimestre).BeginInit();
            SuspendLayout();
            // 
            // gBoxCalificacionesTrimestre
            // 
            gBoxCalificacionesTrimestre.Controls.Add(dgvCalificacionesTrimestre);
            gBoxCalificacionesTrimestre.Location = new Point(12, 12);
            gBoxCalificacionesTrimestre.Name = "gBoxCalificacionesTrimestre";
            gBoxCalificacionesTrimestre.Size = new Size(274, 153);
            gBoxCalificacionesTrimestre.TabIndex = 0;
            gBoxCalificacionesTrimestre.TabStop = false;
            // 
            // dgvCalificacionesTrimestre
            // 
            dgvCalificacionesTrimestre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalificacionesTrimestre.Location = new Point(6, 22);
            dgvCalificacionesTrimestre.Name = "dgvCalificacionesTrimestre";
            dgvCalificacionesTrimestre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCalificacionesTrimestre.Size = new Size(260, 125);
            dgvCalificacionesTrimestre.TabIndex = 0;
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(18, 188);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(0, 15);
            lblPromedio.TabIndex = 1;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(153, 185);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(39, 23);
            txtPromedio.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(203, 216);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormCalificacionesTrimestre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 251);
            Controls.Add(btnVolver);
            Controls.Add(txtPromedio);
            Controls.Add(lblPromedio);
            Controls.Add(gBoxCalificacionesTrimestre);
            Name = "FormCalificacionesTrimestre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calificaciones";
            gBoxCalificacionesTrimestre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCalificacionesTrimestre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gBoxCalificacionesTrimestre;
        private DataGridView dgvCalificacionesTrimestre;
        private Label lblPromedio;
        private TextBox txtPromedio;
        private Button btnVolver;
    }
}