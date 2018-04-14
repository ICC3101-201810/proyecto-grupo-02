using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Notes
{
    public class Alumno : Usuario
    {
        bool administrador = false;
        List<Apuntes>  apuntes;
        bool ayudante = false;

        public Alumno(string nombre, string contrasena) : base (nombre, contrasena)
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

    }
}
