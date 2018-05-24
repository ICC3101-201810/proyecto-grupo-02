using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes2._0
{
    [Serializable()]
    class Notes
    {
        string Nombre;
        Ramo Ramo;
        DateTime Fecha;
        string Contenido;

        public Notes(string nombre, Ramo ramo, DateTime fecha, string contenido)
        {
            Nombre = nombre;
            Ramo = ramo;
            Fecha = fecha;
            Contenido = contenido;
        }
        public string GetNombre()
        {
            return Nombre;
        }
    }
}
