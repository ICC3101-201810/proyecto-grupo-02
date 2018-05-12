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
        public bool VerificarNombre(string nombre, List<Alumno> listaAlumnos, List<Profesor> listaProfesores)
        {
            List<Alumno> verificandoNombreAl = (listaAlumnos.Where(nom => nom.GetNombre() == nombre)).ToList();
            List<Profesor> verificandoNombrePr = (listaProfesores.Where(nom => nom.GetNombre() == nombre)).ToList();
            if (verificandoNombreAl.Count() > 0 && verificandoNombrePr.Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
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
        public bool AgregarAlumno(string nombre, string contrasena, List<Alumno> als, List<Profesor> profs)
        {
            while (VerificarNombre(nombre, als, profs) != true)
            {
                Console.Beep();
                Console.WriteLine("Nombre ya existe.\nIngrese otro:");
                nombre = Console.ReadLine();
                VerificarNombre(nombre, als, profs);
            }

            while (VerificarContrasena(contrasena) != true)
            {
                Console.Beep();
                Console.WriteLine("Contrasena invalida.\nIngrese otra:");
                contrasena = Console.ReadLine();
                VerificarContrasena(contrasena);
            }
            Alumno alumno = new Alumno(nombre, contrasena);
            return true;
        }
        public bool EditarAlumno(string nombre, string nombreNuevo, List<Alumno> als, List<Profesor> profs)
        {
            if (VerificarNombre(nombre, als, profs))
            {
                List<Alumno> alumnoEditado = (als.Where(nom => nom.GetNombre() == nombre)).ToList(); //Esta lsta deberia tener solo 1 elemnto
                if (alumnoEditado.Count() > 1)
                {
                    Console.Beep();
                    Console.WriteLine("Algo salio mal al editar al alumno. Se cancelo la operacion.");
                    return false;
                    
                }
                else
                {
                    Console.WriteLine(alumnoEditado);
                    alumnoEditado[0].SetNombre(nombreNuevo);
                    Console.WriteLine("Se edito correctamente al alumno.");
                    return true;
                }

            }
            return true;
        }
        public bool EditarProfesor(string nombre, string nombreNuevo, List<Alumno> als, List<Profesor> profs)
        {
            if (VerificarNombre(nombre, als, profs))
            {
                List<Profesor> profeEditado = (profs.Where(nom => nom.GetNombre() == nombre)).ToList(); //Esta lsta deberia tener solo 1 elemnto
                if (profeEditado.Count() < 2)
                {
                    Console.Beep();
                    Console.WriteLine("Algo salio mal al editar al alumno. Se cancelo la operacion.");
                    return false;
                }
                else
                {
                    profeEditado[0].SetNombre(nombreNuevo);
                    Console.WriteLine("Se edito correctamente al alumno.");
                    return true;
                }

            }
            return true;
        }
        public bool EliminarAlumno(string nombre, List<Alumno> als)
        {
            Alumno AlumnoX = (als.Find(nom => nom.GetNombre() == nombre));
            als.Remove(AlumnoX);
            return true;
        }
        public bool EliminarAdmin(string nombre, List<Administrador> ads)
        {
            Administrador AdminX = (ads.Find(nom => nom.GetNombre() == nombre));
            ads.Remove(AdminX);
            return true;
        }
        public bool EliminarProfesor(string nombre, List<Profesor> profs)
        {
            Profesor profesorX = (profs.Find(nom => nom.GetNombre() == nombre));
            profs.Remove(profesorX);
            return true;
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
