﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Notes
{
    class Alumno : Usuario
    {
        bool administrador = false;
        List<Apuntes>  apuntes;
        bool ayudante = false;

        public Alumno(string nombre, string contrasena) : base (nombre, contrasena)
        {

        }
        public string GetNombre()
        {
            return base.nombre;
        }
        public void SetNombre(string nombreNuevo)
        {
            nombre = nombreNuevo;
        }

        public bool CrearApunte ()
        {
            return true;
            //aun no implementada
            // necesita tener clase ramo
        }

        public void AgregarRecordatorio()
        {
            //aun no implementada
        }

        public bool CompartirApunte ()
        {
            return true;
            //aun no impementada
        }
        public void SetHacerAyudante(Alumno alumno)
        {
            alumno.ayudante = true;
        }
        public void SetDesHacerAyudante(Alumno alumno)
        {
            alumno.ayudante = false;
        }
        public bool GetPermisoAyudante()
        {
            return ayudante;
        }
    }
}
