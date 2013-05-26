using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public abstract class Personas
    {

        private long DNI;
        public long dni
        {
            get { return DNI; }
            set { DNI = value; }
        }

        private string Nombre;
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        private string Apellido;
        public string apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }

        private DateTime FechaNacimiento;
        public DateTime fechanacimiento
        {
            get { return FechaNacimiento; }
            set { FechaNacimiento = value; }
        }

        private string TelefonoFijo;
        public string telefonofijo
        {
            get { return TelefonoFijo; }
            set { TelefonoFijo = value; }
        }

        private string TelefonoCelular;
        public string telefonocelular
        {
            get { return TelefonoCelular; }
            set { TelefonoCelular = value; }
        }

        private string Direccion;
        public string direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }


    }
}
