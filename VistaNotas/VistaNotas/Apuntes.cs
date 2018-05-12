using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistaNotas
{
    [Serializable()]
    
    class Apuntes
    {
        string nombre;
        Ramo ramo;
        Seccion seccion;
        string contenido;
        DateTime fecha;

        public Apuntes (string ElNombre, Ramo esteRamo, string ElContenido, DateTime time)
        {
            nombre = ElNombre;
            ramo = esteRamo;
            contenido = ElContenido;
            fecha = time;
            //this.seccion = seccion;
        }



    }
}
