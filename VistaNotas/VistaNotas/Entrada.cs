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
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string ContrasenaUsuario = TContrasena.Text;
            string NombreUsuario = TUsuario.Text;
            bool passright = false;
            if (passright != true)
            {

                if (MyNotes.ConfirmarContrasena(NombreUsuario, ContrasenaUsuario))
                {
                    MessageBox.Show("Bienvenido a MyNotes "+ NombreUsuario.ToUpper());
                    passright = true;

                }
                else
                {
                    Console.Beep();
                    MessageBox.Show("Contrasena invalida.\nIntente nuevamente.");
                }

            }
            if (passright == true)
            {
                foreach (Administrador admin in MyNotes.GetListaAdmin())
                {
                    if (NombreUsuario == admin.GetNombre())
                    {
                        this.Hide();
                        Menu_Administrador menu_Administrador = new Menu_Administrador();
                        menu_Administrador.ShowDialog();
                        this.Close();
                    }
                }
                foreach (Alumno alumn in MyNotes.GetListaAlumnos())
                {
                    if (NombreUsuario == alumn.GetNombre())
                    {
                        this.Hide();
                        Menu_Alumno menu_Alumno = new Menu_Alumno();
                        menu_Alumno.ShowDialog();
                        this.Close();
                    }
                }

                foreach (Profesor profe in MyNotes.GetListaProfesores())
                {
                    if (NombreUsuario == profe.GetNombre())
                    {
                        this.Hide();
                        Menu_Profesor menu_Profesor = new Menu_Profesor();
                        menu_Profesor.ShowDialog();
                        this.Close();
                    }
                }

            }
            
        }
            //if (NombreUsuario == MyNotes.GetListaAdmin().)
            //this.Hide();
            //Menu_Profesor f2 = new Menu_Profesor();
            //f2.ShowDialog();
            //this.Close();
    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // contraseña
            string ContrasenaUsuario = TContrasena.Text;
            //return ContrasenaUsuario;
        }

        private void TUsuario_TextChanged(object sender, EventArgs e)
        {
            string NombreUsuario = TUsuario.Text;
            //return NombreUsuario;
        }

        private void HOLANDA_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
