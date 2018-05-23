namespace MyNotes2._0
{
    partial class VerMaterial
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
            this.listaRamos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listaMaterial = new System.Windows.Forms.ComboBox();
            this.verApuntes = new System.Windows.Forms.Button();
            this.eliminarApunte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaRamos
            // 
            this.listaRamos.FormattingEnabled = true;
            this.listaRamos.Location = new System.Drawing.Point(270, 72);
            this.listaRamos.Name = "listaRamos";
            this.listaRamos.Size = new System.Drawing.Size(301, 28);
            this.listaRamos.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Seleccione ramo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Seleccione apunte:";
            // 
            // listaMaterial
            // 
            this.listaMaterial.FormattingEnabled = true;
            this.listaMaterial.Location = new System.Drawing.Point(270, 120);
            this.listaMaterial.Name = "listaMaterial";
            this.listaMaterial.Size = new System.Drawing.Size(301, 28);
            this.listaMaterial.TabIndex = 23;
            // 
            // verApuntes
            // 
            this.verApuntes.Location = new System.Drawing.Point(270, 325);
            this.verApuntes.Name = "verApuntes";
            this.verApuntes.Size = new System.Drawing.Size(107, 33);
            this.verApuntes.TabIndex = 24;
            this.verApuntes.Text = "Ver";
            this.verApuntes.UseVisualStyleBackColor = true;
            // 
            // eliminarApunte
            // 
            this.eliminarApunte.Location = new System.Drawing.Point(429, 325);
            this.eliminarApunte.Name = "eliminarApunte";
            this.eliminarApunte.Size = new System.Drawing.Size(107, 33);
            this.eliminarApunte.TabIndex = 25;
            this.eliminarApunte.Text = "Eliminar";
            this.eliminarApunte.UseVisualStyleBackColor = true;
            // 
            // VerMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eliminarApunte);
            this.Controls.Add(this.verApuntes);
            this.Controls.Add(this.listaMaterial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listaRamos);
            this.Controls.Add(this.label1);
            this.Name = "VerMaterial";
            this.Text = "VerMaterial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listaRamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listaMaterial;
        private System.Windows.Forms.Button verApuntes;
        private System.Windows.Forms.Button eliminarApunte;
    }
}