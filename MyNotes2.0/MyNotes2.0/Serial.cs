using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace MyNotes2._0
{
    [Serializable()]
    static class serial
    {
        public static void Cargar(BaseDeDatos MyNotes)
        {
            try
            {

                using (Stream stream = File.Open(@"..\..\data\DataAdmin.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    List<Administrador> administradores = (List<Administrador>)bin.Deserialize(stream);

                    foreach (Administrador aadministrador in administradores)
                    {
                        MyNotes.AgregarUsuario(aadministrador);
                    }
                }

                using (Stream stream = File.Open(@"..\..\data\DataProfesores.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    List<Profesor> profesores = (List<Profesor>)bin.Deserialize(stream);
                    foreach (Profesor profesorr in profesores)
                    {
                        MyNotes.AgregarUsuario(profesorr);
                    }


                }
                using (Stream stream = File.Open(@"..\..\data\DataAlumno.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    List<Alumno> alumnos = (List<Alumno>)bin.Deserialize(stream);
                    foreach (Alumno alumno in alumnos)
                    {
                        MyNotes.AgregarUsuario(alumno);
                    }
                }
                using (Stream stream = File.Open(@"..\..\data\DataSemestre.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    List<Semestre> semestres = (List<Semestre>)bin.Deserialize(stream);
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

        public static void Guardar(BaseDeDatos MyNotes)
        {
            // serializacion para guardado de datos 
            //using (Stream stream = File.Open(@"..\data\DataAlumno.bin", FileMode.Create));
            using (Stream stream = File.Open(@"..\..\data\DataAdmin.bin", FileMode.Create))
            {
                List<Administrador> ListaAdministradores = MyNotes.GetListaAdmins();

                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, ListaAdministradores);
                stream.Close();
            }
            using (Stream stream = File.Open(@"..\..\data\DataProfesores.bin", FileMode.Create))
            {
                List<Profesor> ListaProfesores = MyNotes.GetListaProfesores();

                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, ListaProfesores);
                stream.Close();
            }
            using (Stream stream = File.Open(@"..\..\data\DataAlumno.bin", FileMode.Create))
            {
                List<Alumno> ListaAlumnos = MyNotes.GetListaAlumnos();

                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, ListaAlumnos);
                stream.Close();
            }
            using (Stream stream = File.Open(@"..\..\data\DataSemestre.bin", FileMode.Create))
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
