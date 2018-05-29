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
        Alumno alumno;
        public Apuntes(object sender, string name)
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
        internal Apuntes(object sender, Notes notes, Usuario usuario)
        {
            InitializeComponent();
            if (sender is Ibd)
            {
                BdD = (Ibd)sender;
            }
            BaseDeDatos bdAux = BdD.GetBaseDeDatos();
            if (usuario is Alumno)
            {
                alumno = (Alumno)usuario;
                foreach (Ramo ramo in alumno.GetRamos())
                {
                    comboBox_Ramos.Items.Add(ramo);
                }
                textBox_Nombre.Text = notes.GetNombre();
                comboBox_Ramos.SelectedItem = notes.GetRamo();
                textBox_Content.Text = notes.GetContent();
            }
            
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            if (alumno.GetApuntes().Count == 0)
            {
                foreach (Notes n in alumno.GetApuntes())
                {
                    if (n.GetNombre() == textBox_Nombre.Text)
                    {
                        MessageBox.Show("Ya existe un apunte con ese nombre.");
                    }
                    else
                    {
                        string nombre = textBox_Nombre.Text;
                        Ramo ramo = (Ramo)comboBox_Ramos.SelectedItem;
                        DateTime dateTime = dateTimePicker1.Value;
                        string contenido = textBox_Content.Text;
                        Notes notes = new Notes(nombre, ramo, dateTime, contenido);
                        alumno.AgregarApuntes(notes);
                        MessageBox.Show("Apunte guardado");
                    }
                }
            }
            else
            {
                string nombre = textBox_Nombre.Text;
                Ramo ramo = (Ramo)comboBox_Ramos.SelectedItem;
                DateTime dateTime = dateTimePicker1.Value;
                string contenido = textBox_Content.Text;
                Notes notes = new Notes(nombre, ramo, dateTime, contenido);
                alumno.AgregarApuntes(notes);
                MessageBox.Show("Apunte guardado");
            }
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
