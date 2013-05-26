using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Peluquero : Personas
    {
        private DateTime HorarioEntrada;
        public DateTime horarioentrada
        {
            get { return HorarioEntrada; }
            set { HorarioEntrada = value; }
        }

        private DateTime HorarioSalida;
        public DateTime horariosalida
        {
            get { return HorarioSalida; }
            set { HorarioSalida = value; }
        }

        private DateTime Fechaingreso;
        public DateTime fechaingreso
        {
            get { return Fechaingreso; }
            set { Fechaingreso = value; }
        }



    }
}
