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
    public partial class AlumnoAdmin : Form, Ibd
    {
        public AlumnoAdmin()
        {
            InitializeComponent();
            
        }

        private void newAlumno_Click(object sender, EventArgs e)
        {
            CrearAlumno crearAlumno = new CrearAlumno(this);
            crearAlumno.ShowDialog();
            Hide();
        }

        private void oldAlumno_Click(object sender, EventArgs e)
        {
            ModificarAlumno modificarAlumno = new ModificarAlumno();
            modificarAlumno.ShowDialog();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
