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
        public DisplayApuntes(object sender, string name)
        {
            InitializeComponent();
            if (sender is Ibd)
            {
                BdD = (Ibd)sender;
            }
            BaseDeDatos bdAux = BdD.GetBaseDeDatos();
            Alumno alumno = (Alumno)bdAux.GetUser(name);
            foreach (Notes apunte in alumno.GetApuntes())
            {
                listBox_Apuntes.Items.Add(apunte);
            }
            
        }
    }
}
