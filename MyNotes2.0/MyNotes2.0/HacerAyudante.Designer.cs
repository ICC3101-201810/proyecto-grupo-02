namespace MyNotes2._0
{
    partial class HacerAyudante
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
            this.nombreAlumno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listaRamos = new System.Windows.Forms.ComboBox();
            this.listaSecciones = new System.Windows.Forms.ComboBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listaSemestre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumno:";
            // 
            // nombreAlumno
            // 
            this.nombreAlumno.AutoSize = true;
            this.nombreAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreAlumno.Location = new System.Drawing.Point(235, 38);
            this.nombreAlumno.Name = "nombreAlumno";
            this.nombreAlumno.Size = new System.Drawing.Size(235, 32);
            this.nombreAlumno.TabIndex = 1;
            this.nombreAlumno.Text = "[Nombre Alumno]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione ramo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione sección:";
            // 
            // listaRamos
            // 
            this.listaRamos.FormattingEnabled = true;
            this.listaRamos.Location = new System.Drawing.Point(266, 152);
            this.listaRamos.Name = "listaRamos";
            this.listaRamos.Size = new System.Drawing.Size(232, 28);
            this.listaRamos.TabIndex = 4;
            this.listaRamos.SelectedIndexChanged += new System.EventHandler(this.listaRamos_SelectedIndexChanged);
            // 
            // listaSecciones
            // 
            this.listaSecciones.FormattingEnabled = true;
            this.listaSecciones.Location = new System.Drawing.Point(266, 197);
            this.listaSecciones.Name = "listaSecciones";
            this.listaSecciones.Size = new System.Drawing.Size(232, 28);
            this.listaSecciones.TabIndex = 5;
            this.listaSecciones.SelectedIndexChanged += new System.EventHandler(this.listaSecciones_SelectedIndexChanged);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(620, 310);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(94, 33);
            this.Aceptar.TabIndex = 7;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(437, 310);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(94, 33);
            this.Cancelar.TabIndex = 6;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seleccione semestre:";
            // 
            // listaSemestre
            // 
            this.listaSemestre.FormattingEnabled = true;
            this.listaSemestre.Location = new System.Drawing.Point(266, 107);
            this.listaSemestre.Name = "listaSemestre";
            this.listaSemestre.Size = new System.Drawing.Size(232, 28);
            this.listaSemestre.TabIndex = 9;
            this.listaSemestre.SelectedIndexChanged += new System.EventHandler(this.listaSemestre_SelectedIndexChanged);
            // 
            // HacerAyudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaSemestre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.listaSecciones);
            this.Controls.Add(this.listaRamos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreAlumno);
            this.Controls.Add(this.label1);
            this.Name = "HacerAyudante";
            this.Text = "d";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombreAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox listaRamos;
        private System.Windows.Forms.ComboBox listaSecciones;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox listaSemestre;
    }
}