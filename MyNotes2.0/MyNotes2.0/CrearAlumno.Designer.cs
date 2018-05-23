namespace MyNotes2._0
{
    partial class CrearAlumno
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
            this.newName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre nuevo alumno:";
            // 
            // newName
            // 
            this.newName.Location = new System.Drawing.Point(269, 73);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(237, 26);
            this.newName.TabIndex = 1;
            this.newName.TextChanged += new System.EventHandler(this.newName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // newPass
            // 
            this.newPass.Location = new System.Drawing.Point(269, 127);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(237, 26);
            this.newPass.TabIndex = 3;
            this.newPass.TextChanged += new System.EventHandler(this.newPass_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CrearAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newName);
            this.Controls.Add(this.label1);
            this.Name = "CrearAlumno";
            this.Text = "CrearAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}