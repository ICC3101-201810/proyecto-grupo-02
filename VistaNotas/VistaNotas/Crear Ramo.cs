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
    public partial class Crear_Ramo : Form
    {
        public Crear_Ramo()
        {
            InitializeComponent();
            foreach (Semestre i in MyNotes.GetListaSemestres())
            {
                comboBox1.Items.Add(i.GetID());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreRamo = textBox1.Text;
            string NRC = textBox2.Text;
            string semestre = comboBox1.Text;

            Ramo ramo = new Ramo(NRC, nombreRamo);
            foreach(Semestre i in MyNotes.GetListaSemestres())
            {
                if (i.GetID() == semestre)
                {
                    i.AgregarRamo(ramo);
                }
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Crear_Ramo_Load(object sender, EventArgs e)
        {

        }
    }
}
