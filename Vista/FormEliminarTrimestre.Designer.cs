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
            this.gBoxTrimestres = new System.Windows.Forms.GroupBox();
            this.btnEliminarTrimestre = new System.Windows.Forms.Button();
            this.dgvTrimestres = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gBoxTrimestres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrimestres)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxTrimestres
            // 
            this.gBoxTrimestres.Controls.Add(this.btnEliminarTrimestre);
            this.gBoxTrimestres.Controls.Add(this.dgvTrimestres);
            this.gBoxTrimestres.Location = new System.Drawing.Point(12, 12);
            this.gBoxTrimestres.Name = "gBoxTrimestres";
            this.gBoxTrimestres.Size = new System.Drawing.Size(463, 221);
            this.gBoxTrimestres.TabIndex = 3;
            this.gBoxTrimestres.TabStop = false;
            this.gBoxTrimestres.Text = "Trimestres";
            // 
            // btnEliminarTrimestre
            // 
            this.btnEliminarTrimestre.Location = new System.Drawing.Point(175, 189);
            this.btnEliminarTrimestre.Name = "btnEliminarTrimestre";
            this.btnEliminarTrimestre.Size = new System.Drawing.Size(87, 25);
            this.btnEliminarTrimestre.TabIndex = 1;
            this.btnEliminarTrimestre.Text = "Eliminar";
            this.btnEliminarTrimestre.UseVisualStyleBackColor = true;
            this.btnEliminarTrimestre.Click += new System.EventHandler(this.btnEliminarTrimestre_Click);
            // 
            // dgvTrimestres
            // 
            this.dgvTrimestres.AllowUserToAddRows = false;
            this.dgvTrimestres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrimestres.Location = new System.Drawing.Point(6, 19);
            this.dgvTrimestres.Name = "dgvTrimestres";
            this.dgvTrimestres.ReadOnly = true;
            this.dgvTrimestres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrimestres.Size = new System.Drawing.Size(448, 150);
            this.dgvTrimestres.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(18, 260);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormEliminarTrimestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 295);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gBoxTrimestres);
            this.Name = "FormEliminarTrimestre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar trimestre";
            this.gBoxTrimestres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrimestres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gBoxTrimestres;
        private System.Windows.Forms.Button btnEliminarTrimestre;
        private System.Windows.Forms.DataGridView dgvTrimestres;
        private System.Windows.Forms.Button btnVolver;
    }
}