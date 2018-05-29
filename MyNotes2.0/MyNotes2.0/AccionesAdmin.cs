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
    public partial class AccionesAdmin : Form
    {
        private Ibd listener;
        public AccionesAdmin(object sender, string nombre)
        {
            InitializeComponent();
            label_NombreAdm.Text = nombre;
            if (sender is Ibd)
            {
                listener = (Ibd)sender;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlumnoAdmin clickAlumno = new AlumnoAdmin(listener);
            clickAlumno.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void adminProfesor_Click(object sender, EventArgs e)
        {
            ProfeAdmin profeAdmin = new ProfeAdmin();
            profeAdmin.Show();
        }

        private void adminRamo_Click(object sender, EventArgs e)
        {
            RamoAdmin ramoAdmin = new RamoAdmin();
            ramoAdmin.Show();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            
            Close();
        }
    }
}
