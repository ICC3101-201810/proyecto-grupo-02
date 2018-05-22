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
    public partial class RamoAdmin : Form
    {
        public RamoAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newRamo_Click(object sender, EventArgs e)
        {
            CrearRamo crearRamo = new CrearRamo();
            crearRamo.ShowDialog();
        }

        private void oldRamo_Click(object sender, EventArgs e)
        {
            ModificarRamo modificarRamo = new ModificarRamo();
            modificarRamo.ShowDialog();
        }

        private void datesRamo_Click(object sender, EventArgs e)
        {

        }
    }
}
