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
    public partial class ModificarProfe : Form
    {
        public ModificarProfe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editarAlumno_Click(object sender, EventArgs e)
        {
            CambiarNombreProfesor cambiarNombreProfesor = new CambiarNombreProfesor();
            cambiarNombreProfesor.ShowDialog();
        }

        private void eliminarAlumno_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profesor eliminado exitosamente!");
            //podriamos poner un messagebox como: esta seguro? bla bla
        }
    }
}
