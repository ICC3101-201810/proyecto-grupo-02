namespace MyNotes2._0
{
    partial class EditarAyudantes
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
            this.LabelRamo = new System.Windows.Forms.Label();
            this.BotonAtras = new System.Windows.Forms.Button();
            this.ListaAyudante = new System.Windows.Forms.ListBox();
            this.BotonEliminarAyudante = new System.Windows.Forms.Button();
            this.BotonAgregarAyudante = new System.Windows.Forms.Button();
            this.comboBoxRamo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabelRamo
            // 
            this.LabelRamo.AutoSize = true;
            this.LabelRamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRamo.Location = new System.Drawing.Point(19, 44);
            this.LabelRamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelRamo.Name = "LabelRamo";
            this.LabelRamo.Size = new System.Drawing.Size(208, 29);
            this.LabelRamo.TabIndex = 2;
            this.LabelRamo.Text = "Seleccionar ramo:";
            // 
            // BotonAtras
            // 
            this.BotonAtras.Location = new System.Drawing.Point(24, 371);
            this.BotonAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(154, 34);
            this.BotonAtras.TabIndex = 3;
            this.BotonAtras.Text = "Atras";
            this.BotonAtras.UseVisualStyleBackColor = true;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // ListaAyudante
            // 
            this.ListaAyudante.FormattingEnabled = true;
            this.ListaAyudante.ItemHeight = 20;
            this.ListaAyudante.Location = new System.Drawing.Point(24, 126);
            this.ListaAyudante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListaAyudante.Name = "ListaAyudante";
            this.ListaAyudante.Size = new System.Drawing.Size(550, 204);
            this.ListaAyudante.TabIndex = 4;
            // 
            // BotonEliminarAyudante
            // 
            this.BotonEliminarAyudante.Location = new System.Drawing.Point(397, 371);
            this.BotonEliminarAyudante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonEliminarAyudante.Name = "BotonEliminarAyudante";
            this.BotonEliminarAyudante.Size = new System.Drawing.Size(154, 34);
            this.BotonEliminarAyudante.TabIndex = 5;
            this.BotonEliminarAyudante.Text = "Eliminar Ayudante";
            this.BotonEliminarAyudante.UseVisualStyleBackColor = true;
            this.BotonEliminarAyudante.Click += new System.EventHandler(this.BotonEliminarAyudante_Click);
            // 
            // BotonAgregarAyudante
            // 
            this.BotonAgregarAyudante.Location = new System.Drawing.Point(217, 371);
            this.BotonAgregarAyudante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonAgregarAyudante.Name = "BotonAgregarAyudante";
            this.BotonAgregarAyudante.Size = new System.Drawing.Size(154, 34);
            this.BotonAgregarAyudante.TabIndex = 6;
            this.BotonAgregarAyudante.Text = "Agregar Ayudante";
            this.BotonAgregarAyudante.UseVisualStyleBackColor = true;
            // 
            // comboBoxRamo
            // 
            this.comboBoxRamo.FormattingEnabled = true;
            this.comboBoxRamo.Location = new System.Drawing.Point(230, 48);
            this.comboBoxRamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxRamo.Name = "comboBoxRamo";
            this.comboBoxRamo.Size = new System.Drawing.Size(278, 28);
            this.comboBoxRamo.TabIndex = 7;
            this.comboBoxRamo.SelectedIndexChanged += new System.EventHandler(this.comboBoxRamo_SelectedIndexChanged);
            // 
            // EditarAyudantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 449);
            this.Controls.Add(this.comboBoxRamo);
            this.Controls.Add(this.BotonAgregarAyudante);
            this.Controls.Add(this.BotonEliminarAyudante);
            this.Controls.Add(this.ListaAyudante);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.LabelRamo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditarAyudantes";
            this.Text = "EditarAyudantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelRamo;
        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.ListBox ListaAyudante;
        private System.Windows.Forms.Button BotonEliminarAyudante;
        private System.Windows.Forms.Button BotonAgregarAyudante;
        private System.Windows.Forms.ComboBox comboBoxRamo;
    }
}