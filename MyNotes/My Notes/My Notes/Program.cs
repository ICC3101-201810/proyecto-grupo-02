using System;
using System.Collections.Generic;
using System.Linq;
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
        }
    }
}
