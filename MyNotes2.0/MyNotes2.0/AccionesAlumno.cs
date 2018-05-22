﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotes2._0
{
    public partial class AccionesAlumno : Form , ILoger
    {
        private ILoger loger;
        public AccionesAlumno(object sender)
        {
            InitializeComponent();
            if (sender is ILoger)
            {
                loger = (ILoger)sender;
            }
            
            
        }
        public void Login(Usuario usuario)
        {
            usuario = (Alumno)usuario;
            label_NameAl.Text = usuario.GetNombre();
        }

        private void button_CrearAp_Click(object sender, EventArgs e)
        {
            Apuntes apuntes = new Apuntes();
            apuntes.Show();
        }

        private void label_NameAl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
