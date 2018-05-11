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
            foreach (Semestre semestre in MyNotes.GetListaSemestres())
            {
                foreach(Ramo ramo in semestre.GetListaRamos())
                {
                    foreach(Seccion seccion in ramo.GetSecciones())
                    {
                        foreach(Profesor profe in seccion.GetProfesores())
                        {
                            if(profe.GetNombre() == MyNotes.Usuario_Actual().GetNombree())
                                comboBox_Seleccion_Ramo.Items.Add(ramo.GetNRC());
                        }
                    }
                    
                }
            }
            comboBox_Seleccion_Ramo.Items.Add("asd"); //asi se agrega un item al combobox
            IngresoMaterial.Text = "hola"; //asi agregamos texto inicial al textbox
        }

        private void CrearMaterial_Load(object sender, EventArgs e)
        {

        }
    }
}
