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
    public partial class ModificarAlumno : Form
    {
        private Ibd listener;
        public ModificarAlumno(object sender)
        {
            InitializeComponent();
            if(sender is Ibd)
            {
                listener = (Ibd)sender;
            }
            foreach (Alumno i in listener.GetBaseDeDatos().GetListaAlumnos())
            {
                listaAlumnos.Items.Add(i.GetNombre());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listaAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void editarAlumno_Click(object sender, EventArgs e)
        {
            CambiarNombreAlumno cambiarNombreAlumno = new CambiarNombreAlumno(listener,listaAlumnos.Text);
            if (listaAlumnos.Text == null)
            {
                MessageBox.Show("Debe seleccionar alumno");
            }
            else
            {
                cambiarNombreAlumno.ShowDialog();
            }
            
        }

        private void eliminarAlumno_Click(object sender, EventArgs e)
        {
            if (listaAlumnos.Text == null)
            {
                MessageBox.Show("Debe seleccionar alumno");
            }
            else
            {
                MessageBox.Show("Alumno eliminado");//no lo hace
            }
        }

        private void toAyudante_Click(object sender, EventArgs e)
        {
            HacerAyudante hacerAyudante = new HacerAyudante(listener, listaAlumnos.Text);
            hacerAyudante.ShowDialog();                       
        }

        private void noAyudante_Click(object sender, EventArgs e)
        {
            HacerAyudante ayudante = new HacerAyudante(sender, listaAlumnos.Text);
            if (String.IsNullOrEmpty(listaAlumnos.Text))
            {
                MessageBox.Show("Debe seleccionar un alumno");
            }
            else
            {
                ayudante.ShowDialog();
            }            
        }

        private void ModificarAlumno_Load(object sender, EventArgs e)
        {
        }
    }
}
