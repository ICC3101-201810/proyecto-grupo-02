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
            this.ComboBoxRamos.Location = new System.Drawing.Point(268, 49);
            this.ComboBoxRamos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxRamos.Name = "ComboBoxRamos";
            this.ComboBoxRamos.Size = new System.Drawing.Size(293, 28);
            this.ComboBoxRamos.TabIndex = 0;
            this.ComboBoxRamos.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRamos_SelectedIndexChanged);
            // 
            // LabelRamo
            // 
            this.LabelRamo.AutoSize = true;
            this.LabelRamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRamo.Location = new System.Drawing.Point(45, 48);
            this.LabelRamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelRamo.Name = "LabelRamo";
            this.LabelRamo.Size = new System.Drawing.Size(170, 25);
            this.LabelRamo.TabIndex = 1;
            this.LabelRamo.Text = "Seleccionar ramo:";
            // 
            // BotonAtras
            // 
            this.BotonAtras.Location = new System.Drawing.Point(453, 349);
            this.BotonAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(122, 41);
            this.BotonAtras.TabIndex = 2;
            this.BotonAtras.Text = "Atras";
            this.BotonAtras.UseVisualStyleBackColor = true;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // BotonEditarAyudantes
            // 
            this.BotonEditarAyudantes.Location = new System.Drawing.Point(50, 147);
            this.BotonEditarAyudantes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonEditarAyudantes.Name = "BotonEditarAyudantes";
            this.BotonEditarAyudantes.Size = new System.Drawing.Size(201, 35);
            this.BotonEditarAyudantes.TabIndex = 3;
            this.BotonEditarAyudantes.Text = "Editar Ayudantes";
            this.BotonEditarAyudantes.UseVisualStyleBackColor = true;
            this.BotonEditarAyudantes.Click += new System.EventHandler(this.BotonEditarAyudantes_Click);
            // 
            // BotonCrearMaterial
            // 
            this.BotonCrearMaterial.Location = new System.Drawing.Point(294, 147);
            this.BotonCrearMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonCrearMaterial.Name = "BotonCrearMaterial";
            this.BotonCrearMaterial.Size = new System.Drawing.Size(201, 35);
            this.BotonCrearMaterial.TabIndex = 4;
            this.BotonCrearMaterial.Text = "Crear Material";
            this.BotonCrearMaterial.UseVisualStyleBackColor = true;
            this.BotonCrearMaterial.Click += new System.EventHandler(this.BotonCrearMaterial_Click);
            // 
            // ProfeRamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 494);
            this.Controls.Add(this.BotonCrearMaterial);
            this.Controls.Add(this.BotonEditarAyudantes);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.LabelRamo);
            this.Controls.Add(this.ComboBoxRamos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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