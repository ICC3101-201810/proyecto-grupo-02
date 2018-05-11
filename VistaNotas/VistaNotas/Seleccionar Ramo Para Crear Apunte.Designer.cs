namespace VistaNotas
{
    partial class Seleccionar_Ramo_Para_Crear_Apunte
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
            this.comboBox_Seleccion_Ramo = new System.Windows.Forms.ComboBox();
            this.LabelSeleccioneRamo = new System.Windows.Forms.Label();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.Nombre_Nuevo_Apunte = new System.Windows.Forms.TextBox();
            this.Label_Escriba_Nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_Seleccion_Ramo
            // 
            this.comboBox_Seleccion_Ramo.FormattingEnabled = true;
            this.comboBox_Seleccion_Ramo.Location = new System.Drawing.Point(536, 100);
            this.comboBox_Seleccion_Ramo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Seleccion_Ramo.Name = "comboBox_Seleccion_Ramo";
            this.comboBox_Seleccion_Ramo.Size = new System.Drawing.Size(465, 24);
            this.comboBox_Seleccion_Ramo.TabIndex = 0;
            // 
            // LabelSeleccioneRamo
            // 
            this.LabelSeleccioneRamo.AutoSize = true;
            this.LabelSeleccioneRamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSeleccioneRamo.Location = new System.Drawing.Point(60, 95);
            this.LabelSeleccioneRamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSeleccioneRamo.Name = "LabelSeleccioneRamo";
            this.LabelSeleccioneRamo.Size = new System.Drawing.Size(219, 29);
            this.LabelSeleccioneRamo.TabIndex = 1;
            this.LabelSeleccioneRamo.Text = "Seleccione Ramo";
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(785, 240);
            this.BotonAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(217, 58);
            this.BotonAceptar.TabIndex = 2;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // Nombre_Nuevo_Apunte
            // 
            this.Nombre_Nuevo_Apunte.Location = new System.Drawing.Point(541, 166);
            this.Nombre_Nuevo_Apunte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nombre_Nuevo_Apunte.Name = "Nombre_Nuevo_Apunte";
            this.Nombre_Nuevo_Apunte.Size = new System.Drawing.Size(459, 22);
            this.Nombre_Nuevo_Apunte.TabIndex = 3;
            this.Nombre_Nuevo_Apunte.TextChanged += new System.EventHandler(this.Nombre_Nuevo_Apunte_TextChanged);
            // 
            // Label_Escriba_Nombre
            // 
            this.Label_Escriba_Nombre.AutoSize = true;
            this.Label_Escriba_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Escriba_Nombre.Location = new System.Drawing.Point(59, 159);
            this.Label_Escriba_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Escriba_Nombre.Name = "Label_Escriba_Nombre";
            this.Label_Escriba_Nombre.Size = new System.Drawing.Size(277, 29);
            this.Label_Escriba_Nombre.TabIndex = 4;
            this.Label_Escriba_Nombre.Text = "Nombre Nuevo Apunte";
            // 
            // Seleccionar_Ramo_Para_Crear_Apunte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Label_Escriba_Nombre);
            this.Controls.Add(this.Nombre_Nuevo_Apunte);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.LabelSeleccioneRamo);
            this.Controls.Add(this.comboBox_Seleccion_Ramo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Seleccionar_Ramo_Para_Crear_Apunte";
            this.Text = "Seleccionar_Ramo_Para_Crear_Apunte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Seleccion_Ramo;
        private System.Windows.Forms.Label LabelSeleccioneRamo;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.TextBox Nombre_Nuevo_Apunte;
        private System.Windows.Forms.Label Label_Escriba_Nombre;
    }
}