using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistaNotas
{
    [Serializable()]
    class Seccion
    {
        string IDSeccion;
        List<Alumno> alumnos = new List<Alumno>();
        List<Alumno> ayudantes = new List<Alumno>();
        List<Profesor> profesores = new List<Profesor>();
        int vacantes;

        public Seccion(string IDSeccion, int vacantes)
        {
            this.IDSeccion = IDSeccion;
            this.vacantes = vacantes;
            //ver como se une con Profesor
        }

        public string GetIDSeccion ()
        {
            return IDSeccion;
        }
        public List<Alumno> GetAlumnos()
        {
            return alumnos;
        }
        public List<Profesor> GetProfesores()
        {
            return profesores;
        }
        public List<Alumno> GetAyudantes()
        {
            return ayudantes;
        }
    }
}
