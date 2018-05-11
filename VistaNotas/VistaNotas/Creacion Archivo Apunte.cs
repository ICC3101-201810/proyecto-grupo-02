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
    public partial class Creacion_Archivo_Apunte : Form
    {
        public Creacion_Archivo_Apunte()
        {
            InitializeComponent();
            
        }

        private void InitializeComboBox()
        {
            this.CBTipo = new ComboBox();
            

            
        }

        private void CBTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
