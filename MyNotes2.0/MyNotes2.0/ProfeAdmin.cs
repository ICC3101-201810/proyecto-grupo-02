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
    public partial class ProfeAdmin : Form
    {
        public ProfeAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newProfe_Click(object sender, EventArgs e)
        {
            CrearProfesor crearProfesor = new CrearProfesor();
            crearProfesor.ShowDialog();
        }

        private void oldProfe_Click(object sender, EventArgs e)
        {
            ModificarProfe modificarProfe = new ModificarProfe();
            modificarProfe.ShowDialog();
        }
    }
}
