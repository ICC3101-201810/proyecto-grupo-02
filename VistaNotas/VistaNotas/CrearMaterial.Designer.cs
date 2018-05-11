namespace VistaNotas
{
    partial class CrearMaterial
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
            this.Label_Escriba_Nombre = new System.Windows.Forms.Label();
            this.Nombre_Nuevo_Apunte = new System.Windows.Forms.TextBox();
            this.LabelSeleccioneRamo = new System.Windows.Forms.Label();
            this.comboBox_Seleccion_Ramo = new System.Windows.Forms.ComboBox();
            this.IngresoMaterial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Escriba_Nombre
            // 
            this.Label_Escriba_Nombre.AutoSize = true;
            this.Label_Escriba_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Escriba_Nombre.Location = new System.Drawing.Point(32, 94);
            this.Label_Escriba_Nombre.Name = "Label_Escriba_Nombre";
            this.Label_Escriba_Nombre.Size = new System.Drawing.Size(231, 24);
            this.Label_Escriba_Nombre.TabIndex = 8;
            this.Label_Escriba_Nombre.Text = "Nombre Nuevo Material";
            // 
            // Nombre_Nuevo_Apunte
            // 
            this.Nombre_Nuevo_Apunte.Location = new System.Drawing.Point(394, 100);
            this.Nombre_Nuevo_Apunte.Name = "Nombre_Nuevo_Apunte";
            this.Nombre_Nuevo_Apunte.Size = new System.Drawing.Size(345, 20);
            this.Nombre_Nuevo_Apunte.TabIndex = 7;
            // 
            // LabelSeleccioneRamo
            // 
            this.LabelSeleccioneRamo.AutoSize = true;
            this.LabelSeleccioneRamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSeleccioneRamo.Location = new System.Drawing.Point(33, 42);
            this.LabelSeleccioneRamo.Name = "LabelSeleccioneRamo";
            this.LabelSeleccioneRamo.Size = new System.Drawing.Size(175, 24);
            this.LabelSeleccioneRamo.TabIndex = 6;
            this.LabelSeleccioneRamo.Text = "Seleccione Ramo";
            // 
            // comboBox_Seleccion_Ramo
            // 
            this.comboBox_Seleccion_Ramo.FormattingEnabled = true;
            this.comboBox_Seleccion_Ramo.Location = new System.Drawing.Point(390, 46);
            this.comboBox_Seleccion_Ramo.Name = "comboBox_Seleccion_Ramo";
            this.comboBox_Seleccion_Ramo.Size = new System.Drawing.Size(350, 21);
            this.comboBox_Seleccion_Ramo.TabIndex = 5;
            // 
            // IngresoMaterial
            // 
            this.IngresoMaterial.Location = new System.Drawing.Point(36, 155);
            this.IngresoMaterial.Multiline = true;
            this.IngresoMaterial.Name = "IngresoMaterial";
            this.IngresoMaterial.Size = new System.Drawing.Size(752, 230);
            this.IngresoMaterial.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingrese Material";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 47);
            this.button2.TabIndex = 11;
            this.button2.Text = "Atras";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(700, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CrearMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IngresoMaterial);
            this.Controls.Add(this.Label_Escriba_Nombre);
            this.Controls.Add(this.Nombre_Nuevo_Apunte);
            this.Controls.Add(this.LabelSeleccioneRamo);
            this.Controls.Add(this.comboBox_Seleccion_Ramo);
            this.Name = "CrearMaterial";
            this.Text = "CrearMaterial";
            this.Load += new System.EventHandler(this.CrearMaterial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Escriba_Nombre;
        private System.Windows.Forms.TextBox Nombre_Nuevo_Apunte;
        private System.Windows.Forms.Label LabelSeleccioneRamo;
        private System.Windows.Forms.ComboBox comboBox_Seleccion_Ramo;
        private System.Windows.Forms.TextBox IngresoMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}