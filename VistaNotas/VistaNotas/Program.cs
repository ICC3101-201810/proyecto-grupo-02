using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VistaNotas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            serial.Cargar();
            //Administrador administrador = new Administrador("admin", "123");
            //MyNotes.AgregarAdmin(administrador);
            //Alumno alumno = new Alumno("alumno", "123");
            //MyNotes.AgregarAlumnos(alumno);
            //Profesor profe = new Profesor("tata", "123");
            //MyNotes.AgregarProfesor(profe);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Entrada());
        }
    }
}
