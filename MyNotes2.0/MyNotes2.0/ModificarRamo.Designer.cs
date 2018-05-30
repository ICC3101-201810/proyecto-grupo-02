namespace MyNotes2._0
{
    partial class ModificarRamo
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
            this.eliminarProfesor = new System.Windows.Forms.Button();
            this.botonCambiarNombre = new System.Windows.Forms.Button();
            this.ComboBoxRamos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCambiarNombre = new System.Windows.Forms.Label();
            this.textBoxCambiarNombre = new System.Windows.Forms.TextBox();
            this.ComboBoxSemestre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 220);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eliminarProfesor
            // 
            this.eliminarProfesor.Location = new System.Drawing.Point(290, 160);
            this.eliminarProfesor.Margin = new System.Windows.Forms.Padding(2);
            this.eliminarProfesor.Name = "eliminarProfesor";
            this.eliminarProfesor.Size = new System.Drawing.Size(163, 20);
            this.eliminarProfesor.TabIndex = 15;
            this.eliminarProfesor.Text = "Eliminar ramo";
            this.eliminarProfesor.UseVisualStyleBackColor = true;
            // 
            // botonCambiarNombre
            // 
            this.botonCambiarNombre.Location = new System.Drawing.Point(79, 160);
            this.botonCambiarNombre.Margin = new System.Windows.Forms.Padding(2);
            this.botonCambiarNombre.Name = "botonCambiarNombre";
            this.botonCambiarNombre.Size = new System.Drawing.Size(163, 20);
            this.botonCambiarNombre.TabIndex = 14;
            this.botonCambiarNombre.Text = "Cambiar nombre ramo";
            this.botonCambiarNombre.UseVisualStyleBackColor = true;
            this.botonCambiarNombre.Click += new System.EventHandler(this.botonCambiarNombreRamo_Click);
            // 
            // ComboBoxRamos
            // 
            this.ComboBoxRamos.FormattingEnabled = true;
            this.ComboBoxRamos.Location = new System.Drawing.Point(213, 59);
            this.ComboBoxRamos.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxRamos.Name = "ComboBoxRamos";
            this.ComboBoxRamos.Size = new System.Drawing.Size(202, 21);
            this.ComboBoxRamos.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seleccione ramo a modificar:";
            // 
            // labelCambiarNombre
            // 
            this.labelCambiarNombre.AutoSize = true;
            this.labelCambiarNombre.Location = new System.Drawing.Point(47, 100);
            this.labelCambiarNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCambiarNombre.Name = "labelCambiarNombre";
            this.labelCambiarNombre.Size = new System.Drawing.Size(117, 13);
            this.labelCambiarNombre.TabIndex = 17;
            this.labelCambiarNombre.Text = "Indique Nuevo Nombre";
            // 
            // textBoxCambiarNombre
            // 
            this.textBoxCambiarNombre.Location = new System.Drawing.Point(213, 97);
            this.textBoxCambiarNombre.Name = "textBoxCambiarNombre";
            this.textBoxCambiarNombre.Size = new System.Drawing.Size(201, 20);
            this.textBoxCambiarNombre.TabIndex = 18;
            // 
            // ComboBoxSemestre
            // 
            this.ComboBoxSemestre.FormattingEnabled = true;
            this.ComboBoxSemestre.Location = new System.Drawing.Point(213, 20);
            this.ComboBoxSemestre.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxSemestre.Name = "ComboBoxSemestre";
            this.ComboBoxSemestre.Size = new System.Drawing.Size(202, 21);
            this.ComboBoxSemestre.TabIndex = 20;
            this.ComboBoxSemestre.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSemestre_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Seleccione Semestre";
            // 
            // ModificarRamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.ComboBoxSemestre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCambiarNombre);
            this.Controls.Add(this.labelCambiarNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eliminarProfesor);
            this.Controls.Add(this.botonCambiarNombre);
            this.Controls.Add(this.ComboBoxRamos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModificarRamo";
            this.Text = "ModificarRamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button eliminarProfesor;
        private System.Windows.Forms.Button botonCambiarNombre;
        private System.Windows.Forms.ComboBox ComboBoxRamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCambiarNombre;
        private System.Windows.Forms.TextBox textBoxCambiarNombre;
        private System.Windows.Forms.ComboBox ComboBoxSemestre;
        private System.Windows.Forms.Label label2;
    }
}