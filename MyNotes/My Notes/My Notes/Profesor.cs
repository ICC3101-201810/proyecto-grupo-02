using System;
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
<<<<<<< HEAD
        public string GetNombre()
=======



        public override bool VerificarNombre(string nombre)
>>>>>>> c4ff693c55267f1bb8c82e54d54bc8bca111c551
        {
            return base.nombre;
        }

<<<<<<< HEAD
=======
        public override bool VerificarContrasena(string constrasena)
        {
            throw new NotImplementedException();
        }
>>>>>>> c4ff693c55267f1bb8c82e54d54bc8bca111c551

        public void SubirMaterial()
        {
            //aun no implementada
        }

        public bool HacerAyudante ()
        {
            return true;
            //aun no implementada
        }

        public bool CrearMaterial ()
        {

            //Console.WriteLine("Material creado");
            return true;
            //aun no implementada
        }
<<<<<<< HEAD
=======


>>>>>>> c4ff693c55267f1bb8c82e54d54bc8bca111c551
    }
}
