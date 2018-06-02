namespace MyNotes2._0
{
    partial class OpcionesSeccion
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
            this.botonAtras = new System.Windows.Forms.Button();
            this.botonMenos = new System.Windows.Forms.Button();
            this.botonMas = new System.Windows.Forms.Button();
            this.textBoxVacantes = new System.Windows.Forms.TextBox();
            this.labelVacantes = new System.Windows.Forms.Label();
            this.botonCambiarVacantes = new System.Windows.Forms.Button();
            this.textBoxNuevoNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRamo = new System.Windows.Forms.ComboBox();
            this.comboBoxSemestre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSeccion = new System.Windows.Forms.ComboBox();
            this.botonCambiarNombre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonAtras
            // 
            this.botonAtras.Location = new System.Drawing.Point(286, 229);
            this.botonAtras.Margin = new System.Windows.Forms.Padding(2);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(113, 26);
            this.botonAtras.TabIndex = 15;
            this.botonAtras.Text = "Atras";
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // botonMenos
            // 
            this.botonMenos.Location = new System.Drawing.Point(237, 144);
            this.botonMenos.Margin = new System.Windows.Forms.Padding(2);
            this.botonMenos.Name = "botonMenos";
            this.botonMenos.Size = new System.Drawing.Size(19, 20);
            this.botonMenos.TabIndex = 29;
            this.botonMenos.Text = "-";
            this.botonMenos.UseVisualStyleBackColor = true;
            this.botonMenos.Click += new System.EventHandler(this.botonMenos_Click);
            // 
            // botonMas
            // 
            this.botonMas.Location = new System.Drawing.Point(261, 144);
            this.botonMas.Margin = new System.Windows.Forms.Padding(2);
            this.botonMas.Name = "botonMas";
            this.botonMas.Size = new System.Drawing.Size(19, 20);
            this.botonMas.TabIndex = 28;
            this.botonMas.Text = "+";
            this.botonMas.UseVisualStyleBackColor = true;
            this.botonMas.Click += new System.EventHandler(this.botonMas_Click);
            // 
            // textBoxVacantes
            // 
            this.textBoxVacantes.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxVacantes.Location = new System.Drawing.Point(170, 144);
            this.textBoxVacantes.Name = "textBoxVacantes";
            this.textBoxVacantes.ReadOnly = true;
            this.textBoxVacantes.Size = new System.Drawing.Size(57, 20);
            this.textBoxVacantes.TabIndex = 27;
            // 
            // labelVacantes
            // 
            this.labelVacantes.AutoSize = true;
            this.labelVacantes.Location = new System.Drawing.Point(27, 147);
            this.labelVacantes.Name = "labelVacantes";
            this.labelVacantes.Size = new System.Drawing.Size(90, 13);
            this.labelVacantes.TabIndex = 26;
            this.labelVacantes.Text = "Ingrese Vacantes";
            // 
            // botonCambiarVacantes
            // 
            this.botonCambiarVacantes.Location = new System.Drawing.Point(68, 191);
            this.botonCambiarVacantes.Margin = new System.Windows.Forms.Padding(2);
            this.botonCambiarVacantes.Name = "botonCambiarVacantes";
            this.botonCambiarVacantes.Size = new System.Drawing.Size(113, 36);
            this.botonCambiarVacantes.TabIndex = 25;
            this.botonCambiarVacantes.Text = "Cambiar Vacantes";
            this.botonCambiarVacantes.UseVisualStyleBackColor = true;
            this.botonCambiarVacantes.Click += new System.EventHandler(this.botonCambiarVacantes_Click);
            // 
            // textBoxNuevoNombre
            // 
            this.textBoxNuevoNombre.Location = new System.Drawing.Point(170, 112);
            this.textBoxNuevoNombre.Name = "textBoxNuevoNombre";
            this.textBoxNuevoNombre.Size = new System.Drawing.Size(145, 20);
            this.textBoxNuevoNombre.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ingrese Nombre Nuevo";
            // 
            // comboBoxRamo
            // 
            this.comboBoxRamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRamo.FormattingEnabled = true;
            this.comboBoxRamo.Location = new System.Drawing.Point(170, 53);
            this.comboBoxRamo.Name = "comboBoxRamo";
            this.comboBoxRamo.Size = new System.Drawing.Size(145, 21);
            this.comboBoxRamo.TabIndex = 22;
            this.comboBoxRamo.SelectedIndexChanged += new System.EventHandler(this.comboBoxRamo_SelectedIndexChanged);
            // 
            // comboBoxSemestre
            // 
            this.comboBoxSemestre.AllowDrop = true;
            this.comboBoxSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSemestre.FormattingEnabled = true;
            this.comboBoxSemestre.Location = new System.Drawing.Point(170, 26);
            this.comboBoxSemestre.Name = "comboBoxSemestre";
            this.comboBoxSemestre.Size = new System.Drawing.Size(145, 21);
            this.comboBoxSemestre.TabIndex = 21;
            this.comboBoxSemestre.SelectedIndexChanged += new System.EventHandler(this.comboBoxSemestre_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Seleccione Ramo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Seleccione Semestre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Seleccione Seccion";
            // 
            // comboBoxSeccion
            // 
            this.comboBoxSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeccion.FormattingEnabled = true;
            this.comboBoxSeccion.Location = new System.Drawing.Point(170, 80);
            this.comboBoxSeccion.Name = "comboBoxSeccion";
            this.comboBoxSeccion.Size = new System.Drawing.Size(145, 21);
            this.comboBoxSeccion.TabIndex = 31;
            this.comboBoxSeccion.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeccion_SelectedIndexChanged);
            // 
            // botonCambiarNombre
            // 
            this.botonCambiarNombre.Location = new System.Drawing.Point(237, 189);
            this.botonCambiarNombre.Margin = new System.Windows.Forms.Padding(2);
            this.botonCambiarNombre.Name = "botonCambiarNombre";
            this.botonCambiarNombre.Size = new System.Drawing.Size(113, 36);
            this.botonCambiarNombre.TabIndex = 32;
            this.botonCambiarNombre.Text = "Cambiar Nombre Seccion";
            this.botonCambiarNombre.UseVisualStyleBackColor = true;
            this.botonCambiarNombre.Click += new System.EventHandler(this.botonCambiarNombre_Click);
            // 
            // OpcionesSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 266);
            this.Controls.Add(this.botonCambiarNombre);
            this.Controls.Add(this.comboBoxSeccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonMenos);
            this.Controls.Add(this.botonMas);
            this.Controls.Add(this.textBoxVacantes);
            this.Controls.Add(this.labelVacantes);
            this.Controls.Add(this.botonCambiarVacantes);
            this.Controls.Add(this.textBoxNuevoNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRamo);
            this.Controls.Add(this.comboBoxSemestre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonAtras);
            this.Name = "OpcionesSeccion";
            this.Text = "OpcionesSeccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Button botonMenos;
        private System.Windows.Forms.Button botonMas;
        private System.Windows.Forms.TextBox textBoxVacantes;
        private System.Windows.Forms.Label labelVacantes;
        private System.Windows.Forms.Button botonCambiarVacantes;
        private System.Windows.Forms.TextBox textBoxNuevoNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRamo;
        private System.Windows.Forms.ComboBox comboBoxSemestre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSeccion;
        private System.Windows.Forms.Button botonCambiarNombre;
    }
}