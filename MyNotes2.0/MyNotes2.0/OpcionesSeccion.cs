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
    public partial class OpcionesSeccion : Form
    {
        private Ibd ibd;
        Semestre semestre;
        List<Semestre> listaSemestres;
        Ramo ramo;
        Seccion seccion;
        int vacantes = 0;
        public OpcionesSeccion(object sender)
        {
            InitializeComponent();
            if (sender is Ibd)
            {
                ibd = (Ibd)sender;
            }
            listaSemestres = ibd.GetBaseDeDatos().GetListaSemestres();
            foreach (Semestre sem in listaSemestres)
            {
                comboBoxSemestre.Items.Add(sem.GetID());
            }
            botonMas.Visible = false;
            botonMenos.Visible = false;
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            Close();
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

        private void comboBoxRamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Seccion sec in ramo.GetSecciones())
                {
                    comboBoxSeccion.Items.RemoveAt(0);
                }
                comboBoxSeccion.Text = null;
                botonMas.Visible = false;
                botonMenos.Visible = false;
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
                    comboBoxSeccion.Items.Add(sec.GetIDSeccion());
                botonMas.Visible = false;
                botonMenos.Visible = false;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Cree una seccion para el ramo primero");
            }

        }

        private void comboBoxSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (Seccion sec in ramo.GetSecciones())
                if (sec.GetIDSeccion() == comboBoxSeccion.SelectedItem.ToString())
                {
                    seccion = sec;
                    vacantes = seccion.GetVacantes();
                }
            
            textBoxVacantes.Text = vacantes.ToString();
            botonMas.Visible = true;
            botonMenos.Visible = true;
        }

        private void botonMas_Click(object sender, EventArgs e)
        {
            vacantes++;
            textBoxVacantes.Text = vacantes.ToString();
        }

        private void botonMenos_Click(object sender, EventArgs e)
        {
            if (seccion.GetAlumnos().Count() == vacantes)
            {
                MessageBox.Show("La seccion ya tiene esa cantidad de alumnos, para hacer menos vacantes, elimine a un alumno primero");
                return;
            }
            vacantes--;
            textBoxVacantes.Text = vacantes.ToString();
        }

        private void botonCambiarNombre_Click(object sender, EventArgs e)
        {
            seccion.SetID(textBoxNuevoNombre.Text);
            Close();
        }

        private void botonCambiarVacantes_Click(object sender, EventArgs e)
        {
            seccion.SetVacantes(Int32.Parse(textBoxVacantes.Text));
            Close();
        }
    }
}
