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
            linkLabel11.Visible = false;
            linkLabel12.Visible = false;
            linkLabel13.Visible = false;
            linkLabel14.Visible = false;
            linkLabel15.Visible = false;
            linkLabel16.Visible = false;
            linkLabel17.Visible = false;
            linkLabel18.Visible = false;
            linkLabel19.Visible = false;
            linkLabel20.Visible = false;
            linkLabel21.Visible = false;
            linkLabel22.Visible = false;
            linkLabel23.Visible = false;
            linkLabel24.Visible = false;
            linkLabel25.Visible = false;
            linkLabel26.Visible = false;
            linkLabel27.Visible = false;


            button1.Visible = false;
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
            button1.Visible = true;

            linkLabel15.Visible = true;
            linkLabel16.Visible = true;
            linkLabel17.Visible = true;


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
            button1.Visible = true;


            linkLabel11.Visible = true;
            linkLabel12.Visible = true;
            linkLabel13.Visible = true;

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

            linkLabel25.Visible = true;
            linkLabel26.Visible = true;
            linkLabel27.Visible = true;

            label1.Text = "Administrar Semestres";
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e) //boton atras
        {
            if (label1.Text == "Editar alumno")
            {
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;
                linkLabel3.Visible = false;
                linkLabel4.Visible = false;

                linkLabel5.Visible = true;
                linkLabel6.Visible = true;
                linkLabel7.Visible = true;

                linkLabel8.Visible = false;
                linkLabel9.Visible = false;
                linkLabel10.Visible = false;

                label1.Text = "Administrar alumnos";
            }

            else if (label1.Text == "Editar profesor")
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

                linkLabel11.Visible = true;
                linkLabel12.Visible = true;
                linkLabel13.Visible = true;

                linkLabel14.Visible = false;


                label1.Text = "Administrar profesores";
            }

            else if (label1.Text == "Editar Ramo")
            {
                linkLabel15.Visible = true;
                linkLabel16.Visible = true;
                linkLabel17.Visible = true;

                linkLabel18.Visible = false;
                linkLabel19.Visible = false;
                linkLabel20.Visible = false;

                label1.Text = "Administrar Ramos";
            }

            else if (label1.Text == "Administrar Fechas")
            {
                linkLabel18.Visible = true;
                linkLabel19.Visible = true;
                linkLabel20.Visible = true;

                linkLabel21.Visible = false;
                linkLabel22.Visible = false;

                label1.Text = "Editar Ramo";
            }

            else if (label1.Text == "Administrar Material")
            {
                linkLabel18.Visible = true;
                linkLabel19.Visible = true;
                linkLabel20.Visible = true;

                linkLabel21.Visible = false;
                linkLabel22.Visible = false;

                linkLabel23.Visible = false;
                linkLabel24.Visible = false;

                label1.Text = "Editar Ramo";
            }

            else
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

                linkLabel11.Visible = false;
                linkLabel12.Visible = false;
                linkLabel13.Visible = false;

                linkLabel14.Visible = false;

                linkLabel15.Visible = false;
                linkLabel16.Visible = false;
                linkLabel17.Visible = false;

                linkLabel18.Visible = false;
                linkLabel19.Visible = false;
                linkLabel20.Visible = false;

                linkLabel21.Visible = false;
                linkLabel22.Visible = false;

                linkLabel23.Visible = false;
                linkLabel24.Visible = false;

                linkLabel25.Visible = false;
                linkLabel26.Visible = false;
                linkLabel27.Visible = false;

                label1.Text = "¿Qué desea administrar?";
                button1.Visible = false;
            }



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

            label1.Text = "Administrar alumnos";

            linkLabel5.Visible = true;
            linkLabel6.Visible = true;
            linkLabel7.Visible = true;

            button1.Visible = true;


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
            Agregar_alumno agregar_Alumno = new Agregar_alumno();
            agregar_Alumno.ShowDialog();

            linkLabel5.Visible = true;
            linkLabel6.Visible = true;
            linkLabel7.Visible = true;

            button1.Visible = true;


        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // editar alumno
        {
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;

            linkLabel4.Visible = false;
            linkLabel5.Visible = false;
            linkLabel6.Visible = false;
            linkLabel7.Visible = false;

            linkLabel8.Visible = true;
            linkLabel9.Visible = true;
            linkLabel10.Visible = true;


            label1.Text = "Editar Alumno";

            button1.Visible = true;

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // eliminar alumno
        {
            Eliminar_alumno eliminar_Alumno = new Eliminar_alumno();
            eliminar_Alumno.ShowDialog();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//  cambiar nom alumno
        {
            CambiarNombreAlumno cambiarNombreAlumno = new CambiarNombreAlumno();
            cambiarNombreAlumno.ShowDialog();

            button1.Visible = true;
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// hacer ayud
        {
            Hacer_Ayudante hacer_Ayudante = new Hacer_Ayudante();
            hacer_Ayudante.ShowDialog();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// eliminar ayudante
        {
            Eliminar_ayudante eliminar_Ayudante = new Eliminar_ayudante();
            eliminar_Ayudante.ShowDialog();
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// agregar profesor
        {
            Agregar_profesor agregar_Profesor = new Agregar_profesor();
            agregar_Profesor.ShowDialog();

            button1.Visible = true;
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// editar profe
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

            linkLabel11.Visible = false;
            linkLabel12.Visible = false;
            linkLabel13.Visible = false;

            linkLabel14.Visible = true;


            label1.Text = "Editar profesor";

            button1.Visible = true;
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// cambiar nombre profe
        {
            Cambiar_Nombre_Profesor cambiar_Nombre_Profesor = new Cambiar_Nombre_Profesor();
            cambiar_Nombre_Profesor.ShowDialog();

            button1.Visible = true;
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// eliminar profe
        {
            Eliminar_Profesor eliminar_Profesor = new Eliminar_Profesor();
            eliminar_Profesor.ShowDialog();
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// crear ramo
        {
            Crear_Ramo crear_Ramo = new Crear_Ramo();
            crear_Ramo.ShowDialog();

            button1.Visible = true;
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// editar ramo
        {
            linkLabel15.Visible = false;
            linkLabel16.Visible = false;
            linkLabel17.Visible = false;

            linkLabel18.Visible = true;
            linkLabel19.Visible = true;
            linkLabel20.Visible = true;

            label1.Text = "Editar Ramo";
            button1.Visible = true;
        }

        private void linkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// cambiar nombre ramo
        {
            Cambiar_Nombre_Ramo cambiar_Nombre_Ramo = new Cambiar_Nombre_Ramo();
            cambiar_Nombre_Ramo.ShowDialog();

            button1.Visible = true;
        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// fechas
        {
            linkLabel18.Visible = false;
            linkLabel19.Visible = false;
            linkLabel20.Visible = false;

            linkLabel21.Visible = true;
            linkLabel22.Visible = true;

            label1.Text = "Administrar Fechas";
            button1.Visible = true;
        }

        private void linkLabel20_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// material
        {
            linkLabel18.Visible = false;

            linkLabel20.Visible = false;

            linkLabel23.Visible = true;
            linkLabel24.Visible = true;

            label1.Text = "Administrar Material";
            button1.Visible = true;
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// eliminar ramo
        {
            Eliminar_Ramo eliminar_Ramo = new Eliminar_Ramo();
            eliminar_Ramo.ShowDialog();

            button1.Visible = true;
        }

        private void linkLabel21_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// crear fecha ramo
        {
            Crear_Fecha_Ramo crear_Fecha_Ramo = new Crear_Fecha_Ramo();
            crear_Fecha_Ramo.ShowDialog();

            button1.Visible = true;
        }

        private void linkLabel22_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// editar fecha ramo
        {
            Editar_Fecha_Ramo editar_Fecha_Ramo = new Editar_Fecha_Ramo();
            editar_Fecha_Ramo.ShowDialog();

            button1.Visible = true;
        }

        private void linkLabel23_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// editar material
        {

        }

        private void linkLabel24_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// eliminar material
        {

        }

        private void linkLabel25_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// crear semestre
        {
            Crear_Semestre crear_Semestre = new Crear_Semestre();
            crear_Semestre.ShowDialog();

            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
            linkLabel4.Visible = false;

            button1.Visible = true;
        }

        private void linkLabel26_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// editar semestre
        {
            Editar_Semestre editar_Semestre = new Editar_Semestre();
            editar_Semestre.ShowDialog();
        }

        private void linkLabel27_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)// eliminar semestre
        {
            Eliminar_Semestre eliminar_Semestre = new Eliminar_Semestre();
            eliminar_Semestre.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serial.Guardar();
            Close();
            
        }
    }   
}
