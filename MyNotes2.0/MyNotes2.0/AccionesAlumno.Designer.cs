namespace MyNotes2._0
{
    partial class AccionesAlumno
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
            this.label_NameAl = new System.Windows.Forms.Label();
            this.button_CrearAp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumno";
            // 
            // label_NameAl
            // 
            this.label_NameAl.AutoSize = true;
            this.label_NameAl.Location = new System.Drawing.Point(243, 101);
            this.label_NameAl.Name = "label_NameAl";
            this.label_NameAl.Size = new System.Drawing.Size(46, 17);
            this.label_NameAl.TabIndex = 1;
            this.label_NameAl.Text = "label2";
            // 
            // button_CrearAp
            // 
            this.button_CrearAp.Location = new System.Drawing.Point(179, 210);
            this.button_CrearAp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_CrearAp.Name = "button_CrearAp";
            this.button_CrearAp.Size = new System.Drawing.Size(100, 54);
            this.button_CrearAp.TabIndex = 2;
            this.button_CrearAp.Text = "Crear Apuntes";
            this.button_CrearAp.UseVisualStyleBackColor = true;
            this.button_CrearAp.Click += new System.EventHandler(this.button_CrearAp_Click);
            // 
            // AccionesAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 395);
            this.Controls.Add(this.button_CrearAp);
            this.Controls.Add(this.label_NameAl);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccionesAlumno";
            this.Text = "AccionesAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_NameAl;
        private System.Windows.Forms.Button button_CrearAp;
    }
}