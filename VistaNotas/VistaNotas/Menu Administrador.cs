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
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
            linkLabel4.Visible = false;
            label1.Text = "Administrar Ramos";
        }


        private void Profesores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
            linkLabel4.Visible = false;
            label1.Text = "Administrar Profesores";
        }

        private void Semestre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
            linkLabel4.Visible = false;
            label1.Text = "Administrar Semestres";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            linkLabel1.Visible = true;
            linkLabel2.Visible = true;
            linkLabel3.Visible = true;
            linkLabel4.Visible = true;
            label1.Text = "¿Qué desea administrar?";
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
            linkLabel4.Visible = false;
            label1.Text = "Administrar Alumnos";
        }
    }
}
