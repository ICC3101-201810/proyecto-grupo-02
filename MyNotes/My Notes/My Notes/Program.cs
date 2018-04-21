﻿using System;
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
                Console.WriteLine("Buenas tarrrrrdes Don Administrador {0}.\n¿Que desea hacer?\n" +
                    "(Ingrese el numero de la opcion seleccionada)",NombreUsuario.ToUpper());
                Console.WriteLine("1.- Crear.\n2.- Editar.\n3.- Eliminar.");
                string opc1 = Console.ReadLine();
                if (opc1 == "1")
                {
                    Console.WriteLine("Que desea Crear?");
                    Console.WriteLine("1.- Crear Alumno");
                    Console.WriteLine("2.- Crear Profesor");
                    Console.WriteLine("3.- Crear Administrador");
                    Console.WriteLine("4.- Crear Semestre");
                    Console.WriteLine("5.- Crear Ramo");
                    Console.WriteLine("6.- Crear Seccion");
                    string opc2 = Console.ReadLine();
                    if (opc2 == "1")
                    {
                        Console.WriteLine("Nombre de usuario para el alumno:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Contrasena para el alumno:");
                        string contrasena = Console.ReadLine();
                        Alumno alumno1 = new Alumno(nombre, contrasena);
                        myNotes.AgregarAlumnos(alumno1);
                    }
                    else if (opc2 == "2")
                    {
                        Console.WriteLine("Nombre de usuario para el profesor:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Contrasena para el profesor:");
                        string contrasena = Console.ReadLine();
                        Profesor profesor1 = new Profesor(nombre, contrasena);
                        myNotes.AgregarProfesor(profesor1);
                    }
                    else if (opc2 == "3")
                    {
                        Console.WriteLine("Nombre de usuario para el administrador:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Contrasena para el admostrador:");
                        string contrasena = Console.ReadLine();
                        Administrador admin1 = new Administrador(nombre, contrasena, true);
                        myNotes.AgregarAdmin(admin1);
                    }
                    else if (opc2 == "4")
                    {
                        Console.WriteLine("ID para el semestre:");
                        string nombre = Console.ReadLine();
                        Semestre semestre = new Semestre(nombre);
                    }
                    else if (opc2 == "5")
                    {
                        Console.WriteLine("NRC para el ramo:");
                        string NRC = Console.ReadLine();
                        Console.WriteLine("Nombre del ramo:");
                        string nombre = Console.ReadLine();
                        Ramo ramo = new Ramo(NRC, nombre);
                    }
                    else if (opc2 == "6")
                    {
                        Console.WriteLine("ID de la seccion:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Cupos para este ramo:");
                        string strcupos = Console.ReadLine();
                        int cupos;
                        Int32.TryParse(strcupos, out cupos);
                        Seccion seccion = new Seccion(nombre, cupos);
                    }
                    else { }
                }
                else if (opc1 == "2")
                {
                    Console.WriteLine("Que desea Editar?");
                    Console.WriteLine("1.- Editar Alumno");
                    Console.WriteLine("2.- Darle permiso de ayudante a un alumno");
                    Console.WriteLine("3.- Quitarle permiso de ayudante a un alumno");
                    Console.WriteLine("4.- Editar Profesor");
                    Console.WriteLine("5.- Editar Administrador");
                    Console.WriteLine("6.- Editar Semestre");
                    Console.WriteLine("7.- Editar Ramo");
                    Console.WriteLine("8.- Editar Seccion");
                    string opc2 = Console.ReadLine();
                    if (opc2 == "1")
                    {
                        Console.WriteLine("Nombre de usuario para el alumno:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Contrasena para el alumno:");
                        string contrasena = Console.ReadLine();
                        Alumno alumno1 = new Alumno(nombre, contrasena);
                        myNotes.AgregarAlumnos(alumno1);
                    }
                    else if (opc2 == "2")
                    {
                        Console.WriteLine("Nombre de usuario para el profesor:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Contrasena para el profesor:");
                        string contrasena = Console.ReadLine();
                        Profesor profesor1 = new Profesor(nombre, contrasena);
                        myNotes.AgregarProfesor(profesor1);
                    }
                    else if (opc2 == "3")
                    {
                        Console.WriteLine("Nombre de usuario para el administrador:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Contrasena para el admostrador:");
                        string contrasena = Console.ReadLine();
                        Administrador admin1 = new Administrador(nombre, contrasena, true);
                        myNotes.AgregarAdmin(admin1);
                    }
                    else if (opc2 == "4")
                    {
                        Console.WriteLine("ID para el semestre:");
                        string nombre = Console.ReadLine();
                        Semestre semestre = new Semestre(nombre);
                    }
                    else if (opc2 == "5")
                    {
                        Console.WriteLine("NRC para el ramo:");
                        string NRC = Console.ReadLine();
                        Console.WriteLine("Nombre del ramo:");
                        string nombre = Console.ReadLine();
                        Ramo ramo = new Ramo(NRC, nombre);
                    }
                    else if (opc2 == "6")
                    {
                        Console.WriteLine("ID de la seccion:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Cupos para este ramo:");
                        string strcupos = Console.ReadLine();
                        int cupos;
                        Int32.TryParse(strcupos, out cupos);
                        Seccion seccion = new Seccion(nombre, cupos);
                    }
                    else { }
                }

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
                                    // desde aca ya tendremos todos los datos de vuelta
                                    // todas las listas ¿reducible?
                                    if (!(proyecto.GetListaAlumnos().Count() == 0))
                                    {
                                        foreach (Alumno alumno in proyecto.GetListaAlumnos())
                                        {
                                            myNotes.AgregarAlumnos(alumno);
                                        }
                                    }
                                    if (!(proyecto.GetListaProfesores().Count() == 0))
                                    {
                                        foreach (Profesor profesor in proyecto.GetListaProfesores())
                                        {
                                            myNotes.AgregarProfesor(profesor);
                                        }
                                    }
                                    Console.WriteLine(proyecto.GetListaAdmin().GetEnumerator());
                                    Console.WriteLine(proyecto.GetListaAlumnos().GetEnumerator());
                                    Console.WriteLine(proyecto.GetListaAdmin().Count());
                                    Console.ReadLine();
                                    if (!(proyecto.GetListaAdmin().Count() == 0))
                                    {
                                        foreach (Administrador aadministrador in proyecto.GetListaAdmin())
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
