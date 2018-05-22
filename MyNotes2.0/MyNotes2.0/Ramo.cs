using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes2._0
{
    [Serializable()]
    class Ramo
    {
        //no NRC por que hay un solo ramo llamado, con distintas secciones dentro
        string nombreRamo;
        List<Seccion> secciones = new List<Seccion>();
        List<DateTime> Fechas = new List<DateTime>(); //trabajar fechas

        public Ramo(string Nombre)
        {
            this.nombreRamo = Nombre;
            //no contriene profesor, ya que el profesor, es profesor de la seccion
        }

        public bool AgregarSeccion(Seccion seccion)
        {
            if (secciones.IndexOf(seccion) == -1)
            {
                secciones.Add(seccion);
                return true;
            }
            return false;
        }
        public bool AgregarFechas(DateTime date)
        {
            Fechas.Add(date);
            return true;
        }
        public List<Seccion> GetSecciones()
        {
            return secciones;
        }
        public List<DateTime> GetFechas()
        {
            return Fechas;
        }
        public void SetNombre(string nombrenuevo)
        {
            nombreRamo = nombrenuevo;
        }
        public string GetNombre()
        {
            return nombreRamo;
        }

    }
}

