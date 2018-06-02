namespace MyNotes2._0
{
    partial class CrearRamo
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelSemestre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNombreNuevoRamo = new System.Windows.Forms.TextBox();
            this.comboBoxSemestre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // labelSemestre
            // 
            this.labelSemestre.AutoSize = true;
            this.labelSemestre.Location = new System.Drawing.Point(72, 43);
            this.labelSemestre.Name = "labelSemestre";
            this.labelSemestre.Size = new System.Drawing.Size(161, 20);
            this.labelSemestre.TabIndex = 12;
            this.labelSemestre.Text = "Seleccione semestre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre nuevo ramo:";
            // 
            // textBoxNombreNuevoRamo
            // 
            this.textBoxNombreNuevoRamo.Location = new System.Drawing.Point(286, 122);
            this.textBoxNombreNuevoRamo.Name = "textBoxNombreNuevoRamo";
            this.textBoxNombreNuevoRamo.Size = new System.Drawing.Size(236, 26);
            this.textBoxNombreNuevoRamo.TabIndex = 7;
            // 
            // comboBoxSemestre
            // 
            this.comboBoxSemestre.FormattingEnabled = true;
            this.comboBoxSemestre.Location = new System.Drawing.Point(286, 40);
            this.comboBoxSemestre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSemestre.Name = "comboBoxSemestre";
            this.comboBoxSemestre.Size = new System.Drawing.Size(236, 28);
            this.comboBoxSemestre.TabIndex = 13;
            // 
            // CrearRamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.comboBoxSemestre);
            this.Controls.Add(this.labelSemestre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNombreNuevoRamo);
            this.Controls.Add(this.label4);
            this.Name = "CrearRamo";
            this.Text = "CrearRamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelSemestre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNombreNuevoRamo;
        private System.Windows.Forms.ComboBox comboBoxSemestre;
    }
}