namespace MyNotes2._0
{
    partial class CrearSeccion
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSemestre = new System.Windows.Forms.ComboBox();
            this.comboBoxRamo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNuevoNombre = new System.Windows.Forms.TextBox();
            this.botonAtras = new System.Windows.Forms.Button();
            this.botonCrearSeccion = new System.Windows.Forms.Button();
            this.labelVacantes = new System.Windows.Forms.Label();
            this.textBoxVacantes = new System.Windows.Forms.TextBox();
            this.botonMas = new System.Windows.Forms.Button();
            this.botonMenos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Semestre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione Ramo";
            // 
            // comboBoxSemestre
            // 
            this.comboBoxSemestre.FormattingEnabled = true;
            this.comboBoxSemestre.Location = new System.Drawing.Point(244, 40);
            this.comboBoxSemestre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSemestre.Name = "comboBoxSemestre";
            this.comboBoxSemestre.Size = new System.Drawing.Size(216, 28);
            this.comboBoxSemestre.TabIndex = 2;
            this.comboBoxSemestre.SelectedIndexChanged += new System.EventHandler(this.comboBoxSemestre_SelectedIndexChanged);
            // 
            // comboBoxRamo
            // 
            this.comboBoxRamo.FormattingEnabled = true;
            this.comboBoxRamo.Location = new System.Drawing.Point(245, 85);
            this.comboBoxRamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxRamo.Name = "comboBoxRamo";
            this.comboBoxRamo.Size = new System.Drawing.Size(216, 28);
            this.comboBoxRamo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese Nombre Seccion";
            // 
            // textBoxNuevoNombre
            // 
            this.textBoxNuevoNombre.Location = new System.Drawing.Point(244, 132);
            this.textBoxNuevoNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNuevoNombre.Name = "textBoxNuevoNombre";
            this.textBoxNuevoNombre.Size = new System.Drawing.Size(216, 26);
            this.textBoxNuevoNombre.TabIndex = 5;
            // 
            // botonAtras
            // 
            this.botonAtras.Location = new System.Drawing.Point(429, 352);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(170, 40);
            this.botonAtras.TabIndex = 13;
            this.botonAtras.Text = "Atras";
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // botonCrearSeccion
            // 
            this.botonCrearSeccion.Location = new System.Drawing.Point(98, 286);
            this.botonCrearSeccion.Name = "botonCrearSeccion";
            this.botonCrearSeccion.Size = new System.Drawing.Size(170, 40);
            this.botonCrearSeccion.TabIndex = 14;
            this.botonCrearSeccion.Text = "Crear Seccion";
            this.botonCrearSeccion.UseVisualStyleBackColor = true;
            this.botonCrearSeccion.Click += new System.EventHandler(this.botonCrearSeccion_Click);
            // 
            // labelVacantes
            // 
            this.labelVacantes.AutoSize = true;
            this.labelVacantes.Location = new System.Drawing.Point(30, 187);
            this.labelVacantes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVacantes.Name = "labelVacantes";
            this.labelVacantes.Size = new System.Drawing.Size(135, 20);
            this.labelVacantes.TabIndex = 15;
            this.labelVacantes.Text = "Ingrese Vacantes";
            // 
            // textBoxVacantes
            // 
            this.textBoxVacantes.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxVacantes.Location = new System.Drawing.Point(243, 182);
            this.textBoxVacantes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxVacantes.Name = "textBoxVacantes";
            this.textBoxVacantes.ReadOnly = true;
            this.textBoxVacantes.Size = new System.Drawing.Size(84, 26);
            this.textBoxVacantes.TabIndex = 16;
            // 
            // botonMas
            // 
            this.botonMas.Location = new System.Drawing.Point(380, 182);
            this.botonMas.Name = "botonMas";
            this.botonMas.Size = new System.Drawing.Size(28, 31);
            this.botonMas.TabIndex = 17;
            this.botonMas.Text = "+";
            this.botonMas.UseVisualStyleBackColor = true;
            this.botonMas.Click += new System.EventHandler(this.botonMas_Click);
            // 
            // botonMenos
            // 
            this.botonMenos.Location = new System.Drawing.Point(344, 182);
            this.botonMenos.Name = "botonMenos";
            this.botonMenos.Size = new System.Drawing.Size(28, 31);
            this.botonMenos.TabIndex = 18;
            this.botonMenos.Text = "-";
            this.botonMenos.UseVisualStyleBackColor = true;
            this.botonMenos.Click += new System.EventHandler(this.botonMenos_Click);
            // 
            // CrearSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 409);
            this.Controls.Add(this.botonMenos);
            this.Controls.Add(this.botonMas);
            this.Controls.Add(this.textBoxVacantes);
            this.Controls.Add(this.labelVacantes);
            this.Controls.Add(this.botonCrearSeccion);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.textBoxNuevoNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRamo);
            this.Controls.Add(this.comboBoxSemestre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CrearSeccion";
            this.Text = "Crear Seccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSemestre;
        private System.Windows.Forms.ComboBox comboBoxRamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNuevoNombre;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Button botonCrearSeccion;
        private System.Windows.Forms.Label labelVacantes;
        private System.Windows.Forms.TextBox textBoxVacantes;
        private System.Windows.Forms.Button botonMas;
        private System.Windows.Forms.Button botonMenos;
    }
}