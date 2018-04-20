using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Notes
{
    class MyNotes
    {//TRES LISTAS porque no podemos hacer lista de Usuarios y meterle porfesores, admins y alumnos.
        List<Alumno> ListaAlumnos;
        List<Profesor> ListaProfesores;
        List<Administrador> ListaAdministradores;

        public MyNotes()
        {
            ListaAlumnos = new List<Alumno>();
            ListaProfesores = new List<Profesor>();
            ListaAdministradores = new List<Administrador>();
        }
        public void AgregarAdmin(Administrador administrador)
        {
            ListaAdministradores.Add(administrador);
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
        public List<Administrador> GetListaAdmin()
        {
            return ListaAdministradores;
        }
        public bool ConfirmarContrasena (string nombre, string pass)
        {
            Alumno Alumno = (ListaAlumnos.Find(nom => nom.GetNombre() == nombre));
            Profesor profesor = (ListaProfesores.Find(nom => nom.GetNombre() == nombre));
            Administrador administrador = (ListaAdministradores.Find(nom => nom.GetNombre() == nombre));
            if (Alumno == null && profesor == null && administrador == null)
            {
                return false;
            }
            else if (Alumno == null && profesor == null)
            {
                if(administrador.GetContrasena() == pass)
                {
                    return true;
                }
                else { return false; }
            }
            else if (administrador == null && profesor == null)
            {
                if (Alumno.GetContrasena() == pass)
                {
                    return true;
                }
                else { return false; }
            }
            else if (Alumno == null && administrador == null)
            {
                if (profesor.GetContrasena() == pass)
                {
                    return true;
                }
                else { return false; }
            }
            else { return false; }
        }
        
        
    }
}
