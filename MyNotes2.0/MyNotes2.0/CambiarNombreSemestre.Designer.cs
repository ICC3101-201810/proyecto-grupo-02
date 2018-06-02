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
            this.labelSemestres.Location = new System.Drawing.Point(24, 52);
            this.labelSemestres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSemestres.Name = "labelSemestres";
            this.labelSemestres.Size = new System.Drawing.Size(86, 20);
            this.labelSemestres.TabIndex = 0;
            this.labelSemestres.Text = "Semestres";
            // 
            // comboBoxSemestres
            // 
            this.comboBoxSemestres.FormattingEnabled = true;
            this.comboBoxSemestres.Location = new System.Drawing.Point(166, 48);
            this.comboBoxSemestres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSemestres.Name = "comboBoxSemestres";
            this.comboBoxSemestres.Size = new System.Drawing.Size(252, 28);
            this.comboBoxSemestres.TabIndex = 1;
            // 
            // BotonAtras
            // 
            this.BotonAtras.Location = new System.Drawing.Point(106, 292);
            this.BotonAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(154, 44);
            this.BotonAtras.TabIndex = 3;
            this.BotonAtras.Text = "Atras";
            this.BotonAtras.UseVisualStyleBackColor = true;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // BotonCamiarNombre
            // 
            this.BotonCamiarNombre.Location = new System.Drawing.Point(340, 292);
            this.BotonCamiarNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonCamiarNombre.Name = "BotonCamiarNombre";
            this.BotonCamiarNombre.Size = new System.Drawing.Size(154, 44);
            this.BotonCamiarNombre.TabIndex = 4;
            this.BotonCamiarNombre.Text = "Cambiar Nombre";
            this.BotonCamiarNombre.UseVisualStyleBackColor = true;
            this.BotonCamiarNombre.Click += new System.EventHandler(this.BotonCamiarNombre_Click);
            // 
            // textBoxNuevoNombre
            // 
            this.textBoxNuevoNombre.Location = new System.Drawing.Point(166, 137);
            this.textBoxNuevoNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNuevoNombre.Name = "textBoxNuevoNombre";
            this.textBoxNuevoNombre.Size = new System.Drawing.Size(252, 26);
            this.textBoxNuevoNombre.TabIndex = 5;
            // 
            // labelNuevoNombre
            // 
            this.labelNuevoNombre.AutoSize = true;
            this.labelNuevoNombre.Location = new System.Drawing.Point(24, 142);
            this.labelNuevoNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNuevoNombre.Name = "labelNuevoNombre";
            this.labelNuevoNombre.Size = new System.Drawing.Size(110, 20);
            this.labelNuevoNombre.TabIndex = 6;
            this.labelNuevoNombre.Text = "NuevoNombre";
            // 
            // CambiarNombreSemestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 409);
            this.Controls.Add(this.labelNuevoNombre);
            this.Controls.Add(this.textBoxNuevoNombre);
            this.Controls.Add(this.BotonCamiarNombre);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.comboBoxSemestres);
            this.Controls.Add(this.labelSemestres);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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