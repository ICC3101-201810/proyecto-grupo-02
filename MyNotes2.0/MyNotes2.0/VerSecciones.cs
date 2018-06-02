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
        Semestre semestre;
        List<Semestre> listaSemestres = new List<Semestre>();
        Ramo ramo;
        public VerSecciones(object sender)
        {
            InitializeComponent();
            if(sender is Ibd)
            {
                listener = (Ibd)sender;
            }
            foreach(Semestre s in listener.GetBaseDeDatos().GetListaSemestres())
            {
                listaSemestres.Add(s);
                comboBoxSemestre.Items.Add(s.GetID());
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Ramo ra in semestre.GetListaRamos())
                {
                    comboBoxRamo.Items.RemoveAt(0);
                }
                comboBoxRamo.Text = null;
                foreach (Seccion sec in ramo.GetSecciones())
                {
                    listBox1.Items.RemoveAt(0);
                }
                listBox1.Text = null;

            }
            catch (System.NullReferenceException)
            {

            }
            try
            {
                foreach (Semestre sem in listaSemestres)
                {
                    if (comboBoxSemestre.Text == sem.GetID())
                    {
                        semestre = sem;
                    }
                }
                foreach (Ramo ra in semestre.GetListaRamos())
                {
                    comboBoxRamo.Items.Add(ra.GetNombre());
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Cree un ramo para el semestre primero");
            }
        }

        private void comboBoxRamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Seccion sec in ramo.GetSecciones())
                {
                    listBox1.Items.RemoveAt(0);
                }
                listBox1.Text = null;
            }
            catch (System.NullReferenceException)
            {

            }
            try
            {
                foreach (Ramo ra in semestre.GetListaRamos())
                    if (ra.GetNombre() == comboBoxRamo.Text)
                        ramo = ra;
                foreach (Seccion sec in ramo.GetSecciones())
                    listBox1.Items.Add(sec.GetIDSeccion());
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Cree una seccion para el ramo primero");
            }
        }


    }
    
}
