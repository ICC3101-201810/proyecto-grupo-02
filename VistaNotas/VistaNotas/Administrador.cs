using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistaNotas//Metodos de verificar, no como interfaces si no en MyNotes para no acceder siempre a las listas
{
    [Serializable()]
    class Administrador : Usuario
    {

        public Administrador(string nombre, string contrasena) : base(nombre, contrasena)
        {
            
        }
        public string GetNombre()
        {
            return base.nombre;
        }
        public void SetNombre(string nombreNuevo)
        {
            nombre = nombreNuevo.ToUpper();
        }
        public string GetContrasena()
        {
            return base.contrasena;
        }
        public bool CrearRamo(string nombre, string nrc)
        {
            Ramo ramo = new Ramo(nrc, nombre);
            return true;
        }
        public bool EditarNombreRamo(Ramo ramo, string nombreNuevo)
        {
            ramo.SetNombre(nombreNuevo);
            return true;
        }
        public bool EliminarRamo(string NRC, List<Ramo> ramos)
        {
            Ramo ramoX = (ramos.Find(nom => nom.GetNRC() == NRC));
            ramos.Remove(ramoX);
            return true;
        }
        public void CrearFechas(Ramo ramo, DateTime fecha)
        {
            ramo.AgregarFechas(fecha);
        }
        public bool EditarFechas(Ramo ramo, DateTime fecha, DateTime fechaNueva)
        {
            DateTime fechaE = (ramo.GetFechas().Find(nom => nom == fecha));
            ramo.GetFechas().Remove(fechaE);
            ramo.AgregarFechas(fechaNueva);
            return true;
        }
        public bool EliminarFechas(Ramo ramo, DateTime fecha)
        {
            DateTime fechaE = (ramo.GetFechas().Find(nom => nom == fecha));
            ramo.GetFechas().Remove(fechaE);
            return true;
        }
        public void HacerAyudante(string nombre, List<Alumno> als)
        {
            Alumno AlumnoX = (als.Find(nom => nom.GetNombre() == nombre));
            AlumnoX.SetHacerAyudante(AlumnoX);//estara bueno?
        }
        public void EliminarAyudante(string nombre, List<Alumno> als)
        {
            Alumno AlumnoX = (als.Find(nom => nom.GetNombre() == nombre));
            AlumnoX.SetDesHacerAyudante(AlumnoX);
        }
        public void EditarMaterial()
        {

        }
        public void EliminarMaterial()
        {

        }
    }
}
