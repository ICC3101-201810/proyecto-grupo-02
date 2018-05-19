using System;
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
    public partial class Bienvenida : Form , ILoger
    {
        BaseDeDatos bd;
        public Bienvenida()
        {
            InitializeComponent();
            bd = new BaseDeDatos();
            Administrador tester = new Administrador("admin", "123");
            bd.AgregarUsuario(tester);
            Alumno alumno = new Alumno("pancho", "hola");
            bd.AgregarUsuario(alumno);
            
        }
        public void Login(Usuario usuario)
        {
            if (usuario is Alumno)
            {
                Alumno UsuarioActual = new Alumno(usuario.GetNombre(), usuario.GetContrasena());
            }
            else if (usuario is Profesor)
            {
                Profesor UsuarioActual = new Profesor(usuario.GetNombre(), usuario.GetContrasena());
            }
            else if (usuario is Administrador)
            {
                Administrador UsuarioActual = new Administrador(usuario.GetNombre(), usuario.GetContrasena());
            }
        }
        private void button_Iniciar_Click(object sender, EventArgs e)
        {
            string name = textBox_User.Text;
            string pwd = textBox_Pwd.Text;
            if (bd.ExisteUser(name)) //Verifica que existe Usuario
            {
                Usuario usuario = bd.GetUser(name);
                if (usuario is Administrador)
                {
                    AccionesAdmin accionesAdmin = new AccionesAdmin(this);
                    Login(usuario);
                    accionesAdmin.Show();
                }
                else if (usuario is Alumno)
                {
                    AccionesAlumno accionesAlumno = new AccionesAlumno(this);
                    Login(usuario);
                    accionesAlumno.Show();
                }
                else //Parte para el profesor
                {

                }
            }
            else
            {
                MessageBox.Show("Usuario o contrasena incorrectas.");
            }
        }
    }
}
