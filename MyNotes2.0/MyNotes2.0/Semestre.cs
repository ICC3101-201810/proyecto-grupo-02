using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes2._0
{
    [Serializable()]
    class Semestre
    {
        string nombreSemestre;
        List<Ramo> ramos = new List<Ramo>();

        public Semestre(string id)
        {
            nombreSemestre = id;
            //ramos = ramosPorSemestre;
        }
        public void SetID(string NewID)
        {
            nombreSemestre = NewID;
        }
        public List<Ramo> GetListaRamos()
        {
            return ramos;
        }

        public bool AgregarRamo(Ramo ramo)
        {
            if (ramos.IndexOf(ramo) == -1)
            {
                ramos.Add(ramo);
                return true;
            }
            else
            {
                Console.Beep();
                return false;
            }
        }
        public bool EliminarRamo(Ramo ramo)
        {
            if (!(ramos.IndexOf(ramo) == -1))
            {
                ramos.Remove(ramo);
                return true;
            }
            return false;
        }

        public string GetID()
        {
            return nombreSemestre;
        }
    }
}
