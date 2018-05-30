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
    public partial class CambiarNombreAlumno : Form
    {
        private Ibd listener;
        string nombre;
        public CambiarNombreAlumno(object sender, string nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
            nombreAlumno.Text = nombre;
            if(sender is Ibd)
            {
                listener = (Ibd)sender;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Alumno a in listener.GetBaseDeDatos().GetListaAlumnos())
            {
                if (a.GetNombre() == nombre)
                {
                    a.SetNombre(a, textBox1.Text);
                }
            }

            Close();
        }

        private void nombreAlumno_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
