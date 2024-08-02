namespace Vista
{
    partial class FormMateriasAdeudadas
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
            gBoxMateriasAdeudadas = new GroupBox();
            dgvMateriasAdeudadas = new DataGridView();
            btnVolver = new Button();
            gBoxMateriasAdeudadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMateriasAdeudadas).BeginInit();
            SuspendLayout();
            // 
            // gBoxMateriasAdeudadas
            // 
            gBoxMateriasAdeudadas.Controls.Add(dgvMateriasAdeudadas);
            gBoxMateriasAdeudadas.Location = new Point(12, 12);
            gBoxMateriasAdeudadas.Name = "gBoxMateriasAdeudadas";
            gBoxMateriasAdeudadas.Size = new Size(254, 150);
            gBoxMateriasAdeudadas.TabIndex = 0;
            gBoxMateriasAdeudadas.TabStop = false;
            gBoxMateriasAdeudadas.Text = "Materias adeudadas";
            // 
            // dgvMateriasAdeudadas
            // 
            dgvMateriasAdeudadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriasAdeudadas.Location = new Point(6, 22);
            dgvMateriasAdeudadas.Name = "dgvMateriasAdeudadas";
            dgvMateriasAdeudadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMateriasAdeudadas.Size = new Size(242, 122);
            dgvMateriasAdeudadas.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(18, 168);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormMateriasAdeudadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 199);
            Controls.Add(btnVolver);
            Controls.Add(gBoxMateriasAdeudadas);
            Name = "FormMateriasAdeudadas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Materias adeudadas";
            gBoxMateriasAdeudadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMateriasAdeudadas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxMateriasAdeudadas;
        private DataGridView dgvMateriasAdeudadas;
        private Button btnVolver;
    }
}