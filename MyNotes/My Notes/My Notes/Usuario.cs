using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Notes
{
    [Serializable()]
    public abstract class Usuario
    {
        protected string nombre;
        protected string contrasena;

        protected Usuario(string nombre, string contrasena)
        {
            this.nombre = nombre;
            this.contrasena = contrasena;
        }
    }
}
