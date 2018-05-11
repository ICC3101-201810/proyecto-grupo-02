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
    public partial class CrearMaterial : Form
    {
        public CrearMaterial()
        {
            InitializeComponent();
            comboBox_Seleccion_Ramo.Items.Add("asd"); //asi se agrega un item al combobox
            IngresoMaterial.Text = "hola"; //asi agregamos texto inicial al textbox
        }

        private void CrearMaterial_Load(object sender, EventArgs e)
        {

        }
    }
}
