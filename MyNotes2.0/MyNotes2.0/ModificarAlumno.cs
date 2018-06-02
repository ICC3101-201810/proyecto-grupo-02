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
            if (string.IsNullOrEmpty(listaAlumnos.Text))
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
            if (string.IsNullOrEmpty(listaAlumnos.Text))
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
            if (string.IsNullOrEmpty(listaAlumnos.Text))
            {
                MessageBox.Show("Debe seleccionar un alumno");
            }
            else
            {
                hacerAyudante.ShowDialog();
            }
        }

        private void noAyudante_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(listaAlumnos.Text))
            {
                MessageBox.Show("Debe seleccionar un alumno");
            }
            else
            {
                foreach(Semestre s in listener.GetBaseDeDatos().GetListaSemestres())
                {
                    foreach(Ramo r in s.GetListaRamos())
                    {
                        foreach(Seccion i in r.GetSecciones())
                        {
                            i.GetAyudantes().Remove((Alumno)listener.GetBaseDeDatos().GetUser(listaAlumnos.Text));
                        }
                    }
                }
                MessageBox.Show("Ayudante eliminado correctamente");
            }            
        }

        private void ModificarAlumno_Load(object sender, EventArgs e)
        {
        }
    }
}
