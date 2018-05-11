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
    public partial class Seleccionar_Ramo_Para_Crear_Apunte : Form
    {
        public Seleccionar_Ramo_Para_Crear_Apunte()
        {
            InitializeComponent();

        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            //confirmar que no hay un apunte con el mismo nombre en este ramo
            comboBox_Seleccion_Ramo.Hide();
            LabelSeleccioneRamo.Hide();
            Label_Escriba_Nombre.Hide();
            Nombre_Nuevo_Apunte.Hide();
            BotonAceptar.Hide();
        }

        private void Nombre_Nuevo_Apunte_TextChanged(object sender, EventArgs e)
        {
            //ACA VA EL METODO CREAR APUNTE.
        }
    }
}
