﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Notes
{
    class Administrador : Usuario , IVerificandoContrasena, IVerivicandoNombre
    {
        bool administrador = true;

        public Administrador(string nombre, string contrasena, bool miAdministrador) : base(nombre, contrasena)
        {
            administrador = miAdministrador;
        }

        public bool VerificarContrasena(string constrasena)
        {
            if (contrasena.Length < 3)
            {
                Console.WriteLine("La contrasena debe tener mas de 3 caracteres");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool VerificarNombre(string nombre, List<Alumno> listaAlumno, List<Profesor> listaProfesor)
        {
            List<Alumno> verificandoNombreAl = (listaAlumno.Where(nom => nom.GetNombre() == nombre)).ToList();
            if(verificandoNombreAl.Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AgregarAlumno(string nombre, string contrasena)
        {
            while ()
            while(VerificarContrasena(contrasena) != true)
            {

            }
            Alumno alumno = new Alumno(nombre, contrasena)
        }

        public bool EditarAlumno (string nombre, string contrasena)
        {
            return true;
        }

        public bool EliminarAlumno (string nombre, string contrasena)
        {
            return true;
        }
        
        public bool CrearRamo (int NRC)
        {
            return true;
        }

        public bool EditarRamo (int NRC)
        {
            return true;
        }

        public bool EliminarRamo (int NRC)
        {
            return true;
        }

        public void CrearFechas ()
        {

        }

        public bool EditarFechas ()
        {
            return true;
        }

        public bool EliminarFechas ()
        {
            return true;
        }

        public void HacerAyudante ()
        {

        }

        public void EliminarAyudante ()
        {

        }

        public void CrearAyudante ()
        {

        }

        public void EditarMaterial ()
        {

        }

        public void EliminarMaterial ()
        {

        }
    }
}
