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
        private Ibd ibd;
        public RamoAdmin(object sender)
        {
            InitializeComponent();
            if (sender is Ibd)
            {
                ibd = (Ibd)sender;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newRamo_Click(object sender, EventArgs e)
        {
            CrearRamo crearRamo = new CrearRamo(ibd);
            crearRamo.ShowDialog();
        }

        private void oldRamo_Click(object sender, EventArgs e)
        {
            ModificarRamo modificarRamo = new ModificarRamo(ibd);
            modificarRamo.ShowDialog();
        }

        private void datesRamo_Click(object sender, EventArgs e)
        {
            FechasRamo fechasRamo = new FechasRamo();
            fechasRamo.ShowDialog();
        }

        private void materialRamo_Click(object sender, EventArgs e)
        {
            VerMaterial verMaterial = new VerMaterial();
            verMaterial.ShowDialog();
        }

        private void RamoAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
