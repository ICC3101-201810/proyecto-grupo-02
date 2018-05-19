using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes2._0
{
    [Serializable()]
    class Seccion : Ramo
    {
        string IDSeccion;
        List<Alumno> alumnos = new List<Alumno>();
        List<Alumno> ayudantes = new List<Alumno>();
        List<Profesor> profesores = new List<Profesor>();
        int vacantes;


        public Seccion(string IDSeccion, int vacantes, string NombreRamo) : base(NombreRamo)
        {
            this.IDSeccion = IDSeccion;
            this.vacantes = vacantes;
            //ver como se une con Profesor
        }


        public string GetIDSeccion()
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
        public bool InscribirAlumno(Alumno alumno) 
        {
            if (alumnos.IndexOf(alumno) == -1)
            {
                alumnos.Add(alumno);
                return true;
            }
            return false;
        }
        public bool EliminarAlumno (Alumno alumno)
        {
            if (!(alumnos.IndexOf(alumno) == -1))
            {
                alumnos.Remove(alumno);
                return true;
            }
            return false;
        }
        public bool InscribirProfesor(Profesor profesor)
        {
            if (profesores.IndexOf(profesor) == -1)
            {
                profesores.Add(profesor);
                return true;
            }
            return false;
        }
        public bool EliminarProfesor (Profesor profesor)
        {
            if (!(profesores.IndexOf(profesor) == -1))
            {
                profesores.Remove(profesor);
                return true;
            }
            return false;
        }
        public bool InscribirAyudante(Alumno ayudante)
        {
            if (ayudantes.IndexOf(ayudante) == -1)
            {
                ayudantes.Add(ayudante);
                return true;
            }
            return false;
        }
        public bool EliminarAyudante(Alumno Ayudante)
        {
            if (!(alumnos.IndexOf(Ayudante) == -1))
            {
                alumnos.Remove(Ayudante);
                return true;
            }
            return false;
        }

    }
}
