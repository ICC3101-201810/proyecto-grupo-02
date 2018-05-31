namespace MyNotes2._0
{
    partial class SeccionesAdmin
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
            this.labelSecciones = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonCrearSeccion = new System.Windows.Forms.Button();
            this.botonEditarSeccion = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSecciones
            // 
            this.labelSecciones.AutoSize = true;
            this.labelSecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecciones.Location = new System.Drawing.Point(32, 35);
            this.labelSecciones.Name = "labelSecciones";
            this.labelSecciones.Size = new System.Drawing.Size(72, 16);
            this.labelSecciones.TabIndex = 0;
            this.labelSecciones.Text = "Secciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "¿Qué desea realizar?";
            // 
            // botonCrearSeccion
            // 
            this.botonCrearSeccion.Location = new System.Drawing.Point(62, 104);
            this.botonCrearSeccion.Margin = new System.Windows.Forms.Padding(2);
            this.botonCrearSeccion.Name = "botonCrearSeccion";
            this.botonCrearSeccion.Size = new System.Drawing.Size(103, 21);
            this.botonCrearSeccion.TabIndex = 10;
            this.botonCrearSeccion.Text = "Crear Seccion";
            this.botonCrearSeccion.UseVisualStyleBackColor = true;
            this.botonCrearSeccion.Click += new System.EventHandler(this.botonCrearSeccion_Click);
            // 
            // botonEditarSeccion
            // 
            this.botonEditarSeccion.Location = new System.Drawing.Point(221, 104);
            this.botonEditarSeccion.Margin = new System.Windows.Forms.Padding(2);
            this.botonEditarSeccion.Name = "botonEditarSeccion";
            this.botonEditarSeccion.Size = new System.Drawing.Size(103, 21);
            this.botonEditarSeccion.TabIndex = 11;
            this.botonEditarSeccion.Text = "Editar Seccion";
            this.botonEditarSeccion.UseVisualStyleBackColor = true;
            // 
            // botonAtras
            // 
            this.botonAtras.Location = new System.Drawing.Point(286, 229);
            this.botonAtras.Margin = new System.Windows.Forms.Padding(2);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(113, 26);
            this.botonAtras.TabIndex = 12;
            this.botonAtras.Text = "Atras";
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // SeccionesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 266);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonEditarSeccion);
            this.Controls.Add(this.botonCrearSeccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSecciones);
            this.Name = "SeccionesAdmin";
            this.Text = "Secciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSecciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonCrearSeccion;
        private System.Windows.Forms.Button botonEditarSeccion;
        private System.Windows.Forms.Button botonAtras;
    }
}