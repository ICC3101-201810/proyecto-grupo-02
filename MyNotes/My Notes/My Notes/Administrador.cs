using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Notes
{
    class Administrador : Usuario
    {
        bool administrador = true;

        protected Administrador(string nombre, string contrasena) : base(nombre, contrasena)
        {

        }

        protected override bool VerificarContraseña()
        {
            throw new NotImplementedException();
        }

        protected override bool VerificarNombre()
        {
            throw new NotImplementedException();
        }

        public bool AgregarAlumno(string nombre, string contrasena)
        {
            return true;
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
