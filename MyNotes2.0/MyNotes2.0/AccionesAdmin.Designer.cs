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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador:";
            // 
            // label_NombreAdm
            // 
            this.label_NombreAdm.AutoSize = true;
            this.label_NombreAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NombreAdm.Location = new System.Drawing.Point(175, 48);
            this.label_NombreAdm.Name = "label_NombreAdm";
            this.label_NombreAdm.Size = new System.Drawing.Size(64, 25);
            this.label_NombreAdm.TabIndex = 1;
            this.label_NombreAdm.Text = "label2";
            // 
            // adminAlumno
            // 
            this.adminAlumno.Location = new System.Drawing.Point(60, 150);
            this.adminAlumno.Name = "adminAlumno";
            this.adminAlumno.Size = new System.Drawing.Size(154, 32);
            this.adminAlumno.TabIndex = 2;
            this.adminAlumno.Text = "Alumnos";
            this.adminAlumno.UseVisualStyleBackColor = true;
            this.adminAlumno.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminProfesor
            // 
            this.adminProfesor.Location = new System.Drawing.Point(60, 205);
            this.adminProfesor.Name = "adminProfesor";
            this.adminProfesor.Size = new System.Drawing.Size(154, 32);
            this.adminProfesor.TabIndex = 3;
            this.adminProfesor.Text = "Profesores";
            this.adminProfesor.UseVisualStyleBackColor = true;
            this.adminProfesor.Click += new System.EventHandler(this.adminProfesor_Click);
            // 
            // adminRamo
            // 
            this.adminRamo.Location = new System.Drawing.Point(311, 150);
            this.adminRamo.Name = "adminRamo";
            this.adminRamo.Size = new System.Drawing.Size(154, 32);
            this.adminRamo.TabIndex = 4;
            this.adminRamo.Text = "Ramos";
            this.adminRamo.UseVisualStyleBackColor = true;
            // 
            // adminSemestre
            // 
            this.adminSemestre.Location = new System.Drawing.Point(311, 205);
            this.adminSemestre.Name = "adminSemestre";
            this.adminSemestre.Size = new System.Drawing.Size(154, 32);
            this.adminSemestre.TabIndex = 5;
            this.adminSemestre.Text = "Semestres";
            this.adminSemestre.UseVisualStyleBackColor = true;
            this.adminSemestre.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "¿Qué desea administrar?";
            // 
            // AccionesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 410);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminSemestre);
            this.Controls.Add(this.adminRamo);
            this.Controls.Add(this.adminProfesor);
            this.Controls.Add(this.adminAlumno);
            this.Controls.Add(this.label_NombreAdm);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}