namespace MyNotes2._0
{
    partial class AdminSemestre
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
            this.BotonAtras = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSemestre = new System.Windows.Forms.Label();
            this.BotonCrearSemestre = new System.Windows.Forms.Button();
            this.BotonCambiarNombreSem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.botonSecciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonAtras
            // 
            this.BotonAtras.Location = new System.Drawing.Point(12, 228);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(113, 26);
            this.BotonAtras.TabIndex = 9;
            this.BotonAtras.Text = "Atras";
            this.BotonAtras.UseVisualStyleBackColor = true;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "¿Qué desea hacer?";
            // 
            // labelSemestre
            // 
            this.labelSemestre.AutoSize = true;
            this.labelSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemestre.Location = new System.Drawing.Point(26, 39);
            this.labelSemestre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSemestre.Name = "labelSemestre";
            this.labelSemestre.Size = new System.Drawing.Size(75, 17);
            this.labelSemestre.TabIndex = 11;
            this.labelSemestre.Text = "Semestres";
            // 
            // BotonCrearSemestre
            // 
            this.BotonCrearSemestre.Location = new System.Drawing.Point(74, 148);
            this.BotonCrearSemestre.Margin = new System.Windows.Forms.Padding(2);
            this.BotonCrearSemestre.Name = "BotonCrearSemestre";
            this.BotonCrearSemestre.Size = new System.Drawing.Size(103, 37);
            this.BotonCrearSemestre.TabIndex = 12;
            this.BotonCrearSemestre.Text = "Crear Semestre";
            this.BotonCrearSemestre.UseVisualStyleBackColor = true;
            this.BotonCrearSemestre.Click += new System.EventHandler(this.BotonCrearSemestre_Click);
            // 
            // BotonCambiarNombreSem
            // 
            this.BotonCambiarNombreSem.Location = new System.Drawing.Point(74, 107);
            this.BotonCambiarNombreSem.Margin = new System.Windows.Forms.Padding(2);
            this.BotonCambiarNombreSem.Name = "BotonCambiarNombreSem";
            this.BotonCambiarNombreSem.Size = new System.Drawing.Size(103, 37);
            this.BotonCambiarNombreSem.TabIndex = 13;
            this.BotonCambiarNombreSem.Text = "Cambiar Nombre Semestre";
            this.BotonCambiarNombreSem.UseVisualStyleBackColor = true;
            this.BotonCambiarNombreSem.Click += new System.EventHandler(this.BotonCambiarNombreSem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(209, 107);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 37);
            this.button3.TabIndex = 14;
            this.button3.Text = "Eliminar Semestre";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // botonSecciones
            // 
            this.botonSecciones.Location = new System.Drawing.Point(209, 148);
            this.botonSecciones.Margin = new System.Windows.Forms.Padding(2);
            this.botonSecciones.Name = "botonSecciones";
            this.botonSecciones.Size = new System.Drawing.Size(103, 37);
            this.botonSecciones.TabIndex = 15;
            this.botonSecciones.Text = "Secciones";
            this.botonSecciones.UseVisualStyleBackColor = true;
            // 
            // AdminSemestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 266);
            this.Controls.Add(this.botonSecciones);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BotonCambiarNombreSem);
            this.Controls.Add(this.BotonCrearSemestre);
            this.Controls.Add(this.labelSemestre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BotonAtras);
            this.Name = "AdminSemestre";
            this.Text = "Semestres ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSemestre;
        private System.Windows.Forms.Button BotonCrearSemestre;
        private System.Windows.Forms.Button BotonCambiarNombreSem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button botonSecciones;
    }
}