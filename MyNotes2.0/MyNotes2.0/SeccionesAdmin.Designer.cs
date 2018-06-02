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
            this.button_verSecciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSecciones
            // 
            this.labelSecciones.AutoSize = true;
            this.labelSecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecciones.Location = new System.Drawing.Point(48, 54);
            this.labelSecciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSecciones.Name = "labelSecciones";
            this.labelSecciones.Size = new System.Drawing.Size(104, 25);
            this.labelSecciones.TabIndex = 0;
            this.labelSecciones.Text = "Secciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "¿Qué desea realizar?";
            // 
            // botonCrearSeccion
            // 
            this.botonCrearSeccion.Location = new System.Drawing.Point(92, 160);
            this.botonCrearSeccion.Name = "botonCrearSeccion";
            this.botonCrearSeccion.Size = new System.Drawing.Size(154, 32);
            this.botonCrearSeccion.TabIndex = 10;
            this.botonCrearSeccion.Text = "Crear Seccion";
            this.botonCrearSeccion.UseVisualStyleBackColor = true;
            this.botonCrearSeccion.Click += new System.EventHandler(this.botonCrearSeccion_Click);
            // 
            // botonEditarSeccion
            // 
            this.botonEditarSeccion.Location = new System.Drawing.Point(332, 160);
            this.botonEditarSeccion.Name = "botonEditarSeccion";
            this.botonEditarSeccion.Size = new System.Drawing.Size(154, 32);
            this.botonEditarSeccion.TabIndex = 11;
            this.botonEditarSeccion.Text = "Editar Seccion";
            this.botonEditarSeccion.UseVisualStyleBackColor = true;
            this.botonEditarSeccion.Click += new System.EventHandler(this.botonEditarSeccion_Click);
            // 
            // botonAtras
            // 
            this.botonAtras.Location = new System.Drawing.Point(429, 352);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(170, 40);
            this.botonAtras.TabIndex = 12;
            this.botonAtras.Text = "Atras";
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // button_verSecciones
            // 
            this.button_verSecciones.Location = new System.Drawing.Point(92, 198);
            this.button_verSecciones.Name = "button_verSecciones";
            this.button_verSecciones.Size = new System.Drawing.Size(154, 32);
            this.button_verSecciones.TabIndex = 13;
            this.button_verSecciones.Text = "Ver Secciones";
            this.button_verSecciones.UseVisualStyleBackColor = true;
            this.button_verSecciones.Click += new System.EventHandler(this.button_verSecciones_Click);
            // 
            // SeccionesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 409);
            this.Controls.Add(this.button_verSecciones);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonEditarSeccion);
            this.Controls.Add(this.botonCrearSeccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSecciones);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SeccionesAdmin";
            this.Text = "Secciones";
            this.Load += new System.EventHandler(this.SeccionesAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSecciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonCrearSeccion;
        private System.Windows.Forms.Button botonEditarSeccion;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Button button_verSecciones;
    }
}