using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositorio;
namespace Servicio
{
    public class Servicio_registro
    {
        
        public void registrarlicencia(ulong clave)
        {
            RegistroWindows regwin = new RegistroWindows();
            regwin.registralicencia(clave);
        }

        public void primeruso()
        {
            RegistroWindows regwin = new RegistroWindows();
            regwin.primeruso();
        }

        public bool validarlicencia ()
        {
            RegistroWindows regwin = new RegistroWindows();
            return regwin.validalicencia();
        }
        public bool validarfechatrial()
        {
            RegistroWindows regwin = new RegistroWindows();
            return regwin.validafechatrial();
        }
        public static string vernumerolicencia()
        {
            RegistroWindows regwin = new RegistroWindows();
            return regwin.vernumerolicencia();
        }
        public bool validalicencianoregistrada(ulong numero)
        {

            if ((numero % 15241 == 0)&& numero!=0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
