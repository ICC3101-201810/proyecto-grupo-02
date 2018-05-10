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
            linkLabel5.Visible = false;
            linkLabel6.Visible = false;
            linkLabel7.Visible = false;
            linkLabel8.Visible = false;
            linkLabel9.Visible = false;
            linkLabel10.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // ramos
        {
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
            linkLabel4.Visible = false;
            linkLabel5.Visible = false;
            linkLabel6.Visible = false;
            linkLabel7.Visible = false;
            linkLabel8.Visible = false;
            linkLabel9.Visible = false;
            linkLabel10.Visible = false;

            label1.Text = "Administrar Ramos";
        }


        private void Profesores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // profesores
        {
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
            linkLabel4.Visible = false;
            linkLabel5.Visible = false;
            linkLabel6.Visible = false;
            linkLabel7.Visible = false;
            linkLabel8.Visible = false;
            linkLabel9.Visible = false;
            linkLabel10.Visible = false;

            label1.Text = "Administrar Profesores";
        }

        private void Semestre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // semestre
        {
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
            linkLabel4.Visible = false;
            linkLabel5.Visible = false;
            linkLabel6.Visible = false;
            linkLabel7.Visible = false;
            linkLabel8.Visible = false;
            linkLabel9.Visible = false;
            linkLabel10.Visible = false;

            label1.Text = "Administrar Semestres";
        }

        private void button1_Click(object sender, EventArgs e) // atras
        {
            
            linkLabel1.Visible = true;
            linkLabel2.Visible = true;
            linkLabel3.Visible = true;
            linkLabel4.Visible = true;
            linkLabel5.Visible = false;
            linkLabel6.Visible = false;
            linkLabel7.Visible = false;
            linkLabel8.Visible = false;
            linkLabel9.Visible = false;
            linkLabel10.Visible = false;

            label1.Text = "¿Qué desea administrar?";
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e) //alumnos
        {
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
            linkLabel4.Visible = false;
            linkLabel5.Visible = false;
            linkLabel8.Visible = false;
            linkLabel9.Visible = false;
            linkLabel10.Visible = false;

            label1.Text = "Administrar Alumnos";

            linkLabel5.Visible = true;
            linkLabel6.Visible = true;
            linkLabel7.Visible = true;


        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // agregar alumno
        {
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
            linkLabel4.Visible = false;
            linkLabel5.Visible = false;
            linkLabel6.Visible = false;
            linkLabel7.Visible = false;
            linkLabel8.Visible = false;
            linkLabel9.Visible = false;
            linkLabel10.Visible = false;
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // editar alumno
        {
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
            linkLabel4.Visible = false;
            linkLabel5.Visible = false;
            linkLabel5.Visible = false;
            linkLabel6.Visible = false;

            label1.Text = "Editar Alumno";
            
            linkLabel7.Visible = true;
            linkLabel8.Visible = true;
            linkLabel9.Visible = true;
            linkLabel10.Visible = true;
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // eliminar alumno
        {

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//  cambiar nom alumno
        {
            CambiarNombreAlumno cambiarNombreAlumno = new CambiarNombreAlumno();
            cambiarNombreAlumno.ShowDialog();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// hacer ayud
        {

        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// eliminar ayudante
        {

        }
    }
}
