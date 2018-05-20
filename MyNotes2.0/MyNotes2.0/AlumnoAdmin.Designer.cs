namespace MyNotes2._0
{
    partial class AlumnoAdmin
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
            this.newAlumno = new System.Windows.Forms.Button();
            this.oldAlumno = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumnos";
            // 
            // newAlumno
            // 
            this.newAlumno.Location = new System.Drawing.Point(138, 126);
            this.newAlumno.Name = "newAlumno";
            this.newAlumno.Size = new System.Drawing.Size(234, 33);
            this.newAlumno.TabIndex = 1;
            this.newAlumno.Text = "Crear alumno nuevo";
            this.newAlumno.UseVisualStyleBackColor = true;
            this.newAlumno.Click += new System.EventHandler(this.newAlumno_Click);
            // 
            // oldAlumno
            // 
            this.oldAlumno.Location = new System.Drawing.Point(138, 177);
            this.oldAlumno.Name = "oldAlumno";
            this.oldAlumno.Size = new System.Drawing.Size(234, 33);
            this.oldAlumno.TabIndex = 2;
            this.oldAlumno.Text = "Modificar alumno antiguo";
            this.oldAlumno.UseVisualStyleBackColor = true;
            this.oldAlumno.Click += new System.EventHandler(this.oldAlumno_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AlumnoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oldAlumno);
            this.Controls.Add(this.newAlumno);
            this.Controls.Add(this.label1);
            this.Name = "AlumnoAdmin";
            this.Text = "AlumnoAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newAlumno;
        private System.Windows.Forms.Button oldAlumno;
        private System.Windows.Forms.Button button1;
    }
}