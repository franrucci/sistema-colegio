namespace Vista
{
    partial class FormCalificacionesTrimestre2
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
            this.gBoxCalificacionesTrimestre2 = new System.Windows.Forms.GroupBox();
            this.dgvCalificacionesTrimestre2 = new System.Windows.Forms.DataGridView();
            this.gBoxCalificacionesTrimestre2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificacionesTrimestre2)).BeginInit();
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
            this.lblPromedio.Text = "Promedio trimestre N°1: ";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(198, 206);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // gBoxCalificacionesTrimestre2
            // 
            this.gBoxCalificacionesTrimestre2.Controls.Add(this.dgvCalificacionesTrimestre2);
            this.gBoxCalificacionesTrimestre2.Location = new System.Drawing.Point(12, 12);
            this.gBoxCalificacionesTrimestre2.Name = "gBoxCalificacionesTrimestre2";
            this.gBoxCalificacionesTrimestre2.Size = new System.Drawing.Size(261, 153);
            this.gBoxCalificacionesTrimestre2.TabIndex = 4;
            this.gBoxCalificacionesTrimestre2.TabStop = false;
            this.gBoxCalificacionesTrimestre2.Text = "Trimestre N°2";
            // 
            // dgvCalificacionesTrimestre2
            // 
            this.dgvCalificacionesTrimestre2.AllowUserToAddRows = false;
            this.dgvCalificacionesTrimestre2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalificacionesTrimestre2.Location = new System.Drawing.Point(6, 19);
            this.dgvCalificacionesTrimestre2.Name = "dgvCalificacionesTrimestre2";
            this.dgvCalificacionesTrimestre2.ReadOnly = true;
            this.dgvCalificacionesTrimestre2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalificacionesTrimestre2.Size = new System.Drawing.Size(246, 115);
            this.dgvCalificacionesTrimestre2.TabIndex = 0;
            // 
            // FormCalificacionesTrimestre2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 241);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gBoxCalificacionesTrimestre2);
            this.Name = "FormCalificacionesTrimestre2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calificaciones trimestre N°2";
            this.gBoxCalificacionesTrimestre2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificacionesTrimestre2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox gBoxCalificacionesTrimestre2;
        private System.Windows.Forms.DataGridView dgvCalificacionesTrimestre2;
    }
}