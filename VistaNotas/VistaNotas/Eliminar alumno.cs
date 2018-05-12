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
    public partial class Eliminar_alumno : Form
    {
        public Eliminar_alumno()
        {
            InitializeComponent();
            foreach (Alumno i in MyNotes.GetListaAlumnos())
            {
                comboBox1.Items.Add(i.GetNombre());
            }
        }

        private void Eliminar_alumno_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool caso = false;
            Alumno elim = null;
            foreach (Alumno al in MyNotes.GetListaAlumnos())
            {
                if (al.GetNombre() == comboBox1.Text)
                {
                    caso = true;
                    elim = al;
                }
            }
            if (caso == true)
            {
                MyNotes.GetListaAlumnos().Remove(elim);
                Close();
            }
            else
                MessageBox.Show("Seleccione alumno a eliminar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
