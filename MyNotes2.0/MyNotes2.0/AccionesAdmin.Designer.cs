namespace MyNotes2._0
{
    partial class AccionesAdmin
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
            this.label_NombreAdm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador";
            // 
            // label_NombreAdm
            // 
            this.label_NombreAdm.AutoSize = true;
            this.label_NombreAdm.Location = new System.Drawing.Point(247, 38);
            this.label_NombreAdm.Name = "label_NombreAdm";
            this.label_NombreAdm.Size = new System.Drawing.Size(46, 17);
            this.label_NombreAdm.TabIndex = 1;
            this.label_NombreAdm.Text = "label2";
            // 
            // AccionesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 328);
            this.Controls.Add(this.label_NombreAdm);
            this.Controls.Add(this.label1);
            this.Name = "AccionesAdmin";
            this.Text = "AccionesAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_NombreAdm;
    }
}