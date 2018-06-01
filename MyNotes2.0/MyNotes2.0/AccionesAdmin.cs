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
        object salida;
        public AccionesAdmin(object sender, string nombre)
        {
            InitializeComponent();
            label_NombreAdm.Text = nombre;
            if (sender is Ibd)
            {
                listener = (Ibd)sender;
            }
            salida = sender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlumnoAdmin clickAlumno = new AlumnoAdmin(listener);
            //Hide();
            clickAlumno.ShowDialog();
            //Show();           
        }

        private void botonSemestre_Click(object sender, EventArgs e)
        {
            AdminSemestre adminSemestre = new AdminSemestre(salida);
            //Hide();
            adminSemestre.ShowDialog();
            //Show();
        }

        private void adminProfesor_Click(object sender, EventArgs e)
        {
            ProfeAdmin profeAdmin = new ProfeAdmin();
            //Hide();
            profeAdmin.ShowDialog();
            //Show();
        }

        private void adminRamo_Click(object sender, EventArgs e)
        {
           // Hide();
            RamoAdmin ramoAdmin = new RamoAdmin(listener);
            ramoAdmin.ShowDialog();
            //Show();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            serial.Guardar(listener.GetBaseDeDatos());
            Close();
        }

        private void botonSecciones_Click(object sender, EventArgs e)
        {
           // Hide();
            SeccionesAdmin seccionesAdmin = new SeccionesAdmin(listener);
            seccionesAdmin.ShowDialog();
            //Show();
        }
    }
}
