using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Notes
{
    enum TipoApunte{ clase, pauta, ejercicio }
    class Apuntes
    {
        string nombre;
        Ramo ramo;
        TipoApunte tipo;
        string contenido;
        string capitulo;
        DateTime fecha;



    }
}
