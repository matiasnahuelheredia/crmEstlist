using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Servicio : Producto_Servicio
    {
        private DateTime tiempo;
        public DateTime Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }
    }
}
