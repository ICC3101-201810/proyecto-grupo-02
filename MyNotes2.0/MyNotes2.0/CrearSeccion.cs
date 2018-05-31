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
    public partial class CrearSeccion : Form
    {
        private Ibd ibd;
        List<Semestre> listaSemestres;
        Semestre semestre;
        Ramo ramo;
        int vacantes = 0;
        public CrearSeccion(object sender)
        {
            InitializeComponent();
            if (sender is Ibd)
            {
                ibd = (Ibd)sender;
            }
            listaSemestres = ibd.GetBaseDeDatos().GetListaSemestres();//ver
            foreach (Semestre sem in listaSemestres)
            {
                comboBoxSemestre.Items.Add(sem.GetID());
            }
            textBoxVacantes.Text = "0";
        }
        
        private void botonAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonCrearSeccion_Click(object sender, EventArgs e)
        {

            foreach (Ramo ra in semestre.GetListaRamos())
            {
                if (ra.GetNombre() == comboBoxRamo.SelectedItem.ToString())
                {
                    ramo = ra;
                    foreach (Seccion sec in ra.GetSecciones())
                    {
                        if (sec.GetIDSeccion() == textBoxNuevoNombre.Text)
                        {
                            MessageBox.Show("Seccion ya existe");
                            return;
                        }
                    }
                }
            }
            
            ramo.AgregarSeccion(new Seccion(textBoxNuevoNombre.Text,Int32.Parse(textBoxVacantes.Text),(ramo.GetNombre())));
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

        private void botonMas_Click(object sender, EventArgs e)
        {
            vacantes++;
            textBoxVacantes.Text = vacantes.ToString();
        }

        private void botonMenos_Click(object sender, EventArgs e)
        {
            vacantes--;
            textBoxVacantes.Text = vacantes.ToString();
        }
    }
}
