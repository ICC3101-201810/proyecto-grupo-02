namespace VistaNotas
{
    partial class Menu_Profesor
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LinkEditarApunte = new System.Windows.Forms.LinkLabel();
            this.LinkAgregarRecordatorio = new System.Windows.Forms.LinkLabel();
            this.LinkCrearApunte = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido Profesor";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cerrar Sesion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "¿Qué desea hacer?";
            // 
            // LinkEditarApunte
            // 
            this.LinkEditarApunte.AutoSize = true;
            this.LinkEditarApunte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkEditarApunte.Location = new System.Drawing.Point(145, 255);
            this.LinkEditarApunte.Name = "LinkEditarApunte";
            this.LinkEditarApunte.Size = new System.Drawing.Size(151, 20);
            this.LinkEditarApunte.TabIndex = 29;
            this.LinkEditarApunte.TabStop = true;
            this.LinkEditarApunte.Text = "Asignar Ayudante";
            // 
            // LinkAgregarRecordatorio
            // 
            this.LinkAgregarRecordatorio.AutoSize = true;
            this.LinkAgregarRecordatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkAgregarRecordatorio.Location = new System.Drawing.Point(145, 206);
            this.LinkAgregarRecordatorio.Name = "LinkAgregarRecordatorio";
            this.LinkAgregarRecordatorio.Size = new System.Drawing.Size(122, 20);
            this.LinkAgregarRecordatorio.TabIndex = 28;
            this.LinkAgregarRecordatorio.TabStop = true;
            this.LinkAgregarRecordatorio.Text = "Crear Material";
            this.LinkAgregarRecordatorio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkAgregarRecordatorio_LinkClicked);
            // 
            // LinkCrearApunte
            // 
            this.LinkCrearApunte.AutoSize = true;
            this.LinkCrearApunte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkCrearApunte.Location = new System.Drawing.Point(145, 156);
            this.LinkCrearApunte.Name = "LinkCrearApunte";
            this.LinkCrearApunte.Size = new System.Drawing.Size(120, 20);
            this.LinkCrearApunte.TabIndex = 27;
            this.LinkCrearApunte.TabStop = true;
            this.LinkCrearApunte.Text = "Subir Material";
            // 
            // Menu_Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LinkEditarApunte);
            this.Controls.Add(this.LinkAgregarRecordatorio);
            this.Controls.Add(this.LinkCrearApunte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "Menu_Profesor";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LinkEditarApunte;
        private System.Windows.Forms.LinkLabel LinkAgregarRecordatorio;
        private System.Windows.Forms.LinkLabel LinkCrearApunte;
    }
}