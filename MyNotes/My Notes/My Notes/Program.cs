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
            Administrador administrador = new Administrador("Admin", "123", true);
            myNotes.AgregarAdmin(administrador);
            Console.WriteLine("\t\t\t\tBIENVENIDO A MY NOTES!\nDesea:\n1.-Iniciar Secion.\n2.- Crear Usuario.");
            Console.WriteLine("Ingrese el numero correspondiente a la opcion que desea.");
            string eleccion1 = Console.ReadLine();
            if (eleccion1 == "1")
            {
                bool passright = false;
                while (passright != true)
                {
                    Console.WriteLine("Nombre de Usuario: ");
                    string NombreUsuario = Console.ReadLine();
                    Console.WriteLine("Contrasena: ");
                    string ContrasenaUsuario = Console.ReadLine();
                    if (myNotes.ConfirmarContrasena(NombreUsuario, ContrasenaUsuario))
                    {
                        Console.WriteLine("Bienvenido a MyNotes {0}", NombreUsuario);
                        passright = true;
                    }
                    else
                    {
                        Console.WriteLine("Contrasena invalida.\nIntente nuevamente.");
                    }
                }

            }
            else if (eleccion1 == "2")
            {

            }
            Console.ReadLine();


            //Serializar inicia
            Console.WriteLine("¿quieres serializar? (s/n) \n");
            string respuesta = Console.ReadLine().ToLower();
            if ( respuesta == "s")
            {
                Console.WriteLine("asdasdasd");
                switch (Console.ReadLine())
                {
                    case "s":

                    try
                    {
                        using (Stream stream = File.Open("data.bin", FileMode.Create))
                           {
                                BinaryFormatter bin = new BinaryFormatter();
                                bin.Serialize(stream, myNotes);
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
                                foreach (MyNotes asd in notasPrograma)
                                {
                                    //desde aca ya tendremos todos los datos de vuelta
                                    // todas las listas ¿reducible?

                                    foreach (Alumno alumno in myNotes.GetListaAlumnos())
                                    {
                                        myNotes.AgregarAlumnos(alumno);
                                    }
                                    foreach (Profesor profesor in myNotes.GetListaProfesores())
                                    {
                                        myNotes.AgregarProfesor(profesor);
                                    }
                                    foreach (Administrador aadministrador in myNotes.GetListaAdmin())
                                    {
                                        myNotes.AgregarAdmin(aadministrador);
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


        }
    }
}
