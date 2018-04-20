using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace My_Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNotes myNotes = new MyNotes();
            Administrador administrador = new Administrador("admin", "123", true);
            myNotes.AgregarAdmin(administrador);
            //CREACION DE PROFES Y ALUMNOS PARA PROBAR CODIGO! BORRAR DESPUES
            Alumno alumno = new Alumno("pepe", "456");
            myNotes.AgregarAlumnos(alumno);
            Profesor profesor = new Profesor("tata", "789");
            myNotes.AgregarProfesor(profesor);
            //---------------------------------------------------------------
            Console.WriteLine("\t\t\t\tBIENVENIDO A MY NOTES!\n");
            Console.WriteLine("Nombre de Usuario: ");
            string NombreUsuario = Console.ReadLine();
            Console.WriteLine("Contrasena: ");
            string ContrasenaUsuario = Console.ReadLine();
            bool passright = false;
            while (passright != true)
            {
                
                if (myNotes.ConfirmarContrasena(NombreUsuario, ContrasenaUsuario))
                {
                    Console.WriteLine("Bienvenido a MyNotes {0}.", NombreUsuario.ToUpper());
                    passright = true;
                    
                }
                else
                {
                    Console.WriteLine("Contrasena invalida.\nIntente nuevamente.");
                    Console.WriteLine("Nombre de Usuario: ");
                    NombreUsuario = Console.ReadLine();
                    Console.WriteLine("Contrasena: ");
                    ContrasenaUsuario = Console.ReadLine();
                }

            }
            if (((myNotes.GetListaAdmin().Find(nom => nom.GetNombre() == NombreUsuario) != null)))
            {
                Console.WriteLine("If comprobando que es un admin");
            }
            else if (((myNotes.GetListaAlumnos().Find(nom => nom.GetNombre() == NombreUsuario) != null)))
            {
                Console.WriteLine("es un alumno");
            }
            else if (((myNotes.GetListaProfesores().Find(nom => nom.GetNombre() == NombreUsuario) != null)))
            {
                Console.WriteLine("es un profesor");
            }
            else
            {

            }
            Console.ReadLine();

            /*
            //Serializar inicia
            Console.WriteLine("¿quieres serializar? (s/n) \n");
            string respuesta = Console.ReadLine().ToLower();
            if ( respuesta == "s")
            {
                Console.WriteLine("\ns= serializar, r =read\n");
                switch (Console.ReadLine())
                {
                    case "s":

                    try
                    {
                        using (Stream stream = File.Open("data.bin", FileMode.Create))
                           {
                                var AGuardar = new List<MyNotes>();
                                AGuardar.Add(myNotes);

                                BinaryFormatter bin = new BinaryFormatter();
                                bin.Serialize(stream, AGuardar);
                            }
                    }
                        catch (IOException)
                        {
                        }
                        break;

                    case "r":
                        try
                        {
                            using (Stream stream = File.Open("data.bin", FileMode.Open))
                            {
                                BinaryFormatter bin = new BinaryFormatter();

                                var notasPrograma = (List<MyNotes>)bin.Deserialize(stream);
                                foreach (MyNotes proyecto in notasPrograma)
                                {
                                    //desde aca ya tendremos todos los datos de vuelta
                                    // todas las listas ¿reducible?
                                    if (!(proyecto.GetListaAlumnos().Count() == 0))
                                    {
                                        foreach (Alumno alumno in myNotes.GetListaAlumnos())
                                        {
                                            myNotes.AgregarAlumnos(alumno);
                                        }
                                    }
                                    if (!(proyecto.GetListaProfesores().Count() == 0))
                                    {
                                        foreach (Profesor profesor in myNotes.GetListaProfesores())
                                        {
                                            myNotes.AgregarProfesor(profesor);
                                        }
                                    }
                                    if (!(proyecto.GetListaAdmin().Count() == 0))
                                    {
                                        List<Administrador> s = myNotes.GetListaAdmin();
                                        foreach (Administrador aadministrador in s)
                                        {
                                            myNotes.AgregarAdmin(aadministrador);
                                        }
                                    }
                                }


                            }
                        }
                        catch (IOException)
                        {
                        }
                        break;


                }
                //termina serializacion
            }
            */

        }
    }
}
