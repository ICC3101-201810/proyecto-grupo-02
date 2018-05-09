namespace VistaNotas
{
    partial class Menu_Administrador
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
            this.Bienvenida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Alumnos = new System.Windows.Forms.LinkLabel();
            this.Profesores = new System.Windows.Forms.LinkLabel();
            this.Ramos = new System.Windows.Forms.LinkLabel();
            this.Semestre = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Bienvenida
            // 
            this.Bienvenida.AutoSize = true;
            this.Bienvenida.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenida.Location = new System.Drawing.Point(72, 47);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(407, 35);
            this.Bienvenida.TabIndex = 0;
            this.Bienvenida.Text = "Bienvenido Administrador";
            this.Bienvenida.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "¿Qué desea administrar?";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Alumnos
            // 
            this.Alumnos.AutoSize = true;
            this.Alumnos.Location = new System.Drawing.Point(87, 148);
            this.Alumnos.Name = "Alumnos";
            this.Alumnos.Size = new System.Drawing.Size(71, 20);
            this.Alumnos.TabIndex = 2;
            this.Alumnos.TabStop = true;
            this.Alumnos.Text = "Alumnos";
            this.Alumnos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Profesores
            // 
            this.Profesores.AutoSize = true;
            this.Profesores.Location = new System.Drawing.Point(87, 168);
            this.Profesores.Name = "Profesores";
            this.Profesores.Size = new System.Drawing.Size(86, 20);
            this.Profesores.TabIndex = 3;
            this.Profesores.TabStop = true;
            this.Profesores.Text = "Profesores";
            // 
            // Ramos
            // 
            this.Ramos.AutoSize = true;
            this.Ramos.Location = new System.Drawing.Point(87, 188);
            this.Ramos.Name = "Ramos";
            this.Ramos.Size = new System.Drawing.Size(60, 20);
            this.Ramos.TabIndex = 4;
            this.Ramos.TabStop = true;
            this.Ramos.Text = "Ramos";
            this.Ramos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // Semestre
            // 
            this.Semestre.AutoSize = true;
            this.Semestre.Location = new System.Drawing.Point(87, 208);
            this.Semestre.Name = "Semestre";
            this.Semestre.Size = new System.Drawing.Size(78, 20);
            this.Semestre.TabIndex = 5;
            this.Semestre.TabStop = true;
            this.Semestre.Text = "Semestre";
            // 
            // Menu_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Semestre);
            this.Controls.Add(this.Ramos);
            this.Controls.Add(this.Profesores);
            this.Controls.Add(this.Alumnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bienvenida);
            this.Name = "Menu_Administrador";
            this.Text = "Menu_Administrador";
            this.Load += new System.EventHandler(this.Menu_Administrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bienvenida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Alumnos;
        private System.Windows.Forms.LinkLabel Profesores;
        private System.Windows.Forms.LinkLabel Ramos;
        private System.Windows.Forms.LinkLabel Semestre;
    }
}