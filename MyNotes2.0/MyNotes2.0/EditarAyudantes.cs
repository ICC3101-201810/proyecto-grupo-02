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
    public partial class EditarAyudantes : Form
    {
        private ISeccion iSeccion;
        private Ibd ibd;
        Seccion seccion;
        Profesor profesor;
        public EditarAyudantes(object sender)
        {
            InitializeComponent();
            if (sender is ISeccion)
            {
                iSeccion = (ISeccion)sender;
            }
            if (sender is Ibd)
            {
                ibd = (Ibd)sender;
            }
            foreach (Seccion sec in iSeccion.GetListaSecciones())
            {
                comboBoxRamo.Items.Add(sec.GetNombre());
            }

        }

        private void BotonAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BotonEliminarAyudante_Click(object sender, EventArgs e)
        {
            // = ListaAyudante.SelectedItem;
        }

        private void comboBoxRamo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
