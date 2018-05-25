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
    public partial class DisplayApuntes : Form
    {
        private Ibd BdD;
        Alumno alumno;
        public DisplayApuntes(object sender, string name)
        {
            InitializeComponent();
            if (sender is Ibd)
            {
                BdD = (Ibd)sender;
            }
            BaseDeDatos bdAux = BdD.GetBaseDeDatos();
            Alumno alumno = (Alumno)bdAux.GetUser(name);
            foreach (Notes apunte in alumno.GetApuntes())
            {
                listBox_Apuntes.Items.Add(apunte);
            }
        }

        private void listBox_Apuntes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BotonEditarApunte_Click(object sender, EventArgs e)
        {
            Apuntes apuntes = new Apuntes(BdD, alumno.GetNombre());
            apuntes.Show();
        }
    }
}
