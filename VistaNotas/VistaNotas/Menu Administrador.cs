using System;
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
    public partial class Menu_Administrador : Form
    {
        public Menu_Administrador()
        {
            InitializeComponent();
        }

        private void Menu_Administrador_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Alumnos.Visible = false;
            Profesores.Visible = false;
            Ramos.Visible = false;
            Semestre.Visible = false;
            label1.Text = "Administrar Alumnos";
        }
    }
}
