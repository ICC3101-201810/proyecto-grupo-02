﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Notes
{
    class Profesor : Usuario
    {
        bool administrador = false;
        List<string> informaicon;
        List<Apuntes> material;

        public Profesor(string nombre, string contrasena) : base (nombre,contrasena)
        {

        }



        protected override bool VerificarNombre()
        {
            throw new NotImplementedException();
        }

        protected override bool VerificarContraseña()
        {
            throw new NotImplementedException();
        }

        public void SubirMaterial()
        {
            //aun no implementada
        }

        public bool HacerAyudante ()
        {
            return true;
            //aun no implementada
        }
    }
}