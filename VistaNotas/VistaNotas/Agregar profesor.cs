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
    public partial class Agregar_profesor : Form
    {
        public Agregar_profesor()
        {
            InitializeComponent();

        }

        private void Agregar_profesor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newName = textBox1.Text;
            string newContraena = textBox2.Text;
            if (MyNotes.VerificarContrasena(newContraena) == false)
                MessageBox.Show("La contrasena debe tener mas de 3 caracteres");
            else if (MyNotes.VerificarNombre(newName) == true)
                MessageBox.Show("Ya existe un Usuario con ese nombre");
            else
            {
                Profesor newprofe = new Profesor(newName, newContraena);
                MyNotes.AgregarProfesor(newprofe);
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
