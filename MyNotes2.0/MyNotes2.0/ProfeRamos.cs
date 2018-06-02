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
    public partial class ProfeRamos : Form, ISeccion
    {
        private ISeccion iseccion;
        private Ibd ibd;
        Seccion seccion;
        List<Seccion> secciones;
        object listener;
        Profesor profesor;
        public ProfeRamos(object sender, string name)
        {
            InitializeComponent();
            listener = sender;
            if (sender is Ibd)
            {
                ibd = (Ibd)sender;
            }
            BaseDeDatos BdAux = ibd.GetBaseDeDatos();
            profesor = (Profesor)BdAux.GetUser(name);
            foreach (Semestre s in BdAux.GetListaSemestres())
            {
                foreach (Ramo r in s.GetListaRamos())
                {
                    foreach (Profesor p in r.GetProfes())
                    {
                        if (p.GetNombre() == profesor.GetNombre())
                        {
                            ComboBoxRamos.Items.Add(r);
                        }
                    }

                }
            }
            
        }

        private void BotonAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BotonEditarAyudantes_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Profesor profe in seccion.GetProfesores())
                {
                    if (ibd.GetBaseDeDatos().GetUsuarioActual() == profe)
                    {
                        Hide();
                        EditarAyudantes editarAyudantes = new EditarAyudantes(listener);
                        Show();
                        return;
                    }
                }
            }
            catch (Exception)
            {

            }
            MessageBox.Show("Seleccione Ramo");
        }

        private void BotonCrearMaterial_Click(object sender, EventArgs e)
        {
            Hide();
            ProfeApuntes apuntes = new ProfeApuntes(sender, ComboBoxRamos.SelectedText);
            apuntes.Show();
            Show();
        }

        private void ComboBoxRamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Semestre sem in ibd.GetBaseDeDatos().GetListaSemestres())
            {
                foreach(Ramo ra in sem.GetListaRamos())
                {
                    foreach (Seccion sec in ra.GetSecciones())
                    {
                        foreach (Profesor prof in sec.GetProfesores())
                        {
                            if (ibd.GetBaseDeDatos().GetUsuarioActual() == prof)
                            {
                                seccion = sec;
                                secciones.Add(seccion);
                            }
                        }
                    }
                }
            }
        }

        public List<Seccion> GetListaSecciones()
        {
            return secciones;
        }
    }
}
