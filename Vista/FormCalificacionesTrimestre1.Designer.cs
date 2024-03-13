namespace Vista
{
    partial class FormCalificacionesTrimestre1
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
            this.gBoxCalificacionesTrimestre1 = new System.Windows.Forms.GroupBox();
            this.dgvCalificacionesTrimestre1 = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.gBoxCalificacionesTrimestre1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificacionesTrimestre1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxCalificacionesTrimestre1
            // 
            this.gBoxCalificacionesTrimestre1.Controls.Add(this.dgvCalificacionesTrimestre1);
            this.gBoxCalificacionesTrimestre1.Location = new System.Drawing.Point(12, 12);
            this.gBoxCalificacionesTrimestre1.Name = "gBoxCalificacionesTrimestre1";
            this.gBoxCalificacionesTrimestre1.Size = new System.Drawing.Size(259, 153);
            this.gBoxCalificacionesTrimestre1.TabIndex = 0;
            this.gBoxCalificacionesTrimestre1.TabStop = false;
            this.gBoxCalificacionesTrimestre1.Text = "Trimestre N°1";
            // 
            // dgvCalificacionesTrimestre1
            // 
            this.dgvCalificacionesTrimestre1.AllowUserToAddRows = false;
            this.dgvCalificacionesTrimestre1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalificacionesTrimestre1.Location = new System.Drawing.Point(6, 19);
            this.dgvCalificacionesTrimestre1.Name = "dgvCalificacionesTrimestre1";
            this.dgvCalificacionesTrimestre1.ReadOnly = true;
            this.dgvCalificacionesTrimestre1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalificacionesTrimestre1.Size = new System.Drawing.Size(245, 115);
            this.dgvCalificacionesTrimestre1.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(196, 206);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(15, 188);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(120, 13);
            this.lblPromedio.TabIndex = 2;
            this.lblPromedio.Text = "Promedio trimestre N°1: ";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(132, 185);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(36, 20);
            this.txtPromedio.TabIndex = 3;
            // 
            // FormCalificacionesTrimestre1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 241);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gBoxCalificacionesTrimestre1);
            this.Name = "FormCalificacionesTrimestre1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calificaciones trimestre N°1";
            this.gBoxCalificacionesTrimestre1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificacionesTrimestre1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxCalificacionesTrimestre1;
        private System.Windows.Forms.DataGridView dgvCalificacionesTrimestre1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.TextBox txtPromedio;
    }
}