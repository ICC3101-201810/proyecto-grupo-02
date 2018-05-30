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
    public partial class HacerAyudante : Form
    {
        private Ibd listener;
        Semestre semestre;
        Ramo ramo;
        public HacerAyudante(object sender, string nombre)
        {
            InitializeComponent();
            if (sender is Ibd)
            {
                listener = (Ibd)sender;
            }
            foreach(Semestre s in listener.GetBaseDeDatos().GetListaSemestres())
            {
                listaSemestre.Items.Add(s.GetID());
            }
            semestre.SetID(listaSemestre.SelectedItem.ToString());
            foreach (Semestre s in listener.GetBaseDeDatos().GetListaSemestres())
            {
                if(s.GetID() == semestre.GetID())
                {
                    foreach(Ramo r in s.GetListaRamos())
                    {
                        listaRamos.Items.Add(r);
                    }
                }
            }

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listaSecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listaRamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listaSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
