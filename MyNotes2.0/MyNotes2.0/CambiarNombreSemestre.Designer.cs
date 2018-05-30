namespace MyNotes2._0
{
    partial class CambiarNombreSemestre
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
            this.labelSemestres = new System.Windows.Forms.Label();
            this.comboBoxSemestres = new System.Windows.Forms.ComboBox();
            this.BotonAtras = new System.Windows.Forms.Button();
            this.BotonCamiarNombre = new System.Windows.Forms.Button();
            this.textBoxNuevoNombre = new System.Windows.Forms.TextBox();
            this.labelNuevoNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSemestres
            // 
            this.labelSemestres.AutoSize = true;
            this.labelSemestres.Location = new System.Drawing.Point(16, 34);
            this.labelSemestres.Name = "labelSemestres";
            this.labelSemestres.Size = new System.Drawing.Size(56, 13);
            this.labelSemestres.TabIndex = 0;
            this.labelSemestres.Text = "Semestres";
            // 
            // comboBoxSemestres
            // 
            this.comboBoxSemestres.FormattingEnabled = true;
            this.comboBoxSemestres.Location = new System.Drawing.Point(111, 31);
            this.comboBoxSemestres.Name = "comboBoxSemestres";
            this.comboBoxSemestres.Size = new System.Drawing.Size(169, 21);
            this.comboBoxSemestres.TabIndex = 1;
            // 
            // BotonAtras
            // 
            this.BotonAtras.Location = new System.Drawing.Point(12, 199);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(105, 55);
            this.BotonAtras.TabIndex = 3;
            this.BotonAtras.Text = "Atras";
            this.BotonAtras.UseVisualStyleBackColor = true;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // BotonCamiarNombre
            // 
            this.BotonCamiarNombre.Location = new System.Drawing.Point(293, 199);
            this.BotonCamiarNombre.Name = "BotonCamiarNombre";
            this.BotonCamiarNombre.Size = new System.Drawing.Size(105, 55);
            this.BotonCamiarNombre.TabIndex = 4;
            this.BotonCamiarNombre.Text = "Cambiar Nombre";
            this.BotonCamiarNombre.UseVisualStyleBackColor = true;
            this.BotonCamiarNombre.Click += new System.EventHandler(this.BotonCamiarNombre_Click);
            // 
            // textBoxNuevoNombre
            // 
            this.textBoxNuevoNombre.Location = new System.Drawing.Point(111, 89);
            this.textBoxNuevoNombre.Name = "textBoxNuevoNombre";
            this.textBoxNuevoNombre.Size = new System.Drawing.Size(169, 20);
            this.textBoxNuevoNombre.TabIndex = 5;
            // 
            // labelNuevoNombre
            // 
            this.labelNuevoNombre.AutoSize = true;
            this.labelNuevoNombre.Location = new System.Drawing.Point(16, 92);
            this.labelNuevoNombre.Name = "labelNuevoNombre";
            this.labelNuevoNombre.Size = new System.Drawing.Size(76, 13);
            this.labelNuevoNombre.TabIndex = 6;
            this.labelNuevoNombre.Text = "NuevoNombre";
            // 
            // CambiarNombreSemestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 266);
            this.Controls.Add(this.labelNuevoNombre);
            this.Controls.Add(this.textBoxNuevoNombre);
            this.Controls.Add(this.BotonCamiarNombre);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.comboBoxSemestres);
            this.Controls.Add(this.labelSemestres);
            this.Name = "CambiarNombreSemestre";
            this.Text = "CambiarNombreSemestre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSemestres;
        private System.Windows.Forms.ComboBox comboBoxSemestres;
        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.Button BotonCamiarNombre;
        private System.Windows.Forms.TextBox textBoxNuevoNombre;
        private System.Windows.Forms.Label labelNuevoNombre;
    }
}