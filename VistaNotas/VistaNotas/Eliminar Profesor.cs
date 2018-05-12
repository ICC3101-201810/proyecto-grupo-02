using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaNotas
{
    public partial class Eliminar_Profesor : Form
    {
        public Eliminar_Profesor()
        {
            InitializeComponent();
            foreach (Profesor i in MyNotes.GetListaProfesores())
            {
                comboBox1.Items.Add(i.GetNombre());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool caso = false;
            Profesor elim = null;
            foreach (Profesor al in MyNotes.GetListaProfesores())
            {
                if (al.GetNombre() == comboBox1.Text)
                {
                    caso = true;
                    elim = al;
                }
            }
            if (caso == true)
            {
                MyNotes.GetListaProfesores().Remove(elim);
                Close();
            }
            else
                MessageBox.Show("Seleccione profesor a eliminar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
