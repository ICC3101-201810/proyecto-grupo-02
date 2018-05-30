using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes2._0
{
    [Serializable()]
    public abstract class Usuario
    {
        string Nombre;
        string Contrasena;

        public Usuario(string nombre, string contrasena)
        {
            this.Nombre = nombre;
            this.Contrasena = contrasena;
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public string GetContrasena()
        {
            return Contrasena;
        }
        public void SetNombre(Usuario usuario, string nuevoNombre)
        {
            usuario.Nombre = nuevoNombre;
        }
    }
}
