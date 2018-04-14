using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Notes
{
    public abstract class Usuario
    {
        protected string nombre;
        protected string contrasena;

        protected Usuario(string nombre, string contrasena)
        {
            this.nombre = nombre;
            this.contrasena = contrasena;
        }


        abstract protected bool VerificarNombre();
        abstract protected bool VerificarContraseña();
        
    }
}
