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
    public partial class Menu_Profesor : Form
    {
        public Menu_Profesor()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serial.Guardar();
            MessageBox.Show("\tSus cambios han sido guardados.\n\tSe he cerrado secion", "Guardado");
            this.Hide();
            Entrada entrada = new Entrada();
            entrada.ShowDialog();
            this.Close();
        }

        private void BotonSubirMaterial_Click(object sender, EventArgs e)
        {

        }

        private void BotonCrearMaterial_Click(object sender, EventArgs e)
        {
            
        }
    }
}
