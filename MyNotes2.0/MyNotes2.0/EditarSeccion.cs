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
    public partial class EditarSeccion : Form
    {
        private Ibd ibd;
        public EditarSeccion(object sender)
        {
            InitializeComponent();
            if (sender is Ibd)
            {
                ibd = (Ibd)sender;
            }
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonOpcionesSeccion_Click(object sender, EventArgs e)
        {
            Hide();
            (new OpcionesSeccion(ibd)).ShowDialog();
            Show();
        }
    }
}
