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
    public partial class Cambiar_Nombre_Profesor : Form
    {
        public Cambiar_Nombre_Profesor()
        {
            InitializeComponent();
            foreach (Profesor i in MyNotes.GetListaProfesores())
            {
                comboBox1.Items.Add(i.GetNombre());
            }
        }

        private void button1_Click(object sender, EventArgs e)// boton cambiar nombre profe
        {
            List<Alumno> alumnos = MyNotes.GetListaAlumnos();
            List<Profesor> profesores = MyNotes.GetListaProfesores();
            string nombreNuevo = textBox1.Text;
            Usuario usuarioActual = MyNotes.Usuario_Actual();

            if (MyNotes.VerificarNombre(nombreNuevo) == true)
            {
                foreach (Profesor pr in MyNotes.GetListaProfesores())
                {
                    if (pr.GetNombre() == comboBox1.Text)
                        pr.SetNombre(nombreNuevo);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
