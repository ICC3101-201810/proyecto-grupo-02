namespace VistaNotas
{
    partial class Menu_Alumno
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
            this.TextoBienvenida = new System.Windows.Forms.Label();
            this.PreguntaOpciones = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.NombreDelAlumno = new System.Windows.Forms.Label();
            this.LinkCrearApunte = new System.Windows.Forms.LinkLabel();
            this.LinkAgregarRecordatorio = new System.Windows.Forms.LinkLabel();
            this.LinkEditarApunte = new System.Windows.Forms.LinkLabel();
            this.LinkCompartirApunte = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TextoBienvenida
            // 
            this.TextoBienvenida.AutoSize = true;
            this.TextoBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoBienvenida.Location = new System.Drawing.Point(152, 43);
            this.TextoBienvenida.Name = "TextoBienvenida";
            this.TextoBienvenida.Size = new System.Drawing.Size(271, 31);
            this.TextoBienvenida.TabIndex = 1;
            this.TextoBienvenida.Text = "Bienvenido Alumno ";
            // 
            // PreguntaOpciones
            // 
            this.PreguntaOpciones.AutoSize = true;
            this.PreguntaOpciones.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreguntaOpciones.Location = new System.Drawing.Point(155, 74);
            this.PreguntaOpciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PreguntaOpciones.Name = "PreguntaOpciones";
            this.PreguntaOpciones.Size = new System.Drawing.Size(158, 18);
            this.PreguntaOpciones.TabIndex = 10;
            this.PreguntaOpciones.Text = "¿Qué desea hacer?";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 391);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 47);
            this.button7.TabIndex = 17;
            this.button7.Text = "Cerrar Sesion";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // NombreDelAlumno
            // 
            this.NombreDelAlumno.AutoSize = true;
            this.NombreDelAlumno.Location = new System.Drawing.Point(452, 53);
            this.NombreDelAlumno.Name = "NombreDelAlumno";
            this.NombreDelAlumno.Size = new System.Drawing.Size(0, 13);
            this.NombreDelAlumno.TabIndex = 18;
            // 
            // LinkCrearApunte
            // 
            this.LinkCrearApunte.AutoSize = true;
            this.LinkCrearApunte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkCrearApunte.Location = new System.Drawing.Point(154, 142);
            this.LinkCrearApunte.Name = "LinkCrearApunte";
            this.LinkCrearApunte.Size = new System.Drawing.Size(116, 20);
            this.LinkCrearApunte.TabIndex = 19;
            this.LinkCrearApunte.TabStop = true;
            this.LinkCrearApunte.Text = "Crear Apunte";
            this.LinkCrearApunte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCrearApunte_LinkClicked);
            // 
            // LinkAgregarRecordatorio
            // 
            this.LinkAgregarRecordatorio.AutoSize = true;
            this.LinkAgregarRecordatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkAgregarRecordatorio.Location = new System.Drawing.Point(154, 241);
            this.LinkAgregarRecordatorio.Name = "LinkAgregarRecordatorio";
            this.LinkAgregarRecordatorio.Size = new System.Drawing.Size(182, 20);
            this.LinkAgregarRecordatorio.TabIndex = 20;
            this.LinkAgregarRecordatorio.TabStop = true;
            this.LinkAgregarRecordatorio.Text = "Agregar Recordatorio";
            // 
            // LinkEditarApunte
            // 
            this.LinkEditarApunte.AutoSize = true;
            this.LinkEditarApunte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkEditarApunte.Location = new System.Drawing.Point(154, 192);
            this.LinkEditarApunte.Name = "LinkEditarApunte";
            this.LinkEditarApunte.Size = new System.Drawing.Size(120, 20);
            this.LinkEditarApunte.TabIndex = 21;
            this.LinkEditarApunte.TabStop = true;
            this.LinkEditarApunte.Text = "Editar Apunte";
            // 
            // LinkCompartirApunte
            // 
            this.LinkCompartirApunte.AutoSize = true;
            this.LinkCompartirApunte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkCompartirApunte.Location = new System.Drawing.Point(154, 290);
            this.LinkCompartirApunte.Name = "LinkCompartirApunte";
            this.LinkCompartirApunte.Size = new System.Drawing.Size(150, 20);
            this.LinkCompartirApunte.TabIndex = 22;
            this.LinkCompartirApunte.TabStop = true;
            this.LinkCompartirApunte.Text = "Compartir Apunte";
            // 
            // Menu_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LinkCompartirApunte);
            this.Controls.Add(this.LinkEditarApunte);
            this.Controls.Add(this.LinkAgregarRecordatorio);
            this.Controls.Add(this.LinkCrearApunte);
            this.Controls.Add(this.NombreDelAlumno);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.PreguntaOpciones);
            this.Controls.Add(this.TextoBienvenida);
            this.Name = "Menu_Alumno";
            this.Text = "Menu_Alumno";
            this.Load += new System.EventHandler(this.Menu_Alumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextoBienvenida;
        private System.Windows.Forms.Label PreguntaOpciones;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label NombreDelAlumno;
        private System.Windows.Forms.LinkLabel LinkCrearApunte;
        private System.Windows.Forms.LinkLabel LinkAgregarRecordatorio;
        private System.Windows.Forms.LinkLabel LinkEditarApunte;
        private System.Windows.Forms.LinkLabel LinkCompartirApunte;
    }
}