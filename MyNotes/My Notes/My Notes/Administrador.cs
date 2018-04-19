using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Notes//Metodos de verificar, no como interfaces si no en MyNotes para no acceder siempre a las listas
{
    class Administrador : Usuario, IVerificandoContrasena, IVerificandoNombre
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
            List<Profesor> verificandoNombrePr = (listaProfesor.Where(nom => nom.GetNombre() == nombre)).ToList();
            if (verificandoNombreAl.Count() > 0 && verificandoNombrePr.Count() > 0)
            {
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
                Console.WriteLine("Nombre ya existe.\nIngrese otro:");
                nombre = Console.ReadLine();
                VerificarNombre(nombre, als, profs);
            }

            while (VerificarContrasena(contrasena) != true)
            {
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
                if (als.Count() < 2)
                {
                    Console.WriteLine("Algo salio mal al editar al alumno. Se cancelo la operacion.");
                    return false;
                }
                else
                {
                    als[0].SetNombre(nombreNuevo);
                    Console.WriteLine("Se edito correctamente al alumno.");
                    return true;
                }

            }
            return true;
        }

        public List<Alumno> EliminarAlumno(string nombre, List<Alumno> als)
        {
            List<Alumno> ListaAlumnosNueva = (als.Where(nom => nom.GetNombre() != nombre)).ToList();
            return ListaAlumnosNueva;
        }

        public bool CrearRamo(int NRC)
        {
            return true;
        }

        public bool EditarRamo(int NRC)
        {
            return true;
        }

        public bool EliminarRamo(int NRC)
        {
            return true;
        }

        public void CrearFechas()
        {

        }

        public bool EditarFechas()
        {
            return true;
        }

        public bool EliminarFechas()
        {
            return true;
        }

        public void HacerAyudante()
        {

        }

        public void EliminarAyudante()
        {

        }

        public void CrearAyudante()
        {

        }

        public void EditarMaterial()
        {

        }

        public void EliminarMaterial()
        {

        }
    }
}
