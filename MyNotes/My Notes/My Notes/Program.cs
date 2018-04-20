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
            Administrador administrador = new Administrador("admin", "123", true);
            myNotes.AgregarAdmin(administrador);
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
                    Console.WriteLine("Bienvenido a MyNotes {0}.", NombreUsuario);
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
            //agragr if getlistaadmin con fond
            Console.ReadLine();
        }
    }
}
