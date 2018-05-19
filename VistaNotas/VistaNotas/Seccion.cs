using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistaNotas
{
    [Serializable()]
    class Seccion : Ramo
    {
        string IDSeccion;
        List<Alumno> alumnos = new List<Alumno>();
        List<Alumno> ayudantes = new List<Alumno>();
        List<Profesor> profesores = new List<Profesor>();
        int vacantes;
        string NRC;


        public Seccion(string IDSeccion, int vacantes, string NRC, string NombreRamo) : base (NRC, NombreRamo)
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
        public void inscribirAlumno (Alumno alumno) // irá aca??
        {
            alumnos.Add(alumno);
        }
    }
}
