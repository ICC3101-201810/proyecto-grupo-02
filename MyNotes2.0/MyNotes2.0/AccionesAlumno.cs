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
    public partial class AccionesAlumno : Form
    {
        private Ibd BdD;
        string NameAl;
        public AccionesAlumno(object sender, string name)
        {
            InitializeComponent();
            if (sender is Ibd)
            {
                BdD = (Ibd)sender;
            }
            label_NameAl.Text = name;
            NameAl = name;
        }
        private void button_CrearAp_Click(object sender, EventArgs e)
        {
            Apuntes apuntes = new Apuntes(BdD, NameAl);
            apuntes.Show();
        }

        private void label_NameAl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_DispAp_Click(object sender, EventArgs e)
        {
            DisplayApuntes displayApuntes = new DisplayApuntes(BdD, NameAl);
            displayApuntes.Show();
        }

        private void BotonInicioSesion_Click(object sender, EventArgs e)
        {
            serial.Guardar(BdD.GetBaseDeDatos());
            Close();
        }
    }
}
