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
            this.TextRamo = new System.Windows.Forms.TextBox();
            this.LabelRamo = new System.Windows.Forms.Label();
            this.BotonAtras = new System.Windows.Forms.Button();
            this.ListaAyudante = new System.Windows.Forms.ListBox();
            this.BotonEliminarAyudante = new System.Windows.Forms.Button();
            this.BotonAgregarAyudante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextRamo
            // 
            this.TextRamo.BackColor = System.Drawing.SystemColors.Window;
            this.TextRamo.Location = new System.Drawing.Point(105, 33);
            this.TextRamo.Name = "TextRamo";
            this.TextRamo.ReadOnly = true;
            this.TextRamo.Size = new System.Drawing.Size(181, 20);
            this.TextRamo.TabIndex = 0;
            // 
            // LabelRamo
            // 
            this.LabelRamo.AutoSize = true;
            this.LabelRamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRamo.Location = new System.Drawing.Point(12, 33);
            this.LabelRamo.Name = "LabelRamo";
            this.LabelRamo.Size = new System.Drawing.Size(56, 20);
            this.LabelRamo.TabIndex = 2;
            this.LabelRamo.Text = "Ramo";
            // 
            // BotonAtras
            // 
            this.BotonAtras.Location = new System.Drawing.Point(16, 224);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(81, 56);
            this.BotonAtras.TabIndex = 3;
            this.BotonAtras.Text = "Atras";
            this.BotonAtras.UseVisualStyleBackColor = true;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // ListaAyudante
            // 
            this.ListaAyudante.FormattingEnabled = true;
            this.ListaAyudante.Location = new System.Drawing.Point(16, 82);
            this.ListaAyudante.Name = "ListaAyudante";
            this.ListaAyudante.Size = new System.Drawing.Size(368, 134);
            this.ListaAyudante.TabIndex = 4;
            // 
            // BotonEliminarAyudante
            // 
            this.BotonEliminarAyudante.Location = new System.Drawing.Point(259, 224);
            this.BotonEliminarAyudante.Name = "BotonEliminarAyudante";
            this.BotonEliminarAyudante.Size = new System.Drawing.Size(81, 56);
            this.BotonEliminarAyudante.TabIndex = 5;
            this.BotonEliminarAyudante.Text = "Eliminar Ayudante";
            this.BotonEliminarAyudante.UseVisualStyleBackColor = true;
            this.BotonEliminarAyudante.Click += new System.EventHandler(this.BotonEliminarAyudante_Click);
            // 
            // BotonAgregarAyudante
            // 
            this.BotonAgregarAyudante.Location = new System.Drawing.Point(153, 224);
            this.BotonAgregarAyudante.Name = "BotonAgregarAyudante";
            this.BotonAgregarAyudante.Size = new System.Drawing.Size(81, 56);
            this.BotonAgregarAyudante.TabIndex = 6;
            this.BotonAgregarAyudante.Text = "Agregar Ayudante";
            this.BotonAgregarAyudante.UseVisualStyleBackColor = true;
            // 
            // EditarAyudantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 292);
            this.Controls.Add(this.BotonAgregarAyudante);
            this.Controls.Add(this.BotonEliminarAyudante);
            this.Controls.Add(this.ListaAyudante);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.LabelRamo);
            this.Controls.Add(this.TextRamo);
            this.Name = "EditarAyudantes";
            this.Text = "EditarAyudantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextRamo;
        private System.Windows.Forms.Label LabelRamo;
        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.ListBox ListaAyudante;
        private System.Windows.Forms.Button BotonEliminarAyudante;
        private System.Windows.Forms.Button BotonAgregarAyudante;
    }
}