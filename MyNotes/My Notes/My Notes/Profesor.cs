using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Notes
{
    [Serializable()]
    class Profesor : Usuario
    {
        bool administrador = false;
        List<string> informaicon;
        List<Apuntes> material;

        public Profesor(string nombre, string contrasena) : base (nombre,contrasena)
        {

        }

        public string GetNombre()
        {
            return base.nombre;
        }
        public void SetNombre(string nombreNuevo)
        {
            nombre = nombreNuevo.ToUpper();
        }

        public string GetContrasena()
        {
            return base.contrasena;
        }

        public void SubirMaterial()
        {
            //aun no implementada
        }

        public bool HacerAyudante ()
        {
            return true;
            //aun no implementada
        }

        public bool CrearMaterial ()
        {

            //Console.WriteLine("Material creado");
            return true;
            //aun no implementada
        }

    }
}
