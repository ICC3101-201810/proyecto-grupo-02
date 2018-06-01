namespace MyNotes2._0
{
    partial class AccionesAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_NombreAdm = new System.Windows.Forms.Label();
            this.adminAlumno = new System.Windows.Forms.Button();
            this.adminProfesor = new System.Windows.Forms.Button();
            this.adminRamo = new System.Windows.Forms.Button();
            this.adminSemestre = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador:";
            // 
            // label_NombreAdm
            // 
            this.label_NombreAdm.AutoSize = true;
            this.label_NombreAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NombreAdm.Location = new System.Drawing.Point(151, 31);
            this.label_NombreAdm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_NombreAdm.Name = "label_NombreAdm";
            this.label_NombreAdm.Size = new System.Drawing.Size(46, 17);
            this.label_NombreAdm.TabIndex = 1;
            this.label_NombreAdm.Text = "label2";
            // 
            // adminAlumno
            // 
            this.adminAlumno.Location = new System.Drawing.Point(40, 97);
            this.adminAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.adminAlumno.Name = "adminAlumno";
            this.adminAlumno.Size = new System.Drawing.Size(103, 21);
            this.adminAlumno.TabIndex = 2;
            this.adminAlumno.Text = "Alumnos";
            this.adminAlumno.UseVisualStyleBackColor = true;
            this.adminAlumno.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminProfesor
            // 
            this.adminProfesor.Location = new System.Drawing.Point(40, 133);
            this.adminProfesor.Margin = new System.Windows.Forms.Padding(2);
            this.adminProfesor.Name = "adminProfesor";
            this.adminProfesor.Size = new System.Drawing.Size(103, 21);
            this.adminProfesor.TabIndex = 3;
            this.adminProfesor.Text = "Profesores";
            this.adminProfesor.UseVisualStyleBackColor = true;
            this.adminProfesor.Click += new System.EventHandler(this.adminProfesor_Click);
            // 
            // adminRamo
            // 
            this.adminRamo.Location = new System.Drawing.Point(207, 97);
            this.adminRamo.Margin = new System.Windows.Forms.Padding(2);
            this.adminRamo.Name = "adminRamo";
            this.adminRamo.Size = new System.Drawing.Size(103, 21);
            this.adminRamo.TabIndex = 4;
            this.adminRamo.Text = "Ramos";
            this.adminRamo.UseVisualStyleBackColor = true;
            this.adminRamo.Click += new System.EventHandler(this.adminRamo_Click);
            // 
            // adminSemestre
            // 
            this.adminSemestre.Location = new System.Drawing.Point(207, 133);
            this.adminSemestre.Margin = new System.Windows.Forms.Padding(2);
            this.adminSemestre.Name = "adminSemestre";
            this.adminSemestre.Size = new System.Drawing.Size(103, 21);
            this.adminSemestre.TabIndex = 5;
            this.adminSemestre.Text = "Semestres";
            this.adminSemestre.UseVisualStyleBackColor = true;
            this.adminSemestre.Click += new System.EventHandler(this.botonSemestre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "¿Qué desea administrar?";
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(263, 217);
            this.logOut.Margin = new System.Windows.Forms.Padding(2);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(113, 26);
            this.logOut.TabIndex = 7;
            this.logOut.Text = "Cerrar sesión";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // AccionesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 266);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminSemestre);
            this.Controls.Add(this.adminRamo);
            this.Controls.Add(this.adminProfesor);
            this.Controls.Add(this.adminAlumno);
            this.Controls.Add(this.label_NombreAdm);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AccionesAdmin";
            this.Text = "AccionesAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_NombreAdm;
        private System.Windows.Forms.Button adminAlumno;
        private System.Windows.Forms.Button adminProfesor;
        private System.Windows.Forms.Button adminRamo;
        private System.Windows.Forms.Button adminSemestre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logOut;
    }
}