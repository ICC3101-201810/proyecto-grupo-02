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
    public partial class ModificarRamo : Form
    {
        private Ibd ibd;
        List<Semestre> listaSemestres;
        Semestre semestre;
        public ModificarRamo(object sender)
        {
            InitializeComponent();
            if (sender is Ibd)
            {
                ibd = (Ibd)sender;
            }
            listaSemestres = ibd.GetBaseDeDatos().GetListaSemestres();
            foreach (Semestre sem in listaSemestres)
            {
                ComboBoxSemestre.Items.Add(sem.GetID());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonCambiarNombreRamo_Click(object sender, EventArgs e)
        {
            bool mal = true;
            if ((textBoxCambiarNombre.Text == null) || (textBoxCambiarNombre.Text == ""))
            {
                MessageBox.Show("Coloca un nombre a colocar");
                return;
            }
            foreach (Ramo ra in semestre.GetListaRamos())
            {
                if (ra.GetNombre() == ComboBoxRamos.SelectedItem.ToString())
                {
                    ra.SetNombre(textBoxCambiarNombre.Text);
                    mal = false;
                    Close();
                }
            }
            if (mal == true)
            {
                MessageBox.Show("Revisa, tienes un error");
            }
        }

        private void ComboBoxSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Ramo ra in semestre.GetListaRamos())
                {
                    ComboBoxRamos.Items.RemoveAt(0);
                }
                    ComboBoxRamos.Text = null;

            }
            catch (System.NullReferenceException)
            {

            }
            try
            {
                foreach (Semestre sem in listaSemestres)
                {
                    if (ComboBoxSemestre.Text == sem.GetID())
                    {
                        semestre = sem;
                    }
                }
                foreach (Ramo ra in semestre.GetListaRamos())
                {
                    ComboBoxRamos.Items.Add(ra.GetNombre());
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Cree un ramo para el semestre primero");
            }
        }
    }
}
