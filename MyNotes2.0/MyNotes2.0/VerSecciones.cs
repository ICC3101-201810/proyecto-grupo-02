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
    public partial class VerSecciones : Form
    {
        private Ibd listener;
        Seccion seccion;
        public VerSecciones(object sender)
        {
            InitializeComponent();
            if(sender is Ibd)
            {
                listener = (Ibd)sender;
            }
            foreach(Semestre s in listener.GetBaseDeDatos().GetListaSemestres())
            {
                foreach(Ramo r in s.GetListaRamos())
                {
                    comboBox_ramos.Items.Add(r);
                }
            }
        }

        private void comboBox_ramos_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = null;
            foreach (Semestre s in listener.GetBaseDeDatos().GetListaSemestres())
            {
                foreach (Ramo r in s.GetListaRamos())
                {
                    foreach (Seccion sec in r.GetSecciones())
                    {
                        seccion = sec;
                    }
                }
            }
            foreach (Seccion s in seccion.GetSecciones())
            {
                textBox1.AppendText(s.GetIDSeccion() + "\n");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
