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
        public void SetNombre(string newname)
        {
            Nombre = newname;
        }
        public void SetRamo(Ramo newRamo)
        {
            Ramo = newRamo;
        }
        public void SetFecha(DateTime newdate)
        {
            Fecha = newdate;
        }
        public void SetContenido(string newcontent)
        {
            Contenido = newcontent;
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
