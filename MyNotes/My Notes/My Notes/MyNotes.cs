using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Notes
{
    class MyNotes
    {//DOS LISTAS porque no podemos hacer lista de Usuarios y meterle porfesores y alumnos.
        List<Alumno> ListaAlumnos;
        List<Profesor> ListaProfesores;

        public MyNotes()
        {
            ListaAlumnos = new List<Alumno>();
            ListaProfesores = new List<Profesor>();
        }
        public void AgregarAlumnos(Alumno alumno)
        {
            ListaAlumnos.Add(alumno);
        }
        public void AgregarProfesor(Profesor profesor)
        {
            ListaProfesores.Add(profesor);
        }
        public List<Alumno> GetListaAlumnos()
        {
            return ListaAlumnos;
        }
        public List<Profesor> GetListaProfesores()
        {
            return ListaProfesores;
        }
    }
}
