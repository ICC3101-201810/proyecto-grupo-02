namespace MyNotes2._0
{
    partial class ProfeApuntes
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
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label_Fecha = new System.Windows.Forms.Label();
            this.label_Ramo = new System.Windows.Forms.Label();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.textBox_Content = new System.Windows.Forms.TextBox();
            this.TextNombreRamo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(555, 120);
            this.button_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(106, 35);
            this.button_Cancelar.TabIndex = 17;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(555, 42);
            this.button_Save.Margin = new System.Windows.Forms.Padding(2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(106, 35);
            this.button_Save.TabIndex = 16;
            this.button_Save.Text = "Guardar";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 137);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(157, 42);
            this.textBox_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(151, 20);
            this.textBox_Nombre.TabIndex = 14;
            // 
            // label_Fecha
            // 
            this.label_Fecha.AutoSize = true;
            this.label_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Fecha.Location = new System.Drawing.Point(37, 131);
            this.label_Fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Fecha.Name = "label_Fecha";
            this.label_Fecha.Size = new System.Drawing.Size(67, 25);
            this.label_Fecha.TabIndex = 13;
            this.label_Fecha.Text = "Fecha";
            // 
            // label_Ramo
            // 
            this.label_Ramo.AutoSize = true;
            this.label_Ramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ramo.Location = new System.Drawing.Point(37, 84);
            this.label_Ramo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Ramo.Name = "label_Ramo";
            this.label_Ramo.Size = new System.Drawing.Size(63, 25);
            this.label_Ramo.TabIndex = 12;
            this.label_Ramo.Text = "Ramo";
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombre.Location = new System.Drawing.Point(37, 36);
            this.label_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(81, 25);
            this.label_Nombre.TabIndex = 11;
            this.label_Nombre.Text = "Nombre";
            // 
            // textBox_Content
            // 
            this.textBox_Content.Location = new System.Drawing.Point(37, 196);
            this.textBox_Content.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Content.Multiline = true;
            this.textBox_Content.Name = "textBox_Content";
            this.textBox_Content.Size = new System.Drawing.Size(727, 219);
            this.textBox_Content.TabIndex = 10;
            // 
            // TextNombreRamo
            // 
            this.TextNombreRamo.BackColor = System.Drawing.SystemColors.Window;
            this.TextNombreRamo.Location = new System.Drawing.Point(157, 90);
            this.TextNombreRamo.Margin = new System.Windows.Forms.Padding(2);
            this.TextNombreRamo.Name = "TextNombreRamo";
            this.TextNombreRamo.ReadOnly = true;
            this.TextNombreRamo.Size = new System.Drawing.Size(151, 20);
            this.TextNombreRamo.TabIndex = 18;
            // 
            // ProfeApuntes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextNombreRamo);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.label_Fecha);
            this.Controls.Add(this.label_Ramo);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.textBox_Content);
            this.Name = "ProfeApuntes";
            this.Text = "ProfeApuntes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label_Fecha;
        private System.Windows.Forms.Label label_Ramo;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.TextBox textBox_Content;
        private System.Windows.Forms.TextBox TextNombreRamo;
    }
}