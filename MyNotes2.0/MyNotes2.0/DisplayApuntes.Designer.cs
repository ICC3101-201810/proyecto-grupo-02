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
            this.SuspendLayout();
            // 
            // listBox_Apuntes
            // 
            this.listBox_Apuntes.FormattingEnabled = true;
            this.listBox_Apuntes.ItemHeight = 16;
            this.listBox_Apuntes.Location = new System.Drawing.Point(47, 163);
            this.listBox_Apuntes.Name = "listBox_Apuntes";
            this.listBox_Apuntes.Size = new System.Drawing.Size(803, 324);
            this.listBox_Apuntes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sus apuntes:";
            // 
            // DisplayApuntes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Apuntes);
            this.Name = "DisplayApuntes";
            this.Text = "DisplayApuntes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Apuntes;
        private System.Windows.Forms.Label label1;
    }
}