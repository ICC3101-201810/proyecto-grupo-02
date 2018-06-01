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
    public partial class AccionesProfesor : Form
    {
        private ILoger loger;
        private IUsuario usuarioActual;
        private Ibd BdD;
        public AccionesProfesor(object sender)
        {
            InitializeComponent();
            if (sender is Ibd)
            {
                BdD = (Ibd)sender;
            }
            if (sender is ILoger)
            {
                loger = (ILoger)sender;
            }
            if (sender is IUsuario)
            {
                usuarioActual = (IUsuario)sender;
            }
            label_NamePr.Text = usuarioActual.GetUsuario().GetNombre();
        }



        private void button_CrearAp_Click(object sender, EventArgs e)
        {

        }

        private void BotonCerrarSesion_Click(object sender, EventArgs e)
        {
            serial.Guardar(BdD.GetBaseDeDatos());
            Close();
        }

        private void BotonAdministrarRamos_Click(object sender, EventArgs e)
        {
            Hide();
            ProfeRamos profeRamos = new ProfeRamos(BdD);
            profeRamos.Show();
            Close();
        }

        private void AccionesProfesor_Load(object sender, EventArgs e)
        {

        }
    }
}
