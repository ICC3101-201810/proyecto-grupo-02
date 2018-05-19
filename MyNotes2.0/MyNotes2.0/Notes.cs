using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes2._0
{
    class Notes
    {
        string Nombre;
        string Ramo;
        DateTime Fecha;
        string Contenido;

        public Notes(string nombre, string ramo, DateTime fecha, string contenido)
        {
            Nombre = nombre;
            Ramo = ramo;
            Fecha = fecha;
            Contenido = contenido;
        }
    }
}
