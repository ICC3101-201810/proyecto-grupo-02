using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace My_Notes
{
    static class serial
    {
        public static void Cargar (MyNotes myNotes)
        {
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
                            foreach (Alumno alumnoo in proyecto.GetListaAlumnos())
                            {

                                myNotes.AgregarAlumnos(alumnoo);
                            }
                        }
                        if (!(proyecto.GetListaProfesores().Count() == 0))
                        {
                            foreach (Profesor profesorr in proyecto.GetListaProfesores())
                            {
                                myNotes.AgregarProfesor(profesorr);
                            }
                        }

                        if (!(proyecto.GetListaAdmin().Count() == 0))
                        {
                            foreach (Administrador aadministrador in proyecto.GetListaAdmin())
                            {
                                if (aadministrador.GetNombre() == "admin")
                                {
                                    continue;
                                }
                                myNotes.AgregarAdmin(aadministrador);
                            }

                        }
                    }
                }
            }
            catch (IOException)
            {

            }
            // datos agregados a intancia actual
        }

        public static void Guardar(MyNotes myNotes)
        {
            // serializacion para guardado de datos 
            using (Stream stream = File.Open("data.bin", FileMode.Create))
            {
                var AGuardar = new List<MyNotes>();
                AGuardar.Add(myNotes);

                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, AGuardar);
                stream.Close();
            }
            //datos guardados 
        }
    }
}
