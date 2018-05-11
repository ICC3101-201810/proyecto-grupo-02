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
            Alumno newAlumno = new Alumno(newName, newContraena);
            MyNotes.AgregarAlumnos(newAlumno);

            Close();
            

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
