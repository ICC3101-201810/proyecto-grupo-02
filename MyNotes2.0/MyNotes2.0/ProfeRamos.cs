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
    public partial class ProfeRamos : Form
    {
        private Ibd ibd;
        public ProfeRamos(object sender)
        {
            InitializeComponent();
            if (sender is Ibd)
            {
                ibd = (Ibd)sender;
            }
            foreach (Semestre sem in ibd.GetBaseDeDatos().GetListaSemestres())
            {
                foreach (Ramo ra in sem.GetListaRamos())
                {
                    foreach (Seccion sec in ra.GetSecciones())
                    {
                        foreach (Profesor prof in  sec.GetProfesores())
                        {
                            if (ibd.GetBaseDeDatos().GetUsuarioActual() == prof)
                            {
                                ComboBoxRamos.Items.Add(ra);
                            }
                        }
                    }
                }
            }
        }

        private void BotonAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BotonEditarAyudantes_Click(object sender, EventArgs e)
        {
            EditarAyudantes editarAyudantes = new EditarAyudantes(sender);
            Close();
        }

        private void BotonCrearMaterial_Click(object sender, EventArgs e)
        {
            Hide();
            ProfeApuntes apuntes = new ProfeApuntes(sender, ComboBoxRamos.SelectedText);
            apuntes.Show();
            Show();
        }
    }
}
