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
    public partial class Crear_Semestre : Form
    {
        public Crear_Semestre()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // cancelar
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e) // crear
        {
            MyNotes.GetListaSemestres().Add(new Semestre(textBox1.Text));
            Close();
        }
    }
}
