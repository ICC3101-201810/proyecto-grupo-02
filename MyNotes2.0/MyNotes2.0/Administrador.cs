using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes2._0
{
    [Serializable()]
    class Administrador : Usuario
    {
        public Administrador(string nombre, string contrasena): base(nombre, contrasena)
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

    }
}
