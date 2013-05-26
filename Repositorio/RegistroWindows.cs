using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
namespace Repositorio
{
    public class RegistroWindows
    {
        public void primeruso()
        {
            RegistryKey registryAccess = Registry.Users;
            registryAccess = registryAccess.OpenSubKey(".DEFAULT", true);
            registryAccess.CreateSubKey(Ofuscacion.EncodeTo64("Peluqueria")); //Creamos una subclave llamada “AccessTime”
            registryAccess = registryAccess.OpenSubKey(Ofuscacion.EncodeTo64("Peluqueria"), true);            
            registryAccess.SetValue(Ofuscacion.EncodeTo64("fecha"), Ofuscacion.EncodeTo64(DateTime.Now.ToString()), RegistryValueKind.String);
        }
        public bool validafechatrial()
        {
            try
            {
                RegistryKey registryAccess = Registry.Users;
                registryAccess = registryAccess.OpenSubKey(".DEFAULT", true);
                registryAccess = registryAccess.OpenSubKey(Ofuscacion.EncodeTo64("Peluqueria"), true);
                String values = registryAccess.GetValue(Ofuscacion.EncodeTo64("fecha")).ToString();
                values = Ofuscacion.DecodeFrom64(values);
                DateTime fecha = new DateTime();
                fecha = Convert.ToDateTime(values);
                if (DateTime.Now > fecha.AddDays(2))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                this.primeruso();
                return true;
            }
        }
        public bool validalicencia()
        {
            try
            {
                RegistryKey registryAccess = Registry.Users;
                registryAccess = registryAccess.OpenSubKey(".DEFAULT", true);
                registryAccess = registryAccess.OpenSubKey(Ofuscacion.EncodeTo64("Peluqueria"), true);
                String values = registryAccess.GetValue(Ofuscacion.EncodeTo64("numerolicencia")).ToString();
                values = Ofuscacion.DecodeFrom64(values);
                ulong numero= Convert.ToUInt64(values);
                if (numero % 15241 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public string vernumerolicencia()
        {
            string values = "";
            try
            {
                RegistryKey registryAccess = Registry.Users;
                registryAccess = registryAccess.OpenSubKey(".DEFAULT", true);
                registryAccess = registryAccess.OpenSubKey(Ofuscacion.EncodeTo64("Peluqueria"), true);
                values = registryAccess.GetValue(Ofuscacion.EncodeTo64("numerolicencia")).ToString();
                values = Ofuscacion.DecodeFrom64(values);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
                return values;
        }
        public void registralicencia(ulong clave)
        {
            RegistryKey registryAccess = Registry.Users;
            registryAccess = registryAccess.OpenSubKey(".DEFAULT", true);
            registryAccess = registryAccess.OpenSubKey(Ofuscacion.EncodeTo64("Peluqueria"), true);
            registryAccess.SetValue(Ofuscacion.EncodeTo64("numerolicencia"), Ofuscacion.EncodeTo64(clave.ToString()), RegistryValueKind.String);
        }
        
    }
}
