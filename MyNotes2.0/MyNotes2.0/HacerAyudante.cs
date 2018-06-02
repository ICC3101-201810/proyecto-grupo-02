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
    public partial class HacerAyudante : Form
    {
        private Ibd listener;
        Semestre semestre;
        Ramo ramo;
        public HacerAyudante(object sender, string nombre)
        {
            InitializeComponent();
            nombreAlumno.Text = nombre;
            if (sender is Ibd)
            {
                listener = (Ibd)sender;
            }//listener
            foreach(Semestre s in listener.GetBaseDeDatos().GetListaSemestres())
            {
                listaSemestre.Items.Add(s.GetID());
                foreach(Ramo r in s.GetListaRamos())
                {
                    listaRamos.Items.Add(r.GetNombre());
                    foreach(Seccion i in r.GetSecciones())
                    {
                        listaSecciones.Items.Add(i.GetIDSeccion() + " " + i.GetNombre());
                    }
                }
            } //combobox
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            bool bandera = true;
            if (String.IsNullOrEmpty(listaRamos.Text) || String.IsNullOrEmpty(listaSecciones.Text) || String.IsNullOrEmpty(listaSemestre.Text))
            {
                MessageBox.Show("Debe seleccionar un alumno");
            }
            else
            {
                foreach (Semestre s in listener.GetBaseDeDatos().GetListaSemestres())
                {
                    foreach (Ramo r in s.GetListaRamos())
                    {
                        foreach (Seccion i in r.GetSecciones())
                        {
                            foreach (Alumno a in listener.GetBaseDeDatos().GetListaAlumnos())
                            {
                                if (i.GetAyudantes().Contains(a))
                                {
                                     MessageBox.Show("Oops, este alumno ya es ayudante");
                                }
                                else
                                {
                                        i.GetAyudantes().Add(a);
                                        MessageBox.Show("Ayudante creado exitosamente");                                       
                                }                               
                            }
                        }
                    }
                }
            }
            serial.Cargar(listener.GetBaseDeDatos());
            Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listaSecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listaRamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaSecciones.Items.Clear();
            listaSecciones.Text = null;
            foreach(Ramo r in semestre.GetListaRamos())
            {
                if(listaRamos.Text == r.GetNombre())
                {
                    ramo = r;
                }
            }
            foreach(Seccion seccion in ramo.GetSecciones())
            {
                listaSecciones.Items.Add(seccion.GetIDSeccion());
            }
        }

        private void listaSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            listaRamos.Items.Clear();
            listaRamos.Text = null;
            foreach (Semestre sem in listener.GetBaseDeDatos().GetListaSemestres())
            {
                if (listaSemestre.Text == sem.GetID())
                {
                    semestre = sem;
                }
            }
            foreach (Ramo ra in semestre.GetListaRamos())
            {
                listaRamos.Items.Add(ra.GetNombre());
            }

        }
    }
}
