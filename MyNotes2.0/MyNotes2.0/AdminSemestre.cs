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
    public partial class AdminSemestre : Form
    {
        object listener;
        public AdminSemestre(object sender)
        {
            InitializeComponent();
            listener = sender;
        }

        private void BotonCrearSemestre_Click(object sender, EventArgs e)
        {
            CrearSemestreAdmin crearSemestre = new CrearSemestreAdmin(listener);
            Hide();
            crearSemestre.ShowDialog();
            Show();
        }

        private void BotonAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BotonCambiarNombreSem_Click(object sender, EventArgs e)
        {
            CambiarNombreSemestre cambiarNombre = new CambiarNombreSemestre(listener);
            Hide();
            cambiarNombre.ShowDialog();
            Show();
        }

        private void botonSecciones_Click(object sender, EventArgs e)
        {
            Hide();
            SeccionesAdmin seccionesAdmin = new SeccionesAdmin(listener);
            seccionesAdmin.ShowDialog();
            Show();
        }
    }
}
