﻿namespace MyNotes2._0
{
    partial class FechasRamo
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
            this.verFechas = new System.Windows.Forms.Button();
            this.listaRamos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // verFechas
            // 
            this.verFechas.Location = new System.Drawing.Point(99, 159);
            this.verFechas.Name = "verFechas";
            this.verFechas.Size = new System.Drawing.Size(244, 31);
            this.verFechas.TabIndex = 19;
            this.verFechas.Text = "Ver fechas";
            this.verFechas.UseVisualStyleBackColor = true;
            this.verFechas.Click += new System.EventHandler(this.verFechas_Click);
            // 
            // listaRamos
            // 
            this.listaRamos.FormattingEnabled = true;
            this.listaRamos.Location = new System.Drawing.Point(241, 78);
            this.listaRamos.Name = "listaRamos";
            this.listaRamos.Size = new System.Drawing.Size(301, 28);
            this.listaRamos.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Seleccione ramo:";
            // 
            // FechasRamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.verFechas);
            this.Controls.Add(this.listaRamos);
            this.Controls.Add(this.label1);
            this.Name = "FechasRamo";
            this.Text = "FechasRamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button verFechas;
        private System.Windows.Forms.ComboBox listaRamos;
        private System.Windows.Forms.Label label1;
    }
}