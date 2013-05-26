using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Cliente : Personas
    {
        private string Email;
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }
        private int Nivel;
        public int nivel
        {
            get { return Nivel; }
            set { Nivel = value; }
        }
    }
}
