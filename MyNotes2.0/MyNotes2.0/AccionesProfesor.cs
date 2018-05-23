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
    public partial class AccionesProfesor : Form, ILoger ,IUsuario
    {
        private ILoger loger;
        private IUsuario usuarioActual;
        object entrada;
        BaseDeDatos bd;
        public AccionesProfesor(object sender)
        {
            InitializeComponent();
            if (sender is Bienvenida)
            {
                Console.WriteLine("SE");
                entrada = sender;
            }
            if (sender is ILoger)
            {
                loger = (ILoger)sender;
            }
            if (sender is IUsuario)
            {
                usuarioActual = (IUsuario)sender;
            }
            //label_NamePr.Text = GetUsuario().GetNombre();
        }

        public Usuario GetUsuario()
        {
            return usuarioActual.GetUsuario();
        }

        public void Login(Usuario usuario)
        {
            usuario = (Profesor)usuario;
            label_NamePr.Text = usuario.GetNombre();
        }

        private void button_CrearAp_Click(object sender, EventArgs e)
        {

        }
    }
}
