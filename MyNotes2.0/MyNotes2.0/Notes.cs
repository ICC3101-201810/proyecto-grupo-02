using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes2._0
{
    [Serializable()]
    internal class Notes
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
        public Ramo GetRamo()
        {
            return Ramo;
        }
        public DateTime GetDate()
        {
            return Fecha;
        }
        public string GetContent()
        {
            return Contenido;
        }

        public override string ToString()
        {
            string display = Nombre +" -["+ Ramo.GetNombre()+"]";
            return display;
        }
    }
}
