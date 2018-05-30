using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes2._0
{
    [Serializable()]
    class Alumno : Usuario
    {
        public bool ayudante = false;
        List<Notes> apuntes = new List<Notes>();
        List<Ramo> Ramos = new List<Ramo>();
        public Alumno(string nombre, string contrasena) : base(nombre, contrasena)
        {

        }
        public string GetNombre()
        {
            return base.GetNombre();
        }
        public string GetContrasena()
        {
            return base.GetContrasena();
        }
        public List<Ramo> GetRamos()
        {
            return Ramos;
        }
        public List<Notes> GetApuntes()
        {
            return apuntes;
        }
        public Notes GetNote(string NombreNote)
        {
            Notes notes = (apuntes.Find(n => n.GetNombre() == NombreNote));
            return notes;
        }
        public void AgregarApuntes(Notes notas)
        {
            apuntes.Add(notas);
        }
        public void AgregarRamo(Ramo ramo)
        {
            Ramos.Add(ramo);
        }
        public void LimpiarRamos()
        {
            Ramos.Clear();
        }
        
    }
}
