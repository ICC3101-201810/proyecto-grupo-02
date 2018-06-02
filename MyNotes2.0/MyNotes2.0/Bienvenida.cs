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
    public partial class Bienvenida : Form , ILoger, IUsuario, Ibd
    {
        BaseDeDatos bd;
        public Bienvenida()
        {
            InitializeComponent();
            bd = new BaseDeDatos();
            serial.Cargar(bd);
            //Administrador tester = new Administrador("admin", "123");
            //bd.AgregarUsuario(tester);
        }
        public Usuario GetUsuario()
        {
            return bd.GetUsuarioActual();
        }

        public void Login(Usuario usuario)
        {
            if (usuario is Alumno)
            {
                Alumno UsuarioActual = new Alumno(usuario.GetNombre(), usuario.GetContrasena());
                bd.SetUsuarioActual(UsuarioActual);
            }
            else if (usuario is Profesor)
            {
                Profesor UsuarioActual = new Profesor(usuario.GetNombre(), usuario.GetContrasena());
                bd.SetUsuarioActual(UsuarioActual);
            }
            else if (usuario is Administrador)
            {
                Administrador UsuarioActual = new Administrador(usuario.GetNombre(), usuario.GetContrasena());
                bd.SetUsuarioActual(UsuarioActual);
            }
        }
        private void button_Iniciar_Click(object sender, EventArgs e)
        {
            string name = textBox_User.Text;
            string pwd = textBox_Pwd.Text;
            if (bd.ExisteUser(name)) //Verifica que existe Usuario
            {
                Usuario usuario = bd.GetUser(name);
                bd.SetUsuarioActual(usuario);
                bool bnd = false;
                while (bnd == false)
                {
                    if (usuario.GetContrasena() != pwd)
                    {
                        MessageBox.Show("Contrasena incorrecta.");
                        break;
                    }
                    else
                    {
                        bnd = true;
                    }
                }
                if (bnd != false)
                {
                    if (usuario is Administrador)
                    {
                        Hide();
                        AccionesAdmin accionesAdmin = new AccionesAdmin(this, name);
                        Login(usuario);
                        accionesAdmin.ShowDialog();
                        Show();
                    }
                    else if (usuario is Alumno)
                    {
                        Hide();
                        AccionesAlumno accionesAlumno = new AccionesAlumno(this, name);
                        Login(usuario);
                        accionesAlumno.ShowDialog();
                        Show();
                    }
                    else
                    {
                        Hide();
                        AccionesProfesor accionesProfesor = new AccionesProfesor(this, name);
                        Login(usuario);
                        accionesProfesor.ShowDialog();
                        Show();
                    }
                }
                else { }
            }
            else
            {
                MessageBox.Show("Usuario o contrasena incorrectas.");
            }
        }
        
        public BaseDeDatos GetBaseDeDatos()
        {
            return bd;
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {

        }
    }
}
