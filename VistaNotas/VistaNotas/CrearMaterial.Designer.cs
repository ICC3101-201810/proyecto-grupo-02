﻿namespace VistaNotas
{
    partial class CrearMaterial
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
            this.Label_Escriba_Nombre = new System.Windows.Forms.Label();
            this.Nombre_Nuevo_Apunte = new System.Windows.Forms.TextBox();
            this.LabelSeleccioneRamo = new System.Windows.Forms.Label();
            this.comboBox_Seleccion_Ramo = new System.Windows.Forms.ComboBox();
            this.IngresoMaterial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BotonCrear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Label_Escriba_Nombre
            // 
            this.Label_Escriba_Nombre.AutoSize = true;
            this.Label_Escriba_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Escriba_Nombre.Location = new System.Drawing.Point(44, 75);
            this.Label_Escriba_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Escriba_Nombre.Name = "Label_Escriba_Nombre";
            this.Label_Escriba_Nombre.Size = new System.Drawing.Size(290, 29);
            this.Label_Escriba_Nombre.TabIndex = 8;
            this.Label_Escriba_Nombre.Text = "Nombre Nuevo Material";
            // 
            // Nombre_Nuevo_Apunte
            // 
            this.Nombre_Nuevo_Apunte.Location = new System.Drawing.Point(521, 75);
            this.Nombre_Nuevo_Apunte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nombre_Nuevo_Apunte.Name = "Nombre_Nuevo_Apunte";
            this.Nombre_Nuevo_Apunte.Size = new System.Drawing.Size(464, 22);
            this.Nombre_Nuevo_Apunte.TabIndex = 7;
            // 
            // LabelSeleccioneRamo
            // 
            this.LabelSeleccioneRamo.AutoSize = true;
            this.LabelSeleccioneRamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSeleccioneRamo.Location = new System.Drawing.Point(44, 35);
            this.LabelSeleccioneRamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSeleccioneRamo.Name = "LabelSeleccioneRamo";
            this.LabelSeleccioneRamo.Size = new System.Drawing.Size(219, 29);
            this.LabelSeleccioneRamo.TabIndex = 6;
            this.LabelSeleccioneRamo.Text = "Seleccione Ramo";
            // 
            // comboBox_Seleccion_Ramo
            // 
            this.comboBox_Seleccion_Ramo.FormattingEnabled = true;
            this.comboBox_Seleccion_Ramo.Location = new System.Drawing.Point(521, 35);
            this.comboBox_Seleccion_Ramo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Seleccion_Ramo.Name = "comboBox_Seleccion_Ramo";
            this.comboBox_Seleccion_Ramo.Size = new System.Drawing.Size(465, 24);
            this.comboBox_Seleccion_Ramo.TabIndex = 5;
            this.comboBox_Seleccion_Ramo.SelectedIndexChanged += new System.EventHandler(this.comboBox_Seleccion_Ramo_SelectedIndexChanged);
            // 
            // IngresoMaterial
            // 
            this.IngresoMaterial.Location = new System.Drawing.Point(48, 191);
            this.IngresoMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IngresoMaterial.Multiline = true;
            this.IngresoMaterial.Name = "IngresoMaterial";
            this.IngresoMaterial.Size = new System.Drawing.Size(1001, 282);
            this.IngresoMaterial.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingrese Material";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(16, 481);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 58);
            this.button2.TabIndex = 11;
            this.button2.Text = "Atras";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BotonCrear
            // 
            this.BotonCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCrear.Location = new System.Drawing.Point(933, 481);
            this.BotonCrear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonCrear.Name = "BotonCrear";
            this.BotonCrear.Size = new System.Drawing.Size(117, 58);
            this.BotonCrear.TabIndex = 12;
            this.BotonCrear.Text = "Crear";
            this.BotonCrear.UseVisualStyleBackColor = true;
            this.BotonCrear.Click += new System.EventHandler(this.BotonCrear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(521, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(465, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // CrearMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BotonCrear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IngresoMaterial);
            this.Controls.Add(this.Label_Escriba_Nombre);
            this.Controls.Add(this.Nombre_Nuevo_Apunte);
            this.Controls.Add(this.LabelSeleccioneRamo);
            this.Controls.Add(this.comboBox_Seleccion_Ramo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CrearMaterial";
            this.Text = "CrearMaterial";
            this.Load += new System.EventHandler(this.CrearMaterial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Escriba_Nombre;
        private System.Windows.Forms.TextBox Nombre_Nuevo_Apunte;
        private System.Windows.Forms.Label LabelSeleccioneRamo;
        private System.Windows.Forms.ComboBox comboBox_Seleccion_Ramo;
        private System.Windows.Forms.TextBox IngresoMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BotonCrear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}