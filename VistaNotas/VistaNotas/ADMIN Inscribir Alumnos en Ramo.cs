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
    public partial class ADMIN_Inscribir_Alumnos_en_Ramo : Form
    {
        public ADMIN_Inscribir_Alumnos_en_Ramo()
        {
            InitializeComponent();
            foreach(Alumno i in MyNotes.GetListaAlumnos())
            {
                comboBox1.Items.Add(i.GetNombre());
            }
            foreach(Semestre i in MyNotes.GetListaSemestres())
            {
                foreach(Ramo j in i.GetListaRamos())
                {
                    comboBox2.Items.Add(j.GetNRC() + " " + j.GetNombre());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            MessageBox.Show("Alumno inscrito");
        }
    }
}
