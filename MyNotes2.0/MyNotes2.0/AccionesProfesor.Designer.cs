﻿namespace MyNotes2._0
{
    partial class AccionesProfesor
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
            this.button_CrearAp = new System.Windows.Forms.Button();
            this.label_NamePr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonInicioSesion = new System.Windows.Forms.Button();
            this.BotonAdministrarRamos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_CrearAp
            // 
            this.button_CrearAp.Location = new System.Drawing.Point(208, 183);
            this.button_CrearAp.Margin = new System.Windows.Forms.Padding(2);
            this.button_CrearAp.Name = "button_CrearAp";
            this.button_CrearAp.Size = new System.Drawing.Size(75, 44);
            this.button_CrearAp.TabIndex = 5;
            this.button_CrearAp.Text = "Crear Apuntes";
            this.button_CrearAp.UseVisualStyleBackColor = true;
            this.button_CrearAp.Click += new System.EventHandler(this.button_CrearAp_Click);
            // 
            // label_NamePr
            // 
            this.label_NamePr.AutoSize = true;
            this.label_NamePr.Location = new System.Drawing.Point(248, 94);
            this.label_NamePr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_NamePr.Name = "label_NamePr";
            this.label_NamePr.Size = new System.Drawing.Size(35, 13);
            this.label_NamePr.TabIndex = 4;
            this.label_NamePr.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Profesor";
            // 
            // BotonInicioSesion
            // 
            this.BotonInicioSesion.Location = new System.Drawing.Point(12, 265);
            this.BotonInicioSesion.Name = "BotonInicioSesion";
            this.BotonInicioSesion.Size = new System.Drawing.Size(75, 44);
            this.BotonInicioSesion.TabIndex = 6;
            this.BotonInicioSesion.Text = "Cerrar Sesion";
            this.BotonInicioSesion.UseVisualStyleBackColor = true;
            this.BotonInicioSesion.Click += new System.EventHandler(this.BotonCerrarSesion_Click);
            // 
            // BotonAdministrarRamos
            // 
            this.BotonAdministrarRamos.Location = new System.Drawing.Point(106, 183);
            this.BotonAdministrarRamos.Margin = new System.Windows.Forms.Padding(2);
            this.BotonAdministrarRamos.Name = "BotonAdministrarRamos";
            this.BotonAdministrarRamos.Size = new System.Drawing.Size(75, 44);
            this.BotonAdministrarRamos.TabIndex = 7;
            this.BotonAdministrarRamos.Text = "Administrar Ramos";
            this.BotonAdministrarRamos.UseVisualStyleBackColor = true;
            this.BotonAdministrarRamos.Click += new System.EventHandler(this.BotonAdministrarRamos_Click);
            // 
            // AccionesProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 321);
            this.Controls.Add(this.BotonAdministrarRamos);
            this.Controls.Add(this.BotonInicioSesion);
            this.Controls.Add(this.button_CrearAp);
            this.Controls.Add(this.label_NamePr);
            this.Controls.Add(this.label1);
            this.Name = "AccionesProfesor";
            this.Text = "AccionesProfesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CrearAp;
        private System.Windows.Forms.Label label_NamePr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonInicioSesion;
        private System.Windows.Forms.Button BotonAdministrarRamos;
    }
}