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
    public partial class CrearAlumno : Form
    {
        private Ibd listener;
        public CrearAlumno(object sender)
        {
            InitializeComponent();
            if(sender is Ibd)
            {
                listener = (Ibd)sender;
            }
        }  

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)//aceptar
        {
            

        }

        private void newName_TextChanged(object sender, EventArgs e)
        {

        }

        private void newPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
