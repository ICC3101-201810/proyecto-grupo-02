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
    public partial class ProfeApuntes : Form
    {
        private Ibd ibd;
        Profesor profesor;
        BaseDeDatos bd;
        public ProfeApuntes(object sender, string nombreramo)
        {
            InitializeComponent();
            if (sender is Ibd)
            {
                ibd = (Ibd)sender;
            }
            bd = ibd.GetBaseDeDatos();
            profesor = (Profesor)bd.GetUsuarioActual();
            foreach (Semestre sem in ibd.GetBaseDeDatos().GetListaSemestres())
            {
                foreach (Ramo ra in sem.GetListaRamos())
                {
                    if (ra.GetNombre() == nombreramo)
                    {
                        TextNombreRamo.Text = nombreramo; 
                    }
                }
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            serial.Guardar(bd);
            Close();
        }
    }
}
