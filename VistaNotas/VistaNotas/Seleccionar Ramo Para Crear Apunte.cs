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
                    //comboBox_Seleccion_Ramo
                    foreach (Semestre semestre in MyNotes.GetListaSemestres())
                    {
                        foreach(Ramo ramo in semestre.GetListaRamos())
                        {
                            foreach (Seccion seccion in ramo.GetSecciones())
                            {
                                if (comboBox_Seleccion_Ramo.GetItemText(comboBox_Seleccion_Ramo.SelectedItem) == ramo.GetNRC())
                                {
                                    alumno.CrearApunte(Nombre_Nuevo_Apunte.Text, IngresoApunte.Text, ramo, seccion); //crear el material --> no implementado aun
                                    serial.Guardar();
                                    this.Hide();
                                    this.Close();
                                    return;
                                }
                            }
                            
                        }
                    }
                }
            }
            MessageBox.Show("error al crear");
            
        }

        private void Nombre_Nuevo_Apunte_TextChanged(object sender, EventArgs e)
        {

        }

        private void IngresoApunte_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Seleccion_Ramo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
