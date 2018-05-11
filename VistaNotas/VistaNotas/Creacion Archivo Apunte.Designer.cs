namespace VistaNotas
{
    partial class Creacion_Archivo_Apunte
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
            this.CBTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBCapitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TPFecha = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            // 
            // CBTipo
            // 
            this.CBTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTipo.FormattingEnabled = true;
            this.CBTipo.Location = new System.Drawing.Point(376, 126);
            this.CBTipo.Name = "CBTipo";
            this.CBTipo.Size = new System.Drawing.Size(259, 33);
            this.CBTipo.TabIndex = 1;
            this.CBTipo.SelectedIndexChanged += new System.EventHandler(this.CBTipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombre.Location = new System.Drawing.Point(376, 69);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(258, 30);
            this.TBNombre.TabIndex = 3;
            this.TBNombre.Text = "SinNombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Creacion de archivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Capitulo/Tema";
            // 
            // TBCapitulo
            // 
            this.TBCapitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCapitulo.Location = new System.Drawing.Point(376, 194);
            this.TBCapitulo.Name = "TBCapitulo";
            this.TBCapitulo.Size = new System.Drawing.Size(258, 30);
            this.TBCapitulo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha";
            // 
            // TPFecha
            // 
            this.TPFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPFecha.Location = new System.Drawing.Point(376, 273);
            this.TPFecha.Name = "TPFecha";
            this.TPFecha.Size = new System.Drawing.Size(256, 30);
            this.TPFecha.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(526, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "Crear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Creacion_Archivo_Apunte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 479);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TPFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBCapitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBTipo);
            this.Controls.Add(this.label1);
            this.Name = "Creacion_Archivo_Apunte";
            this.Text = "Creacion_Archivo_Apunte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBCapitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker TPFecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}