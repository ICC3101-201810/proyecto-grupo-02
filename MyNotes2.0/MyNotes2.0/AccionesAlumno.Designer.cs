﻿namespace MyNotes2._0
{
    partial class AccionesAlumno
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
            this.label_NameAl = new System.Windows.Forms.Label();
            this.button_CrearAp = new System.Windows.Forms.Button();
            this.button_DispAp = new System.Windows.Forms.Button();
            this.BotonInicioSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumno:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_NameAl
            // 
            this.label_NameAl.AutoSize = true;
            this.label_NameAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NameAl.Location = new System.Drawing.Point(187, 59);
            this.label_NameAl.Name = "label_NameAl";
            this.label_NameAl.Size = new System.Drawing.Size(79, 29);
            this.label_NameAl.TabIndex = 1;
            this.label_NameAl.Text = "label2";
            this.label_NameAl.Click += new System.EventHandler(this.label_NameAl_Click);
            // 
            // button_CrearAp
            // 
            this.button_CrearAp.Location = new System.Drawing.Point(67, 138);
            this.button_CrearAp.Name = "button_CrearAp";
            this.button_CrearAp.Size = new System.Drawing.Size(232, 37);
            this.button_CrearAp.TabIndex = 2;
            this.button_CrearAp.Text = "Crear Apuntes";
            this.button_CrearAp.UseVisualStyleBackColor = true;
            this.button_CrearAp.Click += new System.EventHandler(this.button_CrearAp_Click);
            // 
            // button_DispAp
            // 
            this.button_DispAp.Location = new System.Drawing.Point(340, 138);
            this.button_DispAp.Name = "button_DispAp";
            this.button_DispAp.Size = new System.Drawing.Size(232, 37);
            this.button_DispAp.TabIndex = 3;
            this.button_DispAp.Text = "Ver mis Apuntes";
            this.button_DispAp.UseVisualStyleBackColor = true;
            this.button_DispAp.Click += new System.EventHandler(this.button_DispAp_Click);
            // 
            // BotonInicioSesion
            // 
            this.BotonInicioSesion.Location = new System.Drawing.Point(430, 358);
            this.BotonInicioSesion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonInicioSesion.Name = "BotonInicioSesion";
            this.BotonInicioSesion.Size = new System.Drawing.Size(186, 43);
            this.BotonInicioSesion.TabIndex = 4;
            this.BotonInicioSesion.Text = "Cerrar Sesion";
            this.BotonInicioSesion.UseVisualStyleBackColor = true;
            this.BotonInicioSesion.Click += new System.EventHandler(this.BotonInicioSesion_Click);
            // 
            // AccionesAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 494);
            this.Controls.Add(this.BotonInicioSesion);
            this.Controls.Add(this.button_DispAp);
            this.Controls.Add(this.button_CrearAp);
            this.Controls.Add(this.label_NameAl);
            this.Controls.Add(this.label1);
            this.Name = "AccionesAlumno";
            this.Text = "AccionesAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_NameAl;
        private System.Windows.Forms.Button button_CrearAp;
        private System.Windows.Forms.Button button_DispAp;
        private System.Windows.Forms.Button BotonInicioSesion;
    }
}