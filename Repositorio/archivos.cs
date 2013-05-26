using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Repositorio
{
        public class archivos
        {
            static internal  string stringdeconeccionsql()
            {
                string Linea_Datos;
                try
                {
                    StreamReader archivo = new StreamReader(@"stringconectionsql.txt");
                    Linea_Datos = archivo.ReadLine();
                    archivo.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }


                return Linea_Datos;
            }
            static internal string stringdeconeccionmysql()
            {
                string Linea_Datos;
                try
                {
                    StreamReader archivo = new StreamReader(@"stringconectionmysql.txt");
                    Linea_Datos = archivo.ReadLine();
                    archivo.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }


                return Linea_Datos;
            }
            static internal string stringdeconeccionodbc()
            {
                string Linea_Datos;
                try
                {
                    StreamReader archivo = new StreamReader(@"stringconectionodbc.txt");
                   
                    Linea_Datos = archivo.ReadLine();
                    archivo.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }


                return Linea_Datos;
            }
            static internal string stringdelicencia()
            {
                string Linea_Datos="";
                
                    StreamReader archivo = new StreamReader(@"licence/licencia.txt");
                    string linea = archivo.ReadLine();
                    while (linea != null)
                    {

                        Linea_Datos = Linea_Datos + Convert.ToChar(13) + Convert.ToChar(10) + linea;
                        linea = archivo.ReadLine();
                    }
                    archivo.Close();
                


                return Linea_Datos;
            }
            static internal string nombremotorbase()
            {
                string Linea_Datos;
                try
                {
                    StreamReader archivo = new StreamReader(@"nombremotor.txt");
                    Linea_Datos = archivo.ReadLine();
                    archivo.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }


                return Linea_Datos;
            }
        }
    }

