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
            this.BotonCrear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IngresoApunte = new System.Windows.Forms.TextBox();
            this.Label_Escriba_Nombre = new System.Windows.Forms.Label();
            this.Nombre_Nuevo_Apunte = new System.Windows.Forms.TextBox();
            this.LabelSeleccioneRamo = new System.Windows.Forms.Label();
            this.comboBox_Seleccion_Ramo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BotonCrear
            // 
            this.BotonCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCrear.Location = new System.Drawing.Point(700, 376);
            this.BotonCrear.Name = "BotonCrear";
            this.BotonCrear.Size = new System.Drawing.Size(88, 47);
            this.BotonCrear.TabIndex = 20;
            this.BotonCrear.Text = "Crear";
            this.BotonCrear.UseVisualStyleBackColor = true;
            this.BotonCrear.Click += new System.EventHandler(this.BotonCrear_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 47);
            this.button2.TabIndex = 19;
            this.button2.Text = "Atras";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ingrese Apunte";
            // 
            // IngresoApunte
            // 
            this.IngresoApunte.Location = new System.Drawing.Point(36, 140);
            this.IngresoApunte.Multiline = true;
            this.IngresoApunte.Name = "IngresoApunte";
            this.IngresoApunte.Size = new System.Drawing.Size(752, 230);
            this.IngresoApunte.TabIndex = 17;
            // 
            // Label_Escriba_Nombre
            // 
            this.Label_Escriba_Nombre.AutoSize = true;
            this.Label_Escriba_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Escriba_Nombre.Location = new System.Drawing.Point(32, 79);
            this.Label_Escriba_Nombre.Name = "Label_Escriba_Nombre";
            this.Label_Escriba_Nombre.Size = new System.Drawing.Size(225, 24);
            this.Label_Escriba_Nombre.TabIndex = 16;
            this.Label_Escriba_Nombre.Text = "Nombre Nuevo Apunte";
            // 
            // Nombre_Nuevo_Apunte
            // 
            this.Nombre_Nuevo_Apunte.Location = new System.Drawing.Point(394, 85);
            this.Nombre_Nuevo_Apunte.Name = "Nombre_Nuevo_Apunte";
            this.Nombre_Nuevo_Apunte.Size = new System.Drawing.Size(345, 20);
            this.Nombre_Nuevo_Apunte.TabIndex = 15;
            // 
            // LabelSeleccioneRamo
            // 
            this.LabelSeleccioneRamo.AutoSize = true;
            this.LabelSeleccioneRamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSeleccioneRamo.Location = new System.Drawing.Point(33, 27);
            this.LabelSeleccioneRamo.Name = "LabelSeleccioneRamo";
            this.LabelSeleccioneRamo.Size = new System.Drawing.Size(175, 24);
            this.LabelSeleccioneRamo.TabIndex = 14;
            this.LabelSeleccioneRamo.Text = "Seleccione Ramo";
            // 
            // comboBox_Seleccion_Ramo
            // 
            this.comboBox_Seleccion_Ramo.FormattingEnabled = true;
            this.comboBox_Seleccion_Ramo.Location = new System.Drawing.Point(390, 31);
            this.comboBox_Seleccion_Ramo.Name = "comboBox_Seleccion_Ramo";
            this.comboBox_Seleccion_Ramo.Size = new System.Drawing.Size(350, 21);
            this.comboBox_Seleccion_Ramo.TabIndex = 13;
            // 
            // Seleccionar_Ramo_Para_Crear_Apunte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonCrear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IngresoApunte);
            this.Controls.Add(this.Label_Escriba_Nombre);
            this.Controls.Add(this.Nombre_Nuevo_Apunte);
            this.Controls.Add(this.LabelSeleccioneRamo);
            this.Controls.Add(this.comboBox_Seleccion_Ramo);
            this.Name = "Seleccionar_Ramo_Para_Crear_Apunte";
            this.Text = "Seleccionar_Ramo_Para_Crear_Apunte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonCrear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IngresoApunte;
        private System.Windows.Forms.Label Label_Escriba_Nombre;
        private System.Windows.Forms.TextBox Nombre_Nuevo_Apunte;
        private System.Windows.Forms.Label LabelSeleccioneRamo;
        private System.Windows.Forms.ComboBox comboBox_Seleccion_Ramo;
    }
}