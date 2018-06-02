namespace MyNotes2._0
{
    partial class RamoAdmin
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
            this.oldRamo = new System.Windows.Forms.Button();
            this.newRamo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datesRamo = new System.Windows.Forms.Button();
            this.materialRamo = new System.Windows.Forms.Button();
            this.BotonSecciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oldRamo
            // 
            this.oldRamo.Location = new System.Drawing.Point(105, 165);
            this.oldRamo.Name = "oldRamo";
            this.oldRamo.Size = new System.Drawing.Size(234, 32);
            this.oldRamo.TabIndex = 10;
            this.oldRamo.Text = "Modificar ramo antiguo";
            this.oldRamo.UseVisualStyleBackColor = true;
            this.oldRamo.Click += new System.EventHandler(this.oldRamo_Click);
            // 
            // newRamo
            // 
            this.newRamo.Location = new System.Drawing.Point(105, 112);
            this.newRamo.Name = "newRamo";
            this.newRamo.Size = new System.Drawing.Size(234, 32);
            this.newRamo.TabIndex = 9;
            this.newRamo.Text = "Crear ramo nuevo";
            this.newRamo.UseVisualStyleBackColor = true;
            this.newRamo.Click += new System.EventHandler(this.newRamo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ramos";
            // 
            // datesRamo
            // 
            this.datesRamo.Location = new System.Drawing.Point(441, 112);
            this.datesRamo.Name = "datesRamo";
            this.datesRamo.Size = new System.Drawing.Size(234, 32);
            this.datesRamo.TabIndex = 12;
            this.datesRamo.Text = "Ver fechas de un ramo";
            this.datesRamo.UseVisualStyleBackColor = true;
            this.datesRamo.Click += new System.EventHandler(this.datesRamo_Click);
            // 
            // materialRamo
            // 
            this.materialRamo.Location = new System.Drawing.Point(441, 165);
            this.materialRamo.Name = "materialRamo";
            this.materialRamo.Size = new System.Drawing.Size(234, 32);
            this.materialRamo.TabIndex = 13;
            this.materialRamo.Text = "Ver material de un ramo";
            this.materialRamo.UseVisualStyleBackColor = true;
            this.materialRamo.Click += new System.EventHandler(this.materialRamo_Click);
            // 
            // BotonSecciones
            // 
            this.BotonSecciones.Location = new System.Drawing.Point(105, 215);
            this.BotonSecciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotonSecciones.Name = "BotonSecciones";
            this.BotonSecciones.Size = new System.Drawing.Size(234, 32);
            this.BotonSecciones.TabIndex = 14;
            this.BotonSecciones.Text = "Secciones";
            this.BotonSecciones.UseVisualStyleBackColor = true;
            this.BotonSecciones.Click += new System.EventHandler(this.BotonSecciones_Click);
            // 
            // RamoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.BotonSecciones);
            this.Controls.Add(this.materialRamo);
            this.Controls.Add(this.datesRamo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oldRamo);
            this.Controls.Add(this.newRamo);
            this.Controls.Add(this.label1);
            this.Name = "RamoAdmin";
            this.Text = "RamoAdmin";
            this.Load += new System.EventHandler(this.RamoAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button oldRamo;
        private System.Windows.Forms.Button newRamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button datesRamo;
        private System.Windows.Forms.Button materialRamo;
        private System.Windows.Forms.Button BotonSecciones;
    }
}