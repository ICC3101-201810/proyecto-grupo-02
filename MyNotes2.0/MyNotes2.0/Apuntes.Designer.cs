namespace MyNotes2._0
{
    partial class Apuntes
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
            this.textBox_Content = new System.Windows.Forms.TextBox();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Ramo = new System.Windows.Forms.Label();
            this.label_Fecha = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Ramo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Content
            // 
            this.textBox_Content.Location = new System.Drawing.Point(9, 219);
            this.textBox_Content.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Content.Multiline = true;
            this.textBox_Content.Name = "textBox_Content";
            this.textBox_Content.Size = new System.Drawing.Size(727, 22);
            this.textBox_Content.TabIndex = 0;
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombre.Location = new System.Drawing.Point(9, 59);
            this.label_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(81, 25);
            this.label_Nombre.TabIndex = 1;
            this.label_Nombre.Text = "Nombre";
            // 
            // label_Ramo
            // 
            this.label_Ramo.AutoSize = true;
            this.label_Ramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ramo.Location = new System.Drawing.Point(9, 107);
            this.label_Ramo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Ramo.Name = "label_Ramo";
            this.label_Ramo.Size = new System.Drawing.Size(63, 25);
            this.label_Ramo.TabIndex = 2;
            this.label_Ramo.Text = "Ramo";
            // 
            // label_Fecha
            // 
            this.label_Fecha.AutoSize = true;
            this.label_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Fecha.Location = new System.Drawing.Point(9, 154);
            this.label_Fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Fecha.Name = "label_Fecha";
            this.label_Fecha.Size = new System.Drawing.Size(67, 25);
            this.label_Fecha.TabIndex = 3;
            this.label_Fecha.Text = "Fecha";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(129, 65);
            this.textBox_Nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(151, 20);
            this.textBox_Nombre.TabIndex = 4;
            // 
            // textBox_Ramo
            // 
            this.textBox_Ramo.Location = new System.Drawing.Point(129, 113);
            this.textBox_Ramo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Ramo.Name = "textBox_Ramo";
            this.textBox_Ramo.Size = new System.Drawing.Size(151, 20);
            this.textBox_Ramo.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 160);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(527, 65);
            this.button_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(106, 35);
            this.button_Save.TabIndex = 7;
            this.button_Save.Text = "Guardar";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // Apuntes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 447);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_Ramo);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.label_Fecha);
            this.Controls.Add(this.label_Ramo);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.textBox_Content);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Apuntes";
            this.Text = "Apuntes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Content;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_Ramo;
        private System.Windows.Forms.Label label_Fecha;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Ramo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_Save;
    }
}