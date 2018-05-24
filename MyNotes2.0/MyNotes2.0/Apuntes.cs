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
        private Ibd BdD;
        public Apuntes(object sender, string name)
        {
            InitializeComponent();
            if (sender is Ibd)
            {
                BdD = (Ibd)sender;
            }
            BaseDeDatos bdAux = BdD.GetBaseDeDatos();
            Alumno alumno = (Alumno)bdAux.GetUser(name);
            foreach (Ramo ramo in alumno.GetRamos())
            {
                comboBox_Ramos.Items.Add(ramo.GetNombre());
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string nombre = textBox_Nombre.Text;
            Ramo ramo = (Ramo)comboBox_Ramos.SelectedItem;
            DateTime dateTime = dateTimePicker1.Value;
            string contenido = textBox_Content.Text;
            Notes notes = new Notes(nombre, ramo, dateTime, contenido);
            MessageBox.Show("Apunte guardado");
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_Ramos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
