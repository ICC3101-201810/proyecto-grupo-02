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
            this.SuspendLayout();
            // 
            // BotonAtras
            // 
            this.BotonAtras.Location = new System.Drawing.Point(412, 336);
            this.BotonAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(170, 40);
            this.BotonAtras.TabIndex = 9;
            this.BotonAtras.Text = "Atras";
            this.BotonAtras.UseVisualStyleBackColor = true;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "¿Qué desea hacer?";
            // 
            // labelSemestre
            // 
            this.labelSemestre.AutoSize = true;
            this.labelSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemestre.Location = new System.Drawing.Point(40, 47);
            this.labelSemestre.Name = "labelSemestre";
            this.labelSemestre.Size = new System.Drawing.Size(106, 25);
            this.labelSemestre.TabIndex = 11;
            this.labelSemestre.Text = "Semestres";
            // 
            // BotonCrearSemestre
            // 
            this.BotonCrearSemestre.Location = new System.Drawing.Point(55, 211);
            this.BotonCrearSemestre.Name = "BotonCrearSemestre";
            this.BotonCrearSemestre.Size = new System.Drawing.Size(245, 46);
            this.BotonCrearSemestre.TabIndex = 12;
            this.BotonCrearSemestre.Text = "Crear Semestre";
            this.BotonCrearSemestre.UseVisualStyleBackColor = true;
            this.BotonCrearSemestre.Click += new System.EventHandler(this.BotonCrearSemestre_Click);
            // 
            // BotonCambiarNombreSem
            // 
            this.BotonCambiarNombreSem.Location = new System.Drawing.Point(317, 141);
            this.BotonCambiarNombreSem.Name = "BotonCambiarNombreSem";
            this.BotonCambiarNombreSem.Size = new System.Drawing.Size(245, 46);
            this.BotonCambiarNombreSem.TabIndex = 13;
            this.BotonCambiarNombreSem.Text = "Cambiar Nombre Semestre";
            this.BotonCambiarNombreSem.UseVisualStyleBackColor = true;
            this.BotonCambiarNombreSem.Click += new System.EventHandler(this.BotonCambiarNombreSem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 46);
            this.button3.TabIndex = 14;
            this.button3.Text = "Eliminar Semestre";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AdminSemestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 409);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BotonCambiarNombreSem);
            this.Controls.Add(this.BotonCrearSemestre);
            this.Controls.Add(this.labelSemestre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BotonAtras);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}