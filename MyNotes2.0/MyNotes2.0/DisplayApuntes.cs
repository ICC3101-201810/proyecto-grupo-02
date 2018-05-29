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
    public partial class DisplayApuntes : Form
    {
        private Ibd BdD;
        Alumno alumno;
        public DisplayApuntes(object sender, string name)
        {
            InitializeComponent();
            if (sender is Ibd)
            {
                BdD = (Ibd)sender;
            }
            BaseDeDatos bdAux = BdD.GetBaseDeDatos();
            if (bdAux.GetUser(name) is Alumno)
            {
                alumno = (Alumno)bdAux.GetUser(name);
                foreach (Notes apunte in alumno.GetApuntes())
                {
                    listBox_Apuntes.Items.Add(apunte);
                }
            }
            else if (bdAux.GetUser(name) is Profesor)
            {
                Profesor profesor = (Profesor)bdAux.GetUser(name);
            }
        }

        private void listBox_Apuntes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BotonEditarApunte_Click(object sender, EventArgs e)
        {
            if (listBox_Apuntes.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione algun apunte.");
            }
            else
            {
                Notes notes = (Notes)listBox_Apuntes.SelectedItem;
                Apuntes apuntes = new Apuntes(BdD, notes, alumno);
                Close();
                apuntes.Show();

            }
        }
    }
}
