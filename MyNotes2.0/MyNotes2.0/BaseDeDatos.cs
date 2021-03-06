﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes2._0
{
    [Serializable()]
    public class BaseDeDatos
    {
        List<Alumno> listaAlumnos;
        List<Profesor> listaProfesores;
        List<Administrador> listaAdmins;
        List<Semestre> listaSemestres;
        Usuario usuarioActual;
        public BaseDeDatos()
        {
            listaAdmins = new List<Administrador>();
            listaAlumnos = new List<Alumno>();
            listaProfesores = new List<Profesor>();
            listaSemestres = new List<Semestre>();
        }
        internal List<Administrador> GetListaAdmins()
        {
            return listaAdmins;
        }
        internal Administrador GetAdmin(string nombre)
        {
            Administrador Admin = (listaAdmins.Find(n => n.GetNombre() == nombre));
            return Admin;
        }
        public Usuario GetUser(string nombre)
        {
            Alumno alumno = (listaAlumnos.Find(n => n.GetNombre()==nombre));
            Profesor profesor = (listaProfesores.Find(n => n.GetNombre() == nombre));
            Administrador administrador = (listaAdmins.Find(n => n.GetNombre() == nombre));
            if (alumno != null)
            {
                return alumno;
            }
            else if (profesor != null)
            {
                return profesor;
            }
            else if (administrador != null)
            {
                return administrador;
            }
            else
            {
                return null; //si algo sale mal retorna null
            }
            
        }//Retorna el Usuario del nombre del parametro
        internal List<Alumno> GetListaAlumnos()
        {
            return listaAlumnos;
        }
        internal List<Profesor> GetListaProfesores()
        {
            return listaProfesores;
        }
        public bool ExisteUser(string nombre)
        {
            foreach (Administrador a in listaAdmins)
            {
                if (a.GetNombre().ToString()==nombre)
                {
                    return true;
                }
            }
            foreach (Alumno a in listaAlumnos)
            {
                if (a.GetNombre().ToString() == nombre)
                {
                    return true;
                }
            }
            foreach (Profesor p in listaProfesores)
            {
                if (p.GetNombre().ToString() == nombre)
                {
                    return true;
                }
            }
            return false;
        }
        public void AgregarUsuario(Usuario usuario)
        {
            if (usuario is Administrador)
            {
                listaAdmins.Add((Administrador)usuario);
            }
            else if (usuario is Alumno)
            {
                listaAlumnos.Add((Alumno)usuario);
            }
            else if (usuario is Profesor)
            {
                listaProfesores.Add((Profesor)usuario);
            }
        }
        internal List<Semestre> GetListaSemestres()
        {
            return listaSemestres;
        }
        internal bool AgregarSemestre(Semestre semestre)
        {
            foreach (Semestre sem in listaSemestres)
            {
                if(sem.GetID() == semestre.GetID() )
                {
                    return false;
                }
            }
            listaSemestres.Add(semestre);
            return true;
        }
        public void SetUsuarioActual(Usuario usuario)
        {
            usuarioActual = usuario;
        }
        public Usuario GetUsuarioActual()
        {
            return usuarioActual;
        }
    }
}
