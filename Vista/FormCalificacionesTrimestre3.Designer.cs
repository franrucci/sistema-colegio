namespace Vista
{
    partial class FormCalificacionesTrimestre3
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
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gBoxCalificacionesTrimestre3 = new System.Windows.Forms.GroupBox();
            this.dgvCalificacionesTrimestre3 = new System.Windows.Forms.DataGridView();
            this.gBoxCalificacionesTrimestre3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificacionesTrimestre3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(132, 185);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(36, 20);
            this.txtPromedio.TabIndex = 7;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(15, 188);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(120, 13);
            this.lblPromedio.TabIndex = 6;
            this.lblPromedio.Text = "Promedio trimestre N°3: ";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(200, 205);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // gBoxCalificacionesTrimestre3
            // 
            this.gBoxCalificacionesTrimestre3.Controls.Add(this.dgvCalificacionesTrimestre3);
            this.gBoxCalificacionesTrimestre3.Location = new System.Drawing.Point(12, 12);
            this.gBoxCalificacionesTrimestre3.Name = "gBoxCalificacionesTrimestre3";
            this.gBoxCalificacionesTrimestre3.Size = new System.Drawing.Size(263, 153);
            this.gBoxCalificacionesTrimestre3.TabIndex = 4;
            this.gBoxCalificacionesTrimestre3.TabStop = false;
            this.gBoxCalificacionesTrimestre3.Text = "Trimestre N°3";
            // 
            // dgvCalificacionesTrimestre3
            // 
            this.dgvCalificacionesTrimestre3.AllowUserToAddRows = false;
            this.dgvCalificacionesTrimestre3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalificacionesTrimestre3.Location = new System.Drawing.Point(6, 19);
            this.dgvCalificacionesTrimestre3.Name = "dgvCalificacionesTrimestre3";
            this.dgvCalificacionesTrimestre3.ReadOnly = true;
            this.dgvCalificacionesTrimestre3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalificacionesTrimestre3.Size = new System.Drawing.Size(247, 115);
            this.dgvCalificacionesTrimestre3.TabIndex = 0;
            // 
            // FormCalificacionesTrimestre3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 240);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gBoxCalificacionesTrimestre3);
            this.Name = "FormCalificacionesTrimestre3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calificaciones trimestre N°3";
            this.gBoxCalificacionesTrimestre3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificacionesTrimestre3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox gBoxCalificacionesTrimestre3;
        private System.Windows.Forms.DataGridView dgvCalificacionesTrimestre3;
    }
}