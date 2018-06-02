namespace MyNotes2._0
{
    partial class CrearSemestreAdmin
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
            this.textBoxNombreSemestre = new System.Windows.Forms.TextBox();
            this.BotonAtras = new System.Windows.Forms.Button();
            this.BotonCrearSemestre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Nombre Semestre:";
            // 
            // textBoxNombreSemestre
            // 
            this.textBoxNombreSemestre.Location = new System.Drawing.Point(269, 64);
            this.textBoxNombreSemestre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNombreSemestre.Name = "textBoxNombreSemestre";
            this.textBoxNombreSemestre.Size = new System.Drawing.Size(296, 26);
            this.textBoxNombreSemestre.TabIndex = 1;
            // 
            // BotonAtras
            // 
            this.BotonAtras.Location = new System.Drawing.Point(93, 367);
            this.BotonAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(158, 34);
            this.BotonAtras.TabIndex = 2;
            this.BotonAtras.Text = "Atras";
            this.BotonAtras.UseVisualStyleBackColor = true;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // BotonCrearSemestre
            // 
            this.BotonCrearSemestre.Location = new System.Drawing.Point(358, 367);
            this.BotonCrearSemestre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonCrearSemestre.Name = "BotonCrearSemestre";
            this.BotonCrearSemestre.Size = new System.Drawing.Size(158, 34);
            this.BotonCrearSemestre.TabIndex = 3;
            this.BotonCrearSemestre.Text = "Crear Semestre";
            this.BotonCrearSemestre.UseVisualStyleBackColor = true;
            this.BotonCrearSemestre.Click += new System.EventHandler(this.BotonCrearSemestre_Click);
            // 
            // CrearSemestreAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 494);
            this.Controls.Add(this.BotonCrearSemestre);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.textBoxNombreSemestre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CrearSemestreAdmin";
            this.Text = "Crear Semestre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreSemestre;
        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.Button BotonCrearSemestre;
    }
}