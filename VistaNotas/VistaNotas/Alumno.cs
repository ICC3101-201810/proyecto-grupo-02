using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VistaNotas
{
    [Serializable()]
    class Alumno : Usuario
    {
        List<Apuntes>  apuntes = new List<Apuntes>();
        bool ayudante = false;

        public Alumno(string nombre, string contrasena) : base (nombre, contrasena)
        {

        }
        public string GetNombre()
        {
            return base.nombre;
        }
        public string GetContrasena()
        {
            return base.contrasena;
        }
        public void SetNombre(string nombreNuevo)
        {
            nombre = nombreNuevo.ToUpper();
        }

        public void CrearApunte (string nombreApunte, string contenido, Ramo ramo, Seccion seccion)
        {
            //entra ya verificado que esta correcto el ramo
            apuntes.Add(new Apuntes(nombre, ramo, contenido, DateTime.Now, seccion));
            return;
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
