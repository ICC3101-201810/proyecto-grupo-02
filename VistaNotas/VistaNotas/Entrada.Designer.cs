namespace VistaNotas
{
    partial class Entrada
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.TUsuario = new System.Windows.Forms.TextBox();
            this.USUARIO = new System.Windows.Forms.Label();
            this.TContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HOLANDA = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(492, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 121);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log In";
            this.HOLANDA.SetToolTip(this.button1, "ESTE ES UN BOTON, APRETAME");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TUsuario
            // 
            this.TUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUsuario.Location = new System.Drawing.Point(253, 96);
            this.TUsuario.Name = "TUsuario";
            this.TUsuario.Size = new System.Drawing.Size(492, 26);
            this.TUsuario.TabIndex = 2;
            this.TUsuario.TextChanged += new System.EventHandler(this.TUsuario_TextChanged);
            // 
            // USUARIO
            // 
            this.USUARIO.AutoEllipsis = true;
            this.USUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USUARIO.Location = new System.Drawing.Point(85, 102);
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.Size = new System.Drawing.Size(162, 20);
            this.USUARIO.TabIndex = 3;
            this.USUARIO.Text = "USUARIO";
            this.HOLANDA.SetToolTip(this.USUARIO, "BIENVENIDO, FAVOR INGRESE SU USUARIO");
            // 
            // TContrasena
            // 
            this.TContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TContrasena.Location = new System.Drawing.Point(253, 181);
            this.TContrasena.Name = "TContrasena";
            this.TContrasena.PasswordChar = '*';
            this.TContrasena.Size = new System.Drawing.Size(492, 26);
            this.TContrasena.TabIndex = 4;
            this.TContrasena.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "CONTRASEÑA";
            this.HOLANDA.SetToolTip(this.label1, "INGRESA TU PASS, NO TE PREOCUPES, SE VERA \"*\"");
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "BIENVENIDOS A \"MY NOTES\" V0.01";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HOLANDA
            // 
            this.HOLANDA.BackColor = System.Drawing.SystemColors.Highlight;
            this.HOLANDA.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.HOLANDA.IsBalloon = true;
            this.HOLANDA.Popup += new System.Windows.Forms.PopupEventHandler(this.HOLANDA_Popup);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "Salir del Programa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SalirPrograma_Click);
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 448);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TContrasena);
            this.Controls.Add(this.USUARIO);
            this.Controls.Add(this.TUsuario);
            this.Controls.Add(this.button1);
            this.Name = "Entrada";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TUsuario;
        private System.Windows.Forms.Label USUARIO;
        private System.Windows.Forms.TextBox TContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip HOLANDA;
        private System.Windows.Forms.Button button2;
    }
}

