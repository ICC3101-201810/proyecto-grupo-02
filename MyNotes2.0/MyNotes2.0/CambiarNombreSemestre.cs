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
    public partial class CambiarNombreSemestre : Form
    {
        private Ibd ibd;

        public CambiarNombreSemestre(object sender)
        {
            InitializeComponent();
            if (sender is Ibd)
            {
                ibd = (Ibd)sender;
            }
            foreach(Semestre sem in ibd.GetBaseDeDatos().GetListaSemestres())
            {
                comboBoxSemestres.Items.Add(sem.GetID());
            }
            
        }

        private void BotonAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BotonCamiarNombre_Click(object sender, EventArgs e)
        {
            int cont = 0;
            if ((textBoxNuevoNombre.Text == null) || (textBoxNuevoNombre.Text == ""))
            {
                MessageBox.Show("ingrese nombre a colocar");
            }
            else
            {
                foreach (Semestre sem in ibd.GetBaseDeDatos().GetListaSemestres())
                {
                    if (textBoxNuevoNombre.Text == sem.GetID())
                    {
                        cont++;
                    }
                }
                if (cont < 1)
                {
                    foreach (Semestre sem in ibd.GetBaseDeDatos().GetListaSemestres())
                    {
                        if (comboBoxSemestres.SelectedItem.ToString() == sem.GetID())
                        {
                            sem.SetID(textBoxNuevoNombre.Text);
                            Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ya se encuentra un semestre con ese nombre");
                }
            }
        }
    }
}
