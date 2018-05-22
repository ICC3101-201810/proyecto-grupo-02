namespace MyNotes2._0
{
    partial class ModificarRamo
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
            this.button1 = new System.Windows.Forms.Button();
            this.eliminarProfesor = new System.Windows.Forms.Button();
            this.editarAlumno = new System.Windows.Forms.Button();
            this.listaAlumnos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eliminarProfesor
            // 
            this.eliminarProfesor.Location = new System.Drawing.Point(118, 196);
            this.eliminarProfesor.Name = "eliminarProfesor";
            this.eliminarProfesor.Size = new System.Drawing.Size(244, 31);
            this.eliminarProfesor.TabIndex = 15;
            this.eliminarProfesor.Text = "Eliminar ramo";
            this.eliminarProfesor.UseVisualStyleBackColor = true;
            // 
            // editarAlumno
            // 
            this.editarAlumno.Location = new System.Drawing.Point(118, 159);
            this.editarAlumno.Name = "editarAlumno";
            this.editarAlumno.Size = new System.Drawing.Size(244, 31);
            this.editarAlumno.TabIndex = 14;
            this.editarAlumno.Text = "Cambiar nombre ramo";
            this.editarAlumno.UseVisualStyleBackColor = true;
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.FormattingEnabled = true;
            this.listaAlumnos.Location = new System.Drawing.Point(320, 78);
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.Size = new System.Drawing.Size(301, 28);
            this.listaAlumnos.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seleccione ramo a modificar:";
            // 
            // ModificarRamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eliminarProfesor);
            this.Controls.Add(this.editarAlumno);
            this.Controls.Add(this.listaAlumnos);
            this.Controls.Add(this.label1);
            this.Name = "ModificarRamo";
            this.Text = "ModificarRamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button eliminarProfesor;
        private System.Windows.Forms.Button editarAlumno;
        private System.Windows.Forms.ComboBox listaAlumnos;
        private System.Windows.Forms.Label label1;
    }
}