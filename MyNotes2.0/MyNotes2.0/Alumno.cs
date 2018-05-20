using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes2._0
{
    class Alumno : Usuario
    {
        bool ayudante = false;
        List<Notes> apuntes = new List<Notes>();
        //List<Ramo> Ramos = new List<Ramo>();
        public Alumno(string nombre, string contrasena) : base(nombre, contrasena)
        {

        }
        public string GetNombre()
        {
            return base.GetNombre();
        }
        public string GetContrasena()
        {
            return base.GetContrasena();
        }
        public void AgregarApuntes(Notes notas)
        {
            apuntes.Add(notas);
        }
        /*public void AgregarRamo(Ramo ramo)
        {
            Ramos.Add(ramo);
        }
        public void LimpiarRamos()
        {
            Ramos.Clear();
        }*/
    }
}
