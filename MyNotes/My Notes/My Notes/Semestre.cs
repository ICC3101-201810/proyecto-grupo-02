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
        List<Ramo> ramos;

        public Semestre(string id,List<Ramo> ramosPorSemestre)
        {
            ID = id;
            ramos = ramosPorSemestre;
        }
    }
}
