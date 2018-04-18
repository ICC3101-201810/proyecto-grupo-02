using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Notes
{
    public class Seccion
    {
        int IDSeccion;
        List<Alumno> alumnos = new List<Alumno>();
        List<Profesor> profesores = new List<Profesor>();
        int vacantes;

        public Seccion(int IDSeccion, int vacantes)
        {
            this.IDSeccion = IDSeccion;
            this.vacantes = vacantes;
            //ver como se une con Profesor
        }

        public int GetIDSeccion ()
        {
            return IDSeccion;
        }
    }
}
