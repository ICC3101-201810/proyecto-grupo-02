﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Profesor f2 = new Menu_Profesor();
            f2.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // contraseña
            string contra = TContrasena.Text;
        }

        private void TUsuario_TextChanged(object sender, EventArgs e)
        {
            string user = TUsuario.Text;
        }

        private void HOLANDA_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
