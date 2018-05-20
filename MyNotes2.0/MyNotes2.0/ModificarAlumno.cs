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
        public ModificarAlumno()
        {
            InitializeComponent();
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
            CambiarNombreAlumno cambiarNombreAlumno = new CambiarNombreAlumno();
            cambiarNombreAlumno.ShowDialog();
        }

        private void eliminarAlumno_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alumno eliminado");
        }

        private void toAyudante_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayudante creado exitosamente!");
        }

        private void noAyudante_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayudante eliminado exitosamente");

        }

        private void ModificarAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
