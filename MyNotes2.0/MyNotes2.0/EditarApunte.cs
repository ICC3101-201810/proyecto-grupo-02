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
    public partial class EditarApunte : Form
    {
        private Ibd BdD;
        Alumno alumno;
        public EditarApunte(object sender, string name)
        {
            InitializeComponent();
            if (sender is Ibd)
            {
                BdD = (Ibd)sender;
            }
            BaseDeDatos bdAux = BdD.GetBaseDeDatos();
            alumno = (Alumno)bdAux.GetUser(name);
            foreach (Ramo ramo in alumno.GetRamos())
            {
                comboBox_Ramos.Items.Add(ramo);
            }
        }

        public BaseDeDatos GetBaseDeDatos()
        {
            throw new NotImplementedException();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            //ver corroboracion
            serial.Guardar(BdD.GetBaseDeDatos());
            Close();
        }
    }
}
