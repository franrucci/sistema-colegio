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
            gBoxTrimestres = new GroupBox();
            btnEliminarTrimestre = new Button();
            btnModificarTrimestre = new Button();
            btnAgregarNuevoTrimestre = new Button();
            btnVolver = new Button();
            gBoxTrimestres.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxTrimestres
            // 
            gBoxTrimestres.Controls.Add(btnEliminarTrimestre);
            gBoxTrimestres.Controls.Add(btnModificarTrimestre);
            gBoxTrimestres.Controls.Add(btnAgregarNuevoTrimestre);
            gBoxTrimestres.Location = new Point(12, 12);
            gBoxTrimestres.Name = "gBoxTrimestres";
            gBoxTrimestres.Size = new Size(404, 285);
            gBoxTrimestres.TabIndex = 0;
            gBoxTrimestres.TabStop = false;
            // 
            // btnEliminarTrimestre
            // 
            btnEliminarTrimestre.Location = new Point(85, 199);
            btnEliminarTrimestre.Name = "btnEliminarTrimestre";
            btnEliminarTrimestre.Size = new Size(235, 50);
            btnEliminarTrimestre.TabIndex = 2;
            btnEliminarTrimestre.Text = "Eliminar trimestre";
            btnEliminarTrimestre.UseVisualStyleBackColor = true;
            btnEliminarTrimestre.Click += btnEliminarTrimestre_Click;
            // 
            // btnModificarTrimestre
            // 
            btnModificarTrimestre.Location = new Point(85, 128);
            btnModificarTrimestre.Name = "btnModificarTrimestre";
            btnModificarTrimestre.Size = new Size(235, 50);
            btnModificarTrimestre.TabIndex = 1;
            btnModificarTrimestre.Text = "Modificar trimestre";
            btnModificarTrimestre.UseVisualStyleBackColor = true;
            btnModificarTrimestre.Click += btnModificarTrimestre_Click;
            // 
            // btnAgregarNuevoTrimestre
            // 
            btnAgregarNuevoTrimestre.Location = new Point(85, 55);
            btnAgregarNuevoTrimestre.Name = "btnAgregarNuevoTrimestre";
            btnAgregarNuevoTrimestre.Size = new Size(235, 50);
            btnAgregarNuevoTrimestre.TabIndex = 0;
            btnAgregarNuevoTrimestre.Text = "Agregar nuevo trimestre";
            btnAgregarNuevoTrimestre.UseVisualStyleBackColor = true;
            btnAgregarNuevoTrimestre.Click += btnAgregarNuevoTrimestre_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 303);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormTrimestres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 333);
            Controls.Add(btnVolver);
            Controls.Add(gBoxTrimestres);
            Name = "FormTrimestres";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trimestres";
            gBoxTrimestres.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxTrimestres;
        private Button btnEliminarTrimestre;
        private Button btnModificarTrimestre;
        private Button btnAgregarNuevoTrimestre;
        private Button btnVolver;
    }
}