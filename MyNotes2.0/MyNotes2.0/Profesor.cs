using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes2._0
{
    class Profesor : Usuario
    {
        List<string> informacion;
        List<Apuntes> material;

        public Profesor(string nombre, string contrasena) : base(nombre, contrasena)
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
        public void SubirMaterial()
        {

        }
        public void HacerAyudante()
        {

        }
        public void CrearMaterial()
        {

        }
    }
}
