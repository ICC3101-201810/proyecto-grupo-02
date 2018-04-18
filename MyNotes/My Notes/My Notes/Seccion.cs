using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Notes
{
    public class Seccion
    {
        int ID;
        List<Alumno> alumnos;
        Profesor profesor;
        int vacante;

        public Seccion(int id, List<Alumno> Alumnos,
           Profesor Profesor, int Vacante )
        {
            ID = id;
            alumnos = Alumnos;
            profesor = Profesor;
            vacante = Vacante;
        }
    }
}
