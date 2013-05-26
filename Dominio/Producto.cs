using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Producto:Producto_Servicio
    {
        private Byte[] imagen;
        public Byte[] Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        private int cantidad;
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
    }
}
