﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistaNotas
{
    [Serializable()]
    class Ramo
    {
        string NRC;
        string Nombre;
        List<Seccion> secciones = new List<Seccion>();
        List<DateTime> Fechas = new List<DateTime>();

        public Ramo (string NRC, string Nombre)
        {
            this.NRC = NRC;
            this.Nombre = Nombre;
            //no contriene profesor, ya que el profesor, es profesor de la seccion
        }

        public bool AgregarSeccion (Seccion seccion)
        {
            if (secciones.IndexOf(seccion) == -1)
            {
                secciones.Add(seccion);
                
                Console.WriteLine("Seccion " +seccion.GetIDSeccion().ToString() + " Agregada al Ramo "+ Nombre + " satisfactoriamente" );
                return true;
            }
            
            return false;
        }
        public bool AgregarFechas(DateTime date)
        {
            Fechas.Add(date);
            return true;
        }
        public List<Seccion> GetSecciones()
        {
            return secciones;
        }
        public List<DateTime> GetFechas()
        {
            return Fechas;
        }
        public void SetNombre(string nombrenuevo)
        {
            Nombre = nombrenuevo;
        }
        public string GetNRC()
        {
            return NRC;
        }

    }
}

