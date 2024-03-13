namespace Vista
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTrimestres = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.gBoxInicio = new System.Windows.Forms.GroupBox();
            this.gBoxInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTrimestres
            // 
            this.btnTrimestres.Location = new System.Drawing.Point(65, 153);
            this.btnTrimestres.Name = "btnTrimestres";
            this.btnTrimestres.Size = new System.Drawing.Size(208, 42);
            this.btnTrimestres.TabIndex = 3;
            this.btnTrimestres.Text = "Trimestres";
            this.btnTrimestres.UseVisualStyleBackColor = true;
            this.btnTrimestres.Click += new System.EventHandler(this.btnTrimestres_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Location = new System.Drawing.Point(65, 86);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(208, 42);
            this.btnAlumnos.TabIndex = 2;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // gBoxInicio
            // 
            this.gBoxInicio.Controls.Add(this.btnAlumnos);
            this.gBoxInicio.Controls.Add(this.btnTrimestres);
            this.gBoxInicio.Location = new System.Drawing.Point(72, 52);
            this.gBoxInicio.Name = "gBoxInicio";
            this.gBoxInicio.Size = new System.Drawing.Size(328, 281);
            this.gBoxInicio.TabIndex = 4;
            this.gBoxInicio.TabStop = false;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 391);
            this.Controls.Add(this.gBoxInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.gBoxInicio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrimestres;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.GroupBox gBoxInicio;
    }
}

