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

        private void BotonCrear_Click(object sender, EventArgs e)
        {
            foreach (Alumno alumno in MyNotes.GetListaAlumnos())
            {
                if (MyNotes.Usuario_Actual().GetNombree() == alumno.GetNombre())
                {
                    //MessageBox.Show(IngresoMaterial.Text); //--> lo hace cambiado, nice
                    alumno.CrearApunte(IngresoApunte.Text); //crear el material --> no implementado aun
                    serial.Guardar();
                    this.Hide();
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("error al crear");
            
        }
    }
}
