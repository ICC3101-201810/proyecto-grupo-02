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
    public partial class Hacer_Ayudante : Form
    {
        public Hacer_Ayudante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ayudante creado", "", MessageBoxButtons.OK) == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
