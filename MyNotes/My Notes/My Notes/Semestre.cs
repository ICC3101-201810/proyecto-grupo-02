using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Notes
{
    public class Semestre
    {
        string ID;
        List<Ramo> ramos = new List<Ramo>();

        public Semestre(string id)
        {
            ID = id;
            //ramos = ramosPorSemestre;
        }
        public void SetID(string NewID)
        {
            ID = NewID;
        }
        public List<Ramo> GetListaRamos()
        {
            return ramos;
        }

        public bool AgregarRamo (Ramo ramo)
        {
            if (ramos.IndexOf(ramo) == -1)
            {
                ramos.Add(ramo);
                Console.WriteLine("Ramo agregado correctamente");
                return true;
            }
            else
            {
                Console.WriteLine("Ramo ya se encuentra en el Semestre" + this.ID);
                return false;
            }
        }


        




    }
}