namespace MyNotes2._0
{
    partial class ModificarAlumno
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
            this.listaAlumnos = new System.Windows.Forms.ComboBox();
            this.editarAlumno = new System.Windows.Forms.Button();
            this.eliminarAlumno = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toAyudante = new System.Windows.Forms.Button();
            this.noAyudante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione alumno a modificar:";
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.FormattingEnabled = true;
            this.listaAlumnos.Location = new System.Drawing.Point(275, 73);
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.Size = new System.Drawing.Size(301, 28);
            this.listaAlumnos.TabIndex = 1;
            this.listaAlumnos.SelectedIndexChanged += new System.EventHandler(this.listaAlumnos_SelectedIndexChanged);
            // 
            // editarAlumno
            // 
            this.editarAlumno.Location = new System.Drawing.Point(73, 154);
            this.editarAlumno.Name = "editarAlumno";
            this.editarAlumno.Size = new System.Drawing.Size(244, 31);
            this.editarAlumno.TabIndex = 2;
            this.editarAlumno.Text = "Cambiar nombre alumno";
            this.editarAlumno.UseVisualStyleBackColor = true;
            this.editarAlumno.Click += new System.EventHandler(this.editarAlumno_Click);
            // 
            // eliminarAlumno
            // 
            this.eliminarAlumno.Location = new System.Drawing.Point(73, 191);
            this.eliminarAlumno.Name = "eliminarAlumno";
            this.eliminarAlumno.Size = new System.Drawing.Size(244, 31);
            this.eliminarAlumno.TabIndex = 3;
            this.eliminarAlumno.Text = "Eliminar alumno";
            this.eliminarAlumno.UseVisualStyleBackColor = true;
            this.eliminarAlumno.Click += new System.EventHandler(this.eliminarAlumno_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toAyudante
            // 
            this.toAyudante.Location = new System.Drawing.Point(366, 154);
            this.toAyudante.Name = "toAyudante";
            this.toAyudante.Size = new System.Drawing.Size(244, 31);
            this.toAyudante.TabIndex = 5;
            this.toAyudante.Text = "Hacer ayudante";
            this.toAyudante.UseVisualStyleBackColor = true;
            this.toAyudante.Click += new System.EventHandler(this.toAyudante_Click);
            // 
            // noAyudante
            // 
            this.noAyudante.Location = new System.Drawing.Point(366, 191);
            this.noAyudante.Name = "noAyudante";
            this.noAyudante.Size = new System.Drawing.Size(244, 31);
            this.noAyudante.TabIndex = 6;
            this.noAyudante.Text = "Eliminar ayudante";
            this.noAyudante.UseVisualStyleBackColor = true;
            this.noAyudante.Click += new System.EventHandler(this.noAyudante_Click);
            // 
            // ModificarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noAyudante);
            this.Controls.Add(this.toAyudante);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eliminarAlumno);
            this.Controls.Add(this.editarAlumno);
            this.Controls.Add(this.listaAlumnos);
            this.Controls.Add(this.label1);
            this.Name = "ModificarAlumno";
            this.Text = "ModificarAlumno";
            this.Load += new System.EventHandler(this.ModificarAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listaAlumnos;
        private System.Windows.Forms.Button editarAlumno;
        private System.Windows.Forms.Button eliminarAlumno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button toAyudante;
        private System.Windows.Forms.Button noAyudante;
    }
}