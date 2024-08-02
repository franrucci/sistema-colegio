namespace Vista
{
    partial class FormEliminarTrimestre
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
            btnEliminarTrimestre = new Button();
            dgvTrimestres = new DataGridView();
            btnVolver = new Button();
            gBoxTrimestres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrimestres).BeginInit();
            SuspendLayout();
            // 
            // gBoxTrimestres
            // 
            gBoxTrimestres.Controls.Add(btnEliminarTrimestre);
            gBoxTrimestres.Controls.Add(dgvTrimestres);
            gBoxTrimestres.Location = new Point(12, 12);
            gBoxTrimestres.Name = "gBoxTrimestres";
            gBoxTrimestres.Size = new Size(474, 170);
            gBoxTrimestres.TabIndex = 0;
            gBoxTrimestres.TabStop = false;
            gBoxTrimestres.Text = "Trimestres";
            // 
            // btnEliminarTrimestre
            // 
            btnEliminarTrimestre.Location = new Point(197, 142);
            btnEliminarTrimestre.Name = "btnEliminarTrimestre";
            btnEliminarTrimestre.Size = new Size(75, 23);
            btnEliminarTrimestre.TabIndex = 1;
            btnEliminarTrimestre.Text = "Eliminar";
            btnEliminarTrimestre.UseVisualStyleBackColor = true;
            btnEliminarTrimestre.Click += btnEliminarTrimestre_Click;
            // 
            // dgvTrimestres
            // 
            dgvTrimestres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrimestres.Location = new Point(6, 22);
            dgvTrimestres.Name = "dgvTrimestres";
            dgvTrimestres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrimestres.Size = new Size(461, 114);
            dgvTrimestres.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(18, 188);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormEliminarTrimestre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 218);
            Controls.Add(btnVolver);
            Controls.Add(gBoxTrimestres);
            Name = "FormEliminarTrimestre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar trimestre";
            gBoxTrimestres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTrimestres).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxTrimestres;
        private Button btnEliminarTrimestre;
        private DataGridView dgvTrimestres;
        private Button btnVolver;
    }
}