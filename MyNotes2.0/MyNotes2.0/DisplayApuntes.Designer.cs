namespace MyNotes2._0
{
    partial class DisplayApuntes
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
            this.listBox_Apuntes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonEditarApunte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Apuntes
            // 
            this.listBox_Apuntes.FormattingEnabled = true;
            this.listBox_Apuntes.Location = new System.Drawing.Point(35, 132);
            this.listBox_Apuntes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_Apuntes.Name = "listBox_Apuntes";
            this.listBox_Apuntes.Size = new System.Drawing.Size(603, 264);
            this.listBox_Apuntes.TabIndex = 0;
            this.listBox_Apuntes.SelectedIndexChanged += new System.EventHandler(this.listBox_Apuntes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sus apuntes:";
            // 
            // BotonEditarApunte
            // 
            this.BotonEditarApunte.Location = new System.Drawing.Point(541, 29);
            this.BotonEditarApunte.Name = "BotonEditarApunte";
            this.BotonEditarApunte.Size = new System.Drawing.Size(96, 57);
            this.BotonEditarApunte.TabIndex = 2;
            this.BotonEditarApunte.Text = "Editar Apunte";
            this.BotonEditarApunte.UseVisualStyleBackColor = true;
            this.BotonEditarApunte.Click += new System.EventHandler(this.BotonEditarApunte_Click);
            // 
            // DisplayApuntes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 411);
            this.Controls.Add(this.BotonEditarApunte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Apuntes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DisplayApuntes";
            this.Text = "DisplayApuntes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Apuntes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonEditarApunte;
    }
}