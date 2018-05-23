namespace MyNotes2._0
{
    partial class Bienvenida
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label_Usuario = new System.Windows.Forms.Label();
            this.label_pwd = new System.Windows.Forms.Label();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.textBox_Pwd = new System.Windows.Forms.TextBox();
            this.button_Iniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a MyNotes";
            // 
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.Location = new System.Drawing.Point(153, 165);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(72, 20);
            this.label_Usuario.TabIndex = 1;
            this.label_Usuario.Text = "Usuario: ";
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.Location = new System.Drawing.Point(153, 244);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(96, 20);
            this.label_pwd.TabIndex = 2;
            this.label_pwd.Text = "Contrasena:";
            // 
            // textBox_User
            // 
            this.textBox_User.Location = new System.Drawing.Point(307, 159);
            this.textBox_User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(112, 26);
            this.textBox_User.TabIndex = 3;
            // 
            // textBox_Pwd
            // 
            this.textBox_Pwd.Location = new System.Drawing.Point(307, 244);
            this.textBox_Pwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Pwd.Name = "textBox_Pwd";
            this.textBox_Pwd.Size = new System.Drawing.Size(112, 26);
            this.textBox_Pwd.TabIndex = 4;
            // 
            // button_Iniciar
            // 
            this.button_Iniciar.Location = new System.Drawing.Point(335, 324);
            this.button_Iniciar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Iniciar.Name = "button_Iniciar";
            this.button_Iniciar.Size = new System.Drawing.Size(84, 29);
            this.button_Iniciar.TabIndex = 5;
            this.button_Iniciar.Text = "Inciar";
            this.button_Iniciar.UseVisualStyleBackColor = true;
            this.button_Iniciar.Click += new System.EventHandler(this.button_Iniciar_Click);
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.button_Iniciar);
            this.Controls.Add(this.textBox_Pwd);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.label_Usuario);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bienvenida";
            this.Text = "MyNotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.TextBox textBox_Pwd;
        private System.Windows.Forms.Button button_Iniciar;
    }
}

