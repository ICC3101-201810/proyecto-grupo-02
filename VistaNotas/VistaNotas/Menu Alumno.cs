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
    public partial class Menu_Alumno : Form
    {
        public Menu_Alumno()
        {
            InitializeComponent();
        }

        private void Menu_Alumno_Load(object sender, EventArgs e)
        {

        }


        private void button7_Click(object sender, EventArgs e)
        {
            serial.Guardar();
            this.Hide();
            Entrada entrada = new Entrada();
            entrada.ShowDialog();
            this.Close();
        }

        private void BotonCrearApunte_Click(object sender, EventArgs e)
        {
            new Seleccionar_Ramo_Para_Crear_Apunte().ShowDialog();
        }
    }
}
