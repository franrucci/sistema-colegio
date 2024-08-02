namespace Vista
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gBoxInicio = new GroupBox();
            btnTrimestres = new Button();
            btnAlumnos = new Button();
            gBoxInicio.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxInicio
            // 
            gBoxInicio.Controls.Add(btnTrimestres);
            gBoxInicio.Controls.Add(btnAlumnos);
            gBoxInicio.Location = new Point(12, 12);
            gBoxInicio.Name = "gBoxInicio";
            gBoxInicio.Size = new Size(397, 316);
            gBoxInicio.TabIndex = 0;
            gBoxInicio.TabStop = false;
            // 
            // btnTrimestres
            // 
            btnTrimestres.Location = new Point(76, 166);
            btnTrimestres.Name = "btnTrimestres";
            btnTrimestres.Size = new Size(213, 50);
            btnTrimestres.TabIndex = 1;
            btnTrimestres.Text = "Trimestres";
            btnTrimestres.UseVisualStyleBackColor = true;
            btnTrimestres.Click += btnTrimestres_Click;
            // 
            // btnAlumnos
            // 
            btnAlumnos.Location = new Point(76, 77);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(213, 50);
            btnAlumnos.TabIndex = 0;
            btnAlumnos.Text = "Alumnos";
            btnAlumnos.UseVisualStyleBackColor = true;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 348);
            Controls.Add(gBoxInicio);
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            gBoxInicio.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxInicio;
        private Button btnTrimestres;
        private Button btnAlumnos;
    }
}
