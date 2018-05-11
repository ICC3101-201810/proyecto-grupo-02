using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace VistaNotas
{
    static class serial
    {
        public static void Cargar ()
        {
            try
            {

                using (Stream stream = File.Open("DataAdmin.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    List<Administrador> administradores = (List<Administrador>)bin.Deserialize(stream);

                    foreach (Administrador aadministrador in administradores)
                    {
                        MyNotes.AgregarAdmin(aadministrador);
                    }
                }

                using (Stream stream = File.Open("DataProfesores.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    List<Profesor> profesores = (List<Profesor>)bin.Deserialize(stream);
                    foreach (Profesor profesorr in profesores)
                    {
                        MyNotes.AgregarProfesor(profesorr);
                    }


                }
                using (Stream stream = File.Open("DataAlumno.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    List<Alumno> alumnos = (List<Alumno>)bin.Deserialize(stream);
                    foreach (Alumno alumno in alumnos)
                    {
                        MyNotes.AgregarAlumnos(alumno);
                    }
                }
                using (Stream stream = File.Open("DataSemestre.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    List<Semestre> semestres = (List<Semestre>) bin.Deserialize(stream);
                    foreach (Semestre sem in semestres)
                    {
                        MyNotes.AgregarSemestre(sem);
                    }
                }
            }
            catch (Exception)
            {

            }
            // datos agregados a intancia actual
        }

        public static void Guardar()
        {
            // serializacion para guardado de datos 
            using (Stream stream = File.Open("DataAdmin.bin", FileMode.Create))
            {
                List<Administrador> ListaAdministradores = MyNotes.GetListaAdmin();

                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, ListaAdministradores);
                stream.Close();
            }
            using (Stream stream = File.Open("DataProfesores.bin", FileMode.Create))
            {
                List<Profesor> ListaProfesores = MyNotes.GetListaProfesores();

                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, ListaProfesores);
                stream.Close();
            }
            using (Stream stream = File.Open("DataAlumno.bin", FileMode.Create))
            {
                List<Alumno> ListaAlumnos = MyNotes.GetListaAlumnos();

                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, ListaAlumnos);
                stream.Close();
            }
            using (Stream stream = File.Open("DataSemestre.bin", FileMode.Create))
            {
                List<Semestre> ListaSemestres = MyNotes.GetListaSemestres();
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, ListaSemestres);
                stream.Close();
            }
            //datos guardados 
        }
    }
}
