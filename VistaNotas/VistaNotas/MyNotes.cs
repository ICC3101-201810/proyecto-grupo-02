using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace VistaNotas
{
    [Serializable]
    static class MyNotes
    {//TRES LISTAS porque no podemos hacer lista de Usuarios y meterle porfesores, admins y alumnos.
        static List<Alumno> ListaAlumnos = new List<Alumno>();
        static List<Profesor> ListaProfesores = new List<Profesor>();
        static List<Administrador> ListaAdministradores = new List<Administrador>();
        static List<Usuario> UsuarioActual = new List<Usuario>(); //usuario que este en uso actualmente 

        /*
        public  MyNotes()
        {
            serial.Cargar(this);
        }
        */
        public static  void AgregarAdmin(Administrador administrador)
        {
            ListaAdministradores.Add(administrador);
        }
        public static  void AgregarAlumnos(Alumno alumno)
        {
            ListaAlumnos.Add(alumno);
        }
        public static void AgregarProfesor(Profesor profesor)
        {
            ListaProfesores.Add(profesor);
        }
        public static List<Alumno> GetListaAlumnos()
        {
            return ListaAlumnos;
        }
        public static List<Profesor> GetListaProfesores()
        {
            return ListaProfesores;
        }
        public static List<Administrador> GetListaAdmin()
        {
            return ListaAdministradores;
        }
        public static Usuario Usuario_Actual()
        {
            return UsuarioActual[0];
        }
        
        public static string GetNombreUsuarioAcutal()
        {
            return UsuarioActual[0].GetNombree();   
        }
        
        public static void CerrarSesion()
        {
            while (UsuarioActual.Count >= 1)
            {
                UsuarioActual.Remove(UsuarioActual[0]);
            }
        }
        public static void IniciarSesion(string nombre, string constrasena)
        {
            Alumno Alumno = (ListaAlumnos.Find(nom => nom.GetNombre() == nombre));
            Profesor profesor = (ListaProfesores.Find(nom => nom.GetNombre() == nombre));
            Administrador administrador = (ListaAdministradores.Find(nom => nom.GetNombre() == nombre));
            if (Alumno == null && profesor == null && administrador == null)
            {
            }
            else if (Alumno == null && profesor == null)
            {
                if (administrador.GetContrasena() == constrasena)
                {
                    Alumno alumno = new Alumno(nombre, constrasena);
                    UsuarioActual.Add(alumno);
                }
                else { }
            }
            else if (administrador == null && profesor == null)
            {
                if (Alumno.GetContrasena() == constrasena)
                {
                    Administrador admin = new Administrador(nombre, constrasena, true);
                    UsuarioActual.Add(admin);
                }
                else { }
            }
            else if (Alumno == null && administrador == null)
            {
                if (profesor.GetContrasena() == constrasena)
                {
                    Profesor profe = new Profesor(nombre, constrasena);
                    UsuarioActual.Add(profe);

                }
                else {  }
            }
            else {  }
        }
        public static bool ConfirmarContrasena(string nombre, string pass)
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
                if (administrador.GetContrasena() == pass)
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
