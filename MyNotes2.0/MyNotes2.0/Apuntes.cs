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
    public partial class Apuntes : Form
    {
        public Apuntes()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string nombre = textBox_Nombre.Text;
            string ramo = textBox_Ramo.Text;
            DateTime dateTime = dateTimePicker1.Value;
            string contenido = textBox_Content.Text;
            Notes notes = new Notes(nombre, ramo, dateTime, contenido);
        }
    }
}
