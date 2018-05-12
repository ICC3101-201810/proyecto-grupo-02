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
    public partial class Agregar_alumno : Form
    {
        public Agregar_alumno()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string newName = textBox1.Text;
            string newContraena = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newName = textBox1.Text;
            string newContraena = textBox2.Text;
            if (MyNotes.VerificarContrasena(newContraena) == false)
                MessageBox.Show("La contrasena debe tener mas de 3 caracteres");
            else if (MyNotes.VerificarNombre(newName) == false)
                MessageBox.Show("Usuario ya creado");
            else
            {
                Alumno newAlumno = new Alumno(newName, newContraena);
                MyNotes.AgregarAlumnos(newAlumno);
                Close();
            }
            

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Agregar_alumno_Load(object sender, EventArgs e)
        {

        }
    }
}
