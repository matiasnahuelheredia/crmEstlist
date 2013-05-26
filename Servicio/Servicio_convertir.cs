using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Servicio
{
    public class Servicio_convertir
    {
        
        static public bool stringaulong(string entrada)
        {
            ulong num;
            return ulong.TryParse(entrada, out num); 
        }
        static public bool stringaint(string entrada)
        {
            int num;
            return int.TryParse(entrada, out num);
        }
        static public bool stringadatetime(string entrada)
        {
            DateTime fecha;
            return DateTime.TryParse(entrada, out fecha);
        }
    }
}
