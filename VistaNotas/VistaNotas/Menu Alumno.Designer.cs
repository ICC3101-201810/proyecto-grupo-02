﻿namespace VistaNotas
{
    partial class Menu_Alumno
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
            this.TextoBienvenida = new System.Windows.Forms.Label();
            this.PreguntaOpciones = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.BotonCrearApunte = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.NombreDelAlumno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextoBienvenida
            // 
            this.TextoBienvenida.AutoSize = true;
            this.TextoBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoBienvenida.Location = new System.Drawing.Point(130, 44);
            this.TextoBienvenida.Name = "TextoBienvenida";
            this.TextoBienvenida.Size = new System.Drawing.Size(271, 31);
            this.TextoBienvenida.TabIndex = 1;
            this.TextoBienvenida.Text = "Bienvenido Alumno ";
            // 
            // PreguntaOpciones
            // 
            this.PreguntaOpciones.AutoSize = true;
            this.PreguntaOpciones.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreguntaOpciones.Location = new System.Drawing.Point(133, 75);
            this.PreguntaOpciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PreguntaOpciones.Name = "PreguntaOpciones";
            this.PreguntaOpciones.Size = new System.Drawing.Size(158, 18);
            this.PreguntaOpciones.TabIndex = 10;
            this.PreguntaOpciones.Text = "¿Qué desea hacer?";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(368, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 112);
            this.button3.TabIndex = 11;
            this.button3.Text = "AgregarRecordatorio";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 112);
            this.button1.TabIndex = 12;
            this.button1.Text = "salte";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(554, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 112);
            this.button2.TabIndex = 13;
            this.button2.Text = "salte";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(554, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 112);
            this.button4.TabIndex = 14;
            this.button4.Text = "CompartirApunte";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(186, 295);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 112);
            this.button5.TabIndex = 15;
            this.button5.Text = "salte";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // BotonCrearApunte
            // 
            this.BotonCrearApunte.Location = new System.Drawing.Point(186, 147);
            this.BotonCrearApunte.Name = "BotonCrearApunte";
            this.BotonCrearApunte.Size = new System.Drawing.Size(155, 112);
            this.BotonCrearApunte.TabIndex = 16;
            this.BotonCrearApunte.Text = "Crear Apunte";
            this.BotonCrearApunte.UseVisualStyleBackColor = true;
            this.BotonCrearApunte.Click += new System.EventHandler(this.BotonCrearApunte_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 391);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 47);
            this.button7.TabIndex = 17;
            this.button7.Text = "Cerrar Sesion";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // NombreDelAlumno
            // 
            this.NombreDelAlumno.AutoSize = true;
            this.NombreDelAlumno.Location = new System.Drawing.Point(430, 52);
            this.NombreDelAlumno.Name = "NombreDelAlumno";
            this.NombreDelAlumno.Size = new System.Drawing.Size(0, 13);
            this.NombreDelAlumno.TabIndex = 18;
            // 
            // Menu_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NombreDelAlumno);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.BotonCrearApunte);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PreguntaOpciones);
            this.Controls.Add(this.TextoBienvenida);
            this.Name = "Menu_Alumno";
            this.Text = "Menu_Alumno";
            this.Load += new System.EventHandler(this.Menu_Alumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextoBienvenida;
        private System.Windows.Forms.Label PreguntaOpciones;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BotonCrearApunte;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label NombreDelAlumno;
    }
}