namespace MyNotes2._0
{
    partial class ProfeRamos
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
            this.ComboBoxRamos = new System.Windows.Forms.ComboBox();
            this.LabelRamo = new System.Windows.Forms.Label();
            this.BotonAtras = new System.Windows.Forms.Button();
            this.BotonEditarAyudantes = new System.Windows.Forms.Button();
            this.BotonCrearMaterial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxRamos
            // 
            this.ComboBoxRamos.FormattingEnabled = true;
            this.ComboBoxRamos.Location = new System.Drawing.Point(81, 28);
            this.ComboBoxRamos.Name = "ComboBoxRamos";
            this.ComboBoxRamos.Size = new System.Drawing.Size(127, 21);
            this.ComboBoxRamos.TabIndex = 0;
            // 
            // LabelRamo
            // 
            this.LabelRamo.AutoSize = true;
            this.LabelRamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRamo.Location = new System.Drawing.Point(19, 29);
            this.LabelRamo.Name = "LabelRamo";
            this.LabelRamo.Size = new System.Drawing.Size(56, 20);
            this.LabelRamo.TabIndex = 1;
            this.LabelRamo.Text = "Ramo";
            // 
            // BotonAtras
            // 
            this.BotonAtras.Location = new System.Drawing.Point(12, 253);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(81, 56);
            this.BotonAtras.TabIndex = 2;
            this.BotonAtras.Text = "Atras";
            this.BotonAtras.UseVisualStyleBackColor = true;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // BotonEditarAyudantes
            // 
            this.BotonEditarAyudantes.Location = new System.Drawing.Point(95, 130);
            this.BotonEditarAyudantes.Name = "BotonEditarAyudantes";
            this.BotonEditarAyudantes.Size = new System.Drawing.Size(81, 56);
            this.BotonEditarAyudantes.TabIndex = 3;
            this.BotonEditarAyudantes.Text = "Editar Ayudantes";
            this.BotonEditarAyudantes.UseVisualStyleBackColor = true;
            this.BotonEditarAyudantes.Click += new System.EventHandler(this.BotonEditarAyudantes_Click);
            // 
            // BotonCrearMaterial
            // 
            this.BotonCrearMaterial.Location = new System.Drawing.Point(182, 130);
            this.BotonCrearMaterial.Name = "BotonCrearMaterial";
            this.BotonCrearMaterial.Size = new System.Drawing.Size(81, 56);
            this.BotonCrearMaterial.TabIndex = 4;
            this.BotonCrearMaterial.Text = "Crear Material";
            this.BotonCrearMaterial.UseVisualStyleBackColor = true;
            this.BotonCrearMaterial.Click += new System.EventHandler(this.BotonCrearMaterial_Click);
            // 
            // ProfeRamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 321);
            this.Controls.Add(this.BotonCrearMaterial);
            this.Controls.Add(this.BotonEditarAyudantes);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.LabelRamo);
            this.Controls.Add(this.ComboBoxRamos);
            this.Name = "ProfeRamos";
            this.Text = "Editar Ramos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxRamos;
        private System.Windows.Forms.Label LabelRamo;
        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.Button BotonEditarAyudantes;
        private System.Windows.Forms.Button BotonCrearMaterial;
    }
}