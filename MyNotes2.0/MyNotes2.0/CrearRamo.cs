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
    public partial class CrearRamo : Form
    {
        private Ibd ibd;
        List<Semestre> listaSemestres;
        Semestre semestre;
        public CrearRamo(object sender)
        {
            InitializeComponent();
            if (sender is Ibd)
            {
                ibd = (Ibd)sender;
            }
            listaSemestres = ibd.GetBaseDeDatos().GetListaSemestres();
            foreach(Semestre sem in listaSemestres)
            {
                comboBoxSemestre.Items.Add(sem.GetID());
            }
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            int cont = 0;
            foreach (Semestre sem in listaSemestres)
            {
                if (sem.GetID() == comboBoxSemestre.Text)
                {
                    semestre = sem;
                }
            }
            foreach(Ramo ra in semestre.GetListaRamos())
            {    
                if(ra.GetNombre() == textBoxNombreNuevoRamo.Text)
                {
                    MessageBox.Show("Ramo ya existe");
                    cont++; 
                }
            }
            if (cont < 1)
            {
                semestre.AgregarRamo(new Ramo(textBoxNombreNuevoRamo.Text));
                serial.Guardar(ibd.GetBaseDeDatos());
                Close();
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
