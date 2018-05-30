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
            cambiarNombreAlumno.ShowDialog();
            
        }

        private void eliminarAlumno_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alumno eliminado");
        }

        private void toAyudante_Click(object sender, EventArgs e)
        {
            HacerAyudante hacerAyudante = new HacerAyudante(listener, listaAlumnos.Text);
            foreach (Alumno a in listener.GetBaseDeDatos().GetListaAlumnos())
            {
                if (a.GetNombre() == listaAlumnos.Text)
                {
                    if (a.ayudante)
                    {
                        MessageBox.Show("Ups! Este alumno ya es ayudante");
                    }
                    else
                    {
                        a.ayudante = true;
                        MessageBox.Show("Ayudante creado exitosamente!");
                    }
                }
            }
            
        }

        private void noAyudante_Click(object sender, EventArgs e)
        {
            HacerAyudante ayudante = new HacerAyudante(sender, listaAlumnos.Text);
            ayudante.ShowDialog();
            foreach (Alumno a in listener.GetBaseDeDatos().GetListaAlumnos())
            {
                if (a.GetNombre() == listaAlumnos.Text)
                {
                    if (a.ayudante)
                    {
                        a.ayudante = false;
                        MessageBox.Show("Ayudante eliminado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Este alumno no es ayudante");
                    }
                }
            }

        }

        private void ModificarAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
