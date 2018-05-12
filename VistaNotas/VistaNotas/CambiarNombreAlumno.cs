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
    public partial class CambiarNombreAlumno : Form
    {
        public CambiarNombreAlumno()
        {
            InitializeComponent();
            foreach (Alumno i in MyNotes.GetListaAlumnos())
            {
                comboBox1.Items.Add(i.GetNombre());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) // boton cambiar nombre
        {
            List<Alumno> alumnos = MyNotes.GetListaAlumnos();
            List<Profesor> profesores = MyNotes.GetListaProfesores();
            string nombreNuevo = textBox1.Text;
            Usuario usuarioActual = MyNotes.Usuario_Actual(); 

            if (MyNotes.VerificarNombre(nombreNuevo) == true)
            {
                foreach(Alumno al in MyNotes.GetListaAlumnos())
                {
                    if (al.GetNombre() == comboBox1.Text)
                        al.SetNombre(nombreNuevo);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("ya existe el nombre en admin/alumno/profesor, intente nuevamente");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
