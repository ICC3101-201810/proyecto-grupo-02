namespace MyNotes2._0
{
    partial class EditarSeccion
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
            this.botonAtras = new System.Windows.Forms.Button();
            this.botonEliminarProfesor = new System.Windows.Forms.Button();
            this.botonEliminarAlumno = new System.Windows.Forms.Button();
            this.botonOpcionesSeccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "¿Qué desea hacer?";
            // 
            // botonAtras
            // 
            this.botonAtras.Location = new System.Drawing.Point(405, 292);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(170, 40);
            this.botonAtras.TabIndex = 14;
            this.botonAtras.Text = "Atras";
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // botonEliminarProfesor
            // 
            this.botonEliminarProfesor.Location = new System.Drawing.Point(74, 149);
            this.botonEliminarProfesor.Name = "botonEliminarProfesor";
            this.botonEliminarProfesor.Size = new System.Drawing.Size(170, 31);
            this.botonEliminarProfesor.TabIndex = 15;
            this.botonEliminarProfesor.Text = "Eliminar Profesor";
            this.botonEliminarProfesor.UseVisualStyleBackColor = true;
            // 
            // botonEliminarAlumno
            // 
            this.botonEliminarAlumno.Location = new System.Drawing.Point(74, 112);
            this.botonEliminarAlumno.Name = "botonEliminarAlumno";
            this.botonEliminarAlumno.Size = new System.Drawing.Size(170, 31);
            this.botonEliminarAlumno.TabIndex = 16;
            this.botonEliminarAlumno.Text = "Eliminar Alumno";
            this.botonEliminarAlumno.UseVisualStyleBackColor = true;
            // 
            // botonOpcionesSeccion
            // 
            this.botonOpcionesSeccion.Location = new System.Drawing.Point(288, 112);
            this.botonOpcionesSeccion.Name = "botonOpcionesSeccion";
            this.botonOpcionesSeccion.Size = new System.Drawing.Size(170, 31);
            this.botonOpcionesSeccion.TabIndex = 17;
            this.botonOpcionesSeccion.Text = "Opciones Seccion";
            this.botonOpcionesSeccion.UseVisualStyleBackColor = true;
            this.botonOpcionesSeccion.Click += new System.EventHandler(this.botonOpcionesSeccion_Click);
            // 
            // EditarSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 409);
            this.Controls.Add(this.botonOpcionesSeccion);
            this.Controls.Add(this.botonEliminarAlumno);
            this.Controls.Add(this.botonEliminarProfesor);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditarSeccion";
            this.Text = "Editar Seccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Button botonEliminarProfesor;
        private System.Windows.Forms.Button botonEliminarAlumno;
        private System.Windows.Forms.Button botonOpcionesSeccion;
    }
}