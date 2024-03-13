namespace Vista
{
    partial class FormTrimestres
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
            this.btnModificarTrimestre = new System.Windows.Forms.Button();
            this.btnEliminarTrimestre = new System.Windows.Forms.Button();
            this.btnAgregarNuevoTrimestre = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gBoxTrimestres = new System.Windows.Forms.GroupBox();
            this.gBoxTrimestres.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificarTrimestre
            // 
            this.btnModificarTrimestre.Location = new System.Drawing.Point(68, 125);
            this.btnModificarTrimestre.Name = "btnModificarTrimestre";
            this.btnModificarTrimestre.Size = new System.Drawing.Size(208, 42);
            this.btnModificarTrimestre.TabIndex = 8;
            this.btnModificarTrimestre.Text = "Modificar trimestre";
            this.btnModificarTrimestre.UseVisualStyleBackColor = true;
            this.btnModificarTrimestre.Click += new System.EventHandler(this.btnModificarTrimestre_Click);
            // 
            // btnEliminarTrimestre
            // 
            this.btnEliminarTrimestre.Location = new System.Drawing.Point(68, 192);
            this.btnEliminarTrimestre.Name = "btnEliminarTrimestre";
            this.btnEliminarTrimestre.Size = new System.Drawing.Size(208, 42);
            this.btnEliminarTrimestre.TabIndex = 7;
            this.btnEliminarTrimestre.Text = "Eliminar trimestre";
            this.btnEliminarTrimestre.UseVisualStyleBackColor = true;
            this.btnEliminarTrimestre.Click += new System.EventHandler(this.btnEliminarTrimestre_Click);
            // 
            // btnAgregarNuevoTrimestre
            // 
            this.btnAgregarNuevoTrimestre.Location = new System.Drawing.Point(68, 58);
            this.btnAgregarNuevoTrimestre.Name = "btnAgregarNuevoTrimestre";
            this.btnAgregarNuevoTrimestre.Size = new System.Drawing.Size(208, 42);
            this.btnAgregarNuevoTrimestre.TabIndex = 6;
            this.btnAgregarNuevoTrimestre.Text = "Agregar nuevo trimestre";
            this.btnAgregarNuevoTrimestre.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoTrimestre.Click += new System.EventHandler(this.btnAgregarNuevoTrimestre_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 372);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // gBoxTrimestres
            // 
            this.gBoxTrimestres.Controls.Add(this.btnAgregarNuevoTrimestre);
            this.gBoxTrimestres.Controls.Add(this.btnEliminarTrimestre);
            this.gBoxTrimestres.Controls.Add(this.btnModificarTrimestre);
            this.gBoxTrimestres.Location = new System.Drawing.Point(89, 47);
            this.gBoxTrimestres.Name = "gBoxTrimestres";
            this.gBoxTrimestres.Size = new System.Drawing.Size(328, 285);
            this.gBoxTrimestres.TabIndex = 11;
            this.gBoxTrimestres.TabStop = false;
            // 
            // FormTrimestres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 407);
            this.Controls.Add(this.gBoxTrimestres);
            this.Controls.Add(this.btnVolver);
            this.Name = "FormTrimestres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trimestres";
            this.gBoxTrimestres.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnModificarTrimestre;
        private System.Windows.Forms.Button btnEliminarTrimestre;
        private System.Windows.Forms.Button btnAgregarNuevoTrimestre;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox gBoxTrimestres;
    }
}