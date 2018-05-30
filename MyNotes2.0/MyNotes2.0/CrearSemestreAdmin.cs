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
    public partial class CrearSemestreAdmin : Form
    {
        private Ibd ibd;
        BaseDeDatos bd;
        public CrearSemestreAdmin(object sender)
        {
            InitializeComponent();
            if (sender is Ibd)
            {
                ibd = (Ibd)sender;
            }
            bd = ibd.GetBaseDeDatos();
        }

        private void BotonAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BotonCrearSemestre_Click(object sender, EventArgs e)
        {
            bool bien = true;
            foreach(Semestre sem in bd.GetListaSemestres())
            {
                if (sem.GetID() == textBoxNombreSemestre.Text)
                {
                    bien = false;
                }
            }
            if (bien == true)
            {
                bd.AgregarSemestre(new Semestre(textBoxNombreSemestre.Text));
                serial.Guardar(bd);
                Close();
            }
            else
            {
                MessageBox.Show("Ya existe el Semestre");
            }
        }
    }
}
