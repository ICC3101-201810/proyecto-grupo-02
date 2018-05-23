namespace MyNotes2._0
{
    partial class SemestreAdmin
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
            this.button1 = new System.Windows.Forms.Button();
            this.oldSemestre = new System.Windows.Forms.Button();
            this.newSemestre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oldSemestre
            // 
            this.oldSemestre.Location = new System.Drawing.Point(150, 164);
            this.oldSemestre.Name = "oldSemestre";
            this.oldSemestre.Size = new System.Drawing.Size(234, 33);
            this.oldSemestre.TabIndex = 6;
            this.oldSemestre.Text = "Modificar semestre antiguo";
            this.oldSemestre.UseVisualStyleBackColor = true;
            // 
            // newSemestre
            // 
            this.newSemestre.Location = new System.Drawing.Point(150, 113);
            this.newSemestre.Name = "newSemestre";
            this.newSemestre.Size = new System.Drawing.Size(234, 33);
            this.newSemestre.TabIndex = 5;
            this.newSemestre.Text = "Crear semestre nuevo";
            this.newSemestre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Semestres";
            // 
            // SemestreAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oldSemestre);
            this.Controls.Add(this.newSemestre);
            this.Controls.Add(this.label1);
            this.Name = "SemestreAdmin";
            this.Text = "SemestreAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button oldSemestre;
        private System.Windows.Forms.Button newSemestre;
        private System.Windows.Forms.Label label1;
    }
}